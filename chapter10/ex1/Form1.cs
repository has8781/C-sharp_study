using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics objGraphics = CreateGraphics();
            objGraphics.DrawRectangle(Pens.Blue,
            pictureBox1.Left - 2, pictureBox1.Top - 2,
            pictureBox1.Width + 2, pictureBox1.Height + 2);
            objGraphics.Dispose();
        }
    }
}
