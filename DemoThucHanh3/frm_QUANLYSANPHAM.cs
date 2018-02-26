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
    public partial class frm_QUANLYSANPHAM : Form
    {
        CONNECTIONDATA con;
        string SQL;

        public frm_QUANLYSANPHAM()
        {
            con = new CONNECTIONDATA();
            InitializeComponent();
        }

        public void LoadCombobox()
        {
            SQL = "select MaDM, TenDM from DanhMuc";
            cob_DanhMuc.DisplayMember = "TenDM";
            cob_DanhMuc.ValueMember = "MaDM";
            cob_DanhMuc.DataSource = con.getData(SQL);
        }
        
        
        private void frm_QUANLYSANPHAM_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadDataGridView();
        }

        
        private void picAnh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String fileName;
            OpenFileDialog ofd_Image = new OpenFileDialog();
            if(ofd_Image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = ofd_Image.FileName;
                picAnh.Image = Image.FromFile(fileName);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
                DialogResult dlrMessenger;
                dlrMessenger = MessageBox.Show("Thêm mới danh mục", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if (dlrMessenger == DialogResult.Yes)
                {
                    String SQL = "insert into SanPham(MaSP, TenSP, Quycach, Dongia, MaDM)"
                        + "values(" + txtMaSP.Text + ",N'" + txtTenSP.Text + "',N'" + txtMoTa.Text + "'," + txtDonGia.Text + "," + cob_DanhMuc.SelectedValue + ")";
                if (this.con.ExcuteSQL(SQL) == 1)
                {
                    MessageBox.Show("Thêm mới thành công");
                    this.LoadDataGridView();
                }
                else
                    MessageBox.Show("Lỗi thêm mới");
                }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cob_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = ((DataRowView)cob_DanhMuc.SelectedItem).Row;
        }


        public void LoadDataGridView()
        {
            SQL = "select MaSP, TenSP, Quycach, MaDM, Dongia from SanPham";
            this.dataGridView1.DataSource = this.con.getData(SQL);

            //nhap cac du lieu vao dieu khien
            this.txtMaSP.DataBindings.Clear();
            this.txtMaSP.DataBindings.Add("Text", this.dataGridView1.DataSource, "MaSP");
            this.txtTenSP.DataBindings.Clear();
            this.txtTenSP.DataBindings.Add("Text", this.dataGridView1.DataSource, "TenSP");
            this.txtMoTa.DataBindings.Clear();
            this.txtMoTa.DataBindings.Add("Text", this.dataGridView1.DataSource, "Quycach");
            this.cob_DanhMuc.DataBindings.Clear();
            this.cob_DanhMuc.DataBindings.Add("SelectedValue", this.dataGridView1.DataSource, "MaDM");
            this.txtDonGia.DataBindings.Clear();
            this.txtDonGia.DataBindings.Add("Text", this.dataGridView1.DataSource, "Dongia");
        }
    }
}
