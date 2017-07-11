namespace QLSach
{
    partial class frmBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.dtNgaylapHD = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntLapHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSach);
            this.groupBox1.Controls.Add(this.dtNgaylapHD);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbSach
            // 
            this.cbSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(527, 43);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(211, 27);
            this.cbSach.TabIndex = 3;
            // 
            // dtNgaylapHD
            // 
            this.dtNgaylapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaylapHD.Location = new System.Drawing.Point(140, 182);
            this.dtNgaylapHD.Name = "dtNgaylapHD";
            this.dtNgaylapHD.Size = new System.Drawing.Size(174, 27);
            this.dtNgaylapHD.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(527, 182);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(211, 27);
            this.txtThanhTien.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(527, 133);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(211, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(527, 87);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(211, 27);
            this.txtGiaBan.TabIndex = 1;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(140, 130);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(174, 27);
            this.txtKhachHang.TabIndex = 1;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(140, 87);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(174, 27);
            this.txtNhanVien.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(140, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(174, 27);
            this.txtMaHD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(426, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành Tiền";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(426, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Lượng";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(426, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá Bán";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(426, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Sách";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Lập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Purple;
            this.bntLuu.FlatAppearance.BorderSize = 0;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLuu.ForeColor = System.Drawing.Color.White;
            this.bntLuu.Location = new System.Drawing.Point(240, 263);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(128, 36);
            this.bntLuu.TabIndex = 2;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bntXoa.FlatAppearance.BorderSize = 0;
            this.bntXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntXoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.White;
            this.bntXoa.Location = new System.Drawing.Point(442, 263);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(123, 36);
            this.bntXoa.TabIndex = 3;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.Maroon;
            this.bntThoat.FlatAppearance.BorderSize = 0;
            this.bntThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThoat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.ForeColor = System.Drawing.Color.White;
            this.bntThoat.Location = new System.Drawing.Point(657, 263);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(111, 36);
            this.bntThoat.TabIndex = 4;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntLapHoaDon
            // 
            this.bntLapHoaDon.BackColor = System.Drawing.Color.DarkOrange;
            this.bntLapHoaDon.FlatAppearance.BorderSize = 0;
            this.bntLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLapHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.bntLapHoaDon.Location = new System.Drawing.Point(36, 263);
            this.bntLapHoaDon.Name = "bntLapHoaDon";
            this.bntLapHoaDon.Size = new System.Drawing.Size(123, 36);
            this.bntLapHoaDon.TabIndex = 5;
            this.bntLapHoaDon.Text = "Lập Hóa Đơn";
            this.bntLapHoaDon.UseVisualStyleBackColor = false;
            this.bntLapHoaDon.Click += new System.EventHandler(this.bntLapHoaDon_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(796, 528);
            this.Controls.Add(this.bntLapHoaDon);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaylapHD;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ComboBox cbSach;
        private System.Windows.Forms.Button bntLapHoaDon;
    }
}