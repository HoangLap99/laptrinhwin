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
    public partial class quanLyTaiKhoan : Form
    {
        public quanLyTaiKhoan()
        {
            InitializeComponent();
        }
        QLCHDataContext data = new QLCHDataContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            var taikhoan = from tk in data.taikhoans
                               select new
                               {
                                   tk.mataikhoan,
                                   tk.manhanvien,
                                   tk.matkhau,
                                   
                               };
            dataGridtaikhoan.Rows.Clear();
            foreach (var item in taikhoan)
            {
                DataGridViewRow moi = (DataGridViewRow)dataGridtaikhoan.Rows[0].Clone();
                moi.Cells[0].Value = item.mataikhoan;
                moi.Cells[1].Value = item.manhanvien;
                moi.Cells[2].Value = item.matkhau;
                moi.Cells[3].Value = "Xóa";
                dataGridtaikhoan.Rows.Add(moi);
            }
            var nhanvien = from nv in data.nhanviens
                              select nv;
            comboBox.DataSource = nhanvien;
            comboBox.DisplayMember = "tennhanvien";
            comboBox.ValueMember = "manhanvien";
        }
        public quanLyTaiKhoan(string ma):this()
        {
            nhanvien nv = data.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txtTennv.Text = nv.tennhanvien;
        }
        private void Btndangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmataikhoan.Text.Trim().Equals("") && txtmatkhau.Text == "")
                { MessageBox.Show("nhập đầy đủ thông tin"); }
                else
                {
                    taikhoan tkMoi = new taikhoan();

                    tkMoi.mataikhoan = txtmataikhoan.Text;
                    tkMoi.matkhau = txtmatkhau.Text;

                    tkMoi.manhanvien = comboBox.SelectedValue.ToString();

                    data.taikhoans.InsertOnSubmit(tkMoi);
                    //Lưu vào csdl
                    data.SubmitChanges();
                    MessageBox.Show("bạn đã thêm thành công");
                    //Hiển thị lại dữ liệu
                    hienthi();
                }
            }
            catch
            {
                MessageBox.Show("Du lieu khong hop le");
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridtaikhoan.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridtaikhoan.Rows[index];
            txtmataikhoan.Text = Convert.ToString(row.Cells["mataikhoan"].Value);
            comboBox.Text = Convert.ToString(row.Cells["manhanvien"].Value);
            txtmatkhau.Text = Convert.ToString(row.Cells["matkhau"].Value);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            taikhoan tkSua = data.taikhoans.SingleOrDefault(sp => sp.mataikhoan == txtmataikhoan.Text);
            tkSua.mataikhoan = txtmataikhoan.Text;
            tkSua.manhanvien = comboBox.SelectedValue.ToString();
            tkSua.matkhau = txtmatkhau.Text;
           
            //Lưu vào csdl
            data.SubmitChanges();
            MessageBox.Show("bạn đã sửa thành công");
            hienthi();
        }

        private void CellContenClick(object sender, DataGridViewCellEventArgs e)
        {
            string matk = dataGridtaikhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy sản phẩm muốn xóa hoặc sửa
            taikhoan tkXoa = data.taikhoans.SingleOrDefault(tk=>tk.mataikhoan == matk);
            if (e.ColumnIndex == 3)//nếu user click Xóa thì xóa sản phẩm được chọn
            {
                data.taikhoans.DeleteOnSubmit(tkXoa);
                if (MessageBox.Show("bạn có chắc muốn xóa tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data.SubmitChanges();
                    hienthi();
                }
            }
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
           
            string manv = txtmanv.Text;
            trangChu hd = new trangChu(manv);
            this.Visible = false;
            hd.ShowDialog();
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
