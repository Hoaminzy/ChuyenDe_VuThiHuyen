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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            drdsnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    load();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối." + ex.Message);
                }

                //conn.Close();
            }

            clockText();
            btnthemmoi.Enabled = true;
            btnsua.Enabled = false;
            btnsua.Enabled = false;
        }
        void clockText()
        {
            txtma.ReadOnly = true;
            txtten.Enabled = false;
            txttaikhoan.Enabled = false;
            txtmatkhau.Enabled = false;
            txtcmnd.Enabled = false;
            txtdiachi.Enabled = false;
            rdnam.Enabled = false;
            rdnu.Enabled = false;
            txtsdt.Enabled = false;
            dtngaysinh.Enabled = false;
        }

        void UnclockText()
        {
            txtma.ReadOnly = true;
            txtten.Enabled = true;
            txttaikhoan.Enabled = true;
            txtmatkhau.Enabled = true;
            txtcmnd.Enabled = true;
            txtdiachi.Enabled = true;
            rdnam.Enabled = true;
            rdnu.Enabled = true;
            txtsdt.Enabled = true;
            dtngaysinh.Enabled = true;
        }
        void reset()
        {
            txtma.Clear();
            txtten.Clear();
            txtdiachi.Clear();
            txtcmnd.ResetText();
            txtsdt.Clear();
            dtngaysinh.Text = DateTime.Now.ToString();
        }
        private void load()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select_AllNV";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            drdsnhanvien.DataSource = data;
            conn.Close();
        }
        public bool kiemtra(string Username)
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select Username from tbl_NhanVien where Username = '" + txttaikhoan + "'";
            cmd = new SqlCommand(query, conn);
            //cmd.Parameters.Contains(ten);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)// đã tồn tại nhà cung cấp
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        private void drdsnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnclockText();
            int i = drdsnhanvien.CurrentRow.Index;
            txtma.Text = drdsnhanvien.Rows[i].Cells[0].Value.ToString();
            txtten.Text = drdsnhanvien.Rows[i].Cells[1].Value.ToString();
           
            txtdiachi.Text = drdsnhanvien.Rows[i].Cells[2].Value.ToString();
            txtcmnd.Text = drdsnhanvien.Rows[i].Cells[3].Value.ToString();
            if (drdsnhanvien.Rows[i].Cells[4].Value.ToString() == "1")
                rdnam.Checked = true;
            else rdnu.Checked = true;
            txtsdt.Text = drdsnhanvien.Rows[i].Cells[5].Value.ToString();
           
          
            dtngaysinh.Text = drdsnhanvien.Rows[i].Cells[6].Value.ToString();
            txttaikhoan.Text = drdsnhanvien.Rows[i].Cells[7].Value.ToString();
            string mahoa = drdsnhanvien.Rows[i].Cells[8].Value.ToString();
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mahoa);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i1 = 0; i1 < hash.Length; i1++)
            {
                sb.Append(hash[i1].ToString("X2"));
            }
            //MessageBox.Show(sb.ToString());
            txtmatkhau.Text = sb.ToString();


            btnthemmoi.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = true;
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            reset();
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnthemmoi.Enabled = true;
            UnclockText();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtten.Text != "" && txtsdt.Text != "" && txttaikhoan.Text != "" && txtmatkhau.Text !="")
                    {
                        if(kiemtra(txttaikhoan.Text) == true)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại.");
                        }
                        else
                        {
                            if ((DateTime.Today.Year - dtngaysinh.Value.Year > 18)){ 
                                conn.Open();
                                string query = "Insert_NhanVien";
                                cmd = new SqlCommand(query, conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@idNhanVien", txtten.Text);
                                cmd.Parameters.AddWithValue("@sTenNV", txtten.Text);
                                cmd.Parameters.AddWithValue("@sDiaChi", txtdiachi.Text);
                                cmd.Parameters.AddWithValue("@sCMND", txtcmnd.Text);
                                if (rdnam.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@sGioiTinh", rdnam.Text);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@sGioiTinh", rdnu.Text);
                                }
                                cmd.Parameters.AddWithValue("@sSDT", txtsdt.Text);
                                dtngaysinh.CustomFormat = "dd/MM/yyyy";
                                cmd.Parameters.AddWithValue("@sNgaySinh", dtngaysinh.Text);
                                cmd.Parameters.AddWithValue("@Username", txttaikhoan.Text);
                                cmd.Parameters.AddWithValue("@Password", txtmatkhau.Text);

                               
                                int kq = (int)cmd.ExecuteNonQuery();
                                if (kq > 0)
                                {
                                    MessageBox.Show("Thêm thành công!");
                                    DataTable dt = (DataTable)drdsnhanvien.DataSource;
                                    if (dt != null)
                                        dt.Clear();
                                    load();
                                    conn.Close();
                                    btnthemmoi.Enabled = true;
                                    btnsua.Enabled = false;
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhân viên phải lớn hơn 18 tuổi");

                            }

                        }
                      
                    }
                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtten.Text != "" && txtsdt.Text != "" && txttaikhoan.Text != "" && txtmatkhau.Text != "")
                    {

                        if (kiemtra(txttaikhoan.Text) == true)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại.");
                        }
                        else
                        {
                            if ((DateTime.Today.Year - dtngaysinh.Value.Year > 18))
                            {
                                conn.Open();
                                string query = "Update_NhanVien";
                                cmd = new SqlCommand(query, conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@idNhanVien", txtma.Text);
                                cmd.Parameters.AddWithValue("@sTenNV", txtten.Text);
                                cmd.Parameters.AddWithValue("@sDiaChi", txtdiachi.Text);
                                cmd.Parameters.AddWithValue("@sCMND", txtcmnd.Text);
                                if (rdnam.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@sGioiTinh", rdnam.Text);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@sGioiTinh", rdnu.Text);
                                }
                                cmd.Parameters.AddWithValue("@sSDT", txtsdt.Text);
                                dtngaysinh.CustomFormat = "dd/MM/yyyy";
                                cmd.Parameters.AddWithValue("@sNgaySinh", dtngaysinh.Text);
                                cmd.Parameters.AddWithValue("@Username", txttaikhoan.Text);
                                cmd.Parameters.AddWithValue("@Password", txtmatkhau.Text);

                              
                                int kq = (int)cmd.ExecuteNonQuery();
                                if (kq > 0)
                                {
                                    MessageBox.Show("Cập nhật thành công!");
                                    DataTable dt = (DataTable)drdsnhanvien.DataSource;
                                    if (dt != null)
                                        dt.Clear();
                                    load();
                                    conn.Close();
                                    btnthemmoi.Enabled = true;
                                    btnsua.Enabled = false;
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật thất bại.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhân viên phải lớn hơn 18 tuổi");

                            }

                        }

                    }
                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thongbao == DialogResult.OK)
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string query = "delete from tbl_NhanVien where idNhanVien= '" + txtma.Text + "' ";
                /*       string query = "Delete_NhanVien";
                       cmd.Parameters.AddWithValue("@idNhanVien", txtma.Text);*/
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = (DataTable)drdsnhanvien.DataSource;
                if (dt != null)
                    dt.Clear();
                load();
                MessageBox.Show("Hủy thành công.");
                conn.Close();
            }
            reset();
            clockText();
            btnthemmoi.Enabled = true;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btntimkiem_Click(this, new EventArgs());
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txttimkiem.Text != null)
                    {
                        conn.Open();
                        string timTen = "select * from tbl_NhanVien where sTenNV LIKE'%" + txttimkiem.Text + "%'";
                        SqlCommand command = new SqlCommand(timTen, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        drdsnhanvien.DataSource = dt;
                    }
                    else
                    {
                        load();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }

            }
        }
    }
}
