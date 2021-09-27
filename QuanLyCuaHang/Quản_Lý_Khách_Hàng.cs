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
    public partial class Quản_Lý_Khách_Hàng : Form
    {
        public Quản_Lý_Khách_Hàng()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        private void HienThiDuLieu()
        {//hiển thị dữ liệu trong DataGrid View
            dgv.Rows.Clear();//xóa các dòng trong DataGrid view
            //Lấy dữ liệu trong bảng Khách hàng 
            var sanPhamQuery = from kh in db.khachhangs
                               select new
                               {
                                   kh.makhachhang,
                                   kh.tenkhachhang,

                                   kh.diachi,
                                   kh.gioitinh,
                                   kh.sodienthoai
                               };
            //Duyệt từng dòng khách hàng lấy được đưa vào Data Gridview
            foreach (var item in sanPhamQuery)
            {
                DataGridViewRow dongMoi = (DataGridViewRow)
                dgv.Rows[0].Clone();//tạo bản sao của 1 dòng của DataGridView Khách hàng
                //Thêm dữ liệu vào các cột
                dongMoi.Cells[0].Value = item.makhachhang;
                dongMoi.Cells[1].Value = item.tenkhachhang;

                dongMoi.Cells[2].Value = item.diachi;
                dongMoi.Cells[3].Value = item.gioitinh;
                dongMoi.Cells[4].Value = item.sodienthoai;
                dongMoi.Cells[5].Value = "Xóa";
                dongMoi.Cells[6].Value = "Sửa";
                //Thêm dòng mới vào DataGridView
                dgv.Rows.Add(dongMoi);
            }
        }

        private void Quản_Lý_Khách_Hàng_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakh.Text.Trim().Equals(""))
                { MessageBox.Show("nhập đầy đủ thông tin"); }
                else
                {

                    //Tạo đối tượng Khách hàng mới
                    khachhang kh = new khachhang();
                    //gán giá trị cho thuộc tính của đối tượng Khách hàng mới là dữ liệu user nhập vào các điều khiển đơn
                    kh.makhachhang = txtmakh.Text;
                    kh.tenkhachhang = txttenkh.Text;

                    kh.diachi = txtdiachi.Text;
                    kh.gioitinh = txtgioitinh.Text;
                    kh.sodienthoai = txtsdt.Text;

                    //Thêm vào tập hợp Khách hàng
                    db.khachhangs.InsertOnSubmit(kh);
                    //Lưu vào csdl
                    db.SubmitChanges();
                    //Hiển thị lại dữ liệu
                    HienThiDuLieu();
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show("Lỗi mã khách hàng");
                this.Close();
             

            }
        }
        public Quản_Lý_Khách_Hàng(string ma):this()
        {
            nhanvien nv = db.nhanviens.SingleOrDefault(n => n.manhanvien == ma);
            txtmanv.Text = nv.manhanvien;
            txttennv.Text = nv.tennhanvien;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            trangChu hd = new trangChu(manv);
            this.Visible = false;
            hd.ShowDialog();
            
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.Close();
            Quản_Lý_Khách_Hàng frmkhnew3 = new Quản_Lý_Khách_Hàng();
            frmkhnew3.Show();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Tên khách hàng ko được trống");
            }
            else
            {
                dgv.Rows.Clear();
                var timKiemQuery = from kh in db.khachhangs
                                   where kh.tenkhachhang.Contains(txttimkiem.Text)//lấy tên khách hàng từ textbox tìm kiếm
                                   select new
                                   {
                                       kh.makhachhang,
                                       kh.tenkhachhang,

                                       kh.diachi,
                                       kh.gioitinh,
                                       kh.sodienthoai
                                   };

                if (timKiemQuery.Count() == 0)
                    MessageBox.Show("Không có khách hàng tên " + txttimkiem.Text);
                else
                    foreach (var item in timKiemQuery)
                    {
                        DataGridViewRow dongMoi = (DataGridViewRow)
                       dgv.Rows[0].Clone();
                        dongMoi.Cells[0].Value = item.makhachhang;
                        dongMoi.Cells[1].Value = item.tenkhachhang;

                        dongMoi.Cells[2].Value = item.diachi;
                        dongMoi.Cells[3].Value = item.gioitinh;
                        dongMoi.Cells[4].Value = item.sodienthoai;
                        dongMoi.Cells[5].Value = "Xóa";
                        dongMoi.Cells[6].Value = "Sửa";

                        //Thêm dòng mới vào DataGridView
                        dgv.Rows.Add(dongMoi);
                    }
            }
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKH = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Lấy khách hàng muốn xóa hoặc sửa
            khachhang khsuaxoa = db.khachhangs.SingleOrDefault(kh => kh.makhachhang == maKH);
            if (e.ColumnIndex == 5)//nếu user click Xóa thì xóa khách hàng được chọn

                try
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dlr == DialogResult.Yes)
                    {
                        db.khachhangs.DeleteOnSubmit(khsuaxoa);
                        db.SubmitChanges();
                        this.Close();
                        Quản_Lý_Khách_Hàng frmkhnew1 = new Quản_Lý_Khách_Hàng();
                        frmkhnew1.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải xóa khách hàng trong hóa đơn trước");
                }

            
            else if (e.ColumnIndex == 6)//nếu user click Sửa thì hiển thị form sửa khách hàng
            {
                Sửa_Thông_Tin_Khách_Hàng sua = new Sửa_Thông_Tin_Khách_Hàng();
                sua.Tag = khsuaxoa;
                sua.ShowDialog();
                this.Close();
                Quản_Lý_Khách_Hàng frmkhnew2 = new Quản_Lý_Khách_Hàng();
                frmkhnew2.Show();
            }
        }
    }
}
