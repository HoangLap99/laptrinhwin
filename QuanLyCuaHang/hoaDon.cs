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
    public partial class hoaDon : Form
    {
        public hoaDon()
        {
            InitializeComponent();
        }
        QLCHDataContext data = new QLCHDataContext();
        string maKH;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dongia.Text == "" || txt_sl.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                }
                else if (int.Parse(txt_sl.Text) < 0 )
                {
                    MessageBox.Show("Số lượng không được âm");
                }
                else
                {


                    DataGridViewRow dongMoi = (DataGridViewRow)dataGridViewhoadon.Rows[0].Clone();
                    dongMoi.Cells[0].Value = comboBoxSp.SelectedValue.ToString();
                    dongMoi.Cells[1].Value = comboBoxSp.Text;
                    dongMoi.Cells[2].Value = txt_sl.Text;
                    dongMoi.Cells[3].Value = txt_dongia.Text;
                    dongMoi.Cells[4].Value = (int.Parse(txt_dongia.Text) * int.Parse(txt_sl.Text)).ToString();
                    dongMoi.Cells[5].Value = "xoa";
                    dataGridViewhoadon.Rows.Add(dongMoi);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    var khachHangQuery = from kh in data.khachhangs
            //                         where kh.sodienthoai == txt_sdt.Text
            //                         select kh;
            //    khachhang khHienTai = khachHangQuery.SingleOrDefault();
            //    if (khHienTai != null)
            //    {
            //        txt_hoten.Text = khHienTai.tenkhachhang;
            //        maKH = khHienTai.makhachhang;
            //    }
            //    else
            //    {
            //        txt_hoten.Text = "khach vang lai";
            //        maKH = "KH00";
            //    }
            //}
        }

        private void txt_masp_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    sanpham hangMua = (from sp in data.sanphams
            //                       where sp.masanpham == txt_masp.Text
            //                       select sp).SingleOrDefault();
            //    if (hangMua != null)
            //    {
            //        txt_SP.Text = hangMua.tensanpham;
            //        txt_dongia.Text = hangMua.giathanh.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("ma hang sai");
            //    }
            //}
        }
        private void hienthi()
        {
            dataGridViewhoadon.Rows.Clear();
            var hoaDon = from hd in data.hoadons
                         join cthd in data.chitiethoadons on hd.mahoadon equals cthd.hoadon
                         join sp in data.sanphams on cthd.sanpham equals sp.masanpham
                         select new
                         {
                             sp.masanpham,
                             sp.tensanpham,
                             cthd.soluong,
                             cthd.giaban,
                             tien = cthd.soluong * cthd.giaban,
                         };
            foreach (var item in hoaDon)
            {

                DataGridViewRow hdMoi = (DataGridViewRow)
                dataGridViewhoadon.Rows[0].Clone();
                hdMoi.Cells[0].Value = item.masanpham;
                hdMoi.Cells[1].Value = item.tensanpham;
                hdMoi.Cells[2].Value = item.soluong;
                hdMoi.Cells[3].Value = item.giaban;
                hdMoi.Cells[4].Value = item.tien;
                hdMoi.Cells[5].Value = "Xoa";
                dataGridViewhoadon.Rows.Add(hdMoi);
            }
        }
        private void hoaDon_Load(object sender, EventArgs e)
        {
            tenKh();
            loadTensp();
            //taikhoan ndHienTai = (taikhoan)this.Tag;
            ////var nv = from nvdn in data.nhanviens where nvdn.manhanvien==ndHienTai.manhanvien
            ////         select
            //txtnguoidung.Text = ndHienTai.manhanvien;
        }
        private void tenKh()
        {
            var kh = from k in data.khachhangs
                     select k;
            comboBoxTen.DataSource = kh;
            comboBoxTen.DisplayMember = "tenkhachhang";
            comboBoxTen.ValueMember = "makhachhang";
        }

        private void dataGridViewhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string masph = dataGridViewhoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
            sanpham spXoa = data.sanphams.SingleOrDefault(sp => sp.masanpham == masph);

            if (e.ColumnIndex == 5)// xóa
            {
                data.sanphams.DeleteOnSubmit(spXoa);
                if (MessageBox.Show("bạn co chắc muốn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data.SubmitChanges();
                    hienthi();
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            hoadon hoaDonMoi = new hoadon();
            //hoaDonMoi.mahoadon = txt_maHD.Text;
            hoaDonMoi.khachhang = maKH;
            hoaDonMoi.ngaylap = DateTime.Now;
            hoaDonMoi.nhanvienban = txtmanv.Text;
            hoaDonMoi.khachhang = comboBoxTen.SelectedValue.ToString();
            data.hoadons.InsertOnSubmit(hoaDonMoi);
            for (int i = 0; i < dataGridViewhoadon.RowCount - 1; i++)
            {
                chitiethoadon hdct = new chitiethoadon();
                hdct.hoadon = hoaDonMoi.mahoadon;
                hdct.sanpham = dataGridViewhoadon.Rows[i].Cells[0].Value.ToString();
                hdct.soluong = Convert.ToInt32(dataGridViewhoadon.Rows[i].Cells[2].Value);
                hdct.giaban = Convert.ToInt32(dataGridViewhoadon.Rows[i].Cells[3].Value);
                hoaDonMoi.chitiethoadons.Add(hdct);
            }
            data.SubmitChanges();
            MessageBox.Show("Tao hoa don thanh cong");


        }
        //Lay ten cua san pham
        public void loadTensp()
        {
            var sql = from sp in data.sanphams select sp;
            comboBoxSp.DataSource = sql;
            comboBoxSp.DisplayMember = "tensanpham";
            comboBoxSp.ValueMember = "masanpham";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            trangChu tc = new trangChu(manv);
            this.Visible = false;
            tc.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
           
            //trangChu tc = new trangChu();
            //tc.Show();
        }
        //lay ma va ten cua nhan vien
        public hoaDon(string ma) : this()
        {
            nhanvien nv = data.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txttennv.Text = nv.tennhanvien;
        }

        private void comboBoxSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sanpham sp = data.sanphams.Single(s => s.masanpham == comboBoxSp.SelectedValue.ToString());
                txt_dongia.Text = sp.giathanh.ToString();

            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            inhoadon tc = new inhoadon(manv);
            tc.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
            this.Hide();
        }
    }
}
