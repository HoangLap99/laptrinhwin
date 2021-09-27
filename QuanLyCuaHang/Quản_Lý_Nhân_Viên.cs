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
    public partial class Quản_Lý_Nhân_Viên : Form
    {
        public Quản_Lý_Nhân_Viên()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();

        private void btnthemnv_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtmanv.Text.Trim().Equals("") && txttennv.Text == "" && txtdiachinv.Text == "" && txtsdtnv.Text == "" && txtgioitinhnv.Text == "")
                {
                    MessageBox.Show("nhập đầy đủ thông tin");
                }
                else
                {
                    //Tạo đối tượng Sản phẩm mới
                    nhanvien nvMoi = new nhanvien();
                    //gán giá trị cho thuộc tính của đối tượng sản phẩm mới là dữ liệu user nhập vào các điều khiển đơn
                    nvMoi.manhanvien = txtmanv.Text;
                    nvMoi.tennhanvien = txttennv.Text;
                    nvMoi.diachi = txtdiachinv.Text;
                    nvMoi.gioitinh = txtgioitinhnv.Text;
                    nvMoi.sodienthoai = txtsdtnv.Text;
                    //Thêm vào tập hợp Sản phẩm
                    db.nhanviens.InsertOnSubmit(nvMoi);
                    //Lưu vào csdl
                    db.SubmitChanges();
                    //Hiển thị lại dữ liệu
                    HienThiDuLieu();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi mã nhân viên");
                this.Close();
              
            }
        }  
        private void HienThiDuLieu()
        {//hiển thị dữ liệu trong DataGrid View
            dgvnhanvien.Rows.Clear();//xóa các dòng trong DataGrid view
            //Lấy dữ liệu trong bảng nhân viên 
            var sanPhamQuery = from nv in db.nhanviens
                               select new
                               {
                                   nv.manhanvien,
                                   nv.tennhanvien,

                                   nv.diachi,
                                   nv.gioitinh,
                                   nv.sodienthoai
                               };
            //Duyệt từng dòng nhân viên lấy được đưa vào Data Gridview
            foreach (var item in sanPhamQuery)
            {
                DataGridViewRow dongMoi = (DataGridViewRow)
                dgvnhanvien.Rows[0].Clone();//tạo bản sao của 1 dòng của DataGridView nhân viên
                //Thêm dữ liệu vào các cột
                dongMoi.Cells[0].Value = item.manhanvien;
                dongMoi.Cells[1].Value = item.tennhanvien;

                dongMoi.Cells[2].Value = item.diachi;
                dongMoi.Cells[3].Value = item.gioitinh;
                dongMoi.Cells[4].Value = item.sodienthoai;
                dongMoi.Cells[5].Value = "Xóa";
                dongMoi.Cells[6].Value = "Sửa";
                //Thêm dòng mới vào DataGridView
                dgvnhanvien.Rows.Add(dongMoi);
            }
        }

        public Quản_Lý_Nhân_Viên(string ma):this()
        {
            nhanvien nv = db.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtma.Text = nv.manhanvien;
            txtten.Text = nv.tennhanvien;
        }
        private void Btnquaylai_Click(object sender, EventArgs e)
        {

            string manv = txtma.Text;
            trangChu hd = new trangChu(manv);
            this.Visible = false;
            hd.ShowDialog();
          
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.Close();
            Quản_Lý_Nhân_Viên frmnvnew3 = new Quản_Lý_Nhân_Viên();
            frmnvnew3.Show();
        }

        private void btntimnv_Click(object sender, EventArgs e)
        {
            if (txttimkiemnv.Text == "")
            {
                MessageBox.Show("Tên nhân viên ko được trống");
            }
            else
            {
                dgvnhanvien.Rows.Clear();
                var timKiemQuery = from nv in db.nhanviens
                                   where nv.tennhanvien.Contains(txttimkiemnv.Text)//lấy tên nhân viên từ textbox tìm kiếm
                                   select new
                                   {
                                       nv.manhanvien,
                                       nv.tennhanvien,

                                       nv.diachi,
                                       nv.gioitinh,
                                       nv.sodienthoai
                                   };

                if (timKiemQuery.Count() == 0)
                    MessageBox.Show("Không có nhân viên tên " + txttimkiemnv.Text);
                else
                    foreach (var item in timKiemQuery)
                    {
                        DataGridViewRow dongMoi = (DataGridViewRow)
                       dgvnhanvien.Rows[0].Clone();
                        dongMoi.Cells[0].Value = item.manhanvien;
                        dongMoi.Cells[1].Value = item.tennhanvien;

                        dongMoi.Cells[2].Value = item.diachi;
                        dongMoi.Cells[3].Value = item.gioitinh;
                        dongMoi.Cells[4].Value = item.sodienthoai;
                        dongMoi.Cells[5].Value = "Xóa";
                        dongMoi.Cells[6].Value = "Sửa";

                        //Thêm dòng mới vào DataGridView
                        dgvnhanvien.Rows.Add(dongMoi);
                    }
            }
            
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Xóa hoặc sửa dữ liệu của 1 dòng
            //lấy mã sản phẩm của dòng được user click
            string maNV = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy nhân viên muốn xóa hoặc sửa
            nhanvien nvsuaxoa = db.nhanviens.SingleOrDefault(nv => nv.manhanvien == maNV);
            if (e.ColumnIndex == 5)//nếu user click Xóa thì xóa nhân viên được chọn
                try
                {

                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dlr == DialogResult.Yes)
                    {
                        db.nhanviens.DeleteOnSubmit(nvsuaxoa);
                        db.SubmitChanges();
                        this.Close();
                        Quản_Lý_Nhân_Viên frmnvnew1 = new Quản_Lý_Nhân_Viên();
                        frmnvnew1.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải xóa mã nhân viên trong tài khoản trước");
                }

            
            else if (e.ColumnIndex == 6)//nếu user click Sửa thì hiển thị form sửa khách hàng
            {
                Sửa_Thông_Tin_Nhân_Viên sua = new Sửa_Thông_Tin_Nhân_Viên();
                sua.Tag = nvsuaxoa;
                sua.ShowDialog();
                this.Close();
                Quản_Lý_Nhân_Viên frmnvnew2 = new Quản_Lý_Nhân_Viên();
                frmnvnew2.Show();
            }
        }

        private void Quản_Lý_Nhân_Viên_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
