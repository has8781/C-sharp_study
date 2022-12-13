using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            string s = "Hello World!";
            Font f = new Font("Tahoma", 15);
            SizeF sf = g.MeasureString(s, f);
            g.DrawString(s, f, Brushes.Black, 50, 50);
            g.DrawRectangle(Pens.Black, 50, 50, sf.Width, sf.Height);
            f.Dispose();

        }
    }
}
