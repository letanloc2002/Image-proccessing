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
        
        public Form1()
        {
            InitializeComponent();
            // tạo biến chứa đường dẫn file hình;
            string filehinh = @"C:\Users\Loc\Desktop\lena_color1.gif";
            // tạo một biến chứa hình bitmapđược load từ file
            Bitmap hinhgoc = new Bitmap(filehinh);
            // hiển thị hình trong pic_goc
            pic_goc.Image = hinhgoc;
            // tạo biến chứ hình sắp nét
            Bitmap imgsharpe = ColorImageSharpening(hinhgoc);
            //hiển thị kết quả ảnh sắt nét
            pic_red.Image = imgsharpe;
        }
        public Bitmap ColorImageSharpening(Bitmap hinhgoc)
        {
            int[,] c = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            Bitmap imgsharpe= new Bitmap(hinhgoc.Width,hinhgoc.Height);

            // dùng vòng for để đọc điểm ảnh ở dạng 2 chiều, bỏ viền ngoài của ảnh vì là mặt nạ 3x3
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    //các biến cộng dồn giá trị điểm ảnh
                    int Rs = 0, Gs = 0, Bs = 0;
                    int SharpR = 0, SharpG = 0, SharpB = 0;
                    //quét các điểm trong mặt nạ
                    for (int i=x-1;i<=x+1; i++)
                        for(int j = y - 1; j <= y + 1; j++)
                        {
                            Color color=hinhgoc.GetPixel(i, j);
                            int R=color.R; int G=color.G; int B=color.B;
                            // nhân ma trận điểm ảnh với hệ số C
                            Rs += R * c[i - x + 1, j - y + 1];
                            Gs += G * c[i - x + 1, j - y + 1];
                            Bs += B * c[i - x + 1, j - y + 1];

                        }
                    //tính điểm sắc nét
                    Color color1 = hinhgoc.GetPixel(x, y);
                    int R1 = color1.R; int G1 = color1.G;   int B1 = color1.B;

                    SharpR = R1 + Rs; SharpG = G1 + Gs; SharpB = B1 + Bs;

                    if(SharpR<0)
                        SharpR= 0;
                    else if (SharpR>255)
                        SharpR= 255;

                    if (SharpG < 0)
                        SharpG = 0;
                    else if (SharpG > 255)
                        SharpG = 255;

                    if (SharpB < 0)
                        SharpB = 0;
                    else if (SharpB > 255)
                        SharpB = 255;
                    //set các điểm ảnh vào biến
                    imgsharpe.SetPixel(x,y,Color.FromArgb(SharpR,SharpG,SharpB));


                }
            return imgsharpe;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
