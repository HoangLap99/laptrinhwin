namespace QuanLyCuaHang
{
    partial class quanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btndangky = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmataikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnhuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridtaikhoan = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.BtnSua = new System.Windows.Forms.Button();
            this.mataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // Btndangky
            // 
            this.Btndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndangky.Location = new System.Drawing.Point(517, 104);
            this.Btndangky.Name = "Btndangky";
            this.Btndangky.Size = new System.Drawing.Size(94, 29);
            this.Btndangky.TabIndex = 13;
            this.Btndangky.Text = "Thêm";
            this.Btndangky.UseVisualStyleBackColor = true;
            this.Btndangky.Click += new System.EventHandler(this.Btndangky_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quản Lý Tài Khoản";
            // 
            // txtmataikhoan
            // 
            this.txtmataikhoan.Location = new System.Drawing.Point(178, 111);
            this.txtmataikhoan.Name = "txtmataikhoan";
            this.txtmataikhoan.Size = new System.Drawing.Size(163, 22);
            this.txtmataikhoan.TabIndex = 11;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(178, 207);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(163, 22);
            this.txtmatkhau.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Tài khoản :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật Khẩu :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btnhuy
            // 
            this.Btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhuy.Location = new System.Drawing.Point(517, 248);
            this.Btnhuy.Name = "Btnhuy";
            this.Btnhuy.Size = new System.Drawing.Size(94, 30);
            this.Btnhuy.TabIndex = 7;
            this.Btnhuy.Text = "Hủy";
            this.Btnhuy.UseVisualStyleBackColor = true;
            this.Btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhân Viên :";
            // 
            // dataGridtaikhoan
            // 
            this.dataGridtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mataikhoan,
            this.manhanvien,
            this.matkhau,
            this.Column4});
            this.dataGridtaikhoan.Location = new System.Drawing.Point(36, 349);
            this.dataGridtaikhoan.Name = "dataGridtaikhoan";
            this.dataGridtaikhoan.RowHeadersWidth = 51;
            this.dataGridtaikhoan.RowTemplate.Height = 24;
            this.dataGridtaikhoan.Size = new System.Drawing.Size(602, 232);
            this.dataGridtaikhoan.TabIndex = 16;
            this.dataGridtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dataGridtaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContenClick);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(178, 156);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(163, 24);
            this.comboBox.TabIndex = 17;
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(517, 156);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(94, 29);
            this.BtnSua.TabIndex = 18;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // mataikhoan
            // 
            this.mataikhoan.HeaderText = "Mã tài Khoản";
            this.mataikhoan.MinimumWidth = 6;
            this.mataikhoan.Name = "mataikhoan";
            this.mataikhoan.Width = 120;
            // 
            // manhanvien
            // 
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.MinimumWidth = 6;
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Width = 120;
            // 
            // matkhau
            // 
            this.matkhau.HeaderText = "Mật Khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 120;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Xóa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(36, 73);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.ReadOnly = true;
            this.txtTennv.Size = new System.Drawing.Size(141, 22);
            this.txtTennv.TabIndex = 30;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(36, 24);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(85, 22);
            this.txtmanv.TabIndex = 29;
            // 
            // quanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(718, 593);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridtaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btndangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmataikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnhuy);
            this.Name = "quanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.quanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btndangky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmataikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnhuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridtaikhoan;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtmanv;
    }
}