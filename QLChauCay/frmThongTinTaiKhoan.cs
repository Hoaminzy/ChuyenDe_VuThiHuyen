using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChauCay
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            lbtk.Text = frmDangNhap.dangnhap.tendangnhap;
            string query = "select * from tbl_NhanVien where Username='" + lbtk.Text + "'";
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    SqlDataAdapter a = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    lbtk.DataBindings.Add("Text", dt, "Username");
                    lbpass.DataBindings.Add("Text", dt, "Password");
                    lbten.DataBindings.Add("Text", dt, "sTenNV");
                    lbgt.DataBindings.Add("Text", dt, "sGioiTinh");
                    lbcmnd.DataBindings.Add("Text", dt, "sCMND");
                    lbsdt.DataBindings.Add("Text", dt, "sSDT");
                    lbns.DataBindings.Add("Text", dt, "sNgaySinh");
                    lbdc.DataBindings.Add("Text", dt, "sDiaChi");
                    lbngaytao.DataBindings.Add("Text", dt, "Createdate");
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
            if (lbgt.Text == "0")
            {
                lbgt.Text = "Nữ";
            }
            else if (lbgt.Text == "1")
                lbgt.Text = "Nam";
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(lbpass.Text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            //MessageBox.Show(sb.ToString());
            lbpass.Text = sb.ToString();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin ad = new frmCapNhatThongTin();
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }
    }
}
