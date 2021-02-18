
namespace QLChauCay
{
    partial class frmLoaiChau
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaytao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtloaichau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgdsloaichau = new System.Windows.Forms.DataGridView();
            this.tblLoaiChauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLChauCayDataSet = new QLChauCay.QLChauCayDataSet();
            this.btndong = new System.Windows.Forms.Button();
            this.tbl_LoaiChauTableAdapter = new QLChauCay.QLChauCayDataSetTableAdapters.tbl_LoaiChauTableAdapter();
            this.cbbstatus = new System.Windows.Forms.ComboBox();
            this.idLoaiChauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdsloaichau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoaiChauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChauCayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(261, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LOẠI CHẬU CÂY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbstatus);
            this.groupBox1.Controls.Add(this.dtngaytao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtloaichau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaloai);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtngaytao
            // 
            this.dtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaytao.Location = new System.Drawing.Point(328, 103);
            this.dtngaytao.Name = "dtngaytao";
            this.dtngaytao.Size = new System.Drawing.Size(141, 20);
            this.dtngaytao.TabIndex = 7;
            this.dtngaytao.Value = new System.DateTime(2021, 2, 11, 6, 33, 23, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái";
            // 
            // txtloaichau
            // 
            this.txtloaichau.Location = new System.Drawing.Point(85, 103);
            this.txtloaichau.Multiline = true;
            this.txtloaichau.Name = "txtloaichau";
            this.txtloaichau.Size = new System.Drawing.Size(140, 20);
            this.txtloaichau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Chậu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Loại Chậu";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(85, 38);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(140, 20);
            this.txtmaloai.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnthemmoi);
            this.groupBox2.Location = new System.Drawing.Point(538, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
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
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(287, 31);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 60);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(199, 31);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(64, 60);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Chỉnh Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(109, 31);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(64, 60);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgdsloaichau);
            this.groupBox3.Location = new System.Drawing.Point(21, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 251);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách loại chậu";
            // 
            // dgdsloaichau
            // 
            this.dgdsloaichau.AutoGenerateColumns = false;
            this.dgdsloaichau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdsloaichau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoaiChauDataGridViewTextBoxColumn,
            this.sTenLoaiDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.createdateDataGridViewTextBoxColumn});
            this.dgdsloaichau.DataSource = this.tblLoaiChauBindingSource;
            this.dgdsloaichau.Location = new System.Drawing.Point(31, 29);
            this.dgdsloaichau.Name = "dgdsloaichau";
            this.dgdsloaichau.Size = new System.Drawing.Size(806, 205);
            this.dgdsloaichau.TabIndex = 0;
            this.dgdsloaichau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdsloaichau_CellContentClick);
            // 
            // tblLoaiChauBindingSource
            // 
            this.tblLoaiChauBindingSource.DataMember = "tbl_LoaiChau";
            this.tblLoaiChauBindingSource.DataSource = this.qLChauCayDataSet;
            // 
            // qLChauCayDataSet
            // 
            this.qLChauCayDataSet.DataSetName = "QLChauCayDataSet";
            this.qLChauCayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(770, 495);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(88, 40);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // tbl_LoaiChauTableAdapter
            // 
            this.tbl_LoaiChauTableAdapter.ClearBeforeFill = true;
            // 
            // cbbstatus
            // 
            this.cbbstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbstatus.FormattingEnabled = true;
            this.cbbstatus.Items.AddRange(new object[] {
            "Hoạt Động",
            "Khóa"});
            this.cbbstatus.Location = new System.Drawing.Point(328, 35);
            this.cbbstatus.Name = "cbbstatus";
            this.cbbstatus.Size = new System.Drawing.Size(141, 21);
            this.cbbstatus.TabIndex = 8;
            // 
            // idLoaiChauDataGridViewTextBoxColumn
            // 
            this.idLoaiChauDataGridViewTextBoxColumn.DataPropertyName = "idLoaiChau";
            this.idLoaiChauDataGridViewTextBoxColumn.HeaderText = "Mã Loại Chậu";
            this.idLoaiChauDataGridViewTextBoxColumn.Name = "idLoaiChauDataGridViewTextBoxColumn";
            this.idLoaiChauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTenLoaiDataGridViewTextBoxColumn
            // 
            this.sTenLoaiDataGridViewTextBoxColumn.DataPropertyName = "sTenLoai";
            this.sTenLoaiDataGridViewTextBoxColumn.HeaderText = "Loại Chậu";
            this.sTenLoaiDataGridViewTextBoxColumn.Name = "sTenLoaiDataGridViewTextBoxColumn";
            this.sTenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Trạng Thái";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "Createdate";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmLoaiChau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 546);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiChau";
            this.Text = "Loại Chậu Cây";
            this.Load += new System.EventHandler(this.frmLoaiChau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdsloaichau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoaiChauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChauCayDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.DateTimePicker dtngaytao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtloaichau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgdsloaichau;
        private System.Windows.Forms.Button btndong;
        private QLChauCayDataSet qLChauCayDataSet;
        private System.Windows.Forms.BindingSource tblLoaiChauBindingSource;
        private QLChauCayDataSetTableAdapters.tbl_LoaiChauTableAdapter tbl_LoaiChauTableAdapter;
        private System.Windows.Forms.ComboBox cbbstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoaiChauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
    }
}