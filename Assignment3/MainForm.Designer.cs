namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnDeal = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            picCard1 = new PictureBox();
            picCard2 = new PictureBox();
            picCard3 = new PictureBox();
            picCard4 = new PictureBox();
            picCard5 = new PictureBox();
            imglstDeck = new ImageList(components);
            opfiLoadHand = new OpenFileDialog();
            safiSaveHand = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeal.Location = new Point(12, 12);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(144, 48);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(366, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Hand";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoad.Location = new Point(516, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(144, 48);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Hand";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // chkKeep1
            // 
            chkKeep1.AutoSize = true;
            chkKeep1.Location = new Point(12, 206);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(77, 24);
            chkKeep1.TabIndex = 3;
            chkKeep1.Text = "Keep 1";
            chkKeep1.UseVisualStyleBackColor = true;
            // 
            // chkKeep2
            // 
            chkKeep2.AutoSize = true;
            chkKeep2.Location = new Point(143, 206);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(77, 24);
            chkKeep2.TabIndex = 4;
            chkKeep2.Text = "Keep 2";
            chkKeep2.UseVisualStyleBackColor = true;
            // 
            // chkKeep3
            // 
            chkKeep3.AutoSize = true;
            chkKeep3.Location = new Point(274, 206);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(77, 24);
            chkKeep3.TabIndex = 5;
            chkKeep3.Text = "Keep 3";
            chkKeep3.UseVisualStyleBackColor = true;
            // 
            // chkKeep4
            // 
            chkKeep4.AutoSize = true;
            chkKeep4.Location = new Point(405, 206);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(77, 24);
            chkKeep4.TabIndex = 6;
            chkKeep4.Text = "Keep 4";
            chkKeep4.UseVisualStyleBackColor = true;
            // 
            // chkKeep5
            // 
            chkKeep5.AutoSize = true;
            chkKeep5.Location = new Point(536, 206);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(77, 24);
            chkKeep5.TabIndex = 7;
            chkKeep5.Text = "Keep 5";
            chkKeep5.UseVisualStyleBackColor = true;
            // 
            // picCard1
            // 
            picCard1.Location = new Point(12, 236);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(125, 202);
            picCard1.SizeMode = PictureBoxSizeMode.Zoom;
            picCard1.TabIndex = 8;
            picCard1.TabStop = false;
            // 
            // picCard2
            // 
            picCard2.Location = new Point(143, 236);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(125, 202);
            picCard2.SizeMode = PictureBoxSizeMode.Zoom;
            picCard2.TabIndex = 9;
            picCard2.TabStop = false;
            // 
            // picCard3
            // 
            picCard3.Location = new Point(274, 236);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(125, 202);
            picCard3.SizeMode = PictureBoxSizeMode.Zoom;
            picCard3.TabIndex = 10;
            picCard3.TabStop = false;
            // 
            // picCard4
            // 
            picCard4.Location = new Point(405, 236);
            picCard4.Name = "picCard4";
            picCard4.Size = new Size(125, 202);
            picCard4.SizeMode = PictureBoxSizeMode.Zoom;
            picCard4.TabIndex = 11;
            picCard4.TabStop = false;
            // 
            // picCard5
            // 
            picCard5.Location = new Point(536, 236);
            picCard5.Name = "picCard5";
            picCard5.Size = new Size(125, 202);
            picCard5.SizeMode = PictureBoxSizeMode.Zoom;
            picCard5.TabIndex = 12;
            picCard5.TabStop = false;
            // 
            // imglstDeck
            // 
            imglstDeck.ColorDepth = ColorDepth.Depth32Bit;
            imglstDeck.ImageStream = (ImageListStreamer)resources.GetObject("imglstDeck.ImageStream");
            imglstDeck.TransparentColor = Color.Transparent;
            imglstDeck.Images.SetKeyName(0, "p0.png");
            imglstDeck.Images.SetKeyName(1, "p1.png");
            imglstDeck.Images.SetKeyName(2, "p2.png");
            imglstDeck.Images.SetKeyName(3, "p3.png");
            imglstDeck.Images.SetKeyName(4, "p4.png");
            imglstDeck.Images.SetKeyName(5, "p5.png");
            imglstDeck.Images.SetKeyName(6, "p6.png");
            imglstDeck.Images.SetKeyName(7, "p7.png");
            imglstDeck.Images.SetKeyName(8, "p8.png");
            imglstDeck.Images.SetKeyName(9, "p9.png");
            imglstDeck.Images.SetKeyName(10, "p10.png");
            imglstDeck.Images.SetKeyName(11, "p11.png");
            imglstDeck.Images.SetKeyName(12, "p12.png");
            imglstDeck.Images.SetKeyName(13, "p13.png");
            imglstDeck.Images.SetKeyName(14, "p14.png");
            imglstDeck.Images.SetKeyName(15, "p15.png");
            imglstDeck.Images.SetKeyName(16, "p16.png");
            imglstDeck.Images.SetKeyName(17, "p17.png");
            imglstDeck.Images.SetKeyName(18, "p18.png");
            imglstDeck.Images.SetKeyName(19, "p19.png");
            imglstDeck.Images.SetKeyName(20, "p20.png");
            imglstDeck.Images.SetKeyName(21, "p21.png");
            imglstDeck.Images.SetKeyName(22, "p22.png");
            imglstDeck.Images.SetKeyName(23, "p23.png");
            imglstDeck.Images.SetKeyName(24, "p24.png");
            imglstDeck.Images.SetKeyName(25, "p25.png");
            imglstDeck.Images.SetKeyName(26, "p26.png");
            imglstDeck.Images.SetKeyName(27, "p27.png");
            imglstDeck.Images.SetKeyName(28, "p28.png");
            imglstDeck.Images.SetKeyName(29, "p29.png");
            imglstDeck.Images.SetKeyName(30, "p30.png");
            imglstDeck.Images.SetKeyName(31, "p31.png");
            imglstDeck.Images.SetKeyName(32, "p32.png");
            imglstDeck.Images.SetKeyName(33, "p33.png");
            imglstDeck.Images.SetKeyName(34, "p34.png");
            imglstDeck.Images.SetKeyName(35, "p35.png");
            imglstDeck.Images.SetKeyName(36, "p36.png");
            imglstDeck.Images.SetKeyName(37, "p37.png");
            imglstDeck.Images.SetKeyName(38, "p38.png");
            imglstDeck.Images.SetKeyName(39, "p39.png");
            imglstDeck.Images.SetKeyName(40, "p40.png");
            imglstDeck.Images.SetKeyName(41, "p41.png");
            imglstDeck.Images.SetKeyName(42, "p42.png");
            imglstDeck.Images.SetKeyName(43, "p43.png");
            imglstDeck.Images.SetKeyName(44, "p44.png");
            imglstDeck.Images.SetKeyName(45, "p45.png");
            imglstDeck.Images.SetKeyName(46, "p46.png");
            imglstDeck.Images.SetKeyName(47, "p47.png");
            imglstDeck.Images.SetKeyName(48, "p48.png");
            imglstDeck.Images.SetKeyName(49, "p49.png");
            imglstDeck.Images.SetKeyName(50, "p50.png");
            imglstDeck.Images.SetKeyName(51, "p51.png");
            // 
            // opfiLoadHand
            // 
            opfiLoadHand.InitialDirectory = "Assignment3\\\\Saved Hands\\\\";
            // 
            // safiSaveHand
            // 
            safiSaveHand.InitialDirectory = "Assignment3\\\\Saved Hands\\\\";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(picCard5);
            Controls.Add(picCard4);
            Controls.Add(picCard3);
            Controls.Add(picCard2);
            Controls.Add(picCard1);
            Controls.Add(chkKeep5);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnDeal);
            Name = "MainForm";
            Text = "Assignment 3";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeal;
        private Button btnSave;
        private Button btnLoad;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private PictureBox picCard1;
        private PictureBox picCard2;
        private PictureBox picCard3;
        private PictureBox picCard4;
        private PictureBox picCard5;
        private ImageList imglstDeck;
        private OpenFileDialog opfiLoadHand;
        private SaveFileDialog safiSaveHand;
    }
}
