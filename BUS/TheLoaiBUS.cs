using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TheLoaiBUS
    {
        QLNhaSachDataContext DB = new QLNhaSachDataContext();
         public IEnumerable<TheLoai> viewtheloai()
        {
            IEnumerable<TheLoai> theloai = from tl in DB.TheLoais
                                           select tl;
            return theloai;
 
        }
         public bool KTTonTai(string matl)
         {
             int kt = (from tk in DB.TheLoais
                       where tk.MaTheLoai == matl
                       select tk).Count();
             if (kt == 1)
                 return true;
             else
                 return false;


         }
        public void ThemTheLoai( string matl, string tentl)
         {
             TheLoai themtheloai = new TheLoai();
             themtheloai.MaTheLoai = matl;
             themtheloai.TenTheLoai = tentl;
             DB.TheLoais.InsertOnSubmit(themtheloai);
             DB.SubmitChanges();
         }
       public void SuaTheLoai (string matl, string tentl)
        {
            TheLoai suatheloai = (from tl in DB.TheLoais
                                  select tl).Single(t => t.MaTheLoai == matl);
            suatheloai.MaTheLoai = matl;
            suatheloai.TenTheLoai = tentl;
            DB.SubmitChanges();
        }
        public void XoaTheLoai (string matl)
       {
           TheLoai xoatheloai = (from tl in DB.TheLoais
                                 select tl).Single(t => t.MaTheLoai == matl);
           DB.TheLoais.DeleteOnSubmit(xoatheloai);
           DB.SubmitChanges();
       }
    }
}
