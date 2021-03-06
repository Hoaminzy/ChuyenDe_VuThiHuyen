﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLChauCay
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public class ChiTietHoaDon
        {
            static public string maInHD;
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChauCayDataSet.tbl_HoaDon' table. You can move, or remove it, as needed.
       //     this.tbl_HoaDonTableAdapter.Fill(this.qLChauCayDataSet.tbl_HoaDon);
            dghoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.getMaHH();
              //  this.getNV();
            this.getMaHD();
               this.getKH();
            //     loadDL();
            cbbstatus.Enabled = false;
            dtngaylap.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            cbbchau.Enabled = true;
            resetCTHD();
            resetHD();
            txtthanhtien.Text = "0";
            cbbkh.Text = "";
            txtnglap.Text = "";
            txtmakh.Text = "";
            cbbmahd.Text = "";
            if (cbbmahd.Text != "")
            {
                getAutoMaHD();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dghoadon.CurrentRow.Index;
            txtmachau.Text = dghoadon.Rows[i].Cells[0].Value.ToString();
            cbbchau.Text = dghoadon.Rows[i].Cells[1].Value.ToString();
            txtsl.Text = dghoadon.Rows[i].Cells[2].Value.ToString();
            txtdongia.Text = dghoadon.Rows[i].Cells[3].Value.ToString();
            txtthanhtien.Text = dghoadon.Rows[i].Cells[4].Value.ToString();
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnsua.Enabled = true;
            dtngaylap.Enabled = true;
            cbbkh.Enabled = false;
        }

        void getNV()
        {
            string query = "select * from tbl_NhanVien  where Username = '" + frmDangNhap.dangnhap.tendangnhap + "'";
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    SqlDataAdapter a = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    txtnglap.DataBindings.Clear();
                    txtnglap.DataBindings.Add("Text", dt, "idNhanVien");
                    cbbnv.DataBindings.Clear();
                    cbbnv.DataBindings.Add("Text", dt, "sTenNV");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }

        void getKH()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select * from tbl_KhachHang ";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_KhachHang");
            cbbkh.DataSource = ds.Tables[0];
            //adapter.Fill(data);
            cbbkh.DisplayMember = "sSDT";
            cbbkh.ValueMember = "idKhachHang";
            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add(new Binding("Text", cbbkh.DataSource, "idKhachHang"));
            txttenkh.DataBindings.Clear();
            txttenkh.DataBindings.Add(new Binding("Text", cbbkh.DataSource, "sTenKH"));
            conn.Close();
        }
        void getMaHH()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query4 = "select * from tbl_ChauCay";
            cmd = new SqlCommand(query4, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_ChauCay");
            cbbchau.DataSource = ds.Tables[0];
            cbbchau.DisplayMember = "sTenChau";
            cbbchau.ValueMember = "idChau";
            txtmachau.DataBindings.Clear();
            txtmachau.DataBindings.Add(new Binding("Text", cbbchau.DataSource, "idChau"));
            txtdongia.DataBindings.Add(new Binding("Text", cbbchau.DataSource, "fDonGia"));
            conn.Close();

        }

        //Thông tin nhân viên được thêm tự động
        void getAutoNV()
        {
            string query = "select * from tbl_NhanVien where Username = '" + frmDangNhap.dangnhap.tendangnhap + "'";
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    SqlDataAdapter a = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    txtnglap.DataBindings.Clear();
                    txtnglap.DataBindings.Add("Text", dt, "idNhanVien");
                    cbbnv.DataBindings.Clear();
                    cbbnv.DataBindings.Add("Text", dt, "sTenNV");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }
            }
        }
        void getAutoMaHD()
        {

            conn.Open();
            string showCTHD = "select tbl_ChiTietHoaDon.idChau, tbl_ChauCay.sTenChau,  tbl_ChiTietHoaDon.sSoLuong, tbl_ChiTietHoaDon.fDonGia,(sSoLuong*fDonGia) as thanh_tien  from tbl_ChiTietHoaDon, tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau and idHoaDon = " + frmMain.hoadon.maHD;
            SqlCommand command = new SqlCommand(showCTHD, conn);
            SqlDataAdapter a = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dghoadon.DataSource = dt;
            //update tổng tiền
            int sc = dghoadon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien += float.Parse(dghoadon.Rows[i].Cells["thanh_tien"].Value.ToString());
                txttongtien.Text = thanhtien.ToString();
            }

            cbbmahd.Text = frmMain.hoadon.maHD;
        }
        void getMaHD()
        {
            getNV();
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query4 = "getHoadon";
            cmd = new SqlCommand(query4, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_HoaDon");
            cbbmahd.DataSource = ds.Tables[0];
            //adapter.Fill(data);
            cbbmahd.DisplayMember = "idHoaDon";
            cbbmahd.ValueMember = "idHoaDon";
            //cbMaHH.DataSource = data;
            dtngaylap.DataBindings.Clear();
            dtngaylap.DataBindings.Add(new Binding("Value", cbbmahd.DataSource, "Createdate"));
            txtthanhtien.DataBindings.Clear();
            txtthanhtien.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "tong_tien"));
            cbbnv.DataBindings.Clear();
            cbbnv.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "sTenNV"));
            cbbkh.DataBindings.Clear();
            cbbkh.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "sTenKH"));
            txttongtien.DataBindings.Clear();
            txttongtien.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "tong_tien"));

            conn.Close();
            cbbmahd.Text = "";
        }
        void resetCTHD()
        {

            cbbchau.Text = "";
            cbbkh.Text = "";
            txtsl.Clear();
            txtdongia.Clear();
            txtthanhtien.Clear();
        }
        void unlockCTHD()
        {
            cbbchau.Enabled = true;
            txtsl.Enabled = true;
        }
        void resetHD()
        {
            cbbmahd.Text = "";
            dtngaylap.Value = DateTime.Now;
            txtmakh.Text = "";
            cbbkh.Text = "";
            txtmakh.Text = "";
        }
        void unlockHD()
        {
            cbbmahd.Enabled = true;
            dtngaylap.Enabled = true;
           
        }

        private void txtthemmoi_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            cbbmahd.Enabled = false;
            btnluu.Enabled = true;
            cbbkh.Enabled = true;
            cbbkh.Text = "";
            cbbstatus.Enabled = true;
            getAutoNV();
            getKH();
            resetHD();
            resetCTHD();
            unlockCTHD();
            unlockHD();
            getMaHD();
            dtngaylap.Value = DateTime.Now;
        }
        void loadDL()
        {

            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string showCTHD = "	select tbl_ChiTietHoaDon.idChau, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong, tbl_ChiTietHoaDon.fDonGia, (tbl_ChiTietHoaDon.sSoLuong* tbl_ChiTietHoaDon.fDonGia) as thanh_tien  from tbl_ChiTietHoaDon, tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau";
            SqlCommand command = new SqlCommand(showCTHD, conn);
            SqlDataAdapter a = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dghoadon.DataSource = dt;
            int sc = dghoadon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien += float.Parse(dghoadon.Rows[i].Cells["thanh_tien"].Value.ToString());
                txtthanhtien.Text = thanhtien.ToString();
            }

        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                if (cbbmahd.Text == "")
                {
                    try
                    {
                        conn.Open();
                        string query = " insert into tbl_HoaDon (idNhanVien, idKhachHang, Status, Createdate) values('"+txtnglap.Text+"', '"+txtmakh.Text+"','"+cbbstatus.Text+"','"+dtngaylap.Text+"')";
                       /* string query = "Insert_HoaDon";*/
                        SqlCommand cmd1 = new SqlCommand(query, conn);
                       /* cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@idNhanVien", txtnglap.Text);
                        cmd1.Parameters.AddWithValue("@idKhachHang", txtmakh.Text);
                        cmd1.Parameters.AddWithValue("@Status", cbbstatus.Text);
                        cmd1.Parameters.AddWithValue("@Createdate", dtngaylap.Value);*/
                        cmd1.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }

                    try
                    {
                       
                        string getMaxHD = "select max(idHoaDon) as max from tbl_HoaDon";
                        SqlCommand cmd2 = new SqlCommand(getMaxHD, conn);
                        SqlDataReader dr;
                        dr = cmd2.ExecuteReader();
                        while (dr.Read())
                        {
                            cbbmahd.Text = dr["max"].ToString();
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }

                    try
                    {
                        if (txtsl != null )
                        {
                            string cthd = "insert into tbl_ChiTietHoaDon (idHoaDon, idChau, sSoLuong, fDonGia) values('" + cbbmahd.Text + "','" + txtmachau.Text + "', '" + txtsl.Text + "', '" + txtdongia.Text + "')";
                            SqlCommand cmd2 = new SqlCommand(cthd, conn);

                            int kq = (int)cmd2.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                loadDL();
                            }
                            else MessageBox.Show("Thêm thất bại.");
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hãy nhập số lượng hàng hóa bán ra");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        if (txtsl.Text != "")
                        {
                            if (kiemtra(txtmachau.Text, cbbmahd.SelectedValue.ToString()) == true)
                            {
                                conn.Open();
                                int sLCon;
                                int i = dghoadon.CurrentRow.Index;
                                string soLuong = dghoadon.Rows[i].Cells[2].Value.ToString();
                                sLCon = Convert.ToInt32(soLuong) + Convert.ToInt32(txtsl.Text);
                                string query1 = "update tbl_ChiTietHoaDon set idChau = '" + txtmachau.Text + "', sSoLuong='" + Convert.ToString(sLCon) + "' where idHoaDon = '" + cbbmahd.SelectedValue + "' and idChau = '" + txtmachau.Text + "'";
                                SqlCommand cmd4 = new SqlCommand(query1, conn);
                        
                                int kq = (int)cmd4.ExecuteNonQuery();
                                if (kq > 0)
                                {
                                    MessageBox.Show("Thêm thành công!");
                                    loadDL();
                                    conn.Close();


                                }
                                else MessageBox.Show("Thêm thất bại.");

                            }
                            else
                            {
                                conn.Open();
                                string cthd = "insert into tbl_ChiTietHoaDon (idHoaDon, idChau, sSoLuong, fDonGia) values('" + cbbmahd.Text + "','" + txtmachau.Text + "', '" + txtsl.Text + "', '" + txtdongia.Text + "')";
                                SqlCommand cmd2 = new SqlCommand(cthd, conn);
                    
                                int kq1 = (int)cmd2.ExecuteNonQuery();
                                if (kq1 > 0)
                                {
                                    MessageBox.Show("Thêm thành công!");
                                    loadDL();
                                }
                                else MessageBox.Show("Thêm thất bại.");
                                conn.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Hãy nhập số lượng hàng hóa bán ra");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                resetCTHD();
            }
        }
        public bool kiemtra(string maHH, string maHD)
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select * from tbl_ChiTietHoaDon where idHoaDon='" + maHD + "' and idChau = '" + maHH + "'";
            cmd = new SqlCommand(query, conn);
            //cmd.Parameters.Contains(ten);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
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
        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private string ChuyenSo(string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "linh ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }


                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

            return doc;
        }

     

        private void txtdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (cbbmahd.Text != "" && cbbnv.Text != "" && cbbstatus!= null )
                    {
                        conn.Open();
                        string query = "Update_HoaDon";
                        SqlCommand cmd3 = new SqlCommand(query, conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@idHoaDon", cbbmahd.SelectedValue);
                        cmd3.Parameters.AddWithValue("@idNhanVien", txtnglap.Text);
                        cmd3.Parameters.AddWithValue("@idKhachHang", txtmakh.Text);
                        cmd3.Parameters.AddWithValue("@Status", cbbstatus.Text);
                        cmd3.Parameters.AddWithValue("@Createdate", dtngaylap.Value);

                        cmd3.ExecuteNonQuery();
                       if (txtsl.Text != "")
                        {
                            string query1 = "Update_CTHoaDon";
                            //string query1 = "update cthoadon set ma_hd='"+cbMaHD.SelectedValue+"', ma_hh = '"+txtMaHH.Text+"', sl_xuat='"+txtSoLuong.Text+"' where ma_hd = '"+cbMaHD.Text+"' and ma_hh = '"+txtMaHH.Text+"'";
                            SqlCommand cmd4 = new SqlCommand(query1, conn);
                            cmd4.CommandType = CommandType.StoredProcedure;
                            cmd4.Parameters.AddWithValue("@idHoaDon", cbbmahd.SelectedValue);
                            cmd4.Parameters.AddWithValue("@idChau", txtmachau.Text);
                            cmd4.Parameters.AddWithValue("@sSoLuong", txtsl.Text);
                            cmd4.ExecuteNonQuery();
                            int kq = (int)cmd4.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Sửa chi tiết hóa đơn thành công!");
                                loadDL();
                                conn.Close();
                            }
                            else MessageBox.Show("Sửa chi tiết hóa đơn thất bại.");
                            conn.Close();
                        }
                        else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                    }
                    else MessageBox.Show("Hãy nhập đầy đủ thông tin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }

                btnsua.Enabled = true;
                btnhuy.Enabled = false;
                btnthem.Enabled = true;
                btnluu.Enabled = true;
                txtdong.Enabled = true;
                resetCTHD();
            }
        }

        private void cbbmahd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string showCTHD = "select tbl_ChiTietHoaDon.idChau, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong,tbl_ChiTietHoaDon.fDonGia,(tbl_ChiTietHoaDon.sSoLuong*tbl_ChiTietHoaDon.fDonGia) as thanh_tien from tbl_ChiTietHoaDon, tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau and idHoaDon  = " + cbbmahd.SelectedValue;
            SqlCommand command = new SqlCommand(showCTHD, conn);
            SqlDataAdapter a = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dghoadon.DataSource = dt;
            resetCTHD();
            btnluu.Enabled = true;
            if (cbbmahd.Text != null) btnhuy.Enabled = true;
            conn.Close();
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            int thanhTien, soLuong;
            float dongia;
            if (txtsl.Text == "")
            {
                soLuong = 0;
            }
            else if (txtdongia.Text == "")
            {
                dongia = 0;
            }
            else
            {
                //thanhTien = Convert.ToInt32(txtThanhTien.Text);
                soLuong = Convert.ToInt32(txtsl.Text);
                dongia = Convert.ToInt32(txtdongia.Text);
                thanhTien = (int)(soLuong * dongia);
                txtthanhtien.Text = thanhTien.ToString();
            }
        }

        private void dghoadon_DoubleClick(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm trong hóa đơn: '" + cbbmahd.SelectedValue + "' ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                //string xoaCTHD = "sp_XoaCTHD";
                string xoaCTHD = "delete from tbl_ChiTietHoaDon where idHoaDon= '" + cbbmahd.SelectedValue + "' and idChau='" + txtmachau.Text + "'";
                SqlCommand cmd5 = new SqlCommand(xoaCTHD, conn);
                cmd5.ExecuteNonQuery();
                DataTable dt = (DataTable)dghoadon.DataSource;
                if (dt != null)
                
                    dt.Clear();
                    loadDL();
                    MessageBox.Show("Xóa thành công hóa đơn '"+cbbmahd.Text+"'và mã chậu '"+ txtmachau.Text+"'");
                
                conn.Close();
            }
        }

        private void txttongtien_TextChanged_1(object sender, EventArgs e)
        {
            if (txttongtien.Text != "0")
            {
                lbtongtien.Text = "Bằng chữ: " + ChuyenSo(txttongtien.Text);
            }
            else lbtongtien.Text = "";
        }

       

        private void btnin_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon.maInHD = cbbmahd.Text;
            frm_RPHoaDon hd = new frm_RPHoaDon();
            this.Hide();
            hd.ShowDialog();
            this.Show();
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
                        string timTen = "select * from tbl_HoaDon where idHoaDon LIKE'%" + txttimkiem.Text + "%'";
                        SqlCommand command = new SqlCommand(timTen, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dghoadon.DataSource = dt;
                    }
                    else
                    {
                        loadDL();
                        conn.Close();
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

        private void cbbkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btntk_Click(this, new EventArgs());
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    if (cbbkh.Text != null)
                    {
                        conn.Open();
                        string timSDT = "select * from tbl_KhachHang where sSDT LIKE'%" + cbbkh.Text + "%'";
                        SqlCommand command = new SqlCommand(timSDT, conn);
                        SqlDataAdapter a = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dghoadon.DataSource = dt;
                    }
                    else
                    {
                        loadDL();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex.Message);
                }

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (cbbstatus.SelectedItem.ToString() == "0")
            {
                if (cbbmahd.Text != "")
                {
                    DialogResult thongbao;
                    thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (thongbao == DialogResult.OK)
                    {
                        conn = new SqlConnection(ConnectionString.connectionString);
                        conn.Open();

                        string xoamactpn = "delete from tbl_ChiTietHoaDon where idHoaDon= '" + cbbmahd.SelectedValue + "'";
                        SqlCommand cmd4 = new SqlCommand(xoamactpn, conn);
                        cmd4.ExecuteNonQuery();

                        string xoaPN = "delete from tbl_HoaDon where idHoaDon= '" + cbbmahd.SelectedValue + "'";
                        //string query = "sp_XoaNV";
                        SqlCommand cmd5 = new SqlCommand(xoaPN, conn);
                        cmd5.ExecuteNonQuery();
                        DataTable dt1 = (DataTable)dghoadon.DataSource;
                        if (dt1 != null)
                            dt1.Clear();
                        loadDL();
                        MessageBox.Show("Xóa hóa đơn thành công.");
                        //đổ lại dl vào combobox
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "tbl_HoaDon");
                        cbbmahd.DataSource = ds.Tables[0];
                        cbbmahd.DisplayMember = "idHoaDon";
                        cbbmahd.ValueMember = "idHoaDon";
                        cbbmahd.Text = "";
                        conn.Close();
                    }
                    btnluu.Enabled = true;
                }
                else
                    MessageBox.Show("Hãy nhập mã hóa đơn cần xóa.");
            }
            else
            {
                MessageBox.Show("Không được phép xóa hóa đơn đã thanh toán.");
            }
        }
    }
}
