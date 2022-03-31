
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
            this.Plot = new System.Windows.Forms.PictureBox();
            this.CustomFilters = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.numericBlueDither = new System.Windows.Forms.NumericUpDown();
            this.numericGreenDither = new System.Windows.Forms.NumericUpDown();
            this.numericRedDither = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OctoColors = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlueDither)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreenDither)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRedDither)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OctoColors)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.Location = new System.Drawing.Point(14, 44);
            this.OriginalImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(465, 781);
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.TabStop = false;
            // 
            // EditedImage
            // 
            this.EditedImage.Location = new System.Drawing.Point(485, 51);
            this.EditedImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(695, 781);
            this.EditedImage.TabIndex = 1;
            this.EditedImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kamusToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1599, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kamusToolStripMenuItem
            // 
            this.kamusToolStripMenuItem.Name = "kamusToolStripMenuItem";
            this.kamusToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.kamusToolStripMenuItem.Text = "Load";
            this.kamusToolStripMenuItem.Click += new System.EventHandler(this.LoadImage);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveImage);
            // 
            // Revert
            // 
            this.Revert.Location = new System.Drawing.Point(1205, 105);
            this.Revert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(86, 31);
            this.Revert.TabIndex = 3;
            this.Revert.Text = "Revert";
            this.Revert.UseVisualStyleBackColor = true;
            this.Revert.Click += new System.EventHandler(this.RevertImage);
            // 
            // Inversion
            // 
            this.Inversion.Location = new System.Drawing.Point(1374, 231);
            this.Inversion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(86, 35);
            this.Inversion.TabIndex = 4;
            this.Inversion.Text = "Inversion";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.InvertImage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1408, 124);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "BrightnessChange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BrightnessChangeImage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1200, 144);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gamma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GammaImage);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1205, 189);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Contrantenh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ContrastCorrectionImage);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1205, 231);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "Blur";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BlurImage);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1205, 276);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "Sharpen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SharpenImage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1374, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gauss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GaussBlurImage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1375, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edge detect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EdgeDetectImage);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1205, 44);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 43);
            this.button8.TabIndex = 12;
            this.button8.Text = "Embosis";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.EmbossImage);
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(1205, 491);
            this.Plot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(293, 341);
            this.Plot.TabIndex = 13;
            this.Plot.TabStop = false;
            this.Plot.Click += new System.EventHandler(this.ClickPlot);
            // 
            // CustomFilters
            // 
            this.CustomFilters.FormattingEnabled = true;
            this.CustomFilters.ItemHeight = 20;
            this.CustomFilters.Location = new System.Drawing.Point(1205, 437);
            this.CustomFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomFilters.Name = "CustomFilters";
            this.CustomFilters.Size = new System.Drawing.Size(137, 44);
            this.CustomFilters.TabIndex = 14;
            this.CustomFilters.SelectedIndexChanged += new System.EventHandler(this.ChangeFilter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1237, 853);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 31);
            this.button9.TabIndex = 15;
            this.button9.Text = "SaveFilter";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CustomFilterSave);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1205, 323);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 31);
            this.button10.TabIndex = 16;
            this.button10.Text = "medianFilter";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MedianFilter);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1205, 360);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 31);
            this.button11.TabIndex = 17;
            this.button11.Text = "Dither";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dithering);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1205, 399);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 31);
            this.button12.TabIndex = 18;
            this.button12.Text = "Greyscale";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GreyScale);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1347, 450);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 31);
            this.button13.TabIndex = 19;
            this.button13.Text = "Octree";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.MakeOctree);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 30);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 993);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // numericBlueDither
            // 
            this.numericBlueDither.Location = new System.Drawing.Point(1408, 359);
            this.numericBlueDither.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericBlueDither.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericBlueDither.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBlueDither.Name = "numericBlueDither";
            this.numericBlueDither.Size = new System.Drawing.Size(137, 27);
            this.numericBlueDither.TabIndex = 21;
            this.numericBlueDither.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericGreenDither
            // 
            this.numericGreenDither.Location = new System.Drawing.Point(1401, 319);
            this.numericGreenDither.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericGreenDither.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGreenDither.Name = "numericGreenDither";
            this.numericGreenDither.Size = new System.Drawing.Size(150, 27);
            this.numericGreenDither.TabIndex = 22;
            this.numericGreenDither.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericRedDither
            // 
            this.numericRedDither.Location = new System.Drawing.Point(1401, 296);
            this.numericRedDither.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericRedDither.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRedDither.Name = "numericRedDither";
            this.numericRedDither.Size = new System.Drawing.Size(150, 27);
            this.numericRedDither.TabIndex = 23;
            this.numericRedDither.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1347, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1347, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1347, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "blue";
            // 
            // OctoColors
            // 
            this.OctoColors.Location = new System.Drawing.Point(1450, 450);
            this.OctoColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OctoColors.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.OctoColors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OctoColors.Name = "OctoColors";
            this.OctoColors.Size = new System.Drawing.Size(137, 27);
            this.OctoColors.TabIndex = 27;
            this.OctoColors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 1023);
            this.Controls.Add(this.OctoColors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRedDither);
            this.Controls.Add(this.numericGreenDither);
            this.Controls.Add(this.numericBlueDither);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.CustomFilters);
            this.Controls.Add(this.Plot);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlueDither)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreenDither)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRedDither)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OctoColors)).EndInit();
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
        private System.Windows.Forms.PictureBox Plot;
        private System.Windows.Forms.ListBox CustomFilters;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown numericBlueDither;
        private System.Windows.Forms.NumericUpDown numericGreenDither;
        private System.Windows.Forms.NumericUpDown numericRedDither;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown OctoColors;
    }
}

