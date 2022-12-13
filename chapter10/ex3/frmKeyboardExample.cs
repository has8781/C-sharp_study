using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9 {
    public partial class frmKeyboardExample : Form {
        public frmKeyboardExample()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'k') || (e.KeyChar == 'K') ) 
                e.Handled = true; // 별도 처리 설정(이미 처리 완료 지시: 키 무시 됨 )
        }
    }
}
