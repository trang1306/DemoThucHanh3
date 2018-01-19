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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tivi");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Bàn");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Laptop");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Máy Tính", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Máy Giặt");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Máy Lạnh");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Máy Nóng");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Điện Tử", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Nam");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Nữ");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Thời Trang", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Danh Mục", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Node8";
            treeNode13.Text = "Tivi";
            treeNode14.Name = "Node17";
            treeNode14.Text = "Bàn";
            treeNode15.Name = "Node18";
            treeNode15.Text = "Laptop";
            treeNode16.Name = "Node10";
            treeNode16.Text = "Máy Tính";
            treeNode17.Name = "Node11";
            treeNode17.Text = "Máy Giặt";
            treeNode18.Name = "Node12";
            treeNode18.Text = "Máy Lạnh";
            treeNode19.Name = "Node13";
            treeNode19.Text = "Máy Nóng";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Điện Tử";
            treeNode21.Name = "Node15";
            treeNode21.Text = "Nam";
            treeNode22.Name = "Node16";
            treeNode22.Text = "Nữ";
            treeNode23.Name = "Node14";
            treeNode23.Text = "Thời Trang";
            treeNode24.Name = "Node4";
            treeNode24.Text = "Danh Mục";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(215, 456);
            this.treeView1.TabIndex = 0;
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
            // frm_DANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "frm_DANHMUC";
            this.Text = "frm_DANHMUC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}