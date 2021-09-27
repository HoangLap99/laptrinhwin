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
    public partial class Sửa_Thông_Tin_Nhân_Viên : Form
    {
        public Sửa_Thông_Tin_Nhân_Viên()
        {
            InitializeComponent();
        }

        private void Sửa_Thông_Tin_Nhân_Viên_Load(object sender, EventArgs e)
        {
            nhanvien nv = (nhanvien)this.Tag;//nhân viên sửa được truyền từ form Quản lý nhân viên
            //lấy thông tin của khách hàng được sửa hiển thị lên các điều khiển             
            textBoxmanv.Text = nv.manhanvien;
            textBoxtennv.Text = nv.tennhanvien;
            textBoxgioitinhnv.Text = nv.gioitinh;
            textBoxdiachinv.Text = nv.diachi;

            textBoxsdtnv.Text = nv.sodienthoai;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            QLCHDataContext db = new QLCHDataContext();

            nhanvien nvsua = db.nhanviens.SingleOrDefault(nv => nv.manhanvien == textBoxmanv.Text);

            nvsua.tennhanvien = textBoxtennv.Text;
            nvsua.gioitinh = textBoxgioitinhnv.Text;
            nvsua.diachi = textBoxdiachinv.Text;

            nvsua.sodienthoai = textBoxsdtnv.Text;

            db.SubmitChanges();
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
