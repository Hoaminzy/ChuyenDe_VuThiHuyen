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
    public partial class frm_RpChauCay : Form
    {
        public frm_RpChauCay()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_RpChauCay_Load(object sender, EventArgs e)
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
            string getDS = "Rp_Chau";
            //string getDS = query;
            cmd = new SqlCommand(getDS, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            Report.RpChauCay rp = new Report.RpChauCay();
            rp.SetDataSource(data);
            CRChau.ReportSource = rp;
            conn.Close();
        }

    }
}
