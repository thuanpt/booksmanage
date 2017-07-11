using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TacGiaBUS
    {
       QLNhaSachDataContext DB=new QLNhaSachDataContext();
       public IEnumerable<TacGia> viewtacgia()
       {
           IEnumerable<TacGia> tacgia = from tg in DB.TacGias
                                        select tg;
           return tacgia;
       }
       public bool KTTonTai(string matg)
       {
           int kt = (from tk in DB.TacGias
                     where tk.MaTacGia == matg
                     select tk).Count();
           if (kt == 1)
               return true;
           else
               return false;


       }

        public void ThemTacGia(string matg, string tentg, string lienheTG)
       {
           TacGia themtacgia = new TacGia();
           themtacgia.MaTacGia = matg;
           themtacgia.TenTacGia = tentg;
           themtacgia.LienHeTacGia = lienheTG;
           DB.TacGias.InsertOnSubmit(themtacgia);
           DB.SubmitChanges();
       }
        public void SuaTacGia(string matg, string tentg, string lienheTG)
        {
            TacGia suatacgia = (from tg in DB.TacGias
                                select tg).Single(t => t.MaTacGia == matg);
            suatacgia.TenTacGia = tentg;
            suatacgia.LienHeTacGia = lienheTG;
            DB.SubmitChanges();
        }
        public void XoaTacGia (string matg)
        {
            TacGia xoatacgia = (from tg in DB.TacGias
                                select tg).Single(t => t.MaTacGia == matg);
            DB.TacGias.DeleteOnSubmit(xoatacgia);
            DB.SubmitChanges();
        }
    }
}
