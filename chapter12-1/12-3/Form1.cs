using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;
            Image img = new Bitmap(s.Width, s.Height); // 폼 크기와 같은 메모리상 가상 이미지
            Graphics bg = Graphics.FromImage(img); // 가상 이미지에 대한 그래픽 객체
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            bg.FillRectangle(new SolidBrush(c), ClientRectangle); // 참고 : e.ClipRectangle
            Graphics fg = e.Graphics; // 폼에 대한 그래픽 객체
            fg.DrawImage(img, 0, 0); // 폼에 대한 그래픽 객체에 변형된 백그라운드 작업 이미지 표시
        }

    }
}
