
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
            this.CRHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RpHoaDon1 = new QLChauCay.Report.RpHoaDon();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbmahd = new System.Windows.Forms.TextBox();
            this.btlaydulieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // CRHoaDon
            // 
            this.CRHoaDon.ActiveViewIndex = -1;
            this.CRHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRHoaDon.Location = new System.Drawing.Point(3, 124);
            this.CRHoaDon.Name = "CRHoaDon";
            this.CRHoaDon.Size = new System.Drawing.Size(1036, 488);
            this.CRHoaDon.TabIndex = 2;
            this.CRHoaDon.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbmahd);
            this.panel2.Controls.Add(this.btlaydulieu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(139, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 47);
            this.panel2.TabIndex = 3;
            // 
            // cbbmahd
            // 
            this.cbbmahd.Location = new System.Drawing.Point(245, 12);
            this.cbbmahd.Name = "cbbmahd";
            this.cbbmahd.ReadOnly = true;
            this.cbbmahd.Size = new System.Drawing.Size(100, 20);
            this.cbbmahd.TabIndex = 3;
            // 
            // btlaydulieu
            // 
            this.btlaydulieu.Location = new System.Drawing.Point(372, 12);
            this.btlaydulieu.Name = "btlaydulieu";
            this.btlaydulieu.Size = new System.Drawing.Size(75, 23);
            this.btlaydulieu.TabIndex = 2;
            this.btlaydulieu.Text = "Đóng";
            this.btlaydulieu.UseVisualStyleBackColor = true;
            this.btlaydulieu.Click += new System.EventHandler(this.btlaydulieu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // frm_RPHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CRHoaDon);
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRHoaDon;
        private Report.RpHoaDon RpHoaDon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btlaydulieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cbbmahd;
    }
}