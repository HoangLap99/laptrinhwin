using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHang.;

namespace QuanLyCuaHang.controller
{
    class taikhoancontroller
    {
        
        public static List<taikhoan> getTaiKhoan()
        {
            QLCHDataContext data = new QLCHDataContext();
            List<taikhoan> lst = null;
            lst = (from user in data.taikhoans
                   select new taikhoan
                   {
                       mataikhoan = user.mataikhoan,
                       manhanvien = user.manhanvien,
                       matkhau = user.matkhau,
                      
                   }).ToList();
            return lst;
        }

        public static List<taikhoan> getUsers(string userName, string userPass)
        { 
            QLCHDataContext data = new QLCHDataContext();
            List<taikhoan> lst = null;
            lst = (from user in data.taikhoans
                   where user.manhanvien == userName && user.matkhau == userPass
                   select new taikhoan
                   {
                       mataikhoan = user.mataikhoan,
                       manhanvien = user.manhanvien,
                       matkhau = user.matkhau,
                   }).ToList();
            return lst;
        }

        public static bool taotaikhoan(taikhoan tk)
        {
            QLCHDataContext data = new QLCHDataContext();
            try
            {
                taikhoan user = new taikhoan();
                user.mataikhoan = tk.mataikhoan;
                user.manhanvien = tk.manhanvien;
                user.matkhau = tk.matkhau;
                
                data.taikhoans.InsertOnSubmit(user);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

      

        public static bool Xoataikhoan(taikhoan tk)
        {
            QLCHDataContext data = new QLCHDataContext();
            try
            {
                var delete = from user in data.taikhoans
                             where user.mataikhoan == tk.mataikhoan
                             select user;
                foreach (var i in delete)
                {
                    data.taikhoans.DeleteOnSubmit(i);
                    data.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<taikhoan> timtaikhoan(String conds)
        {
            try
            {
                QLCHDataContext data = new QLCHDataContext();
                List<taikhoan> lst = null;
                lst = (from user in data.taikhoans
                       where user.mataikhoan == conds 
                       select new taikhoan
                       {
                           mataikhoan = user.mataikhoan,
                           manhanvien = user.manhanvien,
                           matkhau = user.matkhau,
                       }).ToList();
                return lst;
            }
            catch
            {
                return null;
            }
        }
    }
}
