
namespace QLChauCay
{
    partial class frm_RpChauCay
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
            this.txtloaichau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CRChau = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(144, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(250, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO CHÂU CÂY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndong);
            this.panel2.Controls.Add(this.btnlaydulieu);
            this.panel2.Controls.Add(this.txtloaichau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(144, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 49);
            this.panel2.TabIndex = 1;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(551, 12);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnlaydulieu
            // 
            this.btnlaydulieu.Location = new System.Drawing.Point(432, 12);
            this.btnlaydulieu.Name = "btnlaydulieu";
            this.btnlaydulieu.Size = new System.Drawing.Size(89, 23);
            this.btnlaydulieu.TabIndex = 2;
            this.btnlaydulieu.Text = "Lấy dữ liệu";
            this.btnlaydulieu.UseVisualStyleBackColor = true;
            // 
            // txtloaichau
            // 
            this.txtloaichau.FormattingEnabled = true;
            this.txtloaichau.Location = new System.Drawing.Point(257, 14);
            this.txtloaichau.Name = "txtloaichau";
            this.txtloaichau.Size = new System.Drawing.Size(154, 21);
            this.txtloaichau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Chậu: ";
            // 
            // CRChau
            // 
            this.CRChau.ActiveViewIndex = -1;
            this.CRChau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRChau.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRChau.Location = new System.Drawing.Point(0, 126);
            this.CRChau.Name = "CRChau";
            this.CRChau.Size = new System.Drawing.Size(1074, 455);
            this.CRChau.TabIndex = 2;
            this.CRChau.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_RpChauCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 583);
            this.Controls.Add(this.CRChau);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_RpChauCay";
            this.Text = "Báo Cáo Châu Cây";
            this.Load += new System.EventHandler(this.frm_RpChauCay_Load);
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
        private System.Windows.Forms.ComboBox txtloaichau;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRChau;
    }
}