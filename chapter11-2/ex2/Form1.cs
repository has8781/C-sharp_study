using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1 {
    public partial class Form1 : Form {
        private int index;
        private Image[] images;
        public Form1()
        {
            InitializeComponent();
            // Form1의 생성자에 추가
            images = new Image[10];
            string imagePath = @"C:\Users\deu\Desktop\1207\DUKE\T";
            for (int i = 1; i <= 10; i++)
                images[i - 1] = Image.FromFile(imagePath + i + ".gif");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < 10)
                label1.Image = images[index++];
            else
            {
                index = 0;
                label1.Image = images[index++];
            }
        }
    }
}
