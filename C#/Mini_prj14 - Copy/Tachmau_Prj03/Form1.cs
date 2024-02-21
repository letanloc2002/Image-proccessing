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
            pic_goc.Image = ChuyenhinhRGBsanghinhxamLightness();
            
            
        }
        public Bitmap ChuyenhinhRGBsanghinhxamLightness()
        {
            //tạo biến chứa hình mức xám
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //quét điểm ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy gái trị màu điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm (x,y) sửng dụng công thức average
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);

                    // gán giá trị mức xám vừa tính
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;
        }
        public Bitmap ColorImageBorderline()
        {
            //tạo biến ngưỡng để xét với giá trị 
            int nguong = Convert.ToInt16(text_nguong.Text);
            //tạo biến chứa hình mức xám
            Bitmap hinhxam = ChuyenhinhRGBsanghinhxamLightness();
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
            for (int x = 1; x < hinhxam.Width - 1; x++)
                for (int y = 1; y < hinhxam.Height - 1; y++)
                {
                    //các biến cộng dồn giá trị điểm ảnh
                    int Gx = 0, Gy = 0;
                    int gray = 0;
                    
                    //quét các điểm trong mặt nạ
                    for (int i=x-1;i<=x+1; i++)
                        for(int j = y - 1; j <= y + 1; j++)
                        {
                            Color color=hinhxam.GetPixel(i, j);
                            //lấy giá trị xám
                            gray=color.R;  
                            // nhân ma trận điểm ảnh với hệ số C
                            Gx += gray * ngang[i - x + 1, j - y + 1];
                            Gy += gray * doc[i - x + 1, j - y + 1];
                            
                        }
                    int M=Math.Abs(Gx)+Math.Abs(Gy);
                    if (M <= nguong)
                        gray = 0;
                    else
                        gray = 255;
                    //set các điểm ảnh vào biến
                    imgboderline.SetPixel(x,y,Color.FromArgb(gray,gray,gray));


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
