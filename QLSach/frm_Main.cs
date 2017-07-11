using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach
{
    
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTheLoai frm = new frmTheLoai();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.ShowDialog();
        }

        private void bntSach_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void bntTKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.ShowDialog();
        }

        private void bntNXB_Click(object sender, EventArgs e)
        {
            frmNhaXuaBan frm = new frmNhaXuaBan();
            frm.ShowDialog();
        }

        private void bntTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frm = new frmTacGia();
            frm.ShowDialog();
        }

        private void bntNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {

        }

        private void bntBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void bntNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void bntBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.ShowDialog();
        }
    }
}
