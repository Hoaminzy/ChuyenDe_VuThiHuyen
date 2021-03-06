﻿using System;
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
    public partial class frmChau : Form
    {
        public frmChau()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();

        void clockText()
        {
            txtma.ReadOnly = true;
            cbbloai.Enabled = false;
            txtten.Enabled = false;
            txtchatlieu.Enabled = false;
            txtmau.Enabled = false;
            txtgia.Enabled = false;
            txtgianhap.Enabled = false;
            txtsl.Enabled = false;
            txtmota.Enabled = false;
            txtncc.Enabled = false;
            txthinhanh.Enabled = false;
            txtkichthuoc.Enabled = false;
        }

        void UnclockText()
        {
            txtma.ReadOnly = true;
            cbbloai.Enabled = true;
            txtten.Enabled = true;
            txtchatlieu.Enabled = true;
            txtmau.Enabled = true;
            txtgia.Enabled = true;
            txtgianhap.Enabled = true;
            txtsl.Enabled = true;
            txtmota.Enabled = true;
            txtncc.Enabled = true;
            txthinhanh.Enabled = true;
            txtkichthuoc.Enabled = true;
        }
        void reset()
        {
            txtma.Clear();
            cbbloai.Text = "";
            txtten.Clear();
            txtchatlieu.Clear();
            txtmau.Clear();
            txtgia.Clear(); ;
            txtgianhap.Clear();
            txtsl.Clear();
            txtmota.Clear();
            txtncc.Clear(); 
            txthinhanh.Clear();
            txtkichthuoc.Clear();
            txthinhanh.Clear();
           
        }
        private void frmChau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChauCayDataSet.tbl_ChauCay' table. You can move, or remove it, as needed.
            dgdschau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    load();
                    conn.Close();
                    this.getLoai();
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

        private void dgdschau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnclockText();
            int i = dgdschau.CurrentRow.Index;
            //txtManv.ReadOnly = true;
            txtma.Text = dgdschau.Rows[i].Cells[0].Value.ToString();
            cbbloai.Text = dgdschau.Rows[i].Cells[1].Value.ToString();
            txtten.Text = dgdschau.Rows[i].Cells[2].Value.ToString();
            txtchatlieu.Text = dgdschau.Rows[i].Cells[3].Value.ToString();
            txtmau.Text = dgdschau.Rows[i].Cells[4].Value.ToString();
            txtkichthuoc.Text = dgdschau.Rows[i].Cells[5].Value.ToString();
            txtgia.Text = dgdschau.Rows[i].Cells[6].Value.ToString();
            txtgianhap.Text = dgdschau.Rows[i].Cells[7].Value.ToString();
             txtsl.Text = dgdschau.Rows[i].Cells[8].Value.ToString();
            txtmota.Text = dgdschau.Rows[i].Cells[9].Value.ToString();
            txtncc.Text = dgdschau.Rows[i].Cells[10].Value.ToString();
            txthinhanh.Text = dgdschau.Rows[i].Cells[11].Value.ToString();
           

            btnthemmoi.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = true;
        }
        private void load()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "Select_ChauCay";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            //data = new DataTable();
            adapter.Fill(data);
            dgdschau.DataSource = data;
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
                string query = "delete from tbl_ChauCay where idChau = '"+txtma.Text+"' ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = (DataTable)dgdschau.DataSource;
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
        public void getLoai()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query1 = "select * from tbl_LoaiChau";
            cmd = new SqlCommand(query1, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_LoaiChau");
            cbbloai.DataSource = ds.Tables[0];
            cbbloai.DisplayMember = "sTenLoai";
          //  cbbloai.ValueMember = "idLoaiChau";
          //  cbbloai.DataBindings.Add(new Binding("Text", ds.Tables[0], cbbloai.ValueMember));
            txtmaloai.DataBindings.Add(new Binding("Text", cbbloai.DataSource, "idLoaiChau"));
            conn.Close();


       
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtten.Text != "" && txtchatlieu.Text != "" && txtmau.Text != "" && txtgia.Text != "" && txtgianhap.Text != "" && txtsl.Text != "" && cbbloai.Text != "")
                    {

                        conn.Open();
                        string query = "Insert_ChauCay";
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idLoaiChau", txtmaloai.Text);
                        cmd.Parameters.AddWithValue("@sTenChau", txtten.Text);
                        cmd.Parameters.AddWithValue("@sChatLieu", txtchatlieu.Text);
                        cmd.Parameters.AddWithValue("@sMauSac", txtmau.Text);
                        cmd.Parameters.AddWithValue("@fDonGia", txtgia.Text);
                        cmd.Parameters.AddWithValue("@fGiaNhap", txtgianhap.Text);
                        cmd.Parameters.AddWithValue("@sSoLuong", txtsl.Text);
                        cmd.Parameters.AddWithValue("@sMoTa", txtmota.Text);
                        cmd.Parameters.AddWithValue("@sNhaCungCap", txtncc.Text);
                        cmd.Parameters.AddWithValue("@sHinhAnh", txthinhanh.Text);
                        cmd.Parameters.AddWithValue("@sKichThuoc", txtkichthuoc.Text);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            DataTable dt = (DataTable)dgdschau.DataSource;
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (txtten.Text != "" && txtchatlieu.Text != "" && txtmau.Text != "" && txtgia.Text != "" && txtgianhap.Text != "" && txtsl.Text != "" && txtkichthuoc.Text != "" && cbbloai.Text != "")
                    {

                        conn.Open();
                        string query = "Update_ChauCay";
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idChau", txtma.Text);
                        cmd.Parameters.AddWithValue("@idLoaiChau", txtmaloai.Text);
                        cmd.Parameters.AddWithValue("@sTenChau", txtten.Text);
                        cmd.Parameters.AddWithValue("@sChatLieu", txtchatlieu.Text);
                        cmd.Parameters.AddWithValue("@sMauSac", txtmau.Text);
                        cmd.Parameters.AddWithValue("@fDonGia", txtgia.Text);
                        cmd.Parameters.AddWithValue("@fGiaNhap", txtgianhap.Text);
                        cmd.Parameters.AddWithValue("@sSoLuong", txtsl.Text);
                        cmd.Parameters.AddWithValue("@sMoTa", txtmota.Text);
                        cmd.Parameters.AddWithValue("@sNhaCungCap", txtncc.Text);
                        cmd.Parameters.AddWithValue("@sHinhAnh", txthinhanh.Text);
                        cmd.Parameters.AddWithValue("@sKichThuoc", txtkichthuoc.Text);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            DataTable dt = (DataTable)dgdschau.DataSource;
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
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
                        string timTen = "select * from tbl_ChauCay where sTenChau LIKE'%" + txttimkiem.Text + "%'";
                        SqlCommand command = new SqlCommand(timTen, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dgdschau.DataSource = dt;
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

        private void btnOpenPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtpic.Image = Image.FromFile(dlgOpen.FileName);
                txthinhanh.Text = dlgOpen.FileName;
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            //HoaDon.maInHD = cbMaHD.Text;
            frm_RpChauCay inDSChau = new frm_RpChauCay();
            inDSChau.ShowDialog();
            this.Show();
        }
    }
}
