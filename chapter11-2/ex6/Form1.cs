using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _4 {
    public partial class Form1 : Form {
        Point start;
        Point end;
        Graphics g;
        ArrayList lines = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if (lines.Count > 1)
            {
                for (int i = 0; i < lines.Count - 1; i = 1 + 2)
                    g.DrawLine(Pens.White, (Point)lines[i], (Point)lines[i + 1]);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            lines.Add(start);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end.X = e.X;
            end.Y = e.Y;
            lines.Add(end);
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lines.Clear();
            pictureBox1.Invalidate();
        }
    }
}
