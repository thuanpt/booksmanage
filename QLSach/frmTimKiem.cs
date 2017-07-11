using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLSach
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        QLNhaSachDataContext DB = new QLNhaSachDataContext();
        SachBUS sachbus = new SachBUS();
        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            var listtimkiem = from s in DB.Saches
                                where s.TenSach.Contains(txtTimKiem.Text)//Chọn những thành viên nào có tên gần giống với txtHoTen.Text  
                                //where "TenSach Like N'%{0} %'", txtTimKiem.Text;
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
          
           
                dgvTimKiem.DataSource = listtimkiem;
                dgvTimKiem.Refresh();
            
            
        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dgvTimKiem.DataSource = sachbus.viewsach();

            dgvTimKiem.Columns["AnhBia"].Visible = false;
            dgvTimKiem.Columns["MaTacGia"].Visible = false;
            dgvTimKiem.Columns["MaNXB"].Visible = false;
            dgvTimKiem.Columns["MaNhaCungCap"].Visible = false;
            dgvTimKiem.Columns["MaTheLoai"].Visible = false;


            dgvTimKiem.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvTimKiem.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvTimKiem.Columns["GiaMua"].HeaderText = "Giá Mua";
            dgvTimKiem.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvTimKiem.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvTimKiem.Columns["NhaXuatBan"].HeaderText = "Nhà Xuất Bản";
            dgvTimKiem.Columns["NhaCungCap"].HeaderText = "Nhà Cung Cấp";
            dgvTimKiem.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvTimKiem.Columns["SoLuong"].HeaderText = "Số Lượng";

            
        }
    }
}
