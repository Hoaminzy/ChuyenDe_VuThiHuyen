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
    public partial class frm_RpNhanVien : Form
    {
        public frm_RpNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        private void frm_RpNhanVien_Load(object sender, EventArgs e)
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
            string getDS = "rp_NhanVien";
            //string getDS = query;
            cmd = new SqlCommand(getDS, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            Report.RpNhanVien rp = new Report.RpNhanVien();
            rp.SetDataSource(data);
            CRNhanVien.ReportSource = rp;
            conn.Close();
        }
    }
}
