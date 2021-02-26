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
        private void frm_RPHoaDon_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        void loadDL()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string getDS = "rp_HoaDon";
            //string getDS = query;
            cmd = new SqlCommand(getDS, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            Report.RpHoaDon rp = new Report.RpHoaDon();
            rp.SetDataSource(data);
            CRHoaDon.ReportSource = rp;
            conn.Close();
        }

        private void btnlaydulieu_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string getDSTheoNgay = "select tbl_HoaDon.idHoaDon, tbl_NhanVien.idNhanVien, tbl_NhanVien.sTenNV, tbl_ChauCay.sTenChau,tbl_ChiTietHoaDon.fDonGia, tbl_ChiTietHoaDon.sSoLuong, (tbl_ChiTietHoaDon.fDonGia * tbl_ChiTietHoaDon.sSoLuong) as thanh_tien, tbl_HoaDon.Createdate, sum(tbl_ChiTietHoaDon.fDonGia * tbl_ChiTietHoaDon.sSoLuong) as tong_tien from tbl_HoaDon inner join tbl_NhanVien on tbl_HoaDon.idNhanVien = tbl_NhanVien.idNhanVien inner join tbl_ChiTietHoaDon on tbl_HoaDon.idHoaDon = tbl_ChiTietHoaDon.idHoaDon inner join tbl_ChauCay on tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau where tbl_HoaDon.Createdate between'" + dt1.Value.ToString("dd/MM/yyyy") + "' and '"+ dt2.Value.ToString("dd/MM/yyyy") + "' group by tbl_HoaDon.idHoaDon,tbl_NhanVien.idNhanVien, tbl_NhanVien.sTenNV, tbl_ChauCay.sTenChau,tbl_ChiTietHoaDon.fDonGia, tbl_ChiTietHoaDon.sSoLuong,tbl_HoaDon.Createdate order by tbl_HoaDon.Createdate desc";
                SqlCommand cmd1 = new SqlCommand(getDSTheoNgay, conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable data1 = new DataTable();
                adapter.Fill(data1);
                Report.RpHoaDon rp = new Report.RpHoaDon();
                rp.SetDataSource(data1);
                CRHoaDon.ReportSource = rp;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
