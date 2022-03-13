using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgProcessor
{
    public partial class Form1 : Form
    {
        public int brightness_coeff = 30;
        public float gamma = 1.2f;
        public float contrast_coeff = 1.2f;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImage(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            
            if (op.ShowDialog() == DialogResult.OK)
            {
                OriginalImage.Image = System.Drawing.Image.FromFile(op.FileName);
                EditedImage.Image = System.Drawing.Image.FromFile(op.FileName);
    
            }
        }

        private void RevertImage(object sender, EventArgs e)
        {
            EditedImage.Image = OriginalImage.Image;
        }

        private void InvertImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j); 
                    bmp.SetPixel(i, j, Color.FromArgb(pixel.A , 255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            EditedImage.Image = bmp;
        }

        private void BrightnessChangeImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            int red;
            int green;
            int blue;
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);

                    if (brightness_coeff > 0)
                    {
                        red = pixel.R + brightness_coeff < 255 ? pixel.R + brightness_coeff : 255;
                        green = pixel.G + brightness_coeff < 255 ? pixel.G + brightness_coeff : 255;
                        blue = pixel.B + brightness_coeff < 255 ? pixel.B + brightness_coeff : 255;
                    }
                    else
                    {
                        red = pixel.R + brightness_coeff > 0 ? pixel.R + brightness_coeff : 0;
                        green = pixel.G + brightness_coeff > 0 ? pixel.G + brightness_coeff : 0;
                        blue = pixel.B + brightness_coeff > 0 ? pixel.B + brightness_coeff : 0;

                    }
                    bmp.SetPixel(i, j, Color.FromArgb(pixel.A, red, green, blue));
                }
            EditedImage.Image = bmp;
        }

        private void GammaImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {

                    Color pixel = bmp.GetPixel(i, j);
                    int red = (int)Math.Pow(pixel.R, gamma) < 255 ? (int)Math.Pow(pixel.R, gamma) : 255 ;
                    int green = (int)Math.Pow(pixel.G, gamma) < 255 ? (int)Math.Pow(pixel.G, gamma) : 255;
                    int blue = (int)Math.Pow(pixel.B, gamma) < 255 ? (int)Math.Pow(pixel.B, gamma) : 255;

                    bmp.SetPixel(i, j, Color.FromArgb(pixel.A, red, green, blue));
                }
            EditedImage.Image = bmp;
        }

        private void ContrastCorrectionImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {

                    Color pixel = bmp.GetPixel(i, j);
                    int red = (pixel.R-128)*contrast_coeff + 128 < 255 ? (int)((pixel.R - 128) * contrast_coeff + 128) : 255;
                    int green = (pixel.G - 128) * contrast_coeff + 128 < 255 ? (int)((pixel.G - 128) * contrast_coeff + 128) : 255;
                    int blue = (pixel.B - 128) * contrast_coeff + 128 < 255 ? (int)((pixel.B - 128) * contrast_coeff + 128) : 255;
                    red = red > 0 ? red : 0;
                    green = green > 0 ? green : 0;
                    blue = blue > 0 ? blue : 0;
                    bmp.SetPixel(i, j, Color.FromArgb(pixel.A, red, green, blue));
                }
            EditedImage.Image = bmp;
        }

        private void BlurImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            Bitmap original = new Bitmap(EditedImage.Image);
            int[] filter = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j,
                        Filter(original, filter, i, j, 3)
                    );
                
                }
            EditedImage.Image = bmp;
        }

        private void GaussBlurImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            Bitmap original = new Bitmap(EditedImage.Image);
            int[] filter = { 0, 1, 0, 1, 4, 1, 0, 1, 0 };
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j,
                        Filter(original, filter, i, j, 3)
                    );

                }
            EditedImage.Image = bmp;
        }

        private void SharpenImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            Bitmap original = new Bitmap(EditedImage.Image);
            int[] filter = { -1, -1, -1, -1, 9, -1, -1, -1, -1};
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j,
                        Filter(original, filter, i, j, 3)
                    );

                }
            EditedImage.Image = bmp;
        }

        private void EdgeDetectImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            Bitmap original = new Bitmap(EditedImage.Image);
            int[] filter = { 0, -1, 0, 0, 1, 0, 0, 0, 0 };
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j,
                        Filter(original, filter, i, j, 3)
                    );

                }
            EditedImage.Image = bmp;
        }

        private void EmbossImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            Bitmap original = new Bitmap(EditedImage.Image);
            int[] filter = { -1, 0, 1, -1, 1, 1, -1, 0, 1 };
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j,
                        Filter(original, filter, i, j, 3)
                    );

                }
            EditedImage.Image = bmp;
        }
        private Color Filter(Bitmap bmp, int[] filter, int x, int y, int kernelsize)
        {
            int red = 0;
            int blue = 0;
            int green = 0;
            int imgwidth = bmp.Width;
            int imgheigth = bmp.Height;
            int counter_x = -kernelsize / 2;
            int counter_y = -kernelsize / 2;
            int divisor = filter.Sum((int n) => { return n;});
            if(divisor == 0)
                divisor = 1;

            for (int i = 0; i < kernelsize; ++i) { 
                for (int j = 0; j < kernelsize; ++j)
                {
                    if ( x+counter_x >= imgwidth || y+counter_y >= imgheigth ||
                         x + counter_x < 0 || y + counter_y < 0)
                    {
                        //assuming out of bound pixels are original pixel
                        Color pixel = bmp.GetPixel(x, y);
                        red += pixel.R * filter[j * kernelsize + i];
                        blue += pixel.B * filter[j * kernelsize + i];
                        green += pixel.G * filter[j * kernelsize + i];
                    }
                    else
                    {
                        Color pixel = bmp.GetPixel(x+counter_x, y+counter_y);
                        red += pixel.R * filter[j * kernelsize + i];
                        blue += pixel.B * filter[j * kernelsize + i];
                        green += pixel.G * filter[j * kernelsize + i];
                    }

                    counter_y++;
                }
                counter_x++;
                counter_y = -kernelsize / 2;
            }

            red = red > 0 ? red : 0;
            green = green > 0 ? green : 0;
            blue = blue > 0 ? blue : 0;
            
            return Color.FromArgb( red/divisor > 255 ? 255 : red/ divisor,
                                   green / divisor > 255 ? 255 : green / divisor,
                                   blue / divisor > 255 ? 255 : blue / divisor);

        }
    }
}
