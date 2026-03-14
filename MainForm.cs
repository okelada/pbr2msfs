using ImageMagick;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using wifitracelistener;
using static System.Windows.Forms.DataFormats;



namespace pbr2msfs
{
    public partial class MainForm : Form
    {
        ViewerForm viewer = new ViewerForm();

        System.Windows.Forms.Timer viewerFormTimer = new System.Windows.Forms.Timer();

        wifiTraceListener myTraceListener;

        private string strFolder = "";

        Bitmap? ColorInputImage = null;
        Bitmap? AlphaInputImage;
        Bitmap? AOInputImage;
        Bitmap? MetallicInputImage;
        Bitmap? RoughnessInputImage;
        Bitmap? NormalInputImage;

        Bitmap? NormalOutputImage;
        Bitmap? ColorAlphaOutputImage;
        Bitmap? ARMOutputImage;
        Bitmap? NRMOutputImage;

        public MainForm()
        {
            InitializeComponent();
            myTraceListener = new wifiTraceListener(lvLog, true, "LOG", TraceEventType.Verbose, 600);

            foreach (Control control in Controls)
                control.MouseClick += RedirectMouseClick;

            groupBox1.Click += groupBox1_Click;
        }

        private void RedirectMouseClick(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            Point screenPoint = control.PointToScreen(new Point(e.X, e.Y));
            Point formPoint = PointToClient(screenPoint);
            MouseEventArgs args = new MouseEventArgs(e.Button, e.Clicks,
                formPoint.X, formPoint.Y, e.Delta);
            OnMouseClick(args);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            ResetAll();
            viewerFormTimer.Tick += ViewerFormTimer_Tick;
            viewerFormTimer.Interval = 500;
            viewerFormTimer.Start();
        }



        private void ViewerFormTimer_Tick(object? sender, EventArgs e)
        {
            if (!viewer.viewerRequested && viewer.Visible)
            {
                bool bMouseInViewer = viewer.ClientRectangle.Contains(viewer.PointToClient(Cursor.Position));

                if (!viewer.viewerRequested)// && !bMouseInViewer)
                {
                    viewer.Hide();
                    //  viewerFormTimer.Stop();
                    viewerFormTimer.Interval = 3000;
                    //  Debug.Write("THIDE");
                }
            }
            else if (viewer.viewerRequested && !viewer.Visible)
            {
                viewer.StartPosition = FormStartPosition.Manual;
                viewer.Location = new Point(this.Location.X + (this.Width - viewer.Width) / 2, this.Location.Y + (this.Height - viewer.Height) / 2);

                viewer.Show(this);
                viewerFormTimer.Interval = 500;
                //Debug.Write("TSHOW");
            }

            //Debug.Write("T" + viewer.viewerRequested);
        }

        private bool IsImageFile(FileInfo f)
        {
            // Image img = Image.FromFile(f.FullName);

            return (f.Extension == ".png" || f.Extension == ".jpg" || f.Extension == ".bmp" || f.Extension == ".gif" || f.Extension == ".exr");
        }

        private string? IsColorImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;
            string prefix = null;
            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "color", "diff", "albedo", "basecolor","base" };

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            
            }

            //if (IsImageFile(f) && (f.Name.Contains("_color", StringComparison.InvariantCultureIgnoreCase) ||
            //                       f.Name.Contains("_diff", StringComparison.InvariantCultureIgnoreCase) ||
            //                         f.Name.Contains("_albedo", StringComparison.InvariantCultureIgnoreCase) ||
            //                       f.Name.Contains("_base", StringComparison.InvariantCultureIgnoreCase)))
            //  return true;

            return null;
        }

        private string? IsAlphaImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;

            string prefix = null;

            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "alpha", "mask", "opacity" };

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            }


            //if (IsImageFile(f) && (f.Name.Contains("_alpha", StringComparison.InvariantCultureIgnoreCase) ||
            //                       f.Name.Contains("_mask", StringComparison.InvariantCultureIgnoreCase) ||
            //                       f.Name.Contains("_opacity", StringComparison.InvariantCultureIgnoreCase)))
            //    return true;

            return null;
        }

        private string? IsAOImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;
            string prefix = null;
            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "ao" };

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            }


            //if (IsImageFile(f) && f.Name.Contains("_ao", StringComparison.InvariantCultureIgnoreCase))
            //    return true;

            return null;
        }

        private string? IsRoughnessImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;
            string prefix = null;
            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "rough" };

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            }

            //if (IsImageFile(f) && f.Name.Contains("_rough", StringComparison.InvariantCultureIgnoreCase))
            //    return true;

            return null;
        }

        private string? IsMetallicImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;
            string prefix = null;
            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "metal" };

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            }
            //if (IsImageFile(f) && f.Name.Contains("_metal", StringComparison.InvariantCultureIgnoreCase))
            //    return true;

            return null;
        }

        private string? IsNormalImage(FileInfo f)
        {
            if (!IsImageFile(f))
                return null;
            string prefix = null;
            string name = f.Name.Substring(0, f.Name.Length - f.Extension.Length).ToLower();
            string[] tokens = name.Split(new char[] { '_', '-' });
            string[] keywords = new string[] { "nor"};

            foreach (string token in tokens)
            {
                foreach (string keyword in keywords)
                {
                    if (token.Contains(keyword))
                        return prefix;
                }
                prefix += token + "_";
            }

            //if (IsImageFile(f) && f.Name.Contains("_nor", StringComparison.InvariantCultureIgnoreCase))
            //    return true;

            return null;
        }


        private Bitmap LoadImageFromFileInfo(FileInfo f)
        {
            Bitmap? InputImage = null;

            if (f.Extension == ".exr")
            {
                using var imageFromFile = new MagickImage(f.FullName);
                InputImage = imageFromFile.ToBitmap(MagickFormat.Png24);
            }
            else
            {
                FileStream InputStr = f.OpenRead();
                InputImage = (Bitmap)Image.FromStream(InputStr);
                InputStr.Close();
            }

            return InputImage;
        }

        private Bitmap LoadImageFromFileName(string filename)
        {
            return LoadImageFromFileInfo(new FileInfo(filename));
        }


        private void ResetImages()
        {
            ColorInputImage = null;
            AlphaInputImage = null;
            AOInputImage = null;
            MetallicInputImage = null;
            RoughnessInputImage = null;
            NormalInputImage = null;

            NormalOutputImage = null;
            ColorAlphaOutputImage = null;
            ARMOutputImage = null;
            NRMOutputImage = null;

            pbColorInput.Image = Properties.Resources.noimage;
            pbAlphaInput.Image = Properties.Resources.noimage;
            pbAOInput.Image = Properties.Resources.noimage;
            pbRoughnessInput.Image = Properties.Resources.noimage;
            pbMetallicInput.Image = Properties.Resources.noimage;
            pbNormalInput.Image = Properties.Resources.noimage;

            pbColorAlphaOutput.Image = Properties.Resources.noimage;
            pbARMOutput.Image = Properties.Resources.noimage;
            pbNRMOutput.Image = Properties.Resources.noimage;
            pbNormalOutput.Image = Properties.Resources.noimage;

            lbColorSizes.Text = "";
            lbAlphaSizes.Text = "";
            lbAOSizes.Text = "";
            lbRoughnessSizes.Text = "";
            lbMetallicSizes.Text = "";
            lbNormalSizes.Text = "";
            lbColorAlphaSizes.Text = "";
            lbARMSizes.Text = "";
            lbNRMSizes.Text = "";
            lbInvertedGNormalSizes.Text = "";
        }


        private void ResetAll()
        {
            ResetImages();

            txtColorFilename.Text = "";
            txtAlphaFilename.Text = "";
            txtAOFilename.Text = "";
            txtRoughnessFilename.Text = "";
            txtMetallicFilename.Text = "";
            txtNormalFilename.Text = "";

            lvLog.Items.Clear();
        }



        private bool LoadInputFolder()
        {
            ResetAll();

            string[] prefixes = new string[6];

            try
            {
                DirectoryInfo dir = new DirectoryInfo(strFolder);

                foreach (FileInfo f in dir.GetFiles())
                {
                    if ((prefixes[0] = IsColorImage(f)!) != null)
                    {
                        txtColorFilename.Text = f.FullName;
                        tbPrefix.Text = prefixes[0];
                    }
                    else if ((prefixes[1] = IsAlphaImage(f)!) != null)
                    {
                        txtAlphaFilename.Text = f.FullName;
                    }
                    else if ((prefixes[2] = IsAOImage(f)!) != null)
                    {
                        txtAOFilename.Text = f.FullName;
                    }
                    else if ((prefixes[3] = IsRoughnessImage(f)!) != null)
                    {
                        txtRoughnessFilename.Text = f.FullName;
                    }
                    else if ((prefixes[4] = IsNormalImage(f)!) != null)
                    {
                        txtNormalFilename.Text = f.FullName;
                    }
                    else if ((prefixes[5] = IsMetallicImage(f)!) != null)
                    {
                        txtMetallicFilename.Text = f.FullName;
                    }
                }

                Trace.WriteLine("Folder preloaded, check image filenames");

                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            return false;
        }


        private bool FlipNormalGreens()
        {
            try
            {

                if (NormalInputImage == null)
                {
                    Trace.WriteLine("normal image not found");
                    return false;
                }

                NormalOutputImage = new Bitmap(NormalInputImage);

                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, NormalOutputImage.Width, NormalOutputImage.Height);

                System.Drawing.Imaging.BitmapData bmpData =
                    NormalOutputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmpData.Height;
                byte[] bgraValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, bgraValues, 0, bytes);

                for (int pos = 1; pos < bytes; pos += 4)
                    bgraValues[pos] = (byte)(255 - bgraValues[pos]);//G

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(bgraValues, 0, ptr, bytes);

                // Unlock the bits.
                NormalOutputImage.UnlockBits(bmpData);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }


        private bool MergeAlphaChannel()
        {
            bool bAlphaNeeded = false;

            try
            {

                if (ColorInputImage == null)
                {
                    Trace.WriteLine("color image not found");
                    return false;
                }

                if (AlphaInputImage == null)
                {
                    Trace.WriteLine("alpha image not found. Assuming full opacity");
                    // return;
                    AlphaInputImage = new Bitmap(ColorInputImage);
                    bAlphaNeeded = true;
                }

                Size imgsize;

                if (!CheckSizes(ColorInputImage, AlphaInputImage, null, out imgsize))
                {
                    Trace.WriteLine("No image ready for ARM or incongruent sizes");
                    return false;
                }

                // Debug.Assert(ColorInputImage.Size.Equals(AlphaInputImage.Size));

                int nPixels = imgsize.Height * imgsize.Width;

                ColorAlphaOutputImage = new Bitmap(ColorInputImage);

                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, imgsize.Width, imgsize.Height);

                BitmapData bmpData =
                    ColorAlphaOutputImage.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                BitmapData bmpDataAlpha =
                    AlphaInputImage.LockBits(rect, bAlphaNeeded ? ImageLockMode.ReadWrite : ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;
                IntPtr ptrAlpha = bmpDataAlpha.Scan0;
                // Declare an array to hold the bytes of the bitmap.

                int nBytes = Math.Abs(bmpData.Stride) * bmpData.Height;
                byte[] bgraValues = new byte[nBytes];

                int nAlphaBytes = Math.Abs(bmpDataAlpha.Stride) * bmpDataAlpha.Height;
                byte[] alphaValues = new byte[nAlphaBytes];
                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, bgraValues, 0, nBytes);
                System.Runtime.InteropServices.Marshal.Copy(ptrAlpha, alphaValues, 0, nAlphaBytes);

                if (bAlphaNeeded)
                {
                    for (int i = 0; i < nAlphaBytes; i++)
                    {
                        alphaValues[i] = 255;
                    }
                }


                for (int pos = 0; pos < nPixels; pos++)
                {
                    bgraValues[3 + 4 * pos] = alphaValues[0 + 4 * pos];//A
                }

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(bgraValues, 0, ptr, nBytes);

                if (bAlphaNeeded)
                    System.Runtime.InteropServices.Marshal.Copy(alphaValues, 0, ptrAlpha, nAlphaBytes);

                // Unlock the bits.
                ColorAlphaOutputImage.UnlockBits(bmpData);
                AlphaInputImage.UnlockBits(bmpDataAlpha);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }


        private bool CheckSizes(Bitmap? img0, Bitmap? img1, Bitmap? img2, out Size size)
        {
            int pos = 0;
            Bitmap[] nonnullImgs = new Bitmap[3];

            if (img0 != null)
                nonnullImgs[pos++] = img0;

            if (img1 != null)
                nonnullImgs[pos++] = img1;

            if (img2 != null)
                nonnullImgs[pos++] = img2;

            if (pos == 0)
            {
                size = new Size(0, 0);
                return false;
            }

            Size size0 = nonnullImgs[0].Size;

            for (int i = 0; i < pos; i++)
            {
                if (nonnullImgs[i] != null)
                {
                    Size size1 = nonnullImgs[i].Size;
                    if (!size0.Equals(size1))
                    {
                        size = new Size(0, 0);
                        return false;
                    }

                    size0 = size1;
                }
            }

            //at least one non null image
            //all existing images same size

            size = size0;
            return true;
        }



        private bool MergeNRMChannels()
        {
            Size imgsize;

            if (!CheckSizes(NormalInputImage, MetallicInputImage, RoughnessInputImage, out imgsize))
            {
                Trace.WriteLine("No image ready for ARM or incongruent sizes");
                return false;
            }

            try
            {

                int nPixels = imgsize.Height * imgsize.Width;

                NRMOutputImage = new Bitmap(imgsize.Width, imgsize.Height, PixelFormat.Format24bppRgb);

                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, NRMOutputImage.Width, NRMOutputImage.Height);

                System.Drawing.Imaging.BitmapData bmpDataNRM =
                   NRMOutputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);

                System.Drawing.Imaging.BitmapData? bmpDataNormal = null;
                if (NormalInputImage != null)
                    bmpDataNormal = NormalInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


                System.Drawing.Imaging.BitmapData? bmpDataRoughness = null;
                if (RoughnessInputImage != null)
                    bmpDataRoughness = RoughnessInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                System.Drawing.Imaging.BitmapData? bmpDataMetallic = null;
                if (MetallicInputImage != null)
                    bmpDataMetallic = MetallicInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


                // Get the address of the first line.
                IntPtr ptrNRM = bmpDataNRM.Scan0;
                // Declare an array to hold the bytes of the bitmap.
                int nBytesNRM = Math.Abs(bmpDataNRM.Stride) * bmpDataNRM.Height;
                byte[] bgrValues = new byte[nBytesNRM];

                byte[]? NormalValues = null;

                if (bmpDataNormal != null)
                {
                    IntPtr ptrNormal = bmpDataNormal.Scan0;
                    int nBytesNormal = Math.Abs(bmpDataNormal.Stride) * bmpDataNormal.Height;
                    NormalValues = new byte[nBytesNormal];
                    System.Runtime.InteropServices.Marshal.Copy(ptrNormal, NormalValues, 0, nBytesNormal);
                }

                byte[]? roughnessValues = null;

                if (bmpDataRoughness != null)
                {
                    IntPtr ptrRoughness = bmpDataRoughness.Scan0;
                    int nBytesRoughness = Math.Abs(bmpDataRoughness.Stride) * bmpDataRoughness.Height;
                    roughnessValues = new byte[nBytesRoughness];
                    System.Runtime.InteropServices.Marshal.Copy(ptrRoughness, roughnessValues, 0, nBytesRoughness);

                }

                byte[]? metallicValues = null;

                if (bmpDataMetallic != null)
                {
                    IntPtr ptrMetallic = bmpDataMetallic.Scan0;
                    int nBytesMetallic = Math.Abs(bmpDataMetallic.Stride) * bmpDataMetallic.Height;
                    metallicValues = new byte[nBytesMetallic];
                    System.Runtime.InteropServices.Marshal.Copy(ptrMetallic, metallicValues, 0, nBytesMetallic);
                }

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptrNRM, bgrValues, 0, nBytesNRM);
                
                //Ground COMP channels:
                //red= metallic
                //green = x value of the normal(normal red channel)
                //blue= roughness
                //alpha = y value of the normal(normal green channel)

                for (int pos = 0; pos < nPixels; pos++)
                {   
                    bgrValues[4 * pos + 0] = roughnessValues != null ? roughnessValues[0 + 4 * pos] : (byte)0;//B
                    bgrValues[4 * pos + 1] = NormalValues != null ? NormalValues[2 + 4 * pos] : (byte)0;//G
                    bgrValues[4 * pos + 2] = metallicValues != null ? metallicValues[0 + 4 * pos] : (byte)0;//R
                    bgrValues[4 * pos + 3] = NormalValues != null ? (cbFlipNormalsG.Checked? (byte)(255 - NormalValues[1 + 4 * pos]): NormalValues[1 + 4 * pos]) : (byte)0;//A
                }

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(bgrValues, 0, ptrNRM, nBytesNRM);


                // Unlock the bits.
                NRMOutputImage.UnlockBits(bmpDataNRM);

                if (NormalInputImage != null && bmpDataNormal != null)
                    NormalInputImage.UnlockBits(bmpDataNormal);

                if (RoughnessInputImage != null && bmpDataRoughness != null)
                    RoughnessInputImage.UnlockBits(bmpDataRoughness);

                if (MetallicInputImage != null && bmpDataMetallic != null)
                    MetallicInputImage.UnlockBits(bmpDataMetallic);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }




        private bool MergeARMChannels()
        {
            Size imgsize;

            if (!CheckSizes(AOInputImage, MetallicInputImage, RoughnessInputImage, out imgsize))
            {
                Trace.WriteLine("No image ready for ARM or incongruent sizes");
                return false;
            }

            try
            {

                int nPixels = imgsize.Height * imgsize.Width;

                ARMOutputImage = new Bitmap(imgsize.Width, imgsize.Height, PixelFormat.Format24bppRgb);

                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, ARMOutputImage.Width, ARMOutputImage.Height);

                System.Drawing.Imaging.BitmapData bmpDataARM =
                   ARMOutputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                System.Drawing.Imaging.BitmapData? bmpDataAO = null;
                if (AOInputImage != null)
                    bmpDataAO = AOInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


                System.Drawing.Imaging.BitmapData? bmpDataRoughness = null;
                if (RoughnessInputImage != null)
                    bmpDataRoughness = RoughnessInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                System.Drawing.Imaging.BitmapData? bmpDataMetallic = null;
                if (MetallicInputImage != null)
                    bmpDataMetallic = MetallicInputImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


                // Get the address of the first line.
                IntPtr ptrARM = bmpDataARM.Scan0;
                // Declare an array to hold the bytes of the bitmap.
                int nBytesARM = Math.Abs(bmpDataARM.Stride) * bmpDataARM.Height;
                byte[] bgrValues = new byte[nBytesARM];

                byte[]? aoValues = null;

                if (bmpDataAO != null)
                {
                    IntPtr ptrAO = bmpDataAO.Scan0;
                    int nBytesAO = Math.Abs(bmpDataAO.Stride) * bmpDataAO.Height;
                    aoValues = new byte[nBytesAO];
                    System.Runtime.InteropServices.Marshal.Copy(ptrAO, aoValues, 0, nBytesAO);
                }

                byte[]? roughnessValues = null;

                if (bmpDataRoughness != null)
                {
                    IntPtr ptrRoughness = bmpDataRoughness.Scan0;
                    int nBytesRoughness = Math.Abs(bmpDataRoughness.Stride) * bmpDataRoughness.Height;
                    roughnessValues = new byte[nBytesRoughness];
                    System.Runtime.InteropServices.Marshal.Copy(ptrRoughness, roughnessValues, 0, nBytesRoughness);

                }

                byte[]? metallicValues = null;

                if (bmpDataMetallic != null)
                {
                    IntPtr ptrMetallic = bmpDataMetallic.Scan0;
                    int nBytesMetallic = Math.Abs(bmpDataMetallic.Stride) * bmpDataMetallic.Height;
                    metallicValues = new byte[nBytesMetallic];
                    System.Runtime.InteropServices.Marshal.Copy(ptrMetallic, metallicValues, 0, nBytesMetallic);
                }

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptrARM, bgrValues, 0, nBytesARM);

                for (int pos = 0; pos < nPixels; pos++)
                {
                    bgrValues[3 * pos + 2] = aoValues != null ? aoValues[0 + 4 * pos] : (byte)0;//R
                    bgrValues[3 * pos + 1] = roughnessValues != null ? roughnessValues[0 + 4 * pos] : (byte)0;//G
                    bgrValues[3 * pos + 0] = metallicValues != null ? metallicValues[0 + 4 * pos] : (byte)0;//B
                }

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(bgrValues, 0, ptrARM, nBytesARM);


                // Unlock the bits.
                ARMOutputImage.UnlockBits(bmpDataARM);

                if (AOInputImage != null && bmpDataAO != null)
                    AOInputImage.UnlockBits(bmpDataAO);

                if (RoughnessInputImage != null && bmpDataRoughness != null)
                    RoughnessInputImage.UnlockBits(bmpDataRoughness);

                if (MetallicInputImage != null && bmpDataMetallic != null)
                    MetallicInputImage.UnlockBits(bmpDataMetallic);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }


        private string GetImageSizes(Bitmap bmp)
        {
            return bmp.Width + "x" + bmp.Height;
        }


        private void DoProcessFolder()
        {
            ResetImages();

            if (txtColorFilename.Text != "")
            {
                ColorInputImage = LoadImageFromFileName(txtColorFilename.Text);
                pbColorInput.Image = ColorInputImage;
                lbColorSizes.Text = GetImageSizes(ColorInputImage);
            }

            if (txtAlphaFilename.Text != "")
            {
                AlphaInputImage = LoadImageFromFileName(txtAlphaFilename.Text);
                pbAlphaInput.Image = AlphaInputImage;
                lbAlphaSizes.Text = GetImageSizes(AlphaInputImage);
            }

            if (txtAOFilename.Text != "")
            {
                AOInputImage = LoadImageFromFileName(txtAOFilename.Text);
                pbAOInput.Image = AOInputImage;
                lbAOSizes.Text = GetImageSizes(AOInputImage);
            }

            if (txtRoughnessFilename.Text != "")
            {
                RoughnessInputImage = LoadImageFromFileName(txtRoughnessFilename.Text);
                pbRoughnessInput.Image = RoughnessInputImage;
                lbRoughnessSizes.Text = GetImageSizes(RoughnessInputImage);
            }

            if (txtNormalFilename.Text != "")
            {
                NormalInputImage = LoadImageFromFileName(txtNormalFilename.Text);
                pbNormalInput.Image = NormalInputImage;
                lbNormalSizes.Text = GetImageSizes(NormalInputImage);
            }

            if (txtMetallicFilename.Text != "")
            {
                MetallicInputImage = LoadImageFromFileName(txtMetallicFilename.Text);
                pbMetallicInput.Image = MetallicInputImage;
                lbMetallicSizes.Text = GetImageSizes(MetallicInputImage);
            }
            try
            {
                if (cbFlipNormalsG.Checked)
                {
                    if (FlipNormalGreens())
                    {
                        if (NormalOutputImage != null)
                        {
                            pbNormalOutput.Image = NormalOutputImage;
                            lbInvertedGNormalSizes.Text = GetImageSizes(NormalOutputImage);
                        }
                    }
                }


                if (MergeAlphaChannel())
                {
                    if (AlphaInputImage != null)
                    {
                        pbAlphaInput.Image = AlphaInputImage;//constructed on the fly
                        lbAlphaSizes.Text = GetImageSizes(AlphaInputImage);
                    }
                    if (ColorAlphaOutputImage != null)
                    {
                        pbColorAlphaOutput.Image = ColorAlphaOutputImage;
                        lbColorAlphaSizes.Text = GetImageSizes(ColorAlphaOutputImage);
                    }
                }

                if (MergeARMChannels())
                {
                    if (ARMOutputImage != null)
                    {
                        pbARMOutput.Image = ARMOutputImage;
                        lbARMSizes.Text = GetImageSizes(ARMOutputImage);
                    }
                }


                if (MergeNRMChannels())
                {
                    if (NRMOutputImage != null)
                    {
                        pbNRMOutput.Image = NRMOutputImage;
                        lbNRMSizes.Text = GetImageSizes(NRMOutputImage);
                    }
                }

                btSaveAll.Enabled = NRMOutputImage != null || ARMOutputImage != null || ColorAlphaOutputImage != null || NormalOutputImage != null;


            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            Trace.WriteLine("------------------------ DONE --------------------------");
        }



        private void btChooseFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                strFolder = this.folderBrowserDialog1.SelectedPath;
                txtFolder.Text = strFolder;
                txtOutputFolder.Text = strFolder + "\\output";
                LoadInputFolder(); 
               
                DoProcessFolder();

               

            }
        }

        private void btSaveAll_Click(object sender, EventArgs e)
        {
            string outputFolder = txtOutputFolder.Text;

            try
            {
                if (outputFolder != "" && !Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }


                if (NormalOutputImage != null)
                {
                    NormalOutputImage.Save(outputFolder + "\\" + tbPrefix.Text + "invertedG_normal.png", ImageFormat.Png);
                    Trace.WriteLine("SAVED: " + outputFolder +"\\"+ tbPrefix.Text + "invertedG_normal.png");
                }

                if (ColorAlphaOutputImage != null)
                {
                    ColorAlphaOutputImage.Save(outputFolder + "\\" + tbPrefix.Text + "color_rgba.png", ImageFormat.Png);
                    Trace.WriteLine("SAVED: " + outputFolder + "\\" + tbPrefix.Text + "color_rgba.png");
                }

                if (ARMOutputImage != null)
                {
                    ARMOutputImage.Save(outputFolder + "\\" + tbPrefix.Text + "arm_comp.png", ImageFormat.Png);
                    Trace.WriteLine("SAVED: " + outputFolder + "\\" + tbPrefix.Text + "arm_comp.png");
                }

                if (NRMOutputImage != null)
                {
                    NRMOutputImage.Save(outputFolder + "\\" + tbPrefix.Text + "nrm_comp.png", ImageFormat.Png);
                    Trace.WriteLine("SAVED: " + outputFolder + "\\" + tbPrefix.Text + "nrm_comp.png");
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }


        private string SelectFile()
        {
            OpenFileDialog selectFileDialog = new OpenFileDialog();
            selectFileDialog.InitialDirectory = strFolder;
            selectFileDialog.DefaultExt = "png";
            selectFileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF;*.exr)|*.PNG;*.BMP;*.JPG;*.GIF;*.EXR|All files (*.*)|*.*";


            DialogResult result = selectFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                return selectFileDialog.FileName;
            }

            return null;
        }


        private void btSelectColor_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtColorFilename.Text = fileName;

                FileStream colorInput = new FileInfo(fileName).OpenRead();
                ColorInputImage = (Bitmap)Image.FromStream(colorInput);
                pbColorInput.Image = ColorInputImage;
                colorInput.Close();

                DoProcessFolder();
            }
        }

        private void btSelectAlpha_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtAlphaFilename.Text = fileName;
                DoProcessFolder();
            }
        }

        private void btSelectAO_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtAOFilename.Text = fileName;
                DoProcessFolder();
            }
        }

        private void btSelectMetallic_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtMetallicFilename.Text = fileName;
                DoProcessFolder();
            }

        }

        private void btSelectRoughness_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtRoughnessFilename.Text = fileName;
                DoProcessFolder();
            }
        }

        private void btSelectNormal_Click(object sender, EventArgs e)
        {
            string fileName = SelectFile();
            if (fileName != null)
            {
                txtNormalFilename.Text = fileName;
                DoProcessFolder();
            }
        }



        private void btDelColor_Click(object sender, EventArgs e)
        {
            txtColorFilename.Text = "";
            DoProcessFolder();
        }

        private void btDelAlpha_Click(object sender, EventArgs e)
        {
            txtAlphaFilename.Text = "";
            DoProcessFolder();
        }

        private void btDelAO_Click(object sender, EventArgs e)
        {
            txtAOFilename.Text = "";
            DoProcessFolder();
        }

        private void btDelMetallic_Click(object sender, EventArgs e)
        {
            txtMetallicFilename.Text = "";
            DoProcessFolder();
        }

        private void btDelRoughness_Click(object sender, EventArgs e)
        {
            txtRoughnessFilename.Text = "";
            DoProcessFolder();
        }

        private void btDelNormal_Click(object sender, EventArgs e)
        {
            txtNormalFilename.Text = "";
            DoProcessFolder();
        }

        private void cbFlipNormalsG_CheckedChanged(object sender, EventArgs e)
        {
            DoProcessFolder();
        }

        private void ShowViewer(object sender, EventArgs e)
        {
 
            Bitmap? hoverImage = null;

            if (sender == null)
                return;

            int senderTag = (int)((PictureBox)sender).Tag;
            hoverImage = (Bitmap)((PictureBox)sender).Image;


            if (hoverImage != null)
            {
                if(hoverImage.Width < viewer.ClientSize.Width || hoverImage.Height < viewer.ClientSize.Height)
                    viewer.ClientSize = new Size(hoverImage.Width, hoverImage.Height);
                viewer.pbViewer.Image = hoverImage;
                viewer.viewerRequested = true;
            }
        }


        private void groupBox1_Click(object sender, EventArgs e)
        {
            viewer.viewerRequested = false;
        }
        private void MainForm_Click(object sender, EventArgs e)
        {
            viewer.viewerRequested = false;
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            viewer.viewerRequested = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            viewer.viewerRequested = false;
        }

        private void pbThumbnail_Click(object sender, EventArgs e)
        {
            viewerFormTimer.Interval = 100;
            ShowViewer(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewerFormTimer.Stop();
            viewer.Close();
            e.Cancel = false;
        }


    }
}

