using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace XLA_prj02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image<Bgr, byte> hinhhienthi = new Image<Bgr, byte>(@"C:\Users\Loc\Pictures\Saved Pictures\download.jpg");
            img_hinhhienthi.Image = hinhhienthi;
        }
    }
}
