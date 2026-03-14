using ImageMagick;
using ImageMagick.Factories;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbr2msfs
{
    static internal class Extensions
    {
        public static Bitmap ToBitmap(this IMagickImage mimg, MagickFormat fmt = MagickFormat.Png24)
        {
            Bitmap bmp = null;
            using (MemoryStream ms = new MemoryStream())
            {
                mimg.Write(ms, fmt);
                ms.Position = 0;
                bmp = (Bitmap)Bitmap.FromStream(ms);
            }
            return bmp;
        }


        public static IMagickImage ToMagickImage(this Bitmap bmp)
        {
            IMagickImage img = null;
            MagickFactory f = new MagickFactory();
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                ms.Position = 0;
                img = new MagickImage(f.Image.Create(ms));
            }
            return img;
        }

    }
}
