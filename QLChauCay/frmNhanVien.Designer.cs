
namespace QLChauCay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.drdsnhanvien = new System.Windows.Forms.DataGridView();
            this.idNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drdsnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(322, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndong);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthemmoi);
            this.groupBox2.Location = new System.Drawing.Point(616, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(276, 155);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 36);
            this.btndong.TabIndex = 6;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(276, 99);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 33);
            this.btntimkiem.TabIndex = 5;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(16, 100);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttimkiem.Size = new System.Drawing.Size(261, 30);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(287, 31);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(64, 60);
            this.btnhuy.TabIndex = 3;
            this.btnhuy.Text = "Xóa";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(106, 31);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(64, 60);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(199, 31);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(64, 60);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Chỉnh Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Location = new System.Drawing.Point(16, 31);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(64, 60);
            this.btnthemmoi.TabIndex = 0;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txttaikhoan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(11, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdnu);
            this.panel1.Controls.Add(this.rdnam);
            this.panel1.Location = new System.Drawing.Point(328, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 46);
            this.panel1.TabIndex = 30;
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(79, 12);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 1;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(3, 12);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 0;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(85, 152);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(140, 20);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(85, 112);
            this.txttaikhoan.Multiline = true;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(140, 20);
            this.txttaikhoan.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mật Khẩu";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(85, 188);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(140, 20);
            this.txtdiachi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tên Tài Khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CMND";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(328, 152);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(153, 20);
            this.txtsdt.TabIndex = 6;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(328, 117);
            this.txtcmnd.Multiline = true;
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(153, 20);
            this.txtcmnd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số Điện Thoại";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(85, 71);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(140, 20);
            this.txtten.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(328, 78);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(153, 20);
            this.dtngaysinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(85, 28);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(140, 20);
            this.txtma.TabIndex = 0;
            // 
            // drdsnhanvien
            // 
            this.drdsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drdsnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNhanVien,
            this.sTenNV,
            this.sDiaChi,
            this.sCMND,
            this.sGioiTinh,
            this.sSDT,
            this.sNgaySinh,
            this.Username,
            this.Password});
            this.drdsnhanvien.Location = new System.Drawing.Point(19, 323);
            this.drdsnhanvien.Name = "drdsnhanvien";
            this.drdsnhanvien.Size = new System.Drawing.Size(948, 205);
            this.drdsnhanvien.TabIndex = 5;
            this.drdsnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drdsnhanvien_CellContentClick);
            // 
            // idNhanVien
            // 
            this.idNhanVien.DataPropertyName = "idNhanVien";
            this.idNhanVien.HeaderText = "Mã Nhân Viên";
            this.idNhanVien.Name = "idNhanVien";
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "Tên Nhân Viên";
            this.sTenNV.Name = "sTenNV";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa Chỉ";
            this.sDiaChi.Name = "sDiaChi";
            // 
            // sCMND
            // 
            this.sCMND.DataPropertyName = "sCMND";
            this.sCMND.HeaderText = "CMND";
            this.sCMND.Name = "sCMND";
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới Tính";
            this.sGioiTinh.Name = "sGioiTinh";
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số Điện Thoại";
            this.sSDT.Name = "sSDT";
            // 
            // sNgaySinh
            // 
            this.sNgaySinh.DataPropertyName = "sNgaySinh";
            this.sNgaySinh.HeaderText = "Ngày Sinh";
            this.sNgaySinh.Name = "sNgaySinh";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên Tài Khoản";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật Khẩu";
            this.Password.Name = "Password";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 540);
            this.Controls.Add(this.drdsnhanvien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drdsnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView drdsnhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}