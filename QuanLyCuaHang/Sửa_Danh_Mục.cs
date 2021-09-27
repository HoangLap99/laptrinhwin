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
    public partial class Sửa_Danh_Mục : Form
    {
        public Sửa_Danh_Mục()
        {
            InitializeComponent();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            QLCHDataContext db = new QLCHDataContext();

            loaisanpham spsua = db.loaisanphams.SingleOrDefault(sp => sp.maloaisanpham == textBoxmaloai.Text);

            spsua.tenloaisanpham = textBoxtenloai.Text;


            db.SubmitChanges();
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxtenloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxmaloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sửa_Danh_Mục_Load(object sender, EventArgs e)
        {
            loaisanpham spChon = (loaisanpham)this.Tag;//sản phẩm sửa được truyền từ form Danh mục sản phẩm
            //lấy thông tin của loại sản phẩm được sửa hiển thị lên các điều khiển             
            textBoxmaloai.Text = spChon.maloaisanpham;
            textBoxtenloai.Text = spChon.tenloaisanpham;
        }
    }
}
