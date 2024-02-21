using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mini_prj13
{
    public partial class Form1 : Form
    {
        
        Bitmap hinhgoc = new Bitmap(@"D:\Python\bird_small.jpg");
        public Form1()
        {
            InitializeComponent();
            pic_goc.Image = hinhgoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt16(text_X1.Text);
            int y1 = Convert.ToInt16(text_Y1.Text);
            int x2 = Convert.ToInt16(text_X2.Text);
            int y2 = Convert.ToInt16(text_X2.Text);
            int nguong=Convert.ToInt16(text_nguong.Text);
            //biến chưa vecto trung bình giá trị màu
            double aRtb = 0, aGtb=0, aBtb = 0;
            //tính giá trị vecto trung bình
            for(int x = x1 ; x <= x2; x++) 
                for(int y = y1 ; y <= y2; y++)
                {
                    Color pixel=hinhgoc.GetPixel(x,y);
                    aRtb+= pixel.R;
                    aGtb+= pixel.G;
                    aBtb+= pixel.B;

                }
            //tính trung bình cộng của tất cả điểm ảnh trong vùng đã chọn
            double size= Math.Abs(x2-x1)*Math.Abs(y2-y1);
            aRtb /= size;
            aGtb /= size;
            aBtb /= size;

            //phân đoạn ảnh
            //tạo 1 bitmap chứa hình segmentation
            Bitmap SegImg=new Bitmap(hinhgoc.Width,hinhgoc.Height);
            //vecto z là đối tượng ta muốn khảo sát là nền hay là đối tượng
            for (int x = 0; x < hinhgoc.Width;x++)
                for(int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel1 =hinhgoc.GetPixel(x, y);
                    double zR = pixel1.R;
                    double zG = pixel1.G;
                    double zB = pixel1.B;
                    //áp dụng công thứ Euclidean Distance để tính chênh lệch giá trị màu
                    double D=Math.Sqrt(Math.Pow(zR-aRtb,2)+Math.Pow(zG-aGtb,2)+Math.Pow(zB-aBtb,2));
                    //lấy giá trị D vừa tính được so với giá trị ngưỡng để xác định là object hay background
                    if ((int)D <= nguong)
                        SegImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));//cho điểm này thành màu trắng
                    else
                        SegImg.SetPixel(x,y,Color.FromArgb((int)zR,(int)zG,(int)zB));

                }
            //hiển thị ảnh đã phân đoạn
            pic_seg.Image= SegImg;
        }
    }
}
