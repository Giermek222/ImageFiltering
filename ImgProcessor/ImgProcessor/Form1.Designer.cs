
namespace ImgProcessor
{
    partial class Form1
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
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kamusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Revert = new System.Windows.Forms.Button();
            this.Inversion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.Location = new System.Drawing.Point(12, 33);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(352, 586);
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.TabStop = false;
            // 
            // EditedImage
            // 
            this.EditedImage.Location = new System.Drawing.Point(370, 33);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(352, 586);
            this.EditedImage.TabIndex = 1;
            this.EditedImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kamusToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kamusToolStripMenuItem
            // 
            this.kamusToolStripMenuItem.Name = "kamusToolStripMenuItem";
            this.kamusToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kamusToolStripMenuItem.Text = "Load";
            this.kamusToolStripMenuItem.Click += new System.EventHandler(this.LoadImage);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Revert
            // 
            this.Revert.Location = new System.Drawing.Point(751, 53);
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(75, 23);
            this.Revert.TabIndex = 3;
            this.Revert.Text = "Revert";
            this.Revert.UseVisualStyleBackColor = true;
            this.Revert.Click += new System.EventHandler(this.RevertImage);
            // 
            // Inversion
            // 
            this.Inversion.Location = new System.Drawing.Point(751, 98);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(75, 26);
            this.Inversion.TabIndex = 4;
            this.Inversion.Text = "Inversion";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.InvertImage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "BrightnessChange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BrightnessChangeImage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(741, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gamma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GammaImage);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(746, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "Contrantenh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ContrastCorrectionImage);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(743, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 31);
            this.button6.TabIndex = 8;
            this.button6.Text = "Blur";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BlurImage);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(746, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 30);
            this.button7.TabIndex = 9;
            this.button7.Text = "Sharpen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SharpenImage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gauss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GaussBlurImage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edge detect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EdgeDetectImage);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(744, 485);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 32);
            this.button8.TabIndex = 12;
            this.button8.Text = "Embosis";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.EmbossImage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 631);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.Revert);
            this.Controls.Add(this.EditedImage);
            this.Controls.Add(this.OriginalImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImage;
        private System.Windows.Forms.PictureBox EditedImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kamusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button Revert;
        private System.Windows.Forms.Button Inversion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
    }
}

