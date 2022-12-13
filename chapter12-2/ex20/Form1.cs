using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            string s = "This string is long enough to wrap. "; // 출력할 문자열
            s += "We'll use a 15pt font, and assume ";
            s += "the text string must fit into a width of 250 pixels. ";
            Font f = new Font("Tahoma", 15); // 서체는 타호마, 글자 크기는 15.
            SizeF sf = g.MeasureString(s, f, 250); // 영역의 크기를 측정한다.
            RectangleF rf = new RectangleF(20, 20, sf.Width, sf.Height);
            Rectangle r = Rectangle.Ceiling(rf); // 올림으로 변환
            g.DrawString(s, f, Brushes.Black, r); // 문자열을 출력한다.
            g.DrawRectangle(Pens.Black, r); // 외곽선을 그린다.
            f.Dispose();
        }
    }
}
