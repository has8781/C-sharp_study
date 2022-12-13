using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(50, 50, 150, 100);  // 기준점 (50, 50), 폭과 넓이(150, 100)
            g.DrawArc(Pens.Red, r, 45, 270);    // 시작 각도 x축 기준 45, 호각 270도
        }
    }
}
