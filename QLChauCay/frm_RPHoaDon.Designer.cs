
namespace QLChauCay
{
    partial class frm_RPHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndong = new System.Windows.Forms.Button();
            this.btnlaydulieu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.CRHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RpHoaDon1 = new QLChauCay.Report.RpHoaDon();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(405, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndong);
            this.panel2.Controls.Add(this.btnlaydulieu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dt2);
            this.panel2.Controls.Add(this.dt1);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 47);
            this.panel2.TabIndex = 1;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(791, 9);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(77, 23);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnlaydulieu
            // 
            this.btnlaydulieu.Location = new System.Drawing.Point(643, 9);
            this.btnlaydulieu.Name = "btnlaydulieu";
            this.btnlaydulieu.Size = new System.Drawing.Size(115, 23);
            this.btnlaydulieu.TabIndex = 4;
            this.btnlaydulieu.Text = "Lấy dữ liệu";
            this.btnlaydulieu.UseVisualStyleBackColor = true;
            this.btnlaydulieu.Click += new System.EventHandler(this.btnlaydulieu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày: ";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "dd/MM/yyyy";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(491, 12);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(123, 20);
            this.dt2.TabIndex = 1;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "dd/MM/yyyy";
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(271, 12);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(123, 20);
            this.dt1.TabIndex = 0;
            // 
            // CRHoaDon
            // 
            this.CRHoaDon.ActiveViewIndex = -1;
            this.CRHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRHoaDon.Location = new System.Drawing.Point(3, 124);
            this.CRHoaDon.Name = "CRHoaDon";
            this.CRHoaDon.Size = new System.Drawing.Size(1036, 458);
            this.CRHoaDon.TabIndex = 2;
            this.CRHoaDon.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_RPHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.CRHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_RPHoaDon";
            this.Text = "frm_RPHoaDon";
            this.Load += new System.EventHandler(this.frm_RPHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnlaydulieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRHoaDon;
        private Report.RpHoaDon RpHoaDon1;
    }
}