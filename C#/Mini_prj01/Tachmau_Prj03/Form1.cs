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
            string filehinh = @"C:\Users\Loc\Pictures\Saved Pictures\download.jpg";
            // tạo một biến chứa hình bitmapđược load từ file
            Bitmap hinhgoc = new Bitmap(filehinh);
            // hiển thị hình trong pic_goc
            pic_goc.Image = hinhgoc;
            // khai báo 3 bitmap để chứa 3 hình R_G_B
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            // dùng vòng for để đọc điểm ảnh ở dạng 2 chiều
            for (int x = 0; x < hinhgoc.Width; x++)
                for ( int y=0; y<hinhgoc.Height;y++)
                {
                    // đọc giá trị pixel tại điểm  ảnh có vị trí (x,y)
                    Color pixel = hinhgoc.GetPixel(x, y );
                    //trích xuất giá trị R_G_B_anpha(độ trong suốt)
                    // mỗi kênh mày chiếm giá trị 1 byte(256 bit)
                    byte R = pixel.R;// giá trị kênh red
                    byte G = pixel.G;// giá trị kênh green
                    byte B = pixel.B;// giá trị kênh blue
                    byte A = pixel.A;// giá trị kênh anpha
                    // set các giá trị pixel đọc được cho các hình chứa
                    // các kênh tương ứng RGB
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                }
            //Hiển thị 
            pic_red.Image = red;
            pic_green.Image = green;
            pic_blue.Image = blue;

        }
    }
}
