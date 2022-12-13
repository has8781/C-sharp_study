using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21 {
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
            new Point(0, 100), new Point(200, 100), new Point(0, 0)
            };
            g.DrawImage(img, pts);
        }
    }
}
