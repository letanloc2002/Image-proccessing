using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Tachmau_Prj03
{
    public partial class Form1 : Form
    {
        // tạo biến chứa đường dẫn file hình;
        static string filehinh = @"C:\Users\Loc\Desktop\lena_color1.jpg";
        static string filehinh2 = @"C:\Users\Loc\Desktop\bird_small.jpg";
        // tạo một biến chứa hình bitmapđược load từ file
        Bitmap hinhgoc = new Bitmap(filehinh);
        int point;
        int level;
        
        public Form1()
        {
            InitializeComponent();
            //khởi tạo giá trị ban đầu
            point = 1;
            level = 3;
       
            // hiển thị hình trong pic_goc
            pic_goc.Image = hinhgoc;
            // khai báo 3 bitmap để chứa hình smoothed
            Bitmap pic_smoothed = ColorImageSmoothing(hinhgoc,point,level);
            // hiển thị hình trong pic_smooth
            pic_smooth.Image = pic_smoothed;
            
        }
        //dùng hàm để chuyển ảnh gốc sang ảnh đã được smooth
        public Bitmap ColorImageSmoothing(Bitmap hinhgoc,int point, int level)
        {
           //tạo biến để chứa hình được smooth
            Bitmap pic_smoothed = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //tạo vòng lặp để quét hình 
            // dùng 2 vòng FOR để quét hết ảnh, độ dài và độ rộng phải trừ đi viền của mặt nạ
            for (int x = point; x < hinhgoc.Width - point; x++)
                for (int y = point; y < hinhgoc.Height - point; y++)
                {
                    //biến cộng dồn cho các giá trị điểm màu trên mặt nạn của từng kênh R-G-B
                    int Rs = 0, Gs = 0, Bs = 0;
                    //quét mặt nạ
                    for (int i = x - point; i <= x + point; i++)
                        for (int j = y - point; j <= y + point; j++)
                        {
                            // đọc giá trị pixel tại điểm  ảnh có vị trí (i,j)
                            Color pixel = hinhgoc.GetPixel(i, j);
                            //lấy giá trị màu cảu các kênh
                            byte R = pixel.R;// giá trị kênh red
                            byte G = pixel.G;// giá trị kênh green
                            byte B = pixel.B;// giá trị kênh blue
                            byte A = pixel.A;// giá trị kênh blue
                            //cộng dồn giá trị màu của các kênh
                            Rs += R;
                            Gs += G;
                            Bs += B;
 
                            
                        }
                    //K là số lượng điểm ảnh của mặt nạ
                    int K = level * level;
                    //đưa ra giá trị màu trung bình của kênh trong mặt nạ
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);
                    //gán giá trị màu vào biến bitmap đã tạo
                    pic_smoothed.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            //trả về giá trị của hàm
            return pic_smoothed;
        }
        
        private void three_Click(object sender, EventArgs e)
        {
            
            int point = 1;
            int level = 3;
            Bitmap temp = ColorImageSmoothing(hinhgoc, point, level);
            pic_smooth.Image = temp;


        }

        private void nine_Click(object sender, EventArgs e)
        {
            int point = 4;
            int level = 9;
            Bitmap temp = ColorImageSmoothing(hinhgoc, point, level);
            pic_smooth.Image = temp;
        }

        private void five_Click(object sender, EventArgs e)
        {
            int point = 2;
            int level = 5;
            Bitmap temp = ColorImageSmoothing(hinhgoc, point, level);
            pic_smooth.Image = temp;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            int point = 3;
            int level = 7;
            Bitmap temp = ColorImageSmoothing(hinhgoc, point, level);
            pic_smooth.Image = temp;
        }
    }
}
