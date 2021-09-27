namespace QuanLyCuaHang
{
    partial class Quản_Lý_Nhân_Viên
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
            this.btnreload = new System.Windows.Forms.Button();
            this.Btnquaylai = new System.Windows.Forms.Button();
            this.txtsdtnv = new System.Windows.Forms.TextBox();
            this.txtgioitinhnv = new System.Windows.Forms.TextBox();
            this.txtdiachinv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.sua = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimnv = new System.Windows.Forms.Button();
            this.txttimkiemnv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(511, 175);
            this.btnreload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(100, 28);
            this.btnreload.TabIndex = 64;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // Btnquaylai
            // 
            this.Btnquaylai.Location = new System.Drawing.Point(511, 306);
            this.Btnquaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnquaylai.Name = "Btnquaylai";
            this.Btnquaylai.Size = new System.Drawing.Size(100, 23);
            this.Btnquaylai.TabIndex = 63;
            this.Btnquaylai.Text = "Hủy";
            this.Btnquaylai.UseVisualStyleBackColor = true;
            this.Btnquaylai.Click += new System.EventHandler(this.Btnquaylai_Click);
            // 
            // txtsdtnv
            // 
            this.txtsdtnv.Location = new System.Drawing.Point(184, 271);
            this.txtsdtnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdtnv.Name = "txtsdtnv";
            this.txtsdtnv.Size = new System.Drawing.Size(265, 22);
            this.txtsdtnv.TabIndex = 57;
            // 
            // txtgioitinhnv
            // 
            this.txtgioitinhnv.Location = new System.Drawing.Point(184, 231);
            this.txtgioitinhnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgioitinhnv.Name = "txtgioitinhnv";
            this.txtgioitinhnv.Size = new System.Drawing.Size(265, 22);
            this.txtgioitinhnv.TabIndex = 58;
            // 
            // txtdiachinv
            // 
            this.txtdiachinv.Location = new System.Drawing.Point(184, 187);
            this.txtdiachinv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachinv.Name = "txtdiachinv";
            this.txtdiachinv.Size = new System.Drawing.Size(265, 22);
            this.txtdiachinv.TabIndex = 56;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(184, 145);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(265, 22);
            this.txttennv.TabIndex = 55;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(184, 102);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(265, 22);
            this.txtmanv.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 36);
            this.label8.TabIndex = 53;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã nhân viên";
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.gioitinh,
            this.diachi,
            this.sdt,
            this.xoa,
            this.sua});
            this.dgvnhanvien.Location = new System.Drawing.Point(87, 394);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.Size = new System.Drawing.Size(867, 185);
            this.dgvnhanvien.TabIndex = 59;
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã nhân viên";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.makh.Width = 120;
            // 
            // tenkh
            // 
            this.tenkh.HeaderText = "Tên nhân viên";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 120;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 80;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 80;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa ";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xoa.Width = 50;
            // 
            // sua
            // 
            this.sua.HeaderText = "Sửa";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            this.sua.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "Quản Lý Nhân Viên";
            // 
            // btnthemnv
            // 
            this.btnthemnv.Location = new System.Drawing.Point(511, 245);
            this.btnthemnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(100, 28);
            this.btnthemnv.TabIndex = 61;
            this.btnthemnv.Text = "Thêm";
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntimnv);
            this.groupBox1.Controls.Add(this.txttimkiemnv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(663, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(387, 170);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btntimnv
            // 
            this.btntimnv.Location = new System.Drawing.Point(144, 129);
            this.btntimnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimnv.Name = "btntimnv";
            this.btntimnv.Size = new System.Drawing.Size(100, 28);
            this.btntimnv.TabIndex = 4;
            this.btntimnv.Text = "Tìm kiếm";
            this.btntimnv.UseVisualStyleBackColor = true;
            this.btntimnv.Click += new System.EventHandler(this.btntimnv_Click);
            // 
            // txttimkiemnv
            // 
            this.txttimkiemnv.Location = new System.Drawing.Point(144, 69);
            this.txttimkiemnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiemnv.Name = "txttimkiemnv";
            this.txttimkiemnv.Size = new System.Drawing.Size(221, 22);
            this.txttimkiemnv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên nhân viên";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(28, 20);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(74, 22);
            this.txtma.TabIndex = 65;
            this.txtma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(28, 48);
            this.txtten.Name = "txtten";
            this.txtten.ReadOnly = true;
            this.txtten.Size = new System.Drawing.Size(152, 22);
            this.txtten.TabIndex = 66;
            // 
            // Quản_Lý_Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.Btnquaylai);
            this.Controls.Add(this.txtsdtnv);
            this.Controls.Add(this.txtgioitinhnv);
            this.Controls.Add(this.txtdiachinv);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnthemnv);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Quản_Lý_Nhân_Viên";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Quản_Lý_Nhân_Viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button Btnquaylai;
        private System.Windows.Forms.TextBox txtsdtnv;
        private System.Windows.Forms.TextBox txtgioitinhnv;
        private System.Windows.Forms.TextBox txtdiachinv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
        private System.Windows.Forms.DataGridViewLinkColumn sua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimnv;
        private System.Windows.Forms.TextBox txttimkiemnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
    }
}