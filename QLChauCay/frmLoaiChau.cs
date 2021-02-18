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
    public partial class frmLoaiChau : Form
    {
        public frmLoaiChau()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
      

        private void frmLoaiChau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChauCayDataSet.tbl_LoaiChau' table. You can move, or remove it, as needed.
            this.tbl_LoaiChauTableAdapter.Fill(this.qLChauCayDataSet.tbl_LoaiChau);
            dgdsloaichau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            btnluu.Enabled = false;
            btnluu.Enabled = false;
        }

        void clockText()
        {
            txtmaloai.ReadOnly = true;
            txtloaichau.Enabled = false;
            cbbstatus.Enabled = false;
            dtngaytao.Enabled = false;
           
        }

        void UnclockText()
        {
            txtmaloai.ReadOnly = true;
            txtloaichau.Enabled = true;
            cbbstatus.Enabled = true;
            dtngaytao.Enabled = true;

        }
        void reset()
        {
            txtloaichau.Clear();
            txtmaloai.Clear();
            dtngaytao.Text = DateTime.Now.ToString();
        }

        private void dgdsloaichau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnclockText();
            int i = dgdsloaichau.CurrentRow.Index;
            //txtManv.ReadOnly = true;
            txtmaloai.Text = dgdsloaichau.Rows[i].Cells[0].Value.ToString();
            txtloaichau.Text = dgdsloaichau.Rows[i].Cells[1].Value.ToString();
            if (dgdsloaichau.Rows[i].Cells[2].Value.ToString() == "1")
            {
                cbbstatus.Text = "Hoạt Động";

            }
            else
            {
                cbbstatus.Text = "Khóa";

            }
            dtngaytao.Text = dgdsloaichau.Rows[i].Cells[3].Value.ToString();

            btnthemmoi.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = true;
        }
        private void load()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "Select_LoaiChau";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            //data = new DataTable();
            adapter.Fill(data);
            dgdsloaichau.DataSource = data;
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtloaichau.Text != "")
                    {

                        conn.Open();
                        string query = "Insert_LoaiChau";
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sTenLoai", txtloaichau.Text);

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
                            DataTable dt = (DataTable)dgdsloaichau.DataSource;
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

                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thongbao == DialogResult.OK)
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string query = "update tbl_LoaiChau set Status=0 where idLoaiChau= '" + txtmaloai.Text + "' ";
                //string query = "Delete_KhachHang";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = (DataTable)dgdsloaichau.DataSource;
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtloaichau.Text != "" )
                    {

                        conn.Open();
                        string query = "Update_LoaiChau";
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idLoaiChau", txtmaloai.Text);
                        cmd.Parameters.AddWithValue("@sTenLoai", txtloaichau.Text);


                        if (cbbstatus.Text == "Hoạt Động")
                        {
                            cmd.Parameters.AddWithValue("@Status", "1");
                        }
                        else cmd.Parameters.AddWithValue("@Status", "0");

                        dtngaytao.CustomFormat = "dd/MM/yyyy";
                        cmd.Parameters.AddWithValue("@Createdate", dtngaytao.Value);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            DataTable dt = (DataTable)dgdsloaichau.DataSource;
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

                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txttimkiem.Text != null)
                    {
                        conn.Open();
                        string timTen = "select * from tbl_LoaiChau where sTenLoai LIKE'%" + txttimkiem.Text + "%'";
                        SqlCommand command = new SqlCommand(timTen, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dgdsloaichau.DataSource = dt;
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
