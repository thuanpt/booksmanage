using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class SachBUS
    {
       QLNhaSachDataContext DB = new QLNhaSachDataContext();
       public IQueryable viewsach()
       {
           var sach = from s in DB.Saches
                      join ncc in DB.NhaCungCaps on s.MaNhaCungCap equals ncc.MaNhaCungCap
                      join nxb in DB.NhaXuatBans on s.MaNXB equals nxb.MaNXB
                      join tl in DB.TheLoais on s.MaTheLoai equals tl.MaTheLoai
                      join tg in DB.TacGias on s.MaTacGia equals tg.MaTacGia
                      select new
                      {
                          MaSach = s.MaSach,
                          TenSach = s.TenSach,
                          GiaMua = s.GiaMua,
                          GiaBan = s.GiaBan,
                          MaTacGia = s.MaTacGia,
                          MaNXB = s.MaNXB,
                          MaNhaCungCap = s.MaNhaCungCap,
                          MaTheLoai = s.MaTheLoai,
                          SoLuong = s.SoLuong,
                          AnhBia = s.AnhBia,
                          NhaXuatBan = nxb.TenNXB,
                          NhaCungCap = ncc.TenNhaCungCap,
                          TheLoai = tl.TenTheLoai,
                          TacGia = tg.TenTacGia
                      };

           return sach;
       }
       public bool KTTonTai(string masach)
       {
           int kt = (from tk in DB.Saches
                     where tk.MaSach == masach
                     select tk).Count();
           if (kt == 1)
               return true;
           else
               return false;


       }
       public void ThemSach(string masach, string tensach, int giamua, int giaban, string tacgia, string nxb, string ncp, string theloai, int soluong)
       {
           Sach themsach = new Sach();
           themsach.MaSach = masach;
           themsach.TenSach = tensach;
           themsach.GiaMua = giamua;
           themsach.GiaBan = giaban;
           themsach.MaTacGia = tacgia;
           themsach.MaNXB = nxb;
           themsach.MaNhaCungCap = ncp;
           themsach.MaTheLoai = theloai;
           themsach.SoLuong = soluong;
           DB.Saches.InsertOnSubmit(themsach);
           DB.SubmitChanges();

       }
       public void SuaSach(string masach, string tensach, int giamua, int giaban, string tacgia, string nxb, string ncp, string theloai, int soluong)
       {
           Sach suasach = (from s in DB.Saches
                           select s).Single(t => t.MaSach == masach);
           suasach.TenSach = tensach;
           suasach.GiaMua = giamua;
           suasach.GiaBan = giaban;
           suasach.MaTacGia = tacgia;
           suasach.MaNXB = nxb;
           suasach.MaNhaCungCap = ncp;
           suasach.MaTheLoai = theloai;
           suasach.SoLuong = soluong;
           DB.SubmitChanges();

       }
       public void XoaSach(string masach)
       {
           Sach xoasach = (from s in DB.Saches
                           select s).Single(t => t.MaSach == masach);
           DB.Saches.DeleteOnSubmit(xoasach);
           DB.SubmitChanges();
       }
      
       
    }

}
