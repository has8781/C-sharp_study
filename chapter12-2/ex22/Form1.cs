using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap("vs.png");
            g.DrawImage(img, ClientRectangle); // 지정 영역에 그림
                                               // 영역에 그릴 경우, 그려질 영역의 크기가 이미지의 크기와
                                               // 다를 경우, 이미지는 자동으로 축소되거나 확대되어 그려짐
                                               // (TextureBrush와 달리 반복되지 않고, 이미지가 확대)
        }
    }
}
