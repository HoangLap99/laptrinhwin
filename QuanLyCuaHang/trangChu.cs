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
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();

        }
        //Lay ma cua nhan vien
        public trangChu(string ma):this()
        {
            nhanvien nv = data.nhanviens.SingleOrDefault(n=> n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txtTennv.Text = nv.tennhanvien;
        }
        QLCHDataContext data = new QLCHDataContext();
        private void trangchuload(object sender, EventArgs e)
        {
            //taikhoan ndHienTai = (taikhoan)this.Tag;
            ////var nv = from nvdn in data.nhanviens where nvdn.manhanvien==ndHienTai.manhanvien
            ////         select
            //txtnhanvien.Text = ndHienTai.manhanvien;
            

        }

        private void trangchu_activated(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            quanLyTaiKhoan tc = new quanLyTaiKhoan(manv);
            tc.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
            this.Hide();
            //trangChu tc = new trangChu();
            //tc.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            nhaCungCap tc = new nhaCungCap(manv);
            tc.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
            this.Hide();
            //trangChu tc = new trangChu();
            //tc.Show();
        }

        private void Btnthongke_Click(object sender, EventArgs e)
        {
            if (cbthongke.Text == null)
            {
                MessageBox.Show("bạn chưa chon cách thống kê !");
            }
            else if (cbthongke.Text == "cây đã bán")
            {

                var sanphamquery = from sp in data.sanphams
                                   join cthd in data.chitiethoadons on sp.masanpham equals cthd.sanpham
                                   join hd in data.hoadons on cthd.hoadon equals hd.mahoadon
                                   where hd.ngaylap >= dateTimePicker1.Value && hd.ngaylap <= dateTimePicker2.Value
                                   select new
                                   {
                                       sp.masanpham,
                                       sp.tensanpham,
                                       cthd.soluong,
                                       sp.giathanh,
                                       sp.loaisanpham,
                                       tongtienmua=sp.giathanh*cthd.soluong,
                                       tongtienban=cthd.giaban * cthd.soluong,
                                       hd.ngaylap
                                   };
                dataGridViewtrangchu.Rows.Clear();
                foreach (var item in sanphamquery)
                {
                    DataGridViewRow moi = (DataGridViewRow)dataGridViewtrangchu.Rows[0].Clone();
                    moi.Cells[0].Value = item.masanpham;
                    moi.Cells[1].Value = item.tensanpham;
                    moi.Cells[2].Value = item.soluong;
                    moi.Cells[3].Value = item.giathanh;
                    moi.Cells[4].Value = item.loaisanpham;
                    moi.Cells[5].Value = item.tongtienmua;
                    moi.Cells[6].Value = item.tongtienban;
                    moi.Cells[7].Value = item.ngaylap;
                    dataGridViewtrangchu.Rows.Add(moi);
                }
               
            }
            else if(cbthongke.Text== "cây còn lại")
            {
                var sanphamquery = from sp in data.sanphams
                                   join cthd in data.chitiethoadons on sp.masanpham equals cthd.sanpham
                                   where sp.soluongcon > cthd.soluong
                                   select new
                                   {
                                       sp.masanpham,
                                       sp.tensanpham,
                                       soluongcon1= sp.soluongcon-cthd.soluong,
                                       sp.giathanh,
                                       sp.loaisanpham,
                                   };
                dataGridViewtrangchu.Rows.Clear();
                foreach (var item in sanphamquery)
                {
                    DataGridViewRow moi = (DataGridViewRow)dataGridViewtrangchu.Rows[0].Clone();
                    moi.Cells[0].Value = item.masanpham;
                    moi.Cells[1].Value = item.tensanpham;
                    moi.Cells[2].Value = item.soluongcon1;
                    moi.Cells[3].Value = item.giathanh;
                    moi.Cells[4].Value = item.loaisanpham;
                 
                    dataGridViewtrangchu.Rows.Add(moi);
                }
            }
            else if (cbthongke.Text == "cây đã hết hàng")
            {
                var sanphamquery = from sp in data.sanphams
                                   join cthd in data.chitiethoadons on sp.masanpham equals cthd.sanpham
                                   where sp.soluongcon == cthd.soluong
                                   select new
                                   {
                                       sp.masanpham,
                                       sp.tensanpham,
                                       soluongcon1 = sp.soluongcon - cthd.soluong,
                                       sp.giathanh,
                                       sp.loaisanpham,
                                   };
                dataGridViewtrangchu.Rows.Clear();
                foreach (var item in sanphamquery)
                {
                    DataGridViewRow moi = (DataGridViewRow)dataGridViewtrangchu.Rows[0].Clone();
                    moi.Cells[0].Value = item.masanpham;
                    moi.Cells[1].Value = item.tensanpham;
                    moi.Cells[2].Value = item.soluongcon1;
                    moi.Cells[3].Value = item.giathanh;
                    moi.Cells[4].Value = item.loaisanpham;

                    dataGridViewtrangchu.Rows.Add(moi);
                }
            }
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            hoaDon hd = new hoaDon(manv);
            this.Visible = false;
            hd.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
           
        }

        private void BtnQLKhachhang_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            Quản_Lý_Khách_Hàng hd = new Quản_Lý_Khách_Hàng(manv);
            this.Visible = false;
            hd.ShowDialog();
            
        }

        private void BtnQLNhanVien_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            Quản_Lý_Nhân_Viên hd = new Quản_Lý_Nhân_Viên(manv);
            this.Visible = false;
            hd.ShowDialog();
            
        }

        private void BtnDMSanPham_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            Danh_Mục_Sản_Phẩm dmsp = new Danh_Mục_Sản_Phẩm(manv);
            this.Visible = false;
            dmsp.ShowDialog();
           
        }

        private void btnxemsanpham_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            Xem_sản_phẩm dmsp = new Xem_sản_phẩm(manv);
            this.Visible = false;
            dmsp.ShowDialog();
            
        }
    }
}
