using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap("vs.png");
            Rectangle sr = new Rectangle(0, 0, 80, 30); // 원본의 부분적인 크기
            Rectangle dr = new Rectangle(0, 0, 200, 100); // 그려질 영역 크기
            g.DrawImage(img, dr, sr, GraphicsUnit.Pixel);
        }
    }
}
