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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "" || txtTenTG.Text == "")
                MessageBox.Show("Cần nhập đầy đủ cả Mã Tác Giả và Tên Tác Giả", "Thông báo");
            else
            {
                if (tacgiabus.KTTonTai(txtMaTG.Text) == true)
                    MessageBox.Show("Mã tác giả đã tồn tại !");
                else
                {
                    tacgiabus.ThemTacGia(txtMaTG.Text, txtTenTG.Text, txtLienHeTG.Text);
                    dgvTacGia.DataSource = tacgiabus.viewtacgia();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bntLuu.Enabled = true;
            bntXoa.Enabled = false;

            txtTenTG.Enabled = true;
            txtLienHeTG.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tacgiabus.XoaTacGia(txtMaTG.Text);
            dgvTacGia.DataSource = tacgiabus.viewtacgia();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void bntLuu_Click(object sender, EventArgs e)
        {
            tacgiabus.SuaTacGia(txtMaTG.Text, txtTenTG.Text, txtLienHeTG.Text);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        TacGiaBUS tacgiabus = new TacGiaBUS();
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = tacgiabus.viewtacgia();

            //Đặt tên cột trong dgvTacGia
            dgvTacGia.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            dgvTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvTacGia.Columns["LienHeTacGia"].HeaderText = "Liên Hệ";

            //chỉnh lại độ rộng cho các cột trong dgvTacGia
            dgvTacGia.Columns["MaTacGia"].Width = 60;
            dgvTacGia.Columns["TenTacGia"].Width = 100;
            dgvTacGia.Columns["LienHeTacGia"].Width = 200;

            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void dgvTacGia_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvTacGia.SelectedRows[0];
            txtMaTG.Text = dr.Cells["MaTacGia"].Value.ToString();
            txtTenTG.Text = dr.Cells["TenTacGia"].Value.ToString();
            txtLienHeTG.Text = dr.Cells["LienHeTacGia"].Value.ToString();

            bntThem.Enabled = false;
            bntSua.Enabled = true;
            bntXoa.Enabled = true;

            txtMaTG.Enabled = false;
            txtTenTG.Enabled = false;
            txtLienHeTG.Enabled = false;
        }

        private void bntNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaTG.Enabled = true;
            txtTenTG.Enabled = true;
            txtLienHeTG.Enabled = true;

            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtLienHeTG.Text = "";

            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }
    }
}
