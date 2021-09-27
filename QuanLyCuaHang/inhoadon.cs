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
   
    public partial class inhoadon : Form
    {
        QLCHDataContext data = new QLCHDataContext();
        int mahd = 0;
        string tenNv = "";
        string tenKhach = "";
        int tien = 0;
        string tensp = "";
        int soluong = 0;
        int dongia = 0;
        int tongTien = 0;
        public inhoadon()
        {
            InitializeComponent();
        }
        public void hienThi()
        {
            dgHoadon.Rows.Clear();
            var sql = from hd in data.hoadons
                      select new
                      {
                          hd.mahoadon,
                          hd.nhanvien.tennhanvien,
                          hd.ngaylap,
                          hd.khachhang1.tenkhachhang
                          
                      };
            foreach(var item in sql)
            {
                DataGridViewRow d = (DataGridViewRow)dgHoadon.Rows[0].Clone();
                d.Cells[0].Value = item.mahoadon;
                d.Cells[1].Value = item.tennhanvien;
                d.Cells[2].Value = item.ngaylap;
                d.Cells[3].Value = item.tenkhachhang;
                d.Cells[4].Value = "In hoa don";
                dgHoadon.Rows.Add(d);
            }

        }

        private void inhoadon_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void dgHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma=int.Parse(dgHoadon.Rows[e.RowIndex].Cells[0].Value.ToString());
            hoadon hd = data.hoadons.SingleOrDefault(h => h.mahoadon == ma);
            if(e.ColumnIndex==4)
            {
                mahd = hd.mahoadon;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        public inhoadon(string ma):this()
        {
            nhanvien nv = data.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            hoaDon tc = new hoaDon(manv);
            this.Visible = false;
            tc.ShowDialog();
            //hoaDon hd = new hoaDon();
            //    hd.Show();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hd = data.hoadons.SingleOrDefault(h => h.mahoadon == mahd);
            var width = printDocument1.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawString("Cơ sở hoa-cây cảnh", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
                Brushes.Black, new Point(50, 10));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
                Brushes.Black, new Point(450, 10));
            e.Graphics.DrawString(string.Format("Hoa cây cảnh"), new System.Drawing.Font("Couriar New", 20, FontStyle.Bold),
               Brushes.Black, new Point(550, 50));
            e.Graphics.DrawString(string.Format("Đảm bảo chất lượng"), new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(500, 80));
            e.Graphics.DrawString("Anh Phúc", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
                Brushes.Black,new Point(130,50));
            e.Graphics.DrawString("Đc: Học viện nông nghiệp", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
                Brushes.Black, new Point(0, 90));
            e.Graphics.DrawString(string.Format("Ma hd:{0}",hd.mahoadon), new System.Drawing.Font("Couriar New", 20, FontStyle.Bold),
               Brushes.Black, new Point(100, 180));
            e.Graphics.DrawString(string.Format("Ngay lap hd:{0}", hd.ngaylap), new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(100, 220));

            e.Graphics.DrawString("Ten sp", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString("So luong", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(250, 300));
            e.Graphics.DrawString("Don gia", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(430, 300));
            e.Graphics.DrawString("Thanh tien", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(570, 300));

            var sql = from ct in data.chitiethoadons
                      where ct.hoadon == mahd
                      select new
                      {
                          tensp = ct.sanpham1.tensanpham,
                          soluong = ct.soluong,
                          dongia = ct.giaban,
                          tien = ct.soluong * ct.giaban
                          
                      };
            int y = 400;
            int tong = 0;
            foreach(var item in sql)
            {
                e.Graphics.DrawString(item.tensp, new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(item.soluong.ToString(), new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(300, y));
                e.Graphics.DrawString(item.dongia.ToString(), new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(430, y));
                e.Graphics.DrawString(item.tien.ToString(), new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(570, y));
                y += 50;
                tong += int.Parse(item.tien.ToString());
            }
            e.Graphics.DrawString("Tong tien:"+tong, new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(100, y+50));
            e.Graphics.DrawString("Người nhận hàng", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(50, 800));
            e.Graphics.DrawString("Ngày...Tháng...Năm...", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
               Brushes.Black, new Point(450, 750));
            e.Graphics.DrawString("Người viết hóa đơn", new System.Drawing.Font("Couriar New", 25, FontStyle.Bold),
                Brushes.Black, new Point(480, 800));


        }
    }
}
