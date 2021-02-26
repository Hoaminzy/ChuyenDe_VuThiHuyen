
namespace QLChauCay
{
    partial class frm_RpNhanVien
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
            this.CRNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btndong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(132, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(201, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN";
            // 
            // CRNhanVien
            // 
            this.CRNhanVien.ActiveViewIndex = -1;
            this.CRNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRNhanVien.Location = new System.Drawing.Point(-1, 73);
            this.CRNhanVien.Name = "CRNhanVien";
            this.CRNhanVien.Size = new System.Drawing.Size(1063, 449);
            this.CRNhanVien.TabIndex = 1;
            this.CRNhanVien.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(925, 528);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 32);
            this.btndong.TabIndex = 2;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // frm_RpNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 563);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.CRNhanVien);
            this.Controls.Add(this.panel1);
            this.Name = "frm_RpNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frm_RpNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRNhanVien;
        private System.Windows.Forms.Button btndong;
    }
}