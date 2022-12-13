using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap("vs.png");
            Point[] pts = {
            new Point(0, 0), // 원본의 왼쪽 상단 모서리의 대상 위치
            new Point(200, 0), // 원본의 오른쪽 상단 모서리의 대상 위치
            new Point(50, 100) // 원본의 왼쪽 하단 모서리의 대상 위치
            };
            g.DrawImage(img, pts);
        }
    }
}
