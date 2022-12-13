using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            g.FillRectangle(new SolidBrush(c), ClientRectangle);
        }
    }
}
