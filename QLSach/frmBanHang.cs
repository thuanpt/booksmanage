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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SachBUS sachbus = new SachBUS();
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cbSach.DataSource = sachbus.viewsach();
            cbSach.DisplayMember = "TenSach";
            cbSach.ValueMember = "MaSach";
        }

        private void bntLapHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
