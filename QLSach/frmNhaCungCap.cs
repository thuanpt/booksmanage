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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        NhaCungCapBUS nhacungcapbus = new NhaCungCapBUS();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCP.DataSource = nhacungcapbus.viewnhacungcap();

            dgvNCP.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNCP.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNCP.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNCP.Columns["DienThoai"].HeaderText = "Điện Thoại";
            dgvNCP.Columns["GhiChu"].HeaderText = "Ghi Chú";

            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCP.Text == "" || txtTenNCP.Text == "")
                MessageBox.Show("Không được bỏ trống Mã NCP và Tên NCP", "Thông báo");
            else
            {
                if (nhacungcapbus.KTTonTai(txtMaNCP.Text) == true)
                    MessageBox.Show("Ma nhà cung cấp đã tồn tại !");
                else
                {
                    nhacungcapbus.ThemNhaCungCap(txtMaNCP.Text, txtTenNCP.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);
                    dgvNCP.DataSource = nhacungcapbus.viewnhacungcap();
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            bntLuu.Enabled = true;
            bntXoa.Enabled = false;

            txtTenNCP.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            nhacungcapbus.XoaNhaCungCap(txtMaNCP.Text);
            dgvNCP.DataSource = nhacungcapbus.viewnhacungcap(); 
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            nhacungcapbus.SuaNhaCungCap(txtMaNCP.Text, txtTenNCP.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);
        }

        private void bntNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaNCP.Enabled = true;
            txtTenNCP.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtGhiChu.Enabled = true;

            txtMaNCP.Text = "";
            txtTenNCP.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";

            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void dgvNCP_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNCP.SelectedRows[0];
            txtMaNCP.Text = dr.Cells["MaNhaCungCap"].Value.ToString();
            txtTenNCP.Text = dr.Cells["TenNhaCungCap"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dr.Cells["DienThoai"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();

            bntThem.Enabled = false;
            bntSua.Enabled = true;
            bntXoa.Enabled = true;

            txtMaNCP.Enabled = false;
            txtTenNCP.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtGhiChu.Enabled = false;
        }

        private void dgvNCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
