namespace QuanLyCuaHang
{
    partial class Sửa_Danh_Mục
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
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.textBoxtenloai = new System.Windows.Forms.TextBox();
            this.textBoxmaloai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(442, 315);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 45;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(236, 315);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 46;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // textBoxtenloai
            // 
            this.textBoxtenloai.Location = new System.Drawing.Point(396, 228);
            this.textBoxtenloai.Name = "textBoxtenloai";
            this.textBoxtenloai.Size = new System.Drawing.Size(197, 20);
            this.textBoxtenloai.TabIndex = 43;
            this.textBoxtenloai.TextChanged += new System.EventHandler(this.textBoxtenloai_TextChanged);
            // 
            // textBoxmaloai
            // 
            this.textBoxmaloai.Location = new System.Drawing.Point(396, 185);
            this.textBoxmaloai.Name = "textBoxmaloai";
            this.textBoxmaloai.ReadOnly = true;
            this.textBoxmaloai.Size = new System.Drawing.Size(197, 20);
            this.textBoxmaloai.TabIndex = 44;
            this.textBoxmaloai.TextChanged += new System.EventHandler(this.textBoxmaloai_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tên loại sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mã loại sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "SỬA DANH MỤC SẢN PHẨM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sửa_Danh_Mục
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.textBoxtenloai);
            this.Controls.Add(this.textBoxmaloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Sửa_Danh_Mục";
            this.Text = "Sửa_Danh_Mục";
            this.Load += new System.EventHandler(this.Sửa_Danh_Mục_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox textBoxtenloai;
        private System.Windows.Forms.TextBox textBoxmaloai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}