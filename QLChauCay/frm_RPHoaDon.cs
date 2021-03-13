using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChauCay
{
    public partial class frm_RPHoaDon : Form
    {
        public frm_RPHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        private void fInHoaDon_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            cbbmahd.Text = HoaDon.ChiTietHoaDon.maInHD;
        }

        void inHoaDon()
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    string getDS = "SELECT tbl_HoaDon.idHoaDon, tbl_NhanVien.idNhanVien, tbl_NhanVien.sTenNV, tbl_HoaDon.Createdate, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong, tbl_ChiTietHoaDon.fDonGia, tbl_ChiTietHoaDon.sSoLuong * tbl_ChiTietHoaDon.fDonGia AS thanh_tien FROM tbl_ChiTietHoaDon INNER JOIN tbl_ChauCay ON tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau INNER JOIN tbl_HoaDon ON tbl_ChiTietHoaDon.idHoaDon = tbl_HoaDon.idHoaDon INNER JOIN tbl_NhanVien ON tbl_HoaDon.idNhanVien = tbl_NhanVien.idNhanVien where tbl_HoaDon.idHoaDon = '" + HoaDon.ChiTietHoaDon.maInHD + "'";
                    //string getDS = query;
                    SqlCommand cmd = new SqlCommand(getDS, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    Report.RpInHoaDonBH rp = new Report.RpInHoaDonBH();
                    rp.SetDataSource(data);
                    CRHoaDon.ReportSource = rp;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }


        }
    
    
        private void CRHoaDon_Load(object sender, EventArgs e)
        {
            inHoaDon();
        }

        private void btlaydulieu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
