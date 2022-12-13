using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillEllipse(Brushes.Cyan, r);
            g.DrawEllipse(Pens.Black, r);
        }
    }
}
