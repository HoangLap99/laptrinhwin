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
    public partial class Suasanpham : Form
    {
        QLCHDataContext db = new QLCHDataContext();
        public Suasanpham()
        {
            InitializeComponent();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            

            sanpham spsua = db.sanphams.SingleOrDefault(sp => sp.masanpham == txt_masp.Text);

            spsua.tensanpham = txt_tensp.Text;
            spsua.giathanh = int.Parse(txt_giathanh.Text);
            spsua.soluongcon = int.Parse(txt_slc.Text);
            spsua.loaisanpham = cbb_lsp.SelectedValue.ToString();
            db.SubmitChanges();
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suasanpham_Load(object sender, EventArgs e)
        {
            sanpham spChon = (sanpham)this.Tag;
            txt_masp.Text = spChon.masanpham;
            txt_tensp.Text = spChon.tensanpham;
            txt_giathanh.Text = spChon.giathanh.ToString();
            txt_slc.Text = spChon.soluongcon.ToString();
            cbb_lsp.ValueMember = spChon.loaisanpham;
            loadCb();
        }
        public void loadCb()
        {
            var sql = from sp in db.loaisanphams select sp;
            cbb_lsp.DataSource = sql;
            cbb_lsp.DisplayMember = "tenloaisanpham";
            cbb_lsp.ValueMember = "maloaisanpham";
        }
    }
}
