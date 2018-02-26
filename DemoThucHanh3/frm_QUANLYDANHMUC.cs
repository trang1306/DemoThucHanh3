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
    public partial class frm_QUANLYDANHMUC : Form
    {
        CONNECTIONDATA Con;

        public  enum ActionTree
        {
            Node = 0,
            Add = 1, Edit = 2, Delete = 3
        }

        private ActionTree actiontree = ActionTree.Node;

        public ActionTree ACTIONTRE
        {
            get { return actiontree; }
            set { actiontree = value; }
        }

        public int ParentId { get; set; }

        /// <summary>
        ///  Node = 0,
        /// Add = 1, Edit = 2, Delete = 3
        /// </summary>
        /// <param name="Ac"></param>
        public frm_QUANLYDANHMUC(int Ac)
        {
            
            this.actiontree = (ActionTree)Ac;
            this.Con = new CONNECTIONDATA();
            InitializeComponent();
        }
        public void LoadData()
        {
            if(actiontree == ActionTree.Add)
            {
                this.txtParentID.Text = this.ParentId.ToString();
            }else if(actiontree == ActionTree.Delete || actiontree == ActionTree.Edit)
            {
                String SQL = "select * from DanhMuc where MaDM = " + this.ParentId;
                DataTable tb = this.Con.getData(SQL);
                this.txtMaDM.Text = tb.Rows[0]["MaDM"].ToString();
                this.txtTenDM.Text = tb.Rows[0]["TenDM"].ToString();
                this.txtParentID.Text = tb.Rows[0]["ParentID"].ToString();
            }
        }
        //Vo hieu hoa nut
        public void EnableButton()
        {
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            if (actiontree == ActionTree.Add)
            {
                this.btnThem.Enabled= true;
            }
            else if(actiontree == ActionTree.Edit)
            {
                this.btnSua.Enabled = true ;
            }else
            {
                this.btnXoa.Enabled = true;
            }
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ACTIONTRE == ActionTree.Delete)
            {
                DialogResult dlrMessenger;
                dlrMessenger = MessageBox.Show("Xóa mới danh mục", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlrMessenger == DialogResult.Yes)
                {
                    String SQL = "delete from DanhMuc where MaDM = "+this.txtMaDM.Text;
                    if (this.Con.ExcuteSQL(SQL) == 1)
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Lỗi xóa");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ACTIONTRE == ActionTree.Edit)
            {
                DialogResult dlrMessenger;
                dlrMessenger = MessageBox.Show("Cập nhật danh mục", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlrMessenger == DialogResult.Yes)
                {
                    String SQL = "update DanhMuc set TenDM = N'" 
                        + this.txtTenDM.Text + "' where MaDM=" + this.txtMaDM.Text;
                    if (this.Con.ExcuteSQL(SQL) == 1)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        ((frm_DANHMUC)Owner).LoadTreeView();
                    }
                    else
                        MessageBox.Show("Lỗi cập nhật");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ACTIONTRE == ActionTree.Add)
            {
                DialogResult dlrMessenger;
                dlrMessenger = MessageBox.Show("Thêm mới danh mục", "Thông báo");
                if (dlrMessenger == DialogResult.Yes)
                {
                    String SQL = "insert into DanhMuc(TenDM, ParentID)"
                        + "values(N'" + txtTenDM.Text + "'," + txtParentID.Text + ")";
                    if (this.Con.ExcuteSQL(SQL) == 1)
                        MessageBox.Show("Thêm mới thành công");
                    else
                        MessageBox.Show("Lỗi thêm mới");
                }
            }
        }

        private void frm_QUANLYDANHMUC_Load(object sender, EventArgs e)
        {
            this.txtParentID.Text = this.ParentId.ToString();
            EnableButton();
            LoadData();
        }
    }
}
