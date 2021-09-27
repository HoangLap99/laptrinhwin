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
    public partial class Sửa_Thông_Tin_Khách_Hàng : Form
    {
        public Sửa_Thông_Tin_Khách_Hàng()
        {
            InitializeComponent();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            QLCHDataContext db = new QLCHDataContext();

            khachhang khsua = db.khachhangs.SingleOrDefault(kh => kh.makhachhang == textBoxmakh.Text);

            khsua.tenkhachhang = textBoxtenkh.Text;

            khsua.diachi = textBoxdiachikh.Text;
            khsua.gioitinh = textBoxgioitinhkh.Text;
            khsua.sodienthoai = textBoxsdtkh.Text;

            db.SubmitChanges();
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sửa_Thông_Tin_Khách_Hàng_Load(object sender, EventArgs e)
        {
            khachhang kh = (khachhang)this.Tag;//nhân viên sửa được truyền từ form Quản lý nhân viên
            //lấy thông tin của khách hàng được sửa hiển thị lên các điều khiển             
            textBoxmakh.Text = kh.makhachhang;
            textBoxtenkh.Text = kh.tenkhachhang;

            textBoxdiachikh.Text = kh.diachi;
            textBoxgioitinhkh.Text = kh.gioitinh;
            textBoxsdtkh.Text = kh.sodienthoai;
        }
    }
}
