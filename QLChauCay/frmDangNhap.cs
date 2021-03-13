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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand cmd;
        public class dangnhap
        {
            static public string tendangnhap;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from tbl_NhanVien where Username = '" + txttaikhoan.Text + "' and Password = '" + txtmatkhau.Text + "'";
                    cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@tendn", txtTenDn.Text);
                    //cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        //MessageBox.Show("Đăng nhập thành công!");
                        dangnhap.tendangnhap = txttaikhoan.Text;
                        frmMain f = new frmMain();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                        MessageBox.Show("Đăng nhập thất bại");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void mahoaMK(string pass)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            //MessageBox.Show(sb.ToString());
            //pass = sb.ToString();
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa trong "X2" thành "x"
        }

    }
}
