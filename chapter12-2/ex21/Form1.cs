using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, System.EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap("vs.png");
            g.DrawImage(img, 0, 0); // g.DrawImage(img, new Point(0, 0)); // 지정 좌표에 그림


        }

    }
}
