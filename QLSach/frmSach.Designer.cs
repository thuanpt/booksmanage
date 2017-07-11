namespace QLSach
{
    partial class frmSach
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNCP = new System.Windows.Forms.ComboBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntNhapMoi = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNCP);
            this.groupBox1.Controls.Add(this.cbNXB);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.cbTacGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaMua);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(663, 215);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(220, 27);
            this.txtSoLuong.TabIndex = 15;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged_1);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(546, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số Lượng";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(137, 37);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(230, 27);
            this.txtMaSach.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Sách";
            // 
            // cbNCP
            // 
            this.cbNCP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNCP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNCP.FormattingEnabled = true;
            this.cbNCP.Location = new System.Drawing.Point(663, 167);
            this.cbNCP.Name = "cbNCP";
            this.cbNCP.Size = new System.Drawing.Size(220, 27);
            this.cbNCP.TabIndex = 10;
            this.cbNCP.SelectedIndexChanged += new System.EventHandler(this.cbNCP_SelectedIndexChanged);
            // 
            // cbNXB
            // 
            this.cbNXB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNXB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(663, 120);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(220, 27);
            this.cbNXB.TabIndex = 10;
            this.cbNXB.SelectedIndexChanged += new System.EventHandler(this.cbNXB_SelectedIndexChanged);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(663, 77);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(220, 27);
            this.cbTheLoai.TabIndex = 10;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // cbTacGia
            // 
            this.cbTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Items.AddRange(new object[] {
            ""});
            this.cbTacGia.Location = new System.Drawing.Point(663, 33);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(220, 27);
            this.cbTacGia.TabIndex = 8;
            this.cbTacGia.SelectedIndexChanged += new System.EventHandler(this.cboxTacGia_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nhà Cung Cấp";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(546, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nhà Xuất Bản";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thể Loại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tác Giả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(137, 212);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(230, 27);
            this.txtGiaBan.TabIndex = 4;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(137, 152);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(230, 27);
            this.txtGiaMua.TabIndex = 4;
            this.txtGiaMua.TextChanged += new System.EventHandler(this.txtGiaMua_TextChanged);
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(137, 95);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(230, 27);
            this.txtTenSach.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách";
            this.label2.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá Mua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(51, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá Bán";
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.AllowUserToAddRows = false;
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.GridColor = System.Drawing.Color.Red;
            this.dgv_Sach.Location = new System.Drawing.Point(12, 327);
            this.dgv_Sach.MultiSelect = false;
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersVisible = false;
            this.dgv_Sach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Sach.RowTemplate.Height = 30;
            this.dgv_Sach.RowTemplate.ReadOnly = true;
            this.dgv_Sach.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(965, 242);
            this.dgv_Sach.TabIndex = 4;
            this.dgv_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            this.dgv_Sach.Click += new System.EventHandler(this.dgv_Sach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.bntNhapMoi);
            this.groupBox2.Controls.Add(this.bntThoat);
            this.groupBox2.Controls.Add(this.bntLuu);
            this.groupBox2.Controls.Add(this.bntXoa);
            this.groupBox2.Controls.Add(this.bntSua);
            this.groupBox2.Controls.Add(this.bntThem);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 577);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bntNhapMoi
            // 
            this.bntNhapMoi.BackColor = System.Drawing.Color.Firebrick;
            this.bntNhapMoi.FlatAppearance.BorderSize = 0;
            this.bntNhapMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNhapMoi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapMoi.Location = new System.Drawing.Point(686, 29);
            this.bntNhapMoi.Name = "bntNhapMoi";
            this.bntNhapMoi.Size = new System.Drawing.Size(104, 51);
            this.bntNhapMoi.TabIndex = 1;
            this.bntNhapMoi.Text = "NHẬP MỚI";
            this.bntNhapMoi.UseVisualStyleBackColor = false;
            this.bntNhapMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.bntThoat.FlatAppearance.BorderSize = 0;
            this.bntThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThoat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(836, 29);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(104, 51);
            this.bntThoat.TabIndex = 0;
            this.bntThoat.Text = "THOÁT";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Purple;
            this.bntLuu.FlatAppearance.BorderSize = 0;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLuu.Location = new System.Drawing.Point(529, 32);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(104, 51);
            this.bntLuu.TabIndex = 0;
            this.bntLuu.Text = "LƯU";
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.DarkRed;
            this.bntXoa.FlatAppearance.BorderSize = 0;
            this.bntXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntXoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(355, 32);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(104, 51);
            this.bntXoa.TabIndex = 0;
            this.bntXoa.Text = "XÓA";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bntSua.FlatAppearance.BorderSize = 0;
            this.bntSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.Location = new System.Drawing.Point(186, 29);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(104, 51);
            this.bntSua.TabIndex = 0;
            this.bntSua.Text = "SỬA";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.Green;
            this.bntThem.FlatAppearance.BorderSize = 0;
            this.bntThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.Location = new System.Drawing.Point(26, 29);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(104, 51);
            this.bntThem.TabIndex = 0;
            this.bntThem.Text = "THÊM";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(989, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_Sach);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNCP;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntNhapMoi;
    }
}