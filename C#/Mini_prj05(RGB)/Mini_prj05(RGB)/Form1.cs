using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Mini_prj05_RGB_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tải hình lên
            Bitmap hinhgoc =new Bitmap( @"C:\Users\Loc\Desktop\bird_small.jpg");

            // hiển thị hình gốc
            pic_goc.Image = hinhgoc;
            // gọi hàm đã viết để chạy biểu đồ
            double[,] histogram = TinhHistogram(hinhgoc);
            List<PointPairList> points = ChuyenDoiHistogram(histogram);
            // vẽ và hiển thị biểu đồ
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();

        }
        public double[,] TinhHistogram(Bitmap bmp)
        {

            // khai báo mảng có 3,256 phần tử theo 2 chiều
            //3 là số kênh màu, 256 là giá trị của các kênh màu 
            double[,] histogram = new double[3,256];
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {

                    Color color = bmp.GetPixel(x, y);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    histogram[0,R]++;
                    histogram[1, G]++;
                    histogram[2, B]++;


                }
            return histogram;

        }
        List<PointPairList> ChuyenDoiHistogram(double[,] histogram)
        {

            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList();//chuyển đổi histogram kênh R
            PointPairList greenPoints = new PointPairList();//chuyển đổi histogram kênh G

            PointPairList bluePoints = new PointPairList();//chuyển đổi histogram kênh B

            for (int i = 0; i < 256; i++)
            {
                //i chạy từ 0-->255 vì nó là giá trị gray
                //histogram[i] tương ứng  trục đứng, là số pixels cùng mức xám
                redPoints.Add(i, histogram[0,i]);
                greenPoints.Add(i, histogram[1, i]);
                bluePoints.Add(i, histogram[2, i]);
            }
            // add các kênh vào mảng point
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);

            return points;
        }
        public GraphPane BieuDoHistogram(List<PointPairList> histogram)
        {
            //GraphPane lad đối tượng  biểu đồ trong  Zedgraph
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ  Histogram";//tên biểu đồ
            //gp.Rect = new Rectangle(0, 0, 1000, 900);// khung chứa biểu đồ
            // thiết lập trục ngang
            gp.XAxis.Title.Text = @"Giá trị màu của điểm ảnh";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;
            gp.XAxis.Scale.MinorStep = 1;
            //Thiết lập trục đứng
            gp.YAxis.Title.Text = @"Giá trị màu của điểm ảnh";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 25000;// cho giá trị lớn hơn giá trị điểm ảnh có nhiều nhất
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;
            // dùng biểu đồ dạng Bar để  biểu diễn Histogram
            gp.AddBar("Histogram'red", histogram[0], Color.Red);
            gp.AddBar("Histogram'green", histogram[1], Color.Green);
            gp.AddBar("Histogram'blue", histogram[2], Color.Blue);
            return gp;
        }

    }
}
