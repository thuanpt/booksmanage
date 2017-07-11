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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SachBUS sachbus = new SachBUS();
        TacGiaBUS tacgiabus = new TacGiaBUS();
        TheLoaiBUS theloaibus = new TheLoaiBUS();
        NhaXuatBanBUS nhaxuatbanbus = new NhaXuatBanBUS();
        NhaCungCapBUS nhacungcapbus = new NhaCungCapBUS();
        private void frmSach_Load(object sender, EventArgs e)
        {
            dgv_Sach.DataSource = sachbus.viewsach();
            dgv_Sach.Columns["AnhBia"].Visible = false;
            dgv_Sach.Columns["MaTacGia"].Visible = false;
            dgv_Sach.Columns["MaNXB"].Visible = false;
            dgv_Sach.Columns["MaNhaCungCap"].Visible = false;
            dgv_Sach.Columns["MaTheLoai"].Visible = false;

            dgv_Sach.Columns["TenSach"].Width = 161;

            dgv_Sach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgv_Sach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgv_Sach.Columns["GiaMua"].HeaderText = "Giá Mua";
            dgv_Sach.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgv_Sach.Columns["TacGia"].HeaderText = "Tác Giả";
            dgv_Sach.Columns["NhaXuatBan"].HeaderText = "Nhà Xuất Bản";
            dgv_Sach.Columns["NhaCungCap"].HeaderText = "Nhà Cung Cấp";
            dgv_Sach.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgv_Sach.Columns["SoLuong"].HeaderText = "Số Lượng";

            cbTacGia.DataSource = tacgiabus.viewtacgia();
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";

            cbTheLoai.DataSource = theloaibus.viewtheloai();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember ="MaTheLoai";

            cbNXB.DataSource = nhaxuatbanbus.viewnhaxuatban();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";

            cbNCP.DataSource = nhacungcapbus.viewnhacungcap();
            cbNCP.DisplayMember = "TenNhaCungCap";
            cbNCP.ValueMember = "MaNhaCungCap";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox_TG_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox_TG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNCP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtSoLuong.Text == "" || txtGiaMua.Text == "" || txtGiaBan.Text == "")
                MessageBox.Show("Bạn bỏ qua quá thông tin quan trọng. Hãy nhập lại đầy đủ!", "Thông báo");
            else
            {
                if (sachbus.KTTonTai(txtMaSach.Text) == true)
                    MessageBox.Show("Mã sách đã tồn tại !");
                else
                {
                    sachbus.ThemSach(txtMaSach.Text, txtTenSach.Text, int.Parse(txtGiaMua.Text), int.Parse(txtGiaBan.Text), cbTacGia.SelectedValue.ToString(), cbNXB.SelectedValue.ToString(), cbNCP.SelectedValue.ToString(), cbTheLoai.SelectedValue.ToString(), int.Parse(txtSoLuong.Text));
                    dgv_Sach.DataSource = sachbus.viewsach();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtGiaMua.Enabled = true;
            txtGiaBan.Enabled = true;
            cbTacGia.Enabled = true;
            cbTheLoai.Enabled = true;
            cbNXB.Enabled = true;
            cbNCP.Enabled = true;
            txtSoLuong.Enabled = true;

            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtGiaMua.Text = "";
            txtGiaBan.Text = "";
            cbTacGia.Text = "";
            cbTheLoai.Text = "";
            cbNXB.Text = "";
            cbNCP.Text = "";
            txtSoLuong.Text = "";


            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void txtGiaMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_Sach_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv_Sach.SelectedRows[0];
            txtMaSach.Text = dr.Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dr.Cells["TenSach"].Value.ToString();
            txtGiaMua.Text = dr.Cells["GiaMua"].Value.ToString();
            txtGiaBan.Text = dr.Cells["GiaBan"].Value.ToString();
            cbTacGia.SelectedValue = dr.Cells["MaTacGia"].Value.ToString();
            cbNXB.SelectedValue = dr.Cells["MaNXB"].Value.ToString();
            cbNCP.SelectedValue = dr.Cells["MaNhaCungCap"].Value.ToString();
            cbTheLoai.SelectedValue = dr.Cells["MaTheLoai"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuong"].Value.ToString();

            bntSua.Enabled = true;
            bntXoa.Enabled = true;
            bntThem.Enabled = false;
            bntLuu.Enabled = false;


            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtGiaMua.Enabled = false;
            txtGiaBan.Enabled = false;
            cbTacGia.Enabled = false;
            cbTheLoai.Enabled = false;
            cbNXB.Enabled = false;
            cbNCP.Enabled = false;
            txtSoLuong.Enabled = false;
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            bntLuu.Enabled = true;


            txtMaSach.Enabled = false;
            txtTenSach.Enabled = true;
            txtGiaMua.Enabled = true;
            txtGiaBan.Enabled = true;
            cbTacGia.Enabled = true;
            cbTheLoai.Enabled = true;
            cbNXB.Enabled = true;
            cbNCP.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            sachbus.XoaSach(txtMaSach.Text);
            dgv_Sach.DataSource = sachbus.viewsach();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            sachbus.SuaSach(txtMaSach.Text, txtTenSach.Text, int.Parse(txtGiaMua.Text), int.Parse(txtGiaBan.Text), cbTacGia.SelectedValue.ToString(), cbNXB.SelectedValue.ToString(), cbNCP.SelectedValue.ToString(), cbTheLoai.SelectedValue.ToString(), int.Parse(txtSoLuong.Text));
            dgv_Sach.DataSource = sachbus.viewsach();
        }
    }
}
