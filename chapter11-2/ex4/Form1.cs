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
        Point start;
        Point end;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(this.pictureBox1.BackColor);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end.X = e.X;
            end.Y = e.Y;

            g = this.pictureBox1.CreateGraphics();
            g.DrawLine(Pens.White, start, end);
            // pictureBox1.Refresh();
            // Invalidate();
        }
    }
}
