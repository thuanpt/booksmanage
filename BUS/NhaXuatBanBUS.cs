using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class NhaXuatBanBUS
    {
        QLNhaSachDataContext DB = new QLNhaSachDataContext();
        public IEnumerable<NhaXuatBan> viewnhaxuatban()
        {
            IEnumerable<NhaXuatBan> nhaxuatban = from nxb in DB.NhaXuatBans
                                                 select nxb;
            return nhaxuatban;
        }
        public bool KTTonTai(string mannxb)
        {
            int kt = (from tk in DB.NhaXuatBans
                      where tk.MaNXB == mannxb
                      select tk).Count();
            if (kt == 1)
                return true;
            else
                return false;


        }
        public void ThemNhaXuatBan(string manxb, string tennxb, string diachi, string dienthoai, string email, string ghichu)
        {
            NhaXuatBan themnhaxuatban = new NhaXuatBan();
            themnhaxuatban.MaNXB = manxb;
            themnhaxuatban.TenNXB = tennxb;
            themnhaxuatban.DiaChi = diachi;
            themnhaxuatban.DienThoai = dienthoai;
            themnhaxuatban.Email = email;
            themnhaxuatban.GhiChu = ghichu;
            DB.NhaXuatBans.InsertOnSubmit(themnhaxuatban);
            DB.SubmitChanges();
        }
        public void SuaNhaXuatBan(string manxb, string tennxb, string diachi, string dienthoai, string email, string ghichu)
        {
            NhaXuatBan suanhaxuatban = (from nxb in DB.NhaXuatBans
                                        select nxb).Single(t => t.MaNXB == manxb);
            suanhaxuatban.TenNXB = tennxb;
            suanhaxuatban.DiaChi = diachi;
            suanhaxuatban.DienThoai = dienthoai;
            suanhaxuatban.Email = email;
            suanhaxuatban.GhiChu = ghichu;
            DB.SubmitChanges();
        }
        public void XoaNhaXuatBan(string manxb)
        {
            NhaXuatBan xoanhaxuatban = (from nxb in DB.NhaXuatBans
                                        select nxb).Single(t => t.MaNXB == manxb);
            DB.NhaXuatBans.DeleteOnSubmit(xoanhaxuatban);
            DB.SubmitChanges();
        }
    }
}
