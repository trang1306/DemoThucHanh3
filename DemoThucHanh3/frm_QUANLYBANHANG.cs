using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoThucHanh3
{
    public partial class frm_QUANLYBANHANG : Form
    {
        public frm_QUANLYBANHANG()
        {
            InitializeComponent();
        }

        private void frm_QUANLYBANHANG_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkForm("frm_DANGNHAP"))
            {
                frm_DANGNHAP frmdangnhap = new frm_DANGNHAP();
                frmdangnhap.MdiParent = this; //this la parent
                frmdangnhap.Show();
            }
        }


        public bool checkForm(String frmName)
        {
            bool f = false;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    frm.Activate();
                    f = true;
                    break;
                }
            }
            return f;
        }

        private void nhậpDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkForm("frm_DANGNHAP"))
            {
                frm_DANGNHAP f = new frm_DANGNHAP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void nhapMatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkForm("frm_QUANLYSANPHAM"))
            {
                frm_QUANLYSANPHAM f = new frm_QUANLYSANPHAM();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
