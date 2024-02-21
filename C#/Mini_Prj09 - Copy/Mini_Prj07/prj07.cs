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

                    double X = 0.4124564 * R + 0.3575761 * G + 0.1804375 * B;
                    double Y = 0.2126729 * R + 0.7151522 * G + 0.0721750 * B;
                    double Z = 0.0193339 * R + 0.1191920 * G + 0.9503041 * B;


                    hue.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    saturation.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    intensity.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));

                    hsi.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));
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
