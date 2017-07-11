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
    public partial class frmNhaXuaBan : Form
    {
        public frmNhaXuaBan()
        {
            InitializeComponent();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
                nhaxuatbanbus.SuaNhaXuatBan(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            nhaxuatbanbus.XoaNhaXuatBan(txtMaNXB.Text);
            dgvNXB.DataSource = nhaxuatbanbus.viewnhaxuatban();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        NhaXuatBanBUS nhaxuatbanbus = new NhaXuatBanBUS();
        private void frmNhaXuaBan_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = nhaxuatbanbus.viewnhaxuatban();

            dgvNXB.Columns["MaNXB"].HeaderText = "Mã Nhà Xuất Bản";
            dgvNXB.Columns["TenNXB"].HeaderText = "Tên Nhà Xuất Bản";
            dgvNXB.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNXB.Columns["DienThoai"].HeaderText = "Điện Thoại";
            dgvNXB.Columns["GhiChu"].HeaderText = "Ghi Chú";

            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "" || txtTenNXB.Text == "")
                MessageBox.Show("Cần nhập đầy đủ cả Mã NXB và Tên NXB", "Thông báo");
            else
            {
                if (nhaxuatbanbus.KTTonTai(txtMaNXB.Text) == true)
                    MessageBox.Show("Ma nhà xuất bản đã tồn tại !");
                else
                {
                    nhaxuatbanbus.ThemNhaXuatBan(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);
                    dgvNXB.DataSource = nhaxuatbanbus.viewnhaxuatban();
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            bntLuu.Enabled = true;
            bntXoa.Enabled = false;

            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void bntNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaNXB.Enabled = true;
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtGhiChu.Enabled = true;

            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";

            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void dgvNXB_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNXB.SelectedRows[0];
            txtMaNXB.Text = dr.Cells["MaNXB"].Value.ToString();
            txtTenNXB.Text = dr.Cells["TenNXB"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dr.Cells["DienThoai"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();

            bntThem.Enabled = false;
            bntSua.Enabled = true;
            bntXoa.Enabled = true;

            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtGhiChu.Enabled = false;
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
