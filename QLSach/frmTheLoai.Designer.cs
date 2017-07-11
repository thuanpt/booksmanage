namespace QLSach
{
    partial class frmTheLoai
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
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntNhapMoi = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Location = new System.Drawing.Point(19, 42);
            this.dgvTheLoai.MultiSelect = false;
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersVisible = false;
            this.dgvTheLoai.RowTemplate.Height = 30;
            this.dgvTheLoai.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(320, 199);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellContentClick);
            this.dgvTheLoai.Click += new System.EventHandler(this.dgvTheLoai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntNhapMoi);
            this.groupBox1.Controls.Add(this.bntSua);
            this.groupBox1.Controls.Add(this.bntThem);
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bntThoat);
            this.groupBox1.Controls.Add(this.bntXoa);
            this.groupBox1.Controls.Add(this.bntLuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvTheLoai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bntNhapMoi
            // 
            this.bntNhapMoi.BackColor = System.Drawing.Color.SaddleBrown;
            this.bntNhapMoi.FlatAppearance.BorderSize = 0;
            this.bntNhapMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNhapMoi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapMoi.ForeColor = System.Drawing.Color.White;
            this.bntNhapMoi.Location = new System.Drawing.Point(474, 278);
            this.bntNhapMoi.Name = "bntNhapMoi";
            this.bntNhapMoi.Size = new System.Drawing.Size(79, 48);
            this.bntNhapMoi.TabIndex = 7;
            this.bntNhapMoi.Text = "Mới";
            this.bntNhapMoi.UseVisualStyleBackColor = false;
            this.bntNhapMoi.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.Crimson;
            this.bntSua.FlatAppearance.BorderSize = 0;
            this.bntSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSua.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.ForeColor = System.Drawing.Color.White;
            this.bntSua.Location = new System.Drawing.Point(130, 280);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(79, 48);
            this.bntSua.TabIndex = 2;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.DarkOrange;
            this.bntThem.FlatAppearance.BorderSize = 0;
            this.bntThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.ForeColor = System.Drawing.Color.White;
            this.bntThem.Location = new System.Drawing.Point(19, 280);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(79, 48);
            this.bntThem.TabIndex = 6;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(370, 192);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(179, 26);
            this.txtTenTL.TabIndex = 5;
            this.txtTenTL.TextChanged += new System.EventHandler(this.txtTenTL_TextChanged);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(370, 94);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(179, 26);
            this.txtMaTL.TabIndex = 4;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Thể Loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thể Loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.Maroon;
            this.bntThoat.FlatAppearance.BorderSize = 0;
            this.bntThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThoat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.ForeColor = System.Drawing.Color.White;
            this.bntThoat.Location = new System.Drawing.Point(575, 280);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(79, 48);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.Purple;
            this.bntXoa.FlatAppearance.BorderSize = 0;
            this.bntXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntXoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.White;
            this.bntXoa.Location = new System.Drawing.Point(245, 280);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(79, 48);
            this.bntXoa.TabIndex = 2;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Green;
            this.bntLuu.FlatAppearance.BorderSize = 0;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLuu.ForeColor = System.Drawing.Color.White;
            this.bntLuu.Location = new System.Drawing.Point(356, 278);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(79, 48);
            this.bntLuu.TabIndex = 2;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thể Loại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(700, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTheLoai";
            this.Text = "frmTheLoai";
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntNhapMoi;
    }
}