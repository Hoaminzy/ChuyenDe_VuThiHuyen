
namespace QLChauCay
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.drdskhachhang = new System.Windows.Forms.DataGridView();
            this.idKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drdskhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drdskhachhang
            // 
            this.drdskhachhang.AutoGenerateColumns = false;
            this.drdskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drdskhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKhachHang,
            this.sTenKH,
            this.sDiaChi,
            this.sCMND,
            this.sGioiTinh,
            this.sSDT,
            this.sNgaySinh});
            this.drdskhachhang.DataSource = this.tblKhachHangBindingSource;
            this.drdskhachhang.Location = new System.Drawing.Point(47, 308);
            this.drdskhachhang.Name = "drdskhachhang";
            this.drdskhachhang.Size = new System.Drawing.Size(948, 204);
            this.drdskhachhang.TabIndex = 9;
            this.drdskhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drdskhachhang_CellContentClick);
            // 
            // idKhachHang
            // 
            this.idKhachHang.DataPropertyName = "idKhachHang";
            this.idKhachHang.HeaderText = "Mã Khách Hàng";
            this.idKhachHang.Name = "idKhachHang";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenKH";
            this.sTenKH.HeaderText = "Tên Khách Hàng";
            this.sTenKH.Name = "sTenKH";
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
            this.sSDT.HeaderText = "SĐT";
            this.sSDT.Name = "sSDT";
            // 
            // sNgaySinh
            // 
            this.sNgaySinh.DataPropertyName = "sNgaySinh";
            this.sNgaySinh.HeaderText = "Ngày Sinh";
            this.sNgaySinh.Name = "sNgaySinh";
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tbl_KhachHang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndong);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthemmoi);
            this.groupBox2.Location = new System.Drawing.Point(652, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 228);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(276, 176);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 31);
            this.btndong.TabIndex = 6;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(276, 126);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 33);
            this.btntimkiem.TabIndex = 5;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(16, 127);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttimkiem.Size = new System.Drawing.Size(261, 30);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(287, 31);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 60);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(105, 31);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(64, 60);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(194, 31);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(64, 60);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Cập Nhật";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.BackColor = System.Drawing.Color.Lime;
            this.btnthemmoi.Location = new System.Drawing.Point(16, 31);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(64, 60);
            this.btnthemmoi.TabIndex = 0;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.UseVisualStyleBackColor = false;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnu);
            this.groupBox1.Controls.Add(this.rdnam);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Location = new System.Drawing.Point(47, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Checked = true;
            this.rdnu.Location = new System.Drawing.Point(175, 112);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 34;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(97, 111);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 33;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(334, 112);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(153, 20);
            this.txtdiachi.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CMND";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(334, 29);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(153, 20);
            this.txtsdt.TabIndex = 6;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(95, 143);
            this.txtcmnd.Multiline = true;
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(142, 20);
            this.txtcmnd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số Điện Thoại";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(97, 68);
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
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(334, 71);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(153, 20);
            this.dtngaysinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
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
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(97, 25);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(140, 20);
            this.txtma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(358, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 547);
            this.Controls.Add(this.drdskhachhang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "DANH SÁC KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drdskhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drdskhachhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaySinh;
    }
}