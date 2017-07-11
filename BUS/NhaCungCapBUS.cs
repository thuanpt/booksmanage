using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class NhaCungCapBUS
    {
        QLNhaSachDataContext DB = new QLNhaSachDataContext();
        public IEnumerable<NhaCungCap> viewnhacungcap()
        {
            IEnumerable<NhaCungCap> nhacungcap = from ncp in DB.NhaCungCaps
                                                 select ncp;
            return nhacungcap;
        }
        public bool KTTonTai(string mancp)
        {
            int kt = (from tk in DB.NhaCungCaps
                      where tk.MaNhaCungCap == mancp
                      select tk).Count();
            if (kt == 1)
                return true;
            else
                return false;


        }
        public void ThemNhaCungCap(string mancp, string tenncp, string diachi, string dienthoai, string email, string ghichu)
        {
            NhaCungCap themnhacungcap = new NhaCungCap();
            themnhacungcap.MaNhaCungCap = mancp;
            themnhacungcap.TenNhaCungCap = tenncp;
            themnhacungcap.DiaChi = diachi;
            themnhacungcap.DienThoai = dienthoai;
            themnhacungcap.Email = email;
            themnhacungcap.GhiChu = ghichu;
            DB.NhaCungCaps.InsertOnSubmit(themnhacungcap);
            DB.SubmitChanges();
        }
        public void SuaNhaCungCap(string mancp, string tenncp, string diachi, string dienthoai, string email, string ghichu)
        {
            NhaCungCap suanhacungcap = (from ncp in DB.NhaCungCaps
                                select ncp).Single(t => t.MaNhaCungCap == mancp);
            suanhacungcap.TenNhaCungCap = tenncp;
            suanhacungcap.DiaChi = diachi;
            suanhacungcap.DienThoai = dienthoai;
            suanhacungcap.Email = email;
            suanhacungcap.GhiChu = ghichu;
            DB.SubmitChanges();
        }
        public void XoaNhaCungCap(string mancp)
        {
            NhaCungCap xoanhacungcap = (from ncp in DB.NhaCungCaps
                                select ncp).Single(t => t.MaNhaCungCap == mancp);
            DB.NhaCungCaps.DeleteOnSubmit(xoanhacungcap);
            DB.SubmitChanges();
        }
    }
}
