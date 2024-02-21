using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tachmau_Prj03
{
    public partial class Form1 : Form
    {
        // tạo biến chứa đường dẫn file hình;
        static string filehinh = @"C:\Users\Loc\Desktop\lena_color1.gif";
        // tạo một biến chứa hình bitmap được load từ file
        Bitmap hinhgoc = new Bitmap(filehinh);
        
        public Form1()
        {
            InitializeComponent();
            // hiển thị hình trong pic_goc
            pic_goc.Image = hinhgoc;                                 
        }
        
        public Bitmap ColorImageBorderline()
        {
            int nguong = Convert.ToInt16(text_nguong.Text);
            //tạo biến chứa hình mức xám
            //tạo ma trận sobel theo phương x
            int[,] ngang = { { -1, -2, -1  }, 
                             {  0,  0,  0  },
                             {  1,  2,  1  } };
            //tạo ma trận sobel theo phương y
            int[,] doc   = { { -1, 0, 1 }, 
                             { -2, 0, 2 }, 
                             { -1, 0, 1 } };
            //tạo ma trận sobel theo phương x
            Bitmap imgboderline = new Bitmap(hinhgoc.Width,hinhgoc.Height);
            // dùng vòng for để đọc điểm ảnh ở dạng 2 chiều, bỏ viền ngoài của ảnh vì là mặt nạ 3x3
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    //các biến cộng dồn giá trị điểm ảnh
                    int GxR = 0, GyR = 0;
                    int GxG = 0, GyG = 0;
                    int GxB = 0, GyB = 0;
                    int point = 0;
                    

                    //quét các điểm trong mặt nạ
                    for (int i=x-1;i<=x+1; i++)
                        for(int j = y - 1; j <= y + 1; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                             
                            // nhân ma trận điểm ảnh với hệ số C
                            GxR += R * ngang[i - x + 1, j - y + 1];
                            GyR += R * doc[i - x + 1, j - y + 1];
                            GxG += G * ngang[i - x + 1, j - y + 1];
                            GyG += G * doc[i - x + 1, j - y + 1];
                            GxB += B * ngang[i - x + 1, j - y + 1];
                            GyB += B * doc[i - x + 1, j - y + 1];


                        }
                    //tính các giá trị 
                    int Gxx=Math.Abs(GxR)* Math.Abs(GxR) + Math.Abs(GxG)* Math.Abs(GxG)+ Math.Abs(GxB) * Math.Abs(GxB);
                    int Gyy = Math.Abs(GyR) * Math.Abs(GyR) + Math.Abs(GyG) * Math.Abs(GyG) + Math.Abs(GyB) * Math.Abs(GyB);
                    int Gxy = Math.Abs(GxR) * Math.Abs(GyR) + Math.Abs(GxG) * Math.Abs(GyG) + Math.Abs(GxB) * Math.Abs(GyB);
                    double theta = 0.5 * Math.Atan2((2 * Gxy), (Gxx - Gyy));//dùng atan2 để giá trị không âm

                    double F0 = Math.Sqrt(0.5 * ((Gxx + Gyy) + (Gxx - Gyy) * Math.Cos(2 * theta) + 2 * Gxy * Math.Sin(2 * theta)));


                    if (F0 <= nguong)
                        point = 0;
                    else
                        point = 255;
                    //set các điểm ảnh vào biến
                    imgboderline.SetPixel(x,y,Color.FromArgb(point,point,point));


                }
            return imgboderline;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tạo biến chưa hình đường biên
            Bitmap imgborderline = ColorImageBorderline();
            //hiển thị kết quả ảnh đường biên
            pic_red.Image = imgborderline;
        }
    }
}
