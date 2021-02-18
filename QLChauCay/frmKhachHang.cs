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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();

       

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChauCayDataSet.tbl_KhachHang' table. You can move, or remove it, as needed.
            //this.tbl_KhachHangTableAdapter.Fill(this.qLChauCayDataSet.tbl_KhachHang);
            drdskhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    loadKH();
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
            btnluu.Enabled = false;
            btnsua.Enabled = false;
        }

        void clockText()
        {
            txtma.ReadOnly = true;
            txtten.Enabled = false;
            txtcmnd.Enabled = false;
            rdnam.Enabled = false;
            rdnu.Enabled = false;
            cbbstatus.Enabled = false;
            dtngaysinh.Enabled = false;
            dtngaytao.Enabled = false;
            txtsdt.Enabled = false;
            txtdiachi.Enabled = false;
        }

        void UnclockText()
        {
            txtma.ReadOnly = true;
            txtten.Enabled = true;
            txtcmnd.Enabled = true;
            rdnam.Enabled = true;
            rdnu.Enabled = true;
            cbbstatus.Enabled = true;
            dtngaysinh.Enabled = true;
            dtngaytao.Enabled = true;
            txtsdt.Enabled = true;
            txtdiachi.Enabled = true;
        }
        void reset()
        {
            txtma.Clear();
            txtten.Clear();
            txtdiachi.Clear();
            txtcmnd.ResetText();
            txtsdt.Clear();
            dtngaysinh.Text = DateTime.Now.ToString();
            dtngaytao.Text = DateTime.Now.ToString();
        }

        private void drdskhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnclockText();
            int i = drdskhachhang.CurrentRow.Index;
            //txtManv.ReadOnly = true;
            txtten.Text = drdskhachhang.Rows[i].Cells[1].Value.ToString();
            txtma.Text = drdskhachhang.Rows[i].Cells[0].Value.ToString();
            txtdiachi.Text = drdskhachhang.Rows[i].Cells[2].Value.ToString();
            txtcmnd.Text = drdskhachhang.Rows[i].Cells[3].Value.ToString();
            if (drdskhachhang.Rows[i].Cells[4].Value.ToString() == "Nam")
                rdnam.Checked = true;
            else rdnu.Checked = true;
            txtsdt.Text = drdskhachhang.Rows[i].Cells[5].Value.ToString();
            dtngaysinh.Text = drdskhachhang.Rows[i].Cells[6].Value.ToString();
            if (drdskhachhang.Rows[i].Cells[7].Value.ToString() == "1")
            {
                cbbstatus.Text = "Hoạt Động";

            }
            else
            {
                cbbstatus.Text = "Khóa";
            }
            dtngaytao.Text = drdskhachhang.Rows[i].Cells[8].Value.ToString();
   
            btnthemmoi.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = true;
        }
        private void loadKH()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "Select_KhachHang";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            //data = new DataTable();
            adapter.Fill(data);
            drdskhachhang.DataSource = data;
            conn.Close();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            reset();
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = true;
            btnthemmoi.Enabled = true;
            UnclockText();

        }
       
        private void btnhuy_Click(object sender, EventArgs e)//xóa
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thongbao == DialogResult.OK)
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                  string query = "update tbl_KhachHang set Status=0 where idKhachHang= '" + txtma.Text + "' ";
                //string query = "Delete_KhachHang";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = (DataTable)drdskhachhang.DataSource;
                if (dt != null)
                    dt.Clear();
                loadKH();
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtten.Text != "" && txtsdt.Text != "")
                    {
                       
                            conn.Open();
                            string query = "Insert_KhachHang";
                            cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sTenKH", txtten.Text);
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
                        if (cbbstatus.Text == "Hoạt Động")
                        {
                            cmd.Parameters.AddWithValue("@Status", "1");
                        }
                        else cmd.Parameters.AddWithValue("@Status", "0");
                        dtngaytao.CustomFormat = "dd/MM/yyyy";
                        cmd.Parameters.AddWithValue("@Createdate", dtngaytao.Text);
                            int kq = (int)cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                DataTable dt = (DataTable)drdskhachhang.DataSource;
                                if (dt != null)
                                    dt.Clear();
                                loadKH();
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
                    if (txtten.Text != "" && txtsdt.Text != "")
                    {
                        
                            conn.Open();
                            string query = "Update_KhachHang";
                            cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idKhachHang", txtma.Text);
                        cmd.Parameters.AddWithValue("@sTenKH", txtten.Text);
                            cmd.Parameters.AddWithValue("@sDiaChi", txtdiachi.Text);
                            cmd.Parameters.AddWithValue("@sCMND", txtcmnd.Text);
                      /*  if (rdnam.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@sGioiTinh", rdnam.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@sGioiTinh", rdnu.Text);
                        }*/
                        string gt;
                        if (rdnam.Checked)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        cmd.Parameters.AddWithValue("@sGioiTinh", gt);

                        cmd.Parameters.AddWithValue("@sSDT", txtsdt.Text);
                            cmd.Parameters.AddWithValue("@sNgaySinh", dtngaysinh.Text);
                        string tt;
                        if (cbbstatus.Text == "Hoạt Động")
                        {
                            cmd.Parameters.AddWithValue("@Status", "1");
                        }
                        else cmd.Parameters.AddWithValue("@Status", "0");
                        
                        cmd.Parameters.AddWithValue("@Createdate", dtngaytao.Value);
                            int kq = (int)cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Cập nhật thành công!");
                                DataTable dt = (DataTable)drdskhachhang.DataSource;
                                if (dt != null)
                                    dt.Clear();
                                loadKH();
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

                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
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
                        string timTen = "select * from tbl_KhachHang where sTenKH LIKE'%" + txttimkiem.Text + "%'";
                        SqlCommand command = new SqlCommand(timTen, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        drdskhachhang.DataSource = dt;
                    }
                    else
                    {
                        loadKH();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }

            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btntimkiem_Click(this, new EventArgs());
            }
        }
    }
}
