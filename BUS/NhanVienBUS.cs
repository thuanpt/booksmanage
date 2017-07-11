using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class NhanVienBUS
    {
        QLNhaSachDataContext DB = new QLNhaSachDataContext();//Khởi tạo nguồn DL
        public bool KTDangNhap(string tendangnhap, string matkhau)
        {
            int nhanvien = (from tk in DB.NhanViens
                            where tk.TaiKhoan == tendangnhap && tk.MatKhau == matkhau
                            select tk).Count();
            if (nhanvien == 1)
                return true;
            else
                return false;
        }
        public IEnumerable<NhanVien> laytatca()
        {
            IEnumerable<NhanVien> nhanvien = from tk in DB.NhanViens
                                             select tk;
            return nhanvien;
        }
       
        
        public bool KTTonTai(string manv)
        {
            int kt = (from tk in DB.NhanViens
                      where tk.MaNV == manv
                      select tk).Count();
            if (kt == 1)
                return true;
            else
                return false;


        }
        public void ThemNV(string manv, string tennv, DateTime ngaysinh, string cmnd, string gioitinh, string sdt, string diachi, string taikhoan, string matkhau, string chucvu)
        {
            NhanVien themnhanvien = new NhanVien();
            themnhanvien.MaNV = manv;
            themnhanvien.TenNV = tennv;
            themnhanvien.NgaySinh = ngaysinh;
            themnhanvien.GioiTinh = gioitinh;
            themnhanvien.CMND = cmnd;
            themnhanvien.SDT = sdt;
            themnhanvien.DiaChi = diachi;
            themnhanvien.ChucVu = chucvu;
            themnhanvien.TaiKhoan = taikhoan;
            themnhanvien.MatKhau = matkhau;
            DB.NhanViens.InsertOnSubmit(themnhanvien);
            DB.SubmitChanges();
        }
        public void SuaNhanVien(string manv, string tennv, DateTime ngaysinh,string cmnd, string gioitinh, string sdt, string diachi, string taikhoan, string matkhau, string chucvu)
        {
            NhanVien suanhanvien = (from tk in DB.NhanViens
                                    select tk).Single(t => t.MaNV == manv);
            suanhanvien.TenNV = tennv;
            suanhanvien.NgaySinh = ngaysinh;
            suanhanvien.CMND = cmnd;
            suanhanvien.GioiTinh = gioitinh;
            suanhanvien.SDT = sdt;
            suanhanvien.DiaChi = diachi;
            suanhanvien.TaiKhoan = taikhoan;
            suanhanvien.MatKhau = matkhau;
            suanhanvien.ChucVu = chucvu;
            DB.SubmitChanges();
        }
        public void XoaNhanVien(string manv)
        {
            NhanVien xoataikhoan = (from tk in DB.NhanViens
                                    select tk).Single(t => t.MaNV == manv);
            DB.NhanViens.DeleteOnSubmit(xoataikhoan);
            DB.SubmitChanges();

        }

    }
}
