
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
            this.CRChau = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
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
            // CRChau
            // 
            this.CRChau.ActiveViewIndex = -1;
            this.CRChau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRChau.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRChau.Location = new System.Drawing.Point(0, 71);
            this.CRChau.Name = "CRChau";
            this.CRChau.Size = new System.Drawing.Size(1074, 510);
            this.CRChau.TabIndex = 2;
            this.CRChau.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_RpChauCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 583);
            this.Controls.Add(this.CRChau);
            this.Controls.Add(this.panel1);
            this.Name = "frm_RpChauCay";
            this.Text = "Báo Cáo Châu Cây";
            this.Load += new System.EventHandler(this.frm_RpChauCay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRChau;
    }
}