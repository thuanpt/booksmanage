namespace QLSach
{
    partial class frmNhaXuaBan
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
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntNhapMoi = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhà Xuất Bản";
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(26, 66);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowTemplate.Height = 30;
            this.dgvNXB.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(758, 175);
            this.dgvNXB.TabIndex = 1;
            this.dgvNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvNXB.Click += new System.EventHandler(this.dgvNXB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntNhapMoi);
            this.groupBox1.Controls.Add(this.bntSua);
            this.groupBox1.Controls.Add(this.bntThem);
            this.groupBox1.Controls.Add(this.bntThoat);
            this.groupBox1.Controls.Add(this.bntXoa);
            this.groupBox1.Controls.Add(this.bntLuu);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // bntNhapMoi
            // 
            this.bntNhapMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(26)))), ((int)(((byte)(63)))));
            this.bntNhapMoi.FlatAppearance.BorderSize = 0;
            this.bntNhapMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapMoi.Location = new System.Drawing.Point(549, 43);
            this.bntNhapMoi.Name = "bntNhapMoi";
            this.bntNhapMoi.Size = new System.Drawing.Size(94, 66);
            this.bntNhapMoi.TabIndex = 3;
            this.bntNhapMoi.Text = "NHẬP MỚI";
            this.bntNhapMoi.UseVisualStyleBackColor = false;
            this.bntNhapMoi.Click += new System.EventHandler(this.bntNhapMoi_Click);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.OrangeRed;
            this.bntSua.FlatAppearance.BorderSize = 0;
            this.bntSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.Location = new System.Drawing.Point(146, 43);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(94, 66);
            this.bntSua.TabIndex = 2;
            this.bntSua.Text = "SỬA";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.bntThem.FlatAppearance.BorderSize = 0;
            this.bntThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.Location = new System.Drawing.Point(14, 43);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(94, 66);
            this.bntThem.TabIndex = 1;
            this.bntThem.Text = "THÊM";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.Maroon;
            this.bntThoat.FlatAppearance.BorderSize = 0;
            this.bntThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(678, 42);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(94, 66);
            this.bntThoat.TabIndex = 0;
            this.bntThoat.Text = "THOÁT";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.Orange;
            this.bntXoa.FlatAppearance.BorderSize = 0;
            this.bntXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(282, 43);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(94, 66);
            this.bntXoa.TabIndex = 0;
            this.bntXoa.Text = "XÓA";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Green;
            this.bntLuu.FlatAppearance.BorderSize = 0;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLuu.Location = new System.Drawing.Point(416, 42);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(94, 66);
            this.bntLuu.TabIndex = 0;
            this.bntLuu.Text = "LƯU";
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(28, 288);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(164, 27);
            this.txtMaNXB.TabIndex = 3;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(28, 354);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(164, 27);
            this.txtTenNXB.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(237, 286);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(327, 27);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(237, 355);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(151, 27);
            this.txtDienThoai.TabIndex = 6;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(408, 355);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(603, 286);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(181, 96);
            this.txtGhiChu.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(264, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(448, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(651, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ghi Chú";
            // 
            // frmNhaXuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(811, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaXuaBan";
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.frmNhaXuaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntNhapMoi;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
    }
}