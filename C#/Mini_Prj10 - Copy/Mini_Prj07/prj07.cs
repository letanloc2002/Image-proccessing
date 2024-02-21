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
            Bitmap imgor = new Bitmap(@"C:\Users\Loc\Desktop\lena_color.jpg");
            pic_goc.Image = imgor;

            List<Bitmap> HSI = convertRGBtoHSI(imgor);

            pic_hue.Image = HSI[0];
            pic_saturation.Image = HSI[1];
            pic_intensity.Image = HSI[2];
            pic_hsi.Image = HSI[3];
        }

        public List<Bitmap> convertRGBtoHSI(Bitmap imgor)
        {

            List<Bitmap> HSI = new List<Bitmap>();
            Bitmap hue = new Bitmap(imgor.Width, imgor.Height);
            Bitmap saturation = new Bitmap(imgor.Width, imgor.Height);
            Bitmap intensity = new Bitmap(imgor.Width, imgor.Height);
            Bitmap hsi = new Bitmap(imgor.Width, imgor.Height);
            for (int x=0; x < imgor.Width; x++) 
                for (int y=0; y < imgor.Height; y++)
                {
                    Color pixel = imgor.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double Y = 16 + (65.738 / 256 * R) + (129.057 / 256) * G + (25.064 / 256) * B;
                    double Cb = 128 - (37.945 / 256 * R) - (74.494 / 256) * G + (112.439 / 256) * B;
                    double Cr = 128 + (112.439 / 256 * R) - (94.154 / 256) * G - (18.285 / 256) * B   ;


                    hue.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    saturation.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));
                    intensity.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));

                    hsi.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cb, (byte)Cr));
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
