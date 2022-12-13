using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10 {
    public partial class frmMousePaint : Form {
        private Graphics m_objGraphics;
        public frmMousePaint()
        {
            InitializeComponent();
        }

        private void frmMousePaint_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void frmMousePaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objGraphics.Dispose();
        }

        private void frmMousePaint_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rectEllipse = new Rectangle();
            if (e.Button != MouseButtons.Left) return; // 왼쪽 마우스 버튼이 아닐 경우 바로 종료
            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;
            rectEllipse.Width = 2;
            rectEllipse.Height = 2;
            m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);
        }
    }
}
