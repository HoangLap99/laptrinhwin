namespace QuanLyCuaHang
{
    partial class nhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewnhacungcap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btnquaylai = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.Btnthem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmanhacc = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.manhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhacungcap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewnhacungcap
            // 
            this.dataGridViewnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnhacungcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhacungcap,
            this.tennhacungcap,
            this.diachi,
            this.sdt,
            this.email,
            this.Column1});
            this.dataGridViewnhacungcap.Location = new System.Drawing.Point(4, 392);
            this.dataGridViewnhacungcap.Name = "dataGridViewnhacungcap";
            this.dataGridViewnhacungcap.RowHeadersWidth = 51;
            this.dataGridViewnhacungcap.RowTemplate.Height = 24;
            this.dataGridViewnhacungcap.Size = new System.Drawing.Size(870, 303);
            this.dataGridViewnhacungcap.TabIndex = 0;
            this.dataGridViewnhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            this.dataGridViewnhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellcontentclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã nhà cung cấp";
            // 
            // Btnquaylai
            // 
            this.Btnquaylai.Location = new System.Drawing.Point(366, 216);
            this.Btnquaylai.Name = "Btnquaylai";
            this.Btnquaylai.Size = new System.Drawing.Size(75, 27);
            this.Btnquaylai.TabIndex = 7;
            this.Btnquaylai.Text = "Quay lại";
            this.Btnquaylai.UseVisualStyleBackColor = true;
            this.Btnquaylai.Click += new System.EventHandler(this.Btnquaylai_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(366, 148);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 8;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // Btnthem
            // 
            this.Btnthem.Location = new System.Drawing.Point(366, 80);
            this.Btnthem.Name = "Btnthem";
            this.Btnthem.Size = new System.Drawing.Size(75, 23);
            this.Btnthem.TabIndex = 9;
            this.Btnthem.Text = "Thêm";
            this.Btnthem.UseVisualStyleBackColor = true;
            this.Btnthem.Click += new System.EventHandler(this.Btnthem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Danh sách nhà cung cấp";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(148, 257);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 22);
            this.txtemail.TabIndex = 11;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(148, 213);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(157, 22);
            this.txtsdt.TabIndex = 12;
            // 
            // txtmanhacc
            // 
            this.txtmanhacc.Location = new System.Drawing.Point(148, 80);
            this.txtmanhacc.Name = "txtmanhacc";
            this.txtmanhacc.Size = new System.Drawing.Size(157, 22);
            this.txtmanhacc.TabIndex = 13;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(148, 118);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(157, 22);
            this.txttenncc.TabIndex = 14;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(148, 162);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(157, 22);
            this.txtdiachi.TabIndex = 15;
            this.txtdiachi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btntimkiem);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(471, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 113);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // Btntimkiem
            // 
            this.Btntimkiem.Location = new System.Drawing.Point(270, 70);
            this.Btntimkiem.Name = "Btntimkiem";
            this.Btntimkiem.Size = new System.Drawing.Size(83, 27);
            this.Btntimkiem.TabIndex = 4;
            this.Btntimkiem.Text = "Tìm";
            this.Btntimkiem.UseVisualStyleBackColor = true;
            this.Btntimkiem.Click += new System.EventHandler(this.Btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttimkiem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.Color.DimGray;
            this.txttimkiem.Location = new System.Drawing.Point(18, 39);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(233, 25);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.Text = "Tên nhà cung cấp";
            // 
            // manhacungcap
            // 
            this.manhacungcap.HeaderText = "mã nhà cung cấp";
            this.manhacungcap.MinimumWidth = 6;
            this.manhacungcap.Name = "manhacungcap";
            this.manhacungcap.Width = 125;
            // 
            // tennhacungcap
            // 
            this.tennhacungcap.HeaderText = "Tên nhà cung cấp";
            this.tennhacungcap.MinimumWidth = 6;
            this.tennhacungcap.Name = "tennhacungcap";
            this.tennhacungcap.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Xóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(12, 12);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(55, 22);
            this.txtmanv.TabIndex = 21;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(15, 41);
            this.txttennv.Name = "txttennv";
            this.txttennv.ReadOnly = true;
            this.txttennv.Size = new System.Drawing.Size(133, 22);
            this.txttennv.TabIndex = 22;
            // 
            // nhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(886, 707);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmanhacc);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btnthem);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.Btnquaylai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewnhacungcap);
            this.Name = "nhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.nhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhacungcap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewnhacungcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btnquaylai;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button Btnthem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmanhacc;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
    }
}