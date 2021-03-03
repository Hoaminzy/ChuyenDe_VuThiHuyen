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
    public partial class frm_DoanhSo : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        public frm_DoanhSo()
        {
            InitializeComponent();
        }

        public void loadDL()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string getDS = "Rp_DS";
            //sring getDS = "SELECT hoadon.ngay_xuat, hoadon.ma_hd, nhanvien.ten_nv, SUM(cthoadon.sl_xuat) AS tong_sl, SUM(cthoadon.sl_xuat * cthoadon.dg_xuat) AS tong_tien FROM cthoadon INNER JOIN hoadon ON cthoadon.ma_hd = hoadon.ma_hd INNER JOIN nhanvien ON hoadon.ma_nv = nhanvien.ma_nv GROUP BY hoadon.ngay_xuat, hoadon.ma_hd, nhanvien.ten_nv";
            cmd = new SqlCommand(getDS, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            Report.RP_HoaDonDS rp = new Report.RP_HoaDonDS();
            rp.SetDataSource(data);
            rpDs.ReportSource = rp;
            conn.Close();
        }

        private void rpDs_Load(object sender, EventArgs e)
        {
            loadDL();
        }
    }
}
