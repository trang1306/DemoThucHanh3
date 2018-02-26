using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoThucHanh3
{
    public partial class frm_DANHMUC : Form
    {

        CONNECTIONDATA Condata;
        DataTable tbDanhMuc;
      
        
        public frm_DANHMUC()
        {
            this.Condata = new CONNECTIONDATA();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadTreeView()
        {
            String SQL = "select MaDM, TenDM, ParentID from DanhMuc";

            tbDanhMuc = Condata.getData(SQL);
            this.treeDanhMuc.Nodes.Clear();
            this.tbDanhMuc.DefaultView.RowFilter = "ParentID = 0";
            foreach(DataRow row in this.tbDanhMuc.DefaultView.ToTable().Rows)
            {
                TreeNode Parentnode = new TreeNode();
                Parentnode.Text = row["TenDM"].ToString();

                Parentnode.Tag = row["MaDM"].ToString();
                Subtree(row["MaDM"].ToString(),Parentnode);
                this.treeDanhMuc.Nodes.Add(Parentnode);
            }

            treeDanhMuc.ExpandAll();
        }

        public void Subtree(String id, TreeNode ParentNode)
        {
            this.tbDanhMuc.DefaultView.RowFilter = "ParentID = " + id;
            foreach(DataRow row in this.tbDanhMuc.DefaultView.ToTable().Rows)
            {
                TreeNode ChilNode = new TreeNode();
                ChilNode.Text = row["TenDM"].ToString();
                ChilNode.Tag = row["MaDM"].ToString();

                ParentNode.Nodes.Add(ChilNode);
                Subtree(row["MaDM"].ToString(),ChilNode);
            }
        }

        private void frm_DANHMUC_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            treeDanhMuc.ExpandAll();
        }

        private void dataGridView1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            contextMenuStrip2.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Cursor.Position);

        }
        
        
        private void thêmDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            frm_QUANLYDANHMUC frm = new frm_QUANLYDANHMUC(1);
            frm.ParentId = Convert.ToInt16(this.treeDanhMuc.SelectedNode.Tag);
            
            frm.ShowDialog(this);
            LoadTreeView();
        }

        private void xóaDanhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            frm_QUANLYDANHMUC frm = new frm_QUANLYDANHMUC(3);
            frm.ParentId = Convert.ToInt16(this.treeDanhMuc.SelectedNode.Tag);

            frm.ShowDialog(this);
            LoadTreeView();
        }

        private void treeDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeDanhMuc.SelectedNode = e.Node;
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            this.contextMenuStrip2.Show(this.treeDanhMuc, e.X, e.Y);
        }

        private void hiểnThịDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String SQL = "select MaDM, TenDM, from tbDanhMuc where Parent ID = "
                + this.treeDanhMuc.SelectedNode.Tag;
            this.dataGridView1.DataSource = this.Condata.getData(SQL);
        }

        private void sửaDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QUANLYDANHMUC frm = new frm_QUANLYDANHMUC(2);
            frm.ParentId = Convert.ToInt16(this.treeDanhMuc.SelectedNode.Tag);

            frm.ShowDialog(this);
            LoadTreeView();
        }
    }
}
