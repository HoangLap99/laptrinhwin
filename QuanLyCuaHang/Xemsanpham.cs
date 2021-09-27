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
    public partial class Xem_sản_phẩm : Form
    {
        QLCHDataContext db = new QLCHDataContext();
        public Xem_sản_phẩm()
        {
            InitializeComponent();
        }
        private void Cbb()
        {
            var loaiSanPham = from lsp in db.loaisanphams
                              select lsp;
            cbb_lsp.DataSource = loaiSanPham;
            cbb_lsp.DisplayMember = "tenloaisanpham";
            cbb_lsp.ValueMember = "maloaisanpham";
        }
        private void HienThiDuLieu()
        {//hiển thị dữ liệu trong DataGrid View
            dataGridView1.Rows.Clear();//xóa các dòng trong DataGrid view
            //Lấy dữ liệu trong bảng Khách hàng 
            var sanPhamQuery = from sp in db.sanphams
                               select new
                               {
                                   sp.masanpham,
                                   sp.tensanpham,
                                   sp.giathanh,                                
                                   sp.soluongcon,
                                   sp.loaisanpham,
                               };
            //Duyệt từng dòng khách hàng lấy được đưa vào Data Gridview
            foreach (var item in sanPhamQuery)
            {
                DataGridViewRow dongMoi = (DataGridViewRow)
                dataGridView1.Rows[0].Clone();//tạo bản sao của 1 dòng của DataGridView Khách hàng
                //Thêm dữ liệu vào các cột
                dongMoi.Cells[0].Value = item.masanpham;
                dongMoi.Cells[1].Value = item.tensanpham;
                dongMoi.Cells[2].Value = item.giathanh;
                dongMoi.Cells[3].Value = item.soluongcon;
                dongMoi.Cells[4].Value = item.loaisanpham; 
                dongMoi.Cells[5].Value = "Xóa";
                dongMoi.Cells[6].Value = "Sửa";
                //Thêm dòng mới vào DataGridView
                dataGridView1.Rows.Add(dongMoi);
            }
        }

        private void Xem_sản_phẩm_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            Cbb();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_masp.Text.Trim().Equals("") && txt_tensp.Text == "" && txt_slc.Text == "" && txt_giathanh.Text == "")
                { MessageBox.Show("nhập đầy đủ thông tin"); }
                else
                {
                    //Tạo đối tượng Khách hàng mới
                    sanpham sp = new sanpham();
                    //gán giá trị cho thuộc tính của đối tượng Khách hàng mới là dữ liệu user nhập vào các điều khiển đơn
                    sp.masanpham = txt_masp.Text;
                    sp.tensanpham = txt_tensp.Text;
                    sp.giathanh = int.Parse(txt_giathanh.Text);
                    sp.soluongcon = int.Parse(txt_slc.Text);
                    sp.loaisanpham = cbb_lsp.SelectedValue.ToString();
                    //Thêm vào tập hợp Khách hàng
                    db.sanphams.InsertOnSubmit(sp);
                    //Lưu vào csdl
                    db.SubmitChanges();
                    //Hiển thị lại dữ liệu
                    HienThiDuLieu();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Du lieu khong hop le");
            }
                
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSP = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy khách hàng muốn xóa hoặc sửa
            sanpham spsuaxoa = db.sanphams.SingleOrDefault(sp => sp.masanpham == maSP);
            if (e.ColumnIndex == 5)//nếu user click Xóa thì xóa khách hàng được chọn
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dlr == DialogResult.Yes)
                {
                    db.sanphams.DeleteOnSubmit(spsuaxoa);
                    db.SubmitChanges();
                    HienThiDuLieu();
                }

            }
            else if (e.ColumnIndex == 6)//nếu user click Sửa thì hiển thị form sửa khách hàng
            {
                Suasanpham sua = new Suasanpham();
                sua.Tag = spsuaxoa;
                sua.ShowDialog();
                this.Close();
                Xem_sản_phẩm xsp = new Xem_sản_phẩm();
                xsp.Show();
            }
        }
        public Xem_sản_phẩm(string ma):this()
        {
            nhanvien nv = db.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txtTennv.Text = nv.tennhanvien;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var timKiemQuery = from sp in db.sanphams
                               where sp.tensanpham.Contains(txttimkiem.Text)//lấy tên khách hàng từ textbox tìm kiếm
                               select new
                               {
                                   sp.masanpham,
                                   sp.tensanpham,
                                   sp.giathanh,
                                   sp.soluongcon,
                                   sp.loaisanpham,
                                   
                               };

            if (timKiemQuery.Count() == 0)
                MessageBox.Show("Không có ten san pham " + txttimkiem.Text);
            else
                foreach (var item in timKiemQuery)
                {
                    DataGridViewRow dongMoi = (DataGridViewRow)
                   dataGridView1.Rows[0].Clone();
                    dongMoi.Cells[0].Value = item.masanpham;
                    dongMoi.Cells[1].Value = item.tensanpham;
                    dongMoi.Cells[2].Value = item.giathanh;
                    dongMoi.Cells[3].Value = item.soluongcon;
                    dongMoi.Cells[4].Value = item.loaisanpham;
                   
                    dongMoi.Cells[5].Value = "Xóa";
                    dongMoi.Cells[6].Value = "Sửa";

                    //Thêm dòng mới vào DataGridView
                    dataGridView1.Rows.Add(dongMoi);
                }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            trangChu hd = new trangChu(manv);
            this.Visible = false;
            hd.ShowDialog();
         
        }

        private void Xem_sản_phẩm_Activated(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
