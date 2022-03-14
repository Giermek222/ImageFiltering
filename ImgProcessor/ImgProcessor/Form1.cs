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
        public float gamma = 1.5f;
        public float contrast_coeff = 1.2f;

        public int[] plot = new int[256];
        Bitmap plot_bmp = new Bitmap(256, 256);
        public List<Point> plot_points = new List<Point>() { new Point(0,0), new Point(255,255) };
        public Form1()
        {
            for (int i = 0; i < 256; i++)
                plot[i] = i;
            InitializeComponent();
            
        }

        private void LoadImage(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();


            UpdatePlot();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            
            if (op.ShowDialog() == DialogResult.OK)
            {
                OriginalImage.Image = System.Drawing.Image.FromFile(op.FileName);
                OriginalImage.SizeMode = PictureBoxSizeMode.StretchImage;
                EditedImage.Image = System.Drawing.Image.FromFile(op.FileName);
                EditedImage.SizeMode = PictureBoxSizeMode.StretchImage;

                Plot.Image = plot_bmp;
            }
        }

        public void UpdatePlot()
        {
            for (int i = 0; i < 256; ++i)
                for (int j = 0; j < 256; ++j)
                {
                    
                    
                    if (plot_points.Contains(new Point(i, 255-j)))
                        plot_bmp.SetPixel(i, 255 - plot[i], Color.Red);
                    else if (plot[i] == 255 - j)
                        plot_bmp.SetPixel(i, 255 - plot[i], Color.Black);
                    else
                        plot_bmp.SetPixel(i, j, Color.White);
                }
        }

        private void RevertImage(object sender, EventArgs e)
        {
            EditedImage.Image = OriginalImage.Image;
            for (int i = 0; i < 256; ++i)
                plot[i] =  i;
            plot_points = new List<Point>() { new Point(0, 0), new Point(255, 255) };
            UpdatePlot();
            Plot.Image = plot_bmp;
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
            for (int i = 0; i < 256; ++i)
                plot[i] = 255 - plot[i];
            List<Point> newList = new List<Point>();
            for (int i = 0; i < plot_points.Count; i++)
            {
                newList.Add(new Point(plot_points[i].X, 255 -plot_points[i].Y ));
            }
            plot_points = newList;
            UpdatePlot();
            Plot.Image = plot_bmp;
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
            for (int i = 0; i < 256; ++i) { 
                if (brightness_coeff > 0)
                    plot[i] = plot[i] + brightness_coeff < 255 ? plot[i] + brightness_coeff : 255;
                else
                    plot[i] = plot[i] + brightness_coeff > 0 ? plot[i] + brightness_coeff : 0;
            }
            List<Point> newList = new List<Point>();
            for (int i = 0; i < plot_points.Count; i++)
            {
                if (brightness_coeff > 0)
                    newList.Add(new Point(plot_points[i].X, plot_points[i].Y + brightness_coeff < 255 ? plot_points[i].Y + brightness_coeff : 255));
                else
                    newList.Add(new Point(plot_points[i].X, plot_points[i].Y + brightness_coeff > 0 ? plot_points[i].Y + brightness_coeff : 0));

            }
            plot_points = newList;

            UpdatePlot();
            Plot.Image = plot_bmp;
            EditedImage.Image = bmp;
        }

        private void GammaImage(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(EditedImage.Image);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {

                    Color pixel = bmp.GetPixel(i, j);
                    int red = (int)(Math.Pow((double)pixel.R / (double)255, gamma) * 255);
                    int green = (int)(Math.Pow((double)pixel.G / (double)255, gamma) * 255);
                    int blue = (int)(Math.Pow((double)pixel.B / (double)255, gamma) * 255);

                    bmp.SetPixel(i, j, Color.FromArgb(pixel.A, red, green, blue));
                }
            
            for (int i = 0; i < 256; ++i)
            {
                
                plot[i] = (int)(Math.Pow((double)plot[i] / (double)255, gamma) * 255);
            }
            List<Point> newList = new List<Point>();
            for (int i = 0; i < plot_points.Count; i++)
            {
                newList.Add(new Point(plot_points[i].X, (int)(Math.Pow((double)plot_points[i].Y / (double)255, gamma) * 255)));
            }
            plot_points = newList;
            UpdatePlot();
            Plot.Image = plot_bmp;
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
            for (int i = 0; i < 256; ++i)
            {

                plot[i] = (plot[i] - 128) * contrast_coeff + 128 < 255 ? (int)((plot[i] - 128) * contrast_coeff + 128) < 0 ? 0 : (int)((plot[i] - 128) * contrast_coeff + 128) : 255;
            }

            UpdatePlot();
            Plot.Image = plot_bmp;
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

        private void ClickPlot(object sender, EventArgs e)
        {
            MouseEventArgs m = e as MouseEventArgs;
            //We clicked on existing point and we want it gone
            if (plot_points.Contains(new Point(m.X, 255 - m.Y)))
            {
                //you cannot delete start and end point
                if (m.X == 255 || m.X == 0)
                    return;
                else
                    plot_points.Remove(new Point(m.X, 255 - m.Y));

            }
            //there can only be one point for each value so hitting
            //occupied spot moves point
            else if (plot_points.Where(p => p.X == m.X).Count() != 0)
            {
                plot_points.Remove(plot_points.Where(p => p.X == m.X).ElementAt(0));
                plot_points.Add(new Point(m.X, 255 - m.Y));
            } 
            //adding new point
            else
            {
                plot_points.Add(new Point(m.X, 255 - m.Y));
            }
            plot_points.Sort(( n,  m) =>  n.X.CompareTo(m.X));
            AdjustAfterNewPoint();
            UpdatePlot();
            PictureAfterNewPoint();
            
            Plot.Image = plot_bmp;

        }

        private void AdjustAfterNewPoint()
        {
            for (int i = 0; i < plot_points.Count - 1; ++i)
            {
                double a = ((double)( plot_points[i + 1].Y - plot_points[i].Y) / (double)(plot_points[i+1].X - plot_points[i].X));
                double b =  plot_points[i].Y - plot_points[i].X * a;
                for (int j = plot_points[i].X; j <= plot_points[i + 1].X; ++j)
                {
                    plot[j] = (int)(a * j + b);
                }
            }
        }

        private void PictureAfterNewPoint()
        {
            Bitmap plot_bmp = new Bitmap(OriginalImage.Image);
            for (int i = 0; i < plot_bmp.Width; i++)
                for (int j = 0; j < plot_bmp.Height; j++)
                {
                    Color pixel = plot_bmp.GetPixel(i, j);
                    int red = plot[pixel.R];
                    int green = plot[pixel.G];
                    int blue = plot[pixel.B];

                    plot_bmp.SetPixel(i, j, Color.FromArgb(pixel.A, red, green, blue));
                }
            EditedImage.Image = plot_bmp;
        }
    }
}
