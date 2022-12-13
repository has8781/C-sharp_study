using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Point[] pts = {
            new Point(115, 30), new Point(140, 90),
            new Point(200, 115), new Point(140, 140),
            new Point(115, 200), new Point(90, 140),
            new Point(30, 115), new Point(90, 90)
            };
            g.FillClosedCurve(Brushes.Yellow, pts); // 내부 색 : 노란색
            g.DrawClosedCurve(Pens.Red, pts);   // 테두리 색 : 빨간색
        }
    }
}
