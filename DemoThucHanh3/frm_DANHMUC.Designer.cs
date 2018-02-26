using System;
using System.Windows.Forms;

namespace DemoThucHanh3
{
    partial class frm_DANHMUC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeDanhMuc = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDanhMụcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeDanhMuc
            // 
            this.treeDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.treeDanhMuc.Name = "treeDanhMuc";
            this.treeDanhMuc.Size = new System.Drawing.Size(215, 456);
            this.treeDanhMuc.TabIndex = 0;
            this.treeDanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDanhMuc_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(215, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(820, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ContextMenuStripChanged += new System.EventHandler(this.dataGridView1_ContextMenuStripChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Danh Mục";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Danh Mục";
            this.Column2.Name = "Column2";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDanhMụcToolStripMenuItem,
            this.xóaDanhMụcToolStripMenuItem1,
            this.sửaDanhMụcToolStripMenuItem,
            this.hiểnThịDanhMụcToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(267, 178);
            // 
            // thêmDanhMụcToolStripMenuItem
            // 
            this.thêmDanhMụcToolStripMenuItem.Name = "thêmDanhMụcToolStripMenuItem";
            this.thêmDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.thêmDanhMụcToolStripMenuItem.Text = "Thêm Danh Mục";
            this.thêmDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.thêmDanhMụcToolStripMenuItem_Click);
            // 
            // xóaDanhMụcToolStripMenuItem1
            // 
            this.xóaDanhMụcToolStripMenuItem1.Name = "xóaDanhMụcToolStripMenuItem1";
            this.xóaDanhMụcToolStripMenuItem1.Size = new System.Drawing.Size(266, 34);
            this.xóaDanhMụcToolStripMenuItem1.Text = "Xóa Danh Mục";
            this.xóaDanhMụcToolStripMenuItem1.Click += new System.EventHandler(this.xóaDanhMụcToolStripMenuItem1_Click);
            // 
            // sửaDanhMụcToolStripMenuItem
            // 
            this.sửaDanhMụcToolStripMenuItem.Name = "sửaDanhMụcToolStripMenuItem";
            this.sửaDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.sửaDanhMụcToolStripMenuItem.Text = "Sửa Danh Mục";
            this.sửaDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.sửaDanhMụcToolStripMenuItem_Click);
            // 
            // hiểnThịDanhMụcToolStripMenuItem
            // 
            this.hiểnThịDanhMụcToolStripMenuItem.Name = "hiểnThịDanhMụcToolStripMenuItem";
            this.hiểnThịDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.hiểnThịDanhMụcToolStripMenuItem.Text = "Hiển Thị Danh Mục";
            this.hiểnThịDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịDanhMụcToolStripMenuItem_Click);
            // 
            // frm_DANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeDanhMuc);
            this.Name = "frm_DANHMUC";
            this.Text = "frm_DANHMUC";
            this.Load += new System.EventHandler(this.frm_DANHMUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TreeView treeDanhMuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDanhMụcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sửaDanhMụcToolStripMenuItem;
        private ToolStripMenuItem hiểnThịDanhMụcToolStripMenuItem;
    }
}