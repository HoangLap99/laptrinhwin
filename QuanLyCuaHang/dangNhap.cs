using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCuaHang
{
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }
        
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            QLCHDataContext db = new QLCHDataContext();
            taikhoan tkhientai = db.taikhoans.SingleOrDefault(
                tk => tk.manhanvien == txttendangnhap.Text &&
                tk.matkhau == txtmatkhau.Text);
            if (tkhientai != null)
            {
                //trangChu formtrangchu = new trangChu();
                //formtrangchu.Tag = tkhientai;
                //hoaDon hd = new hoaDon();
                //hd.Tag = tkhientai;
                //formtrangchu.Show();
                string manv = tkhientai.manhanvien;
                trangChu send = new trangChu(manv);
                this.Visible = false;
                send.ShowDialog();
              
            }
            else
                MessageBox.Show("Tên đăng nhập và (hoặc) mật khẩu sai");

             
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
