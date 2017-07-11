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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            theloaibus.SuaTheLoai(txtMaTL.Text, txtTenTL.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            theloaibus.XoaTheLoai(txtMaTL.Text);
            dgvTheLoai.DataSource = theloaibus.viewtheloai();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TheLoaiBUS theloaibus = new TheLoaiBUS();
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = theloaibus.viewtheloai();

            dgvTheLoai.Columns["MaTheloai"].HeaderText = "Mã Thể Loại";
            dgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên Thể Loại";

            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "" || txtTenTL.Text == "")
                MessageBox.Show("Bạn bỏ qua quá thông tin quan trọng. Hãy nhập lại đầy đủ!", "Thông báo");
            else
            {
                if (theloaibus.KTTonTai(txtMaTL.Text) == true)
                    MessageBox.Show("Mã thể loại đã tồn tại !");
                else
                {
                    theloaibus.ThemTheLoai(txtMaTL.Text, txtTenTL.Text);
                    dgvTheLoai.DataSource = theloaibus.viewtheloai();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bntLuu.Enabled = true;


            txtMaTL.Enabled = false;
            txtTenTL.Enabled = true;
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTheLoai_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvTheLoai.SelectedRows[0];
            txtMaTL.Text = dr.Cells["MaTheLoai"].Value.ToString();
            txtTenTL.Text = dr.Cells["TenTheLoai"].Value.ToString();

            bntSua.Enabled = true;
            bntXoa.Enabled = true;
            bntThem.Enabled = false;
            bntLuu.Enabled = false;


            txtMaTL.Enabled = false;
            txtTenTL.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtMaTL.Enabled = true;
            txtTenTL.Enabled = true;    

            txtMaTL.Text = "";
            txtTenTL.Text = "";
            

            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntLuu.Enabled = false;
        }
    }
}
