
namespace QLChauCay
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripthongtintaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.striptaotaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.stripdangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.strip = new System.Windows.Forms.ToolStripMenuItem();
            this.striploaichaucay = new System.Windows.Forms.ToolStripMenuItem();
            this.stripchaucay = new System.Windows.Forms.ToolStripMenuItem();
            this.striphoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.stripkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.stripthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoChauCay = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.stripthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbanhang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dghoadon = new System.Windows.Forms.DataGridView();
            this.grbchitiet = new System.Windows.Forms.GroupBox();
            this.dgCthoadon = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghoadon)).BeginInit();
            this.grbchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCthoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.strip,
            this.striphoadon,
            this.stripkhachhang,
            this.stripthongke,
            this.stripthoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripthongtintaikhoan,
            this.striptaotaikhoan,
            this.stripdangxuat});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.trangChủToolStripMenuItem.Text = "Tài khoản";
            // 
            // stripthongtintaikhoan
            // 
            this.stripthongtintaikhoan.Name = "stripthongtintaikhoan";
            this.stripthongtintaikhoan.Size = new System.Drawing.Size(178, 22);
            this.stripthongtintaikhoan.Text = "Thông tin tài khoản";
            this.stripthongtintaikhoan.Click += new System.EventHandler(this.stripthongtintaikhoan_Click);
            // 
            // striptaotaikhoan
            // 
            this.striptaotaikhoan.Name = "striptaotaikhoan";
            this.striptaotaikhoan.Size = new System.Drawing.Size(178, 22);
            this.striptaotaikhoan.Text = "Nhân Viên";
            this.striptaotaikhoan.Click += new System.EventHandler(this.striptaotaikhoan_Click);
            // 
            // stripdangxuat
            // 
            this.stripdangxuat.Name = "stripdangxuat";
            this.stripdangxuat.Size = new System.Drawing.Size(178, 22);
            this.stripdangxuat.Text = "Đăng xuất";
            this.stripdangxuat.Click += new System.EventHandler(this.stripdangxuat_Click);
            // 
            // strip
            // 
            this.strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.striploaichaucay,
            this.stripchaucay});
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(77, 20);
            this.strip.Text = "Danh mục ";
            // 
            // striploaichaucay
            // 
            this.striploaichaucay.Name = "striploaichaucay";
            this.striploaichaucay.Size = new System.Drawing.Size(150, 22);
            this.striploaichaucay.Text = "Loại Chậu Cây";
            this.striploaichaucay.Click += new System.EventHandler(this.striploaichaucay_Click);
            // 
            // stripchaucay
            // 
            this.stripchaucay.Name = "stripchaucay";
            this.stripchaucay.Size = new System.Drawing.Size(150, 22);
            this.stripchaucay.Text = "Chậu Cây";
            this.stripchaucay.Click += new System.EventHandler(this.stripchaucay_Click);
            // 
            // striphoadon
            // 
            this.striphoadon.Name = "striphoadon";
            this.striphoadon.Size = new System.Drawing.Size(65, 20);
            this.striphoadon.Text = "Hóa đơn";
            this.striphoadon.Click += new System.EventHandler(this.striphoadon_Click);
            // 
            // stripkhachhang
            // 
            this.stripkhachhang.Name = "stripkhachhang";
            this.stripkhachhang.Size = new System.Drawing.Size(84, 20);
            this.stripkhachhang.Text = "Khách Hàng";
            this.stripkhachhang.Click += new System.EventHandler(this.stripkhachhang_Click);
            // 
            // stripthongke
            // 
            this.stripthongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoHoaDon,
            this.baoCaoChauCay,
            this.baoCaoNhanVien});
            this.stripthongke.Name = "stripthongke";
            this.stripthongke.Size = new System.Drawing.Size(70, 20);
            this.stripthongke.Text = "Thống Kê";
            // 
            // baoCaoHoaDon
            // 
            this.baoCaoHoaDon.Name = "baoCaoHoaDon";
            this.baoCaoHoaDon.Size = new System.Drawing.Size(180, 22);
            this.baoCaoHoaDon.Text = "Doanh Số";
            this.baoCaoHoaDon.Click += new System.EventHandler(this.baoCaoHoaDon_Click);
            // 
            // baoCaoChauCay
            // 
            this.baoCaoChauCay.Name = "baoCaoChauCay";
            this.baoCaoChauCay.Size = new System.Drawing.Size(180, 22);
            this.baoCaoChauCay.Text = "Chậu Cây";
            this.baoCaoChauCay.Click += new System.EventHandler(this.baoCaoChauCay_Click);
            // 
            // baoCaoNhanVien
            // 
            this.baoCaoNhanVien.Name = "baoCaoNhanVien";
            this.baoCaoNhanVien.Size = new System.Drawing.Size(180, 22);
            this.baoCaoNhanVien.Text = "Nhân Viên";
            this.baoCaoNhanVien.Click += new System.EventHandler(this.baoCaoNhanVien_Click);
            // 
            // stripthoat
            // 
            this.stripthoat.Name = "stripthoat";
            this.stripthoat.Size = new System.Drawing.Size(50, 20);
            this.stripthoat.Text = "Thoát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(496, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbanhang);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnbanhang
            // 
            this.btnbanhang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanhang.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnbanhang.Location = new System.Drawing.Point(41, 35);
            this.btnbanhang.Name = "btnbanhang";
            this.btnbanhang.Size = new System.Drawing.Size(96, 39);
            this.btnbanhang.TabIndex = 0;
            this.btnbanhang.Text = "Bán Hàng";
            this.btnbanhang.UseVisualStyleBackColor = false;
            this.btnbanhang.UseWaitCursor = true;
            this.btnbanhang.Click += new System.EventHandler(this.btnbanhang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dghoadon);
            this.groupBox2.Location = new System.Drawing.Point(220, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            this.groupBox2.UseWaitCursor = true;
            // 
            // dghoadon
            // 
            this.dghoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghoadon.Location = new System.Drawing.Point(21, 31);
            this.dghoadon.Name = "dghoadon";
            this.dghoadon.Size = new System.Drawing.Size(806, 202);
            this.dghoadon.TabIndex = 0;
            this.dghoadon.UseWaitCursor = true;
            this.dghoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghoadon_CellContentClick);
            // 
            // grbchitiet
            // 
            this.grbchitiet.Controls.Add(this.dgCthoadon);
            this.grbchitiet.Location = new System.Drawing.Point(220, 337);
            this.grbchitiet.Name = "grbchitiet";
            this.grbchitiet.Size = new System.Drawing.Size(844, 189);
            this.grbchitiet.TabIndex = 3;
            this.grbchitiet.TabStop = false;
            this.grbchitiet.Text = "Hóa Đơn Chi Tiết";
            this.grbchitiet.UseWaitCursor = true;
            // 
            // dgCthoadon
            // 
            this.dgCthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCthoadon.Location = new System.Drawing.Point(21, 29);
            this.dgCthoadon.Name = "dgCthoadon";
            this.dgCthoadon.Size = new System.Drawing.Size(806, 147);
            this.dgCthoadon.TabIndex = 0;
            this.dgCthoadon.UseWaitCursor = true;
            this.dgCthoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCthoadon_CellContentClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 534);
            this.Controls.Add(this.grbchitiet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ BÁN CHẬU CÂY";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dghoadon)).EndInit();
            this.grbchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCthoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripthongtintaikhoan;
        private System.Windows.Forms.ToolStripMenuItem striptaotaikhoan;
        private System.Windows.Forms.ToolStripMenuItem stripdangxuat;
        private System.Windows.Forms.ToolStripMenuItem strip;
        private System.Windows.Forms.ToolStripMenuItem striphoadon;
        private System.Windows.Forms.ToolStripMenuItem stripkhachhang;
        private System.Windows.Forms.ToolStripMenuItem stripthongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbanhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dghoadon;
        private System.Windows.Forms.GroupBox grbchitiet;
        private System.Windows.Forms.DataGridView dgCthoadon;
        private System.Windows.Forms.ToolStripMenuItem stripthoat;
        private System.Windows.Forms.ToolStripMenuItem striploaichaucay;
        private System.Windows.Forms.ToolStripMenuItem stripchaucay;
        private System.Windows.Forms.ToolStripMenuItem baoCaoHoaDon;
        private System.Windows.Forms.ToolStripMenuItem baoCaoChauCay;
        private System.Windows.Forms.ToolStripMenuItem baoCaoNhanVien;
    }
}

