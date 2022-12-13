using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, System.EventArgs e)
        {
            Graphics g = CreateGraphics();
            Font f = new Font("Tahoma", 15);
            g.DrawString("Hello World!", f, Brushes.Black, 10, 10);
            f.Dispose();
        }

    }
}
