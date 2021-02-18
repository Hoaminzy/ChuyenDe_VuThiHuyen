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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        SqlCommand cmd1;
        SqlDataAdapter a;
        DataTable data1 = new DataTable();

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dghoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCthoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    LoadHoaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }

            }

            this.Refresh();
        }
        public class hoadon
        {
            static public string maHD;
        }
        void LoadHoaDon()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string getHD = "sp_ThemHD";
            cmd = new SqlCommand(getHD, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            dghoadon.DataSource = data;

        }

        private void dghoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dghoadon.CurrentRow.Index;
            try
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string query = "select tbl_ChiTietHoaDon.idChau, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong, tbl_ChiTietHoaDon.fDonGia,(tbl_ChiTietHoaDon.sSoLuong*tbl_ChiTietHoaDon.fDonGia) as thanh_tien  from tbl_ChiTietHoaDon,tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau and  tbl_ChiTietHoaDon.idHoaDon = '" + dghoadon.Rows[i].Cells[0].Value.ToString() + "'";
                cmd1 = new SqlCommand(query, conn);
                a = new SqlDataAdapter(cmd1);
                data1 = new DataTable();
                a.Fill(data1);
                dgCthoadon.DataSource = data1;
                hoadon.maHD = dgCthoadon.Rows[i].Cells[0].Value.ToString();
                conn.Close();
            }
            catch (SqlException sql)
            {
                MessageBox.Show("" + sql.Message);
            }
        }
        private void dgCthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.ShowDialog();
            this.Show();
            LoadHoaDon();
        }
        private void stripkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void stripchaucay_Click(object sender, EventArgs e)
        {
            frmChau kh = new frmChau();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void striploaichaucay_Click(object sender, EventArgs e)
        {
            frmLoaiChau kh = new frmLoaiChau();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void striptaotaikhoan_Click(object sender, EventArgs e)
        {
            frmNhanVien kh = new frmNhanVien();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void stripdangxuat_Click(object sender, EventArgs e)
        {
            frmDangNhap kh = new frmDangNhap();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void striphoadon_Click(object sender, EventArgs e)
        {
            HoaDon kh = new HoaDon();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void stripthongtintaikhoan_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan tk = new frmThongTinTaiKhoan();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }
    }
}
