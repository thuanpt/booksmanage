namespace QLSach
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.dtNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_DSnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnOut = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bnt_Luu = new System.Windows.Forms.Button();
            this.bnt_Nhapmoi = new System.Windows.Forms.Button();
            this.bnt_Them = new System.Windows.Forms.Button();
            this.bnt_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSnhanvien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(553, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(782, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số CMND";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(313, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện Thoại";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chức Vụ";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(364, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quản Lý Nhân Viên";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.dtNgaySinhNV);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(934, 39);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(47, 23);
            this.radioNu.TabIndex = 4;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Checked = true;
            this.radioNam.Location = new System.Drawing.Point(871, 39);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 23);
            this.radioNam.TabIndex = 3;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinhNV
            // 
            this.dtNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinhNV.Location = new System.Drawing.Point(637, 36);
            this.dtNgaySinhNV.Name = "dtNgaySinhNV";
            this.dtNgaySinhNV.Size = new System.Drawing.Size(110, 27);
            this.dtNgaySinhNV.TabIndex = 2;
            this.dtNgaySinhNV.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(96, 109);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(167, 27);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(96, 70);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(167, 27);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(394, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(589, 27);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(838, 109);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(143, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(622, 104);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(125, 27);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(394, 107);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(139, 27);
            this.txtChucVu.TabIndex = 1;
            this.txtChucVu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(394, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(139, 27);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(96, 38);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(167, 27);
            this.txtTenNV.TabIndex = 1;
            this.txtTenNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(760, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mật Khẩu";
            this.label12.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(540, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tài Khoản";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgv_DSnhanvien
            // 
            this.dgv_DSnhanvien.AllowUserToAddRows = false;
            this.dgv_DSnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSnhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv_DSnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSnhanvien.GridColor = System.Drawing.Color.Red;
            this.dgv_DSnhanvien.Location = new System.Drawing.Point(12, 327);
            this.dgv_DSnhanvien.MultiSelect = false;
            this.dgv_DSnhanvien.Name = "dgv_DSnhanvien";
            this.dgv_DSnhanvien.ReadOnly = true;
            this.dgv_DSnhanvien.RowHeadersVisible = false;
            this.dgv_DSnhanvien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DSnhanvien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DSnhanvien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSnhanvien.Size = new System.Drawing.Size(1000, 316);
            this.dgv_DSnhanvien.TabIndex = 2;
            this.dgv_DSnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_DSnhanvien.Click += new System.EventHandler(this.dgv_DSnhanvien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnOut);
            this.groupBox2.Controls.Add(this.bntSua);
            this.groupBox2.Controls.Add(this.bnt_Luu);
            this.groupBox2.Controls.Add(this.bnt_Nhapmoi);
            this.groupBox2.Controls.Add(this.bnt_Them);
            this.groupBox2.Controls.Add(this.bnt_Xoa);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bnOut
            // 
            this.bnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnOut.Location = new System.Drawing.Point(885, 36);
            this.bnOut.Name = "bnOut";
            this.bnOut.Size = new System.Drawing.Size(98, 41);
            this.bnOut.TabIndex = 5;
            this.bnOut.Text = "Thoát";
            this.bnOut.UseVisualStyleBackColor = false;
            this.bnOut.Click += new System.EventHandler(this.bnOut_Click);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntSua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.Image = global::QLSach.Properties.Resources.ch;
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(182, 36);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(81, 41);
            this.bntSua.TabIndex = 4;
            this.bntSua.Text = "Sửa";
            this.bntSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.button5_Click);
            // 
            // bnt_Luu
            // 
            this.bnt_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnt_Luu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Luu.Image = global::QLSach.Properties.Resources.save;
            this.bnt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Luu.Location = new System.Drawing.Point(544, 36);
            this.bnt_Luu.Name = "bnt_Luu";
            this.bnt_Luu.Size = new System.Drawing.Size(82, 41);
            this.bnt_Luu.TabIndex = 3;
            this.bnt_Luu.Text = "Lưu";
            this.bnt_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Luu.UseVisualStyleBackColor = false;
            this.bnt_Luu.Click += new System.EventHandler(this.bnt_Luu_Click);
            // 
            // bnt_Nhapmoi
            // 
            this.bnt_Nhapmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnt_Nhapmoi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Nhapmoi.Image = global::QLSach.Properties.Resources.ghi;
            this.bnt_Nhapmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Nhapmoi.Location = new System.Drawing.Point(702, 36);
            this.bnt_Nhapmoi.Name = "bnt_Nhapmoi";
            this.bnt_Nhapmoi.Size = new System.Drawing.Size(140, 41);
            this.bnt_Nhapmoi.TabIndex = 3;
            this.bnt_Nhapmoi.Text = "Nhập Mới";
            this.bnt_Nhapmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Nhapmoi.UseVisualStyleBackColor = false;
            this.bnt_Nhapmoi.Click += new System.EventHandler(this.bnt_Nhapmoi_Click);
            // 
            // bnt_Them
            // 
            this.bnt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnt_Them.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Them.Image = global::QLSach.Properties.Resources.add;
            this.bnt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Them.Location = new System.Drawing.Point(16, 36);
            this.bnt_Them.Name = "bnt_Them";
            this.bnt_Them.Size = new System.Drawing.Size(97, 41);
            this.bnt_Them.TabIndex = 3;
            this.bnt_Them.Text = "Thêm";
            this.bnt_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Them.UseVisualStyleBackColor = false;
            this.bnt_Them.Click += new System.EventHandler(this.bnt_Them_Click);
            // 
            // bnt_Xoa
            // 
            this.bnt_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnt_Xoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Xoa.Image = global::QLSach.Properties.Resources.Xoa;
            this.bnt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Xoa.Location = new System.Drawing.Point(358, 36);
            this.bnt_Xoa.Name = "bnt_Xoa";
            this.bnt_Xoa.Size = new System.Drawing.Size(98, 41);
            this.bnt_Xoa.TabIndex = 3;
            this.bnt_Xoa.Text = "Xóa";
            this.bnt_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Xoa.UseVisualStyleBackColor = false;
            this.bnt_Xoa.Click += new System.EventHandler(this.bnt_Xoa_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1027, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_DSnhanvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSnhanvien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgaySinhNV;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_DSnhanvien;
        private System.Windows.Forms.Button bnt_Luu;
        private System.Windows.Forms.Button bnt_Them;
        private System.Windows.Forms.Button bnt_Xoa;
        private System.Windows.Forms.Button bnt_Nhapmoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bnOut;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
    }
}