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
    public partial class Danh_Mục_Sản_Phẩm : Form
    {
        public Danh_Mục_Sản_Phẩm()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();

        private void HienThiDuLieu()
        {//hiển thị dữ liệu trong DataGrid View
            dgvdanhmuc.Rows.Clear();//xóa các dòng trong DataGrid view
            //Lấy dữ liệu trong bảng loại sản phẩm
            var sanPhamQuery = from sp in db.loaisanphams
                               select new
                               {
                                   sp.maloaisanpham,
                                   sp.tenloaisanpham

                               };
            //Duyệt từng dòng loại sản phẩm lấy được đưa vào Data Gridview
            foreach (var item in sanPhamQuery)
            {
                DataGridViewRow dongMoi = (DataGridViewRow)
                dgvdanhmuc.Rows[0].Clone();//tạo bản sao của 1 dòng của DataGridView loại sản phẩm
                //Thêm dữ liệu vào các cột
                dongMoi.Cells[0].Value = item.maloaisanpham;
                dongMoi.Cells[1].Value = item.tenloaisanpham;
                dongMoi.Cells[2].Value = "Xóa";
                dongMoi.Cells[3].Value = "Sửa";



                //Thêm dòng mới vào DataGridView
                dgvdanhmuc.Rows.Add(dongMoi);
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmaloai.Text.Trim().Equals(""))
                { MessageBox.Show("nhập đầy đủ thông tin"); }
                else
                {

                    //Tạo đối tượng loại sản phẩm mới
                    loaisanpham sp = new loaisanpham();
                    //gán giá trị cho thuộc tính của đối tượng loại sản phẩm mới là dữ liệu user nhập vào các điều khiển đơn
                    sp.maloaisanpham = txtmaloai.Text;
                    sp.tenloaisanpham = txttenloai.Text;

                    //Thêm vào tập hợp loại sản phẩm
                    db.loaisanphams.InsertOnSubmit(sp);
                    //Lưu vào csdl
                    db.SubmitChanges();
                    //Hiển thị lại dữ liệu
                    HienThiDuLieu();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi mã sản phẩm");
                this.Close();
                Danh_Mục_Sản_Phẩm frm5 = new Danh_Mục_Sản_Phẩm();
                frm5.Show();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            trangChu hd = new trangChu(manv);
            this.Visible = false;
            hd.ShowDialog();

           
            
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.Close();
            Danh_Mục_Sản_Phẩm frmdmnew3 = new Danh_Mục_Sản_Phẩm();
            frmdmnew3.Show();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttimtenloai.Text == "")
            {
                MessageBox.Show("Tên loại sản phẩm ko được trống");
            }
            else
            {
                dgvdanhmuc.Rows.Clear();
                var timKiemQuery = from sp in db.loaisanphams
                                   where sp.tenloaisanpham.Contains(txttimtenloai.Text)//lấy tên loại sản phẩm từ textbox tìm kiếm
                                   select new
                                   {
                                       sp.maloaisanpham,
                                       sp.tenloaisanpham
                                   };

                if (timKiemQuery.Count() == 0)
                    MessageBox.Show("Không có loại sản phẩm tên " + txttimtenloai.Text);
                else
                    foreach (var item in timKiemQuery)
                    {
                        DataGridViewRow dongMoi = (DataGridViewRow)
                       dgvdanhmuc.Rows[0].Clone();
                        dongMoi.Cells[0].Value = item.maloaisanpham;
                        dongMoi.Cells[1].Value = item.tenloaisanpham;

                        dongMoi.Cells[2].Value = "Xóa";
                        dongMoi.Cells[3].Value = "Sửa";

                        //Thêm dòng mới vào DataGridView
                        dgvdanhmuc.Rows.Add(dongMoi);
                    }
            }
        }

        private void Danh_Mục_Sản_Phẩm_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void dgvdanhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maL = dgvdanhmuc.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy khách hàng muốn xóa hoặc sửa
            loaisanpham spsuaxoa = db.loaisanphams.SingleOrDefault(sp => sp.maloaisanpham == maL);
            if (e.ColumnIndex == 2)
                try
            {
                //nếu user click Xóa thì xóa khách hàng được chọn
                
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dlr == DialogResult.Yes)
                    {
                        db.loaisanphams.DeleteOnSubmit(spsuaxoa);
                        db.SubmitChanges();
                        this.Close();
                        Danh_Mục_Sản_Phẩm frmdmnew1 = new Danh_Mục_Sản_Phẩm();
                        frmdmnew1.Show();
                    }

                
                
            }
            catch
            {
                MessageBox.Show("Bạn phải xóa sản phẩm thuộc loại sản phẩm trước");
            }
            else if (e.ColumnIndex == 3)//nếu user click Sửa thì hiển thị form sửa khách hàng
            {
                Sửa_Danh_Mục sua = new Sửa_Danh_Mục();
                sua.Tag = spsuaxoa;
                sua.ShowDialog();
                this.Close();
                Danh_Mục_Sản_Phẩm frmdmnew2 = new Danh_Mục_Sản_Phẩm();
                frmdmnew2.Show();
            }

        }
        public Danh_Mục_Sản_Phẩm(string ma):this()
        {
            nhanvien nv = db.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txtTennv.Text = nv.tennhanvien;
        }
    }
}
