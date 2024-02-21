using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mini_Prj07
{
    public partial class prj07 : Form
    {
        public prj07()
        {
            InitializeComponent();
            // Upload picture from the file
            Bitmap imgor = new Bitmap(@"C:\Users\Loc\Desktop\lena_color1.jpg");
            pic_goc.Image = imgor;

            List<Bitmap> HSI = convertRGBtoHSI(imgor);
            //put data in Image
            pic_hue.Image = HSI[0];
            pic_saturation.Image = HSI[1];
            pic_intensity.Image = HSI[2];
            pic_hsi.Image = HSI[3];
        }

        public List<Bitmap> convertRGBtoHSI(Bitmap imgor)
        {
            //declare variable
            List<Bitmap> HSI = new List<Bitmap>();
            Bitmap hue = new Bitmap(imgor.Width, imgor.Height);
            Bitmap saturation = new Bitmap(imgor.Width, imgor.Height);
            Bitmap intensity = new Bitmap(imgor.Width, imgor.Height);
            Bitmap hsi = new Bitmap(imgor.Width, imgor.Height);
            //get data
            for (int x=0; x < imgor.Width; x++) 
                for (int y=0; y < imgor.Height; y++)    
                {
                    Color pixel = imgor.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double t1 = ((R - G) + (R - B)) / 2;

                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (R - B));
                    double theta = Math.Acos(t1 / t2);

                    double H = 0;
                    // set the point to compare
                    if (B <= G) 
                        H = theta;
                    else
                        H = 2 * Math.PI - theta;
                    H = H * 180 / Math.PI;

                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B))/(R+G+B);

                    double I = (R + G + B) / 3;
                    hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    saturation.SetPixel(x, y, Color.FromArgb((byte)(S*255), (byte)(S*255), (byte)(S*255)));
                    intensity.SetPixel(x, y, Color.FromArgb((byte)I, (byte)I, (byte)I));

                    hsi.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S*255), (byte)I));
                }
            HSI.Add(hue);
            HSI.Add(saturation);
            HSI.Add(intensity);

            HSI.Add(hsi);

            return HSI;



        }
        
        private void pic_hue_Click(object sender, EventArgs e)
        {

        }
    }
}
