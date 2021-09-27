using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Object
{
    class taiKhoan
    {
        private string mataikhoan;

        public string _mataikhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
        private string manhanvien;

        public string _manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }

        }
        private string matkhau;

        public string _matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public taiKhoan()
        {

        }
        public taiKhoan(string matk, string mnv, string mk)
        {
            this.mataikhoan = matk;
            this.manhanvien = mnv;
            this.matkhau = mk;
        }


    }
}
