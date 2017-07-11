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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        NhanVienBUS nhanvienbus = new NhanVienBUS();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgv_DSnhanvien.DataSource = nhanvienbus.laytatca();
            dgv_DSnhanvien.Columns["MatKhau"].Visible = false;

            //Đặt tên cột cho dgv_DSnhanvien
            dgv_DSnhanvien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgv_DSnhanvien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgv_DSnhanvien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgv_DSnhanvien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgv_DSnhanvien.Columns["SDT"].HeaderText = "Số ĐT";
            dgv_DSnhanvien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgv_DSnhanvien.Columns["TaiKhoan"].HeaderText = "Tài khoản";
            dgv_DSnhanvien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgv_DSnhanvien.Columns["ChucVu"].HeaderText = "Chức vụ";


            bntSua.Enabled = false;
            bnt_Xoa.Enabled = false;
            bnt_Luu.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bnt_Luu.Enabled = true;


            txtTenNV.Enabled = true;
            dtNgaySinhNV.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            txtChucVu.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
        }

        private void bnt_Luu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radioNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            nhanvienbus.SuaNhanVien(txtMaNV.Text, txtTenNV.Text, dtNgaySinhNV.Value ,txtCMND.Text, gioitinh, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text, txtChucVu.Text);
        }

        private void bnt_Xoa_Click(object sender, EventArgs e)
        {
            nhanvienbus.XoaNhanVien(txtMaNV.Text);
            dgv_DSnhanvien.DataSource = nhanvienbus.laytatca();
        }

        private void bnOut_Click(object sender, EventArgs e)
        {
            this.Close();
            
          
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bnt_Them_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Bạn bỏ qua quá thông tin quan trọng. Hãy nhập lại đầy đủ!","Thông báo");
            else
            {
                string gioitinh = "";
                if (radioNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nữ";
                if (nhanvienbus.KTTonTai(txtMaNV.Text) == true)
                    MessageBox.Show("MaNV đã tồn tại !");
                else
                {
                    nhanvienbus.ThemNV(txtMaNV.Text, txtTenNV.Text, dtNgaySinhNV.Value ,txtCMND.Text, gioitinh, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text, txtChucVu.Text);
                    dgv_DSnhanvien.DataSource = nhanvienbus.laytatca();
                }

            }   
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_DSnhanvien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv_DSnhanvien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();          
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtTaiKhoan.Text = dr.Cells["TaiKhoan"].Value.ToString();
            txtMatKhau.Text = dr.Cells["MatKhau"].Value.ToString();
            txtChucVu.Text = dr.Cells["ChucVu"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;



            bntSua.Enabled = true;
            bnt_Xoa.Enabled = true;
            bnt_Them.Enabled = false;
            bnt_Luu.Enabled = false;


            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            dtNgaySinhNV.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            txtChucVu.Enabled = false;
            radioNam.Enabled = false;
            radioNu.Enabled = false;

        }

        private void bnt_Nhapmoi_Click(object sender, EventArgs e)
        {

            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            dtNgaySinhNV.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            txtChucVu.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtChucVu.Text = "";

            bnt_Them.Enabled = true;
            bntSua.Enabled = false;
            bnt_Xoa.Enabled = false;
            bnt_Luu.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    
    }
}
