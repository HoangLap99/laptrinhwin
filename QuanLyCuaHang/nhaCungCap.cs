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
    public partial class nhaCungCap : Form
    {
        public nhaCungCap()
        {
            InitializeComponent();
        }
        QLCHDataContext data = new QLCHDataContext();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewnhacungcap.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridViewnhacungcap.Rows[index];
            txtmanhacc.Text = Convert.ToString(row.Cells["manhacungcap"].Value);
            txttenncc.Text = Convert.ToString(row.Cells["tennhacungcap"].Value);
            txtdiachi.Text = Convert.ToString(row.Cells["diachi"].Value);
            txtsdt.Text = Convert.ToString(row.Cells["sdt"].Value);
            txtemail.Text = Convert.ToString(row.Cells["email"].Value);
        }

        private void nhaCungCap_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            var ncc = from nc in data.nhacungcaps
                           select new
                           {
                              nc.manhacungcap,
                              nc.tennhacungcap,
                              nc.diachi,
                              nc.sodienthoai,
                              nc.email

                           };
            dataGridViewnhacungcap.Rows.Clear();
            foreach (var item in ncc)
            {
                DataGridViewRow moi = (DataGridViewRow)dataGridViewnhacungcap.Rows[0].Clone();
                moi.Cells[0].Value = item.manhacungcap;
                moi.Cells[1].Value = item.tennhacungcap;
                moi.Cells[2].Value = item.diachi;
                moi.Cells[3].Value = item.sodienthoai;
                moi.Cells[4].Value = item.email;
                moi.Cells[5].Value = "Xóa";
                dataGridViewnhacungcap.Rows.Add(moi);
            }
        }
        //Lấy mã và tên nv
        public nhaCungCap(string ma) : this()
        {
            nhanvien nv = data.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txttennv.Text = nv.tennhanvien;
        }
        private void Btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanhacc.Text.Trim().Equals(""))
                { MessageBox.Show("nhập đầy đủ thông tin"); }
                else
                {
                    nhacungcap ncc = new nhacungcap();

                    ncc.manhacungcap = txtmanhacc.Text;
                    ncc.tennhacungcap = txttenncc.Text;
                    ncc.diachi = txtdiachi.Text;
                    ncc.sodienthoai = txtsdt.Text;
                    ncc.email = txtemail.Text;
                    data.nhacungcaps.InsertOnSubmit(ncc);
                    //Lưu vào csdl
                    data.SubmitChanges();
                    MessageBox.Show("bạn đã thêm thành công");
                    //Hiển thị lại dữ liệu
                    hienthi();
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show("Du lieu khong hop le");
            }
        }

        private void cellcontentclick(object sender, DataGridViewCellEventArgs e)
        {
            string mancc = dataGridViewnhacungcap.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy sản phẩm muốn xóa hoặc sửa
            nhacungcap nccXoa = data.nhacungcaps.SingleOrDefault(ncc => ncc.manhacungcap == mancc);
            if (e.ColumnIndex == 5)//nếu user click Xóa thì xóa sản phẩm được chọn
            {
                data.nhacungcaps.DeleteOnSubmit(nccXoa);
                if (MessageBox.Show("bạn có chắc muốn xóa nhà cung cấp này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data.SubmitChanges();
                    hienthi();
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            nhacungcap nccsua = data.nhacungcaps.SingleOrDefault(ncc => ncc.manhacungcap == txtmanhacc.Text);
            nccsua.manhacungcap = txtmanhacc.Text;
            nccsua.tennhacungcap = txttenncc.Text;
            nccsua.diachi = txtdiachi.Text;
            nccsua.sodienthoai = txtsdt.Text;
            nccsua.email = txtemail.Text;

            //Lưu vào csdl
            data.SubmitChanges();
            MessageBox.Show("bạn đã sửa thành công");
            hienthi();
        }

        private void Btntimkiem_Click(object sender, EventArgs e)
        {
            var timKiemQuery = from ncc in data.nhacungcaps
                               where ncc.tennhacungcap.Contains(txttimkiem.Text)//lấy các sản phẩm tên chứa chuỗi user nhập vào textBoxTim
                               select ncc;


            if (timKiemQuery.Count() == 0)
                MessageBox.Show("Không có sản phẩm nào chứa chuỗi " + txttimkiem.Text);
            else
            {
                dataGridViewnhacungcap.Rows.Clear();
                foreach (var item in timKiemQuery)

                {
                    DataGridViewRow moi = (DataGridViewRow)dataGridViewnhacungcap.Rows[0].Clone();
                    moi.Cells[0].Value = item.manhacungcap;
                    moi.Cells[1].Value = item.tennhacungcap;
                    moi.Cells[2].Value = item.diachi;
                    moi.Cells[3].Value = item.sodienthoai;
                    moi.Cells[4].Value = item.email;
                    moi.Cells[5].Value = "Xóa";
                    //Thêm dòng mới vào DataGridView
                    dataGridViewnhacungcap.Rows.Add(moi);
                }
            }
        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            trangChu tc = new trangChu(manv);
            this.Visible = false;
            tc.ShowDialog();
          
           
          
        }
    }
}
