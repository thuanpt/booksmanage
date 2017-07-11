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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        NhanVienBUS taikhoanbus = new NhanVienBUS();
        private void bnt_DangNhap_Click(object sender, EventArgs e)
        {
            if (taikhoanbus.KTDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                this.Hide();
                frm_Main frm = new frm_Main();
                frm.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
        }
    }
}
