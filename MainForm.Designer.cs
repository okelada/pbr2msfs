namespace pbr2msfs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btLoadFolder = new Button();
            lvLog = new ListView();
            groupBox1 = new GroupBox();
            label23 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label15 = new Label();
            lbNormalSizes = new Label();
            lbMetallicSizes = new Label();
            lbRoughnessSizes = new Label();
            lbAOSizes = new Label();
            lbAlphaSizes = new Label();
            lbColorSizes = new Label();
            btDelNormal = new Button();
            btDelMetallic = new Button();
            btDelRoughness = new Button();
            btDelAO = new Button();
            btDelAlpha = new Button();
            btDelColor = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pbNormalInput = new PictureBox();
            pbMetallicInput = new PictureBox();
            pbRoughnessInput = new PictureBox();
            pbAOInput = new PictureBox();
            pbAlphaInput = new PictureBox();
            pbColorInput = new PictureBox();
            label8 = new Label();
            txtNormalFilename = new TextBox();
            button7 = new Button();
            label7 = new Label();
            txtMetallicFilename = new TextBox();
            button6 = new Button();
            label6 = new Label();
            txtRoughnessFilename = new TextBox();
            button5 = new Button();
            label5 = new Label();
            txtAOFilename = new TextBox();
            button4 = new Button();
            label4 = new Label();
            txtAlphaFilename = new TextBox();
            button3 = new Button();
            label3 = new Label();
            txtColorFilename = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label24 = new Label();
            tbPrefix = new TextBox();
            lbNRMSizes = new Label();
            pbNRMOutput = new PictureBox();
            label22 = new Label();
            lbInvertedGNormalSizes = new Label();
            lbARMSizes = new Label();
            lbColorAlphaSizes = new Label();
            btSaveAll = new Button();
            pbNormalOutput = new PictureBox();
            label16 = new Label();
            pbARMOutput = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            pbColorAlphaOutput = new PictureBox();
            txtFolder = new TextBox();
            label1 = new Label();
            txtOutputFolder = new TextBox();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNormalInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMetallicInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRoughnessInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAOInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlphaInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColorInput).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNRMOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNormalOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbARMOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColorAlphaOutput).BeginInit();
            SuspendLayout();
            // 
            // btLoadFolder
            // 
            btLoadFolder.Location = new Point(1146, 19);
            btLoadFolder.Name = "btLoadFolder";
            btLoadFolder.Size = new Size(138, 39);
            btLoadFolder.TabIndex = 0;
            btLoadFolder.Text = "Preload Folder";
            btLoadFolder.UseVisualStyleBackColor = true;
            btLoadFolder.Click += btChooseFolder_Click;
            // 
            // lvLog
            // 
            lvLog.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvLog.Location = new Point(11, 797);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(1290, 156);
            lvLog.TabIndex = 2;
            lvLog.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lbNormalSizes);
            groupBox1.Controls.Add(lbMetallicSizes);
            groupBox1.Controls.Add(lbRoughnessSizes);
            groupBox1.Controls.Add(lbAOSizes);
            groupBox1.Controls.Add(lbAlphaSizes);
            groupBox1.Controls.Add(lbColorSizes);
            groupBox1.Controls.Add(btDelNormal);
            groupBox1.Controls.Add(btDelMetallic);
            groupBox1.Controls.Add(btDelRoughness);
            groupBox1.Controls.Add(btDelAO);
            groupBox1.Controls.Add(btDelAlpha);
            groupBox1.Controls.Add(btDelColor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(pbNormalInput);
            groupBox1.Controls.Add(pbMetallicInput);
            groupBox1.Controls.Add(pbRoughnessInput);
            groupBox1.Controls.Add(pbAOInput);
            groupBox1.Controls.Add(pbAlphaInput);
            groupBox1.Controls.Add(pbColorInput);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNormalFilename);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMetallicFilename);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtRoughnessFilename);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAOFilename);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAlphaFilename);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtColorFilename);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(11, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1290, 451);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inputs";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.LimeGreen;
            label23.Location = new Point(846, 323);
            label23.Name = "label23";
            label23.Size = new Size(47, 50);
            label23.TabIndex = 55;
            label23.Text = "+";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.LimeGreen;
            label21.Location = new Point(1063, 323);
            label21.Name = "label21";
            label21.Size = new Size(47, 50);
            label21.TabIndex = 54;
            label21.Text = "+";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.OrangeRed;
            label20.Location = new Point(846, 269);
            label20.Name = "label20";
            label20.Size = new Size(47, 50);
            label20.TabIndex = 53;
            label20.Text = "+";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.OrangeRed;
            label19.Location = new Point(630, 269);
            label19.Name = "label19";
            label19.Size = new Size(47, 50);
            label19.TabIndex = 52;
            label19.Text = "+";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(195, 291);
            label15.Name = "label15";
            label15.Size = new Size(47, 50);
            label15.TabIndex = 51;
            label15.Text = "+";
            // 
            // lbNormalSizes
            // 
            lbNormalSizes.Font = new Font("Segoe UI", 7.8F);
            lbNormalSizes.Location = new Point(1176, 425);
            lbNormalSizes.Name = "lbNormalSizes";
            lbNormalSizes.Size = new Size(101, 20);
            lbNormalSizes.TabIndex = 50;
            lbNormalSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbMetallicSizes
            // 
            lbMetallicSizes.Font = new Font("Segoe UI", 7.8F);
            lbMetallicSizes.Location = new Point(959, 425);
            lbMetallicSizes.Name = "lbMetallicSizes";
            lbMetallicSizes.Size = new Size(101, 20);
            lbMetallicSizes.TabIndex = 49;
            lbMetallicSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbRoughnessSizes
            // 
            lbRoughnessSizes.Font = new Font("Segoe UI", 7.8F);
            lbRoughnessSizes.Location = new Point(741, 425);
            lbRoughnessSizes.Name = "lbRoughnessSizes";
            lbRoughnessSizes.Size = new Size(101, 20);
            lbRoughnessSizes.TabIndex = 48;
            lbRoughnessSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbAOSizes
            // 
            lbAOSizes.Font = new Font("Segoe UI", 7.8F);
            lbAOSizes.Location = new Point(522, 425);
            lbAOSizes.Name = "lbAOSizes";
            lbAOSizes.Size = new Size(101, 20);
            lbAOSizes.TabIndex = 47;
            lbAOSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbAlphaSizes
            // 
            lbAlphaSizes.Font = new Font("Segoe UI", 7.8F);
            lbAlphaSizes.Location = new Point(305, 425);
            lbAlphaSizes.Name = "lbAlphaSizes";
            lbAlphaSizes.Size = new Size(101, 20);
            lbAlphaSizes.TabIndex = 46;
            lbAlphaSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbColorSizes
            // 
            lbColorSizes.Font = new Font("Segoe UI", 7.8F);
            lbColorSizes.Location = new Point(87, 425);
            lbColorSizes.Name = "lbColorSizes";
            lbColorSizes.Size = new Size(101, 20);
            lbColorSizes.TabIndex = 45;
            lbColorSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // btDelNormal
            // 
            btDelNormal.Location = new Point(1147, 189);
            btDelNormal.Name = "btDelNormal";
            btDelNormal.Size = new Size(45, 29);
            btDelNormal.TabIndex = 44;
            btDelNormal.Text = "CLR";
            btDelNormal.UseVisualStyleBackColor = true;
            btDelNormal.Click += btDelNormal_Click;
            // 
            // btDelMetallic
            // 
            btDelMetallic.Location = new Point(1147, 156);
            btDelMetallic.Name = "btDelMetallic";
            btDelMetallic.Size = new Size(45, 29);
            btDelMetallic.TabIndex = 43;
            btDelMetallic.Text = "CLR";
            btDelMetallic.UseVisualStyleBackColor = true;
            btDelMetallic.Click += btDelMetallic_Click;
            // 
            // btDelRoughness
            // 
            btDelRoughness.Location = new Point(1147, 123);
            btDelRoughness.Name = "btDelRoughness";
            btDelRoughness.Size = new Size(45, 29);
            btDelRoughness.TabIndex = 42;
            btDelRoughness.Text = "CLR";
            btDelRoughness.UseVisualStyleBackColor = true;
            btDelRoughness.Click += btDelRoughness_Click;
            // 
            // btDelAO
            // 
            btDelAO.Location = new Point(1147, 91);
            btDelAO.Name = "btDelAO";
            btDelAO.Size = new Size(45, 29);
            btDelAO.TabIndex = 41;
            btDelAO.Text = "CLR";
            btDelAO.UseVisualStyleBackColor = true;
            btDelAO.Click += btDelAO_Click;
            // 
            // btDelAlpha
            // 
            btDelAlpha.Location = new Point(1147, 57);
            btDelAlpha.Name = "btDelAlpha";
            btDelAlpha.Size = new Size(45, 29);
            btDelAlpha.TabIndex = 40;
            btDelAlpha.Text = "CLR";
            btDelAlpha.UseVisualStyleBackColor = true;
            btDelAlpha.Click += btDelAlpha_Click;
            // 
            // btDelColor
            // 
            btDelColor.Location = new Point(1147, 24);
            btDelColor.Name = "btDelColor";
            btDelColor.Size = new Size(45, 29);
            btDelColor.TabIndex = 39;
            btDelColor.Text = "CLR";
            btDelColor.UseVisualStyleBackColor = true;
            btDelColor.Click += btDelColor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F);
            label9.Location = new Point(1099, 425);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 38;
            label9.Text = "Normal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F);
            label10.Location = new Point(882, 425);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 37;
            label10.Text = "Metallic";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F);
            label11.Location = new Point(664, 425);
            label11.Name = "label11";
            label11.Size = new Size(72, 17);
            label11.TabIndex = 36;
            label11.Text = "Roughness";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F);
            label12.Location = new Point(446, 425);
            label12.Name = "label12";
            label12.Size = new Size(26, 17);
            label12.TabIndex = 35;
            label12.Text = "AO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F);
            label13.Location = new Point(229, 425);
            label13.Name = "label13";
            label13.Size = new Size(41, 17);
            label13.TabIndex = 34;
            label13.Text = "Alpha";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7.8F);
            label14.Location = new Point(10, 425);
            label14.Name = "label14";
            label14.Size = new Size(50, 17);
            label14.TabIndex = 33;
            label14.Text = "Albedo";
            // 
            // pbNormalInput
            // 
            pbNormalInput.BorderStyle = BorderStyle.FixedSingle;
            pbNormalInput.Location = new Point(1113, 232);
            pbNormalInput.Name = "pbNormalInput";
            pbNormalInput.Size = new Size(160, 186);
            pbNormalInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbNormalInput.TabIndex = 32;
            pbNormalInput.TabStop = false;
            pbNormalInput.Tag = 5;
            pbNormalInput.Click += pbThumbnail_Click;
            // 
            // pbMetallicInput
            // 
            pbMetallicInput.BorderStyle = BorderStyle.FixedSingle;
            pbMetallicInput.Location = new Point(896, 232);
            pbMetallicInput.Name = "pbMetallicInput";
            pbMetallicInput.Size = new Size(160, 186);
            pbMetallicInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbMetallicInput.TabIndex = 31;
            pbMetallicInput.TabStop = false;
            pbMetallicInput.Tag = 4;
            pbMetallicInput.Click += pbThumbnail_Click;
            // 
            // pbRoughnessInput
            // 
            pbRoughnessInput.BorderStyle = BorderStyle.FixedSingle;
            pbRoughnessInput.Location = new Point(679, 232);
            pbRoughnessInput.Name = "pbRoughnessInput";
            pbRoughnessInput.Size = new Size(160, 186);
            pbRoughnessInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbRoughnessInput.TabIndex = 30;
            pbRoughnessInput.TabStop = false;
            pbRoughnessInput.Tag = 3;
            pbRoughnessInput.Click += pbThumbnail_Click;
            // 
            // pbAOInput
            // 
            pbAOInput.BorderStyle = BorderStyle.FixedSingle;
            pbAOInput.Location = new Point(462, 232);
            pbAOInput.Name = "pbAOInput";
            pbAOInput.Size = new Size(160, 186);
            pbAOInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbAOInput.TabIndex = 29;
            pbAOInput.TabStop = false;
            pbAOInput.Tag = 2;
            pbAOInput.Click += pbThumbnail_Click;
            // 
            // pbAlphaInput
            // 
            pbAlphaInput.BorderStyle = BorderStyle.FixedSingle;
            pbAlphaInput.Location = new Point(245, 232);
            pbAlphaInput.Name = "pbAlphaInput";
            pbAlphaInput.Size = new Size(160, 186);
            pbAlphaInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlphaInput.TabIndex = 28;
            pbAlphaInput.TabStop = false;
            pbAlphaInput.Tag = 1;
            pbAlphaInput.Click += pbThumbnail_Click;
            // 
            // pbColorInput
            // 
            pbColorInput.BorderStyle = BorderStyle.FixedSingle;
            pbColorInput.Location = new Point(27, 232);
            pbColorInput.Name = "pbColorInput";
            pbColorInput.Size = new Size(160, 186);
            pbColorInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbColorInput.TabIndex = 27;
            pbColorInput.TabStop = false;
            pbColorInput.Tag = 0;
            pbColorInput.Click += pbThumbnail_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 195);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 26;
            label8.Text = "Normal";
            // 
            // txtNormalFilename
            // 
            txtNormalFilename.Location = new Point(125, 191);
            txtNormalFilename.Name = "txtNormalFilename";
            txtNormalFilename.Size = new Size(1003, 27);
            txtNormalFilename.TabIndex = 25;
            // 
            // button7
            // 
            button7.Location = new Point(1199, 189);
            button7.Name = "button7";
            button7.Size = new Size(74, 29);
            button7.TabIndex = 24;
            button7.Text = "Select";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btSelectNormal_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 161);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 23;
            label7.Text = "Metallic";
            // 
            // txtMetallicFilename
            // 
            txtMetallicFilename.Location = new Point(125, 157);
            txtMetallicFilename.Name = "txtMetallicFilename";
            txtMetallicFilename.Size = new Size(1003, 27);
            txtMetallicFilename.TabIndex = 22;
            // 
            // button6
            // 
            button6.Location = new Point(1199, 156);
            button6.Name = "button6";
            button6.Size = new Size(74, 29);
            button6.TabIndex = 21;
            button6.Text = "Select";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btSelectMetallic_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 128);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 20;
            label6.Text = "Roughness";
            // 
            // txtRoughnessFilename
            // 
            txtRoughnessFilename.Location = new Point(125, 125);
            txtRoughnessFilename.Name = "txtRoughnessFilename";
            txtRoughnessFilename.Size = new Size(1003, 27);
            txtRoughnessFilename.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(1199, 123);
            button5.Name = "button5";
            button5.Size = new Size(74, 29);
            button5.TabIndex = 18;
            button5.Text = "Select";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btSelectRoughness_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 95);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 17;
            label5.Text = "AO";
            // 
            // txtAOFilename
            // 
            txtAOFilename.Location = new Point(125, 92);
            txtAOFilename.Name = "txtAOFilename";
            txtAOFilename.Size = new Size(1003, 27);
            txtAOFilename.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(1199, 91);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 15;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btSelectAO_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 61);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 14;
            label4.Text = "Alpha";
            // 
            // txtAlphaFilename
            // 
            txtAlphaFilename.Location = new Point(125, 59);
            txtAlphaFilename.Name = "txtAlphaFilename";
            txtAlphaFilename.Size = new Size(1003, 27);
            txtAlphaFilename.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(1199, 57);
            button3.Name = "button3";
            button3.Size = new Size(74, 29);
            button3.TabIndex = 12;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btSelectAlpha_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 29);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Albedo";
            // 
            // txtColorFilename
            // 
            txtColorFilename.Location = new Point(125, 27);
            txtColorFilename.Name = "txtColorFilename";
            txtColorFilename.Size = new Size(1003, 27);
            txtColorFilename.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(1199, 24);
            button2.Name = "button2";
            button2.Size = new Size(74, 29);
            button2.TabIndex = 9;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btSelectColor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(tbPrefix);
            groupBox2.Controls.Add(lbNRMSizes);
            groupBox2.Controls.Add(pbNRMOutput);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(lbInvertedGNormalSizes);
            groupBox2.Controls.Add(lbARMSizes);
            groupBox2.Controls.Add(lbColorAlphaSizes);
            groupBox2.Controls.Add(btSaveAll);
            groupBox2.Controls.Add(pbNormalOutput);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(pbARMOutput);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(pbColorAlphaOutput);
            groupBox2.Location = new Point(11, 545);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1290, 247);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Outputs";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(15, 41);
            label24.Name = "label24";
            label24.Size = new Size(46, 20);
            label24.TabIndex = 56;
            label24.Text = "Prefix";
            // 
            // tbPrefix
            // 
            tbPrefix.Location = new Point(67, 38);
            tbPrefix.Name = "tbPrefix";
            tbPrefix.Size = new Size(233, 27);
            tbPrefix.TabIndex = 56;
            // 
            // lbNRMSizes
            // 
            lbNRMSizes.Font = new Font("Segoe UI", 7.8F);
            lbNRMSizes.ForeColor = Color.FromArgb(0, 192, 0);
            lbNRMSizes.Location = new Point(939, 220);
            lbNRMSizes.Name = "lbNRMSizes";
            lbNRMSizes.Size = new Size(101, 20);
            lbNRMSizes.TabIndex = 56;
            lbNRMSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // pbNRMOutput
            // 
            pbNRMOutput.BorderStyle = BorderStyle.FixedSingle;
            pbNRMOutput.Location = new Point(872, 27);
            pbNRMOutput.Name = "pbNRMOutput";
            pbNRMOutput.Size = new Size(160, 186);
            pbNRMOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbNRMOutput.TabIndex = 54;
            pbNRMOutput.TabStop = false;
            pbNRMOutput.Tag = 9;
            pbNRMOutput.Click += pbThumbnail_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 7.8F);
            label22.ForeColor = Color.FromArgb(0, 192, 0);
            label22.Location = new Point(859, 220);
            label22.Name = "label22";
            label22.Size = new Size(83, 17);
            label22.TabIndex = 55;
            label22.Text = "NRM(COMP)";
            // 
            // lbInvertedGNormalSizes
            // 
            lbInvertedGNormalSizes.Font = new Font("Segoe UI", 7.8F);
            lbInvertedGNormalSizes.Location = new Point(1180, 220);
            lbInvertedGNormalSizes.Name = "lbInvertedGNormalSizes";
            lbInvertedGNormalSizes.Size = new Size(101, 20);
            lbInvertedGNormalSizes.TabIndex = 53;
            lbInvertedGNormalSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbARMSizes
            // 
            lbARMSizes.Font = new Font("Segoe UI", 7.8F);
            lbARMSizes.ForeColor = Color.Red;
            lbARMSizes.Location = new Point(694, 221);
            lbARMSizes.Name = "lbARMSizes";
            lbARMSizes.Size = new Size(101, 20);
            lbARMSizes.TabIndex = 52;
            lbARMSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // lbColorAlphaSizes
            // 
            lbColorAlphaSizes.Font = new Font("Segoe UI", 7.8F);
            lbColorAlphaSizes.Location = new Point(453, 220);
            lbColorAlphaSizes.Name = "lbColorAlphaSizes";
            lbColorAlphaSizes.Size = new Size(101, 20);
            lbColorAlphaSizes.TabIndex = 51;
            lbColorAlphaSizes.TextAlign = ContentAlignment.TopRight;
            // 
            // btSaveAll
            // 
            btSaveAll.Enabled = false;
            btSaveAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSaveAll.Location = new Point(15, 165);
            btSaveAll.Name = "btSaveAll";
            btSaveAll.Size = new Size(131, 48);
            btSaveAll.TabIndex = 9;
            btSaveAll.Text = "Save outputs";
            btSaveAll.UseVisualStyleBackColor = true;
            btSaveAll.Click += btSaveAll_Click;
            // 
            // pbNormalOutput
            // 
            pbNormalOutput.BorderStyle = BorderStyle.FixedSingle;
            pbNormalOutput.Location = new Point(1113, 27);
            pbNormalOutput.Name = "pbNormalOutput";
            pbNormalOutput.Size = new Size(160, 186);
            pbNormalOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbNormalOutput.TabIndex = 35;
            pbNormalOutput.TabStop = false;
            pbNormalOutput.Tag = 8;
            pbNormalOutput.Click += pbThumbnail_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F);
            label16.Location = new Point(1099, 220);
            label16.Name = "label16";
            label16.Size = new Size(72, 17);
            label16.TabIndex = 41;
            label16.Text = "Inv. Y normal";
            // 
            // pbARMOutput
            // 
            pbARMOutput.BackColor = SystemColors.Control;
            pbARMOutput.BorderStyle = BorderStyle.FixedSingle;
            pbARMOutput.Location = new Point(629, 27);
            pbARMOutput.Name = "pbARMOutput";
            pbARMOutput.Size = new Size(160, 186);
            pbARMOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbARMOutput.TabIndex = 34;
            pbARMOutput.TabStop = false;
            pbARMOutput.Tag = 7;
            pbARMOutput.Click += pbThumbnail_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 7.8F);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(616, 220);
            label17.Name = "label17";
            label17.Size = new Size(81, 17);
            label17.TabIndex = 40;
            label17.Text = "ARM(COMP)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 7.8F);
            label18.Location = new Point(373, 220);
            label18.Name = "label18";
            label18.Size = new Size(40, 17);
            label18.TabIndex = 39;
            label18.Text = "RGBA";
            // 
            // pbColorAlphaOutput
            // 
            pbColorAlphaOutput.BorderStyle = BorderStyle.FixedSingle;
            pbColorAlphaOutput.Location = new Point(388, 27);
            pbColorAlphaOutput.Name = "pbColorAlphaOutput";
            pbColorAlphaOutput.Size = new Size(160, 186);
            pbColorAlphaOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbColorAlphaOutput.TabIndex = 33;
            pbColorAlphaOutput.TabStop = false;
            pbColorAlphaOutput.Tag = 6;
            pbColorAlphaOutput.Click += pbThumbnail_Click;
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(137, 23);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(988, 27);
            txtFolder.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "PBR folder";
            // 
            // txtOutputFolder
            // 
            txtOutputFolder.Location = new Point(137, 56);
            txtOutputFolder.Name = "txtOutputFolder";
            txtOutputFolder.Size = new Size(988, 27);
            txtOutputFolder.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 8;
            label2.Text = "Output folder";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 965);
            Controls.Add(label2);
            Controls.Add(txtOutputFolder);
            Controls.Add(label1);
            Controls.Add(txtFolder);
            Controls.Add(groupBox1);
            Controls.Add(lvLog);
            Controls.Add(btLoadFolder);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PBR2MSFS";
            FormClosing += MainForm_FormClosing;
            Load += Mainform_Load;
            Click += MainForm_Click;
            DoubleClick += MainForm_DoubleClick;
            KeyDown += MainForm_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNormalInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMetallicInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRoughnessInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAOInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlphaInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColorInput).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNRMOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNormalOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbARMOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColorAlphaOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btLoadFolder;
        private ListView lvLog;
        private GroupBox groupBox1;
        private PictureBox pbNormalInput;
        private PictureBox pbMetallicInput;
        private PictureBox pbRoughnessInput;
        private PictureBox pbAOInput;
        private PictureBox pbAlphaInput;
        private PictureBox pbColorInput;
        private Label label8;
        private TextBox txtNormalFilename;
        private Button button7;
        private Label label7;
        private TextBox txtMetallicFilename;
        private Button button6;
        private Label label6;
        private TextBox txtRoughnessFilename;
        private Button button5;
        private Label label5;
        private TextBox txtAOFilename;
        private Button button4;
        private Label label4;
        private TextBox txtAlphaFilename;
        private Button button3;
        private Label label3;
        private TextBox txtColorFilename;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox txtFolder;
        private Label label1;
        private TextBox txtOutputFolder;
        private Label label2;
        private PictureBox pbNormalOutput;
        private PictureBox pbARMOutput;
        private PictureBox pbColorAlphaOutput;
        private Button btSaveAll;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btDelNormal;
        private Button btDelMetallic;
        private Button btDelRoughness;
        private Button btDelAO;
        private Button btDelAlpha;
        private Button btDelColor;
        private Label lbNormalSizes;
        private Label lbMetallicSizes;
        private Label lbRoughnessSizes;
        private Label lbAOSizes;
        private Label lbAlphaSizes;
        private Label lbColorSizes;
        private Label lbInvertedGNormalSizes;
        private Label lbARMSizes;
        private Label lbColorAlphaSizes;
        private Label label20;
        private Label label19;
        private Label label15;
        private Label label23;
        private Label label21;
        private Label lbNRMSizes;
        private PictureBox pbNRMOutput;
        private Label label22;
        private Label label24;
        private TextBox tbPrefix;
    }
}