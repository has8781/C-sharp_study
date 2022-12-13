using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawBezier(Pens.Magenta,
            new Point(100, 50), // start point
            new Point(0, 100), // control point one
            new Point(200, 100), // control point two
            new Point(100, 150)); // end point
        }
    }
}
