using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XLA_Prj03
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc;
        public Form1()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"C:\Users\Loc\Desktop\download2.jpg");
            //hiển thị ảnh gốc
            pic_goc.Image = hinhgoc;
            // hiển thị hình xám lightness
            pic_lightness.Image = ChuyenhinhRGBsanghinhxamLightness(hinhgoc);
            // hiển thị hình xám average
            pic_average.Image = ChuyenhinhRBGsanghinhxamAverage(hinhgoc);
            // hiển thị hình xám Luminance
            pic_luminance.Image = ChuyenhinhRBGsanghinhxamLuminance(hinhgoc);
            // hiển thị hình mức nhị phân
            pic_nhiphan.Image = ChuyenhinhRBGsanghinhnhiphan(hinhgoc, 100);
        }
        public Bitmap ChuyenhinhRGBsanghinhxamLightness(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm (x,y)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);

                    // gán giá trị mức xám vừa tính
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;
        }
        public Bitmap ChuyenhinhRBGsanghinhxamAverage(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm (x,y)
                    byte gray = (byte)((R + G + B) / 3);
                    // gán giá trị mức xám vừa tính
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;
        }
        public Bitmap ChuyenhinhRBGsanghinhxamLuminance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm (x,y)
                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    // gán giá trị mức xám vừa tính
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;
        }
        public Bitmap ChuyenhinhRBGsanghinhnhiphan(Bitmap hinhgoc, byte nguong)
        {
            Bitmap HinhNhiPhan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm (x,y)
                    byte nhiphan = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    // phân loại giá trị

                    if (nhiphan < nguong)
                        nhiphan = 0;
                    else
                        nhiphan = 255;
                    // gán giá trị mức xám vừa tính
                    HinhNhiPhan.SetPixel(x, y, Color.FromArgb(nhiphan, nhiphan, nhiphan));

                }
            return HinhNhiPhan;
        }

        private void vScrollBarnhiphan_ValueChanged(object sender, EventArgs e)
        {

            byte nguong = (byte)vScrollBarnhiphan.Value;

            //hiển thị giá trị ngưỡng
            lbnguong.Text = nguong.ToString();

            pic_nhiphan.Image = ChuyenhinhRBGsanghinhnhiphan(hinhgoc, nguong);
        }
    }
}