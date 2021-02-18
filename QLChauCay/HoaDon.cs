using System;
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
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChauCayDataSet.tbl_HoaDon' table. You can move, or remove it, as needed.
            this.tbl_HoaDonTableAdapter.Fill(this.qLChauCayDataSet.tbl_HoaDon);
            dghoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.getMaHH();
              //  this.getNV();
            this.getMaHD();
            //    this.getKH();
            loadDL();
            dtngaylap.Enabled = false;
            cbbstatus.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            cbbchau.Enabled = true;
            resetCTHD();
            resetHD();
            txtthanhtien.Text = "0";
            cbbnv.Text = "";
            cbbkh.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dghoadon.CurrentRow.Index;
            cbbmahd.Text = dghoadon.Rows[i].Cells[0].Value.ToString();
            cbbchau.Text = dghoadon.Rows[i].Cells[1].Value.ToString();
            txtsl.Text = dghoadon.Rows[i].Cells[2].Value.ToString();
            txtdongia.Text = dghoadon.Rows[i].Cells[3].Value.ToString();
            txtthanhtien.Text = dghoadon.Rows[i].Cells[4].Value.ToString();
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnsua.Enabled = true;
            cbbstatus.Enabled = true;
            dtngaylap.Enabled = true;
        }

        void getNV()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select * from tbl_NhanVien ";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_NhanVien");
            cbbnv.DataSource = ds.Tables[0];
            //adapter.Fill(data);
            cbbnv.DisplayMember = "sTenNV";
            cbbnv.ValueMember = "idNhanVien";
            txtnglap.DataBindings.Clear();
            txtnglap.DataBindings.Add(new Binding("Text", cbbnv.DataSource, "idNhanVien"));
            conn.Close();
        }

        void getKH()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query = "select * from tbl_KhachHang";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_KhachHang");
            cbbkh.DataSource = ds.Tables[0];
            //adapter.Fill(data);
            cbbkh.DisplayMember = "sTenKH";
            cbbkh.ValueMember = "idKhachHang";
      //      txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add(new Binding("Text", cbbkh.DataSource, "idKhachHang"));
            conn.Close();
        }
        void getMaHH()
        {
            conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            string query4 = "select * from tbl_ChauCay where Status=1";
            cmd = new SqlCommand(query4, conn);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_ChauCay");
            cbbchau.DataSource = ds.Tables[0];
            //adapter.Fill(data);
            cbbchau.DisplayMember = "sTenChau";
            cbbchau.ValueMember = "idChau";
            //cbMaHH.DataSource = data;
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
            cbbstatus.DataBindings.Clear();
            cbbstatus.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "Status"));
            txtthanhtien.DataBindings.Clear();
            txtthanhtien.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "tong_tien"));
            cbbnv.DataBindings.Clear();
            cbbnv.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "sTenNV"));
            cbbkh.DataBindings.Clear();
            cbbkh.DataBindings.Add(new Binding("Text", cbbmahd.DataSource, "sTenKH"));
            //txtMaHD.DataBindings.Add(new Binding("Text", cbMaHD.DataSource, "ma_hd"));
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
            //cbTenNV.Text = "";
            //txtMaNV.Clear();
            dtngaylap.Value = DateTime.Now;
        }
        void unlockHD()
        {
            cbbmahd.Enabled = true;
            dtngaylap.Enabled = true;
            cbbstatus.Enabled = true;
           
        }

        private void txtthemmoi_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            cbbmahd.Enabled = false;
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
            string showCTHD = "	select tbl_ChiTietHoaDon.idHoaDon, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong, tbl_ChiTietHoaDon.fDonGia, (tbl_ChiTietHoaDon.sSoLuong* tbl_ChiTietHoaDon.fDonGia) as thanh_tien  from tbl_ChiTietHoaDon, tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau";
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
                        string query = "Insert_HoaDon";
                        SqlCommand cmd1 = new SqlCommand(query, conn);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@idNhanVien", cbbnv.Text);
                        cmd1.Parameters.AddWithValue("@idKhachHang", cbbkh.Text);
                         cmd1.Parameters.AddWithValue("@Status", cbbstatus.Text);


                       /* if (cbbstatus.Text == "Hoạt Động")
                        {
                            cmd1.Parameters.AddWithValue("@Status", "1");
                        }
                        else cmd.Parameters.AddWithValue("@Status", "0");*/
                        cmd1.Parameters.AddWithValue("@Createdate", dtngaylap.Text);
                        cmd1.ExecuteNonQuery();
                        //conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }

                    try
                    {
                        //conn.Open();
                        string getMaxHD = "select max(idHoaDon) as max from tbl_HoaDon";
                        SqlCommand cmd2 = new SqlCommand(getMaxHD, conn);
                        SqlDataReader dr;
                        dr = cmd2.ExecuteReader();
                        while (dr.Read())
                        {
                            cbbmahd.Text = dr["max"].ToString();
                            //txtMaHD.Text = dr["max"].ToString();
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }

                    try
                    {
                        if (txtsl != null)
                        {
                            //conn.Open();
                            //string cthd = "sp_ThemCTHD";
                            string cthd = "insert into tbl_ChiTietHoaDon (idHoaDon, idChau, sSoLuong, fDonGia) values('" + cbbmahd.Text + "','" + cbbchau.Text + "', '" + txtsl.Text + "', '" + txtdongia.Text + "')";
                            SqlCommand cmd2 = new SqlCommand(cthd, conn);
                            //cmd2.Parameters.AddWithValue("@mahd", cbMaHD.Text);
                            //cmd2.Parameters.AddWithValue("@mahh", txtMaHH.Text);
                            //cmd2.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
                            //cmd2.Parameters.AddWithValue("@dongia", txtDonGia.Text);
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
                                //conn.Close();

                            }
                            else
                            {
                                conn.Open();
                                string cthd = "insert into tbl_ChiTietHoaDon (idHoaDon, idChau, sSoLuong, fDonGia) values('" + cbbmahd.Text + "','" + txtmachau.Text + "', '" + txtsl.Text + "', '" + txtdongia.Text + "')";
                                SqlCommand cmd2 = new SqlCommand(cthd, conn);
                             /*   cmd2.Parameters.AddWithValue("@idHoaDon", cbbmahd.Text);
                                cmd2.Parameters.AddWithValue("@idChau", txtmachau.Text);
                                cmd2.Parameters.AddWithValue("@sSoLuong", txtsl.Text);
                                cmd2.Parameters.AddWithValue("@fDonGia", txtdongia.Text);*/
                                int kq1 = (int)cmd2.ExecuteNonQuery();
                                if (kq1 > 0)
                                {
                                    MessageBox.Show("Thêm thành công!");
                                    loadDL();
                                    //getMaHD();
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
                    if (cbbmahd.Text != "" && cbbnv.Text != "" && cbbstatus.Text != "")
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
                            cmd4.Parameters.AddWithValue("@idNhanVien", txtnglap.Text);
                            cmd4.Parameters.AddWithValue("@idKhachHang", txtmakh.Text);
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
            string showCTHD = "select tbl_ChiTietHoaDon.idHoaDon, tbl_ChauCay.sTenChau, tbl_ChiTietHoaDon.sSoLuong,tbl_ChiTietHoaDon.fDonGia,(tbl_ChiTietHoaDon.sSoLuong*tbl_ChiTietHoaDon.fDonGia) as thanh_tien from tbl_ChiTietHoaDon, tbl_ChauCay where tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau and idHoaDon  = " + cbbmahd.SelectedValue;
            SqlCommand command = new SqlCommand(showCTHD, conn);
            SqlDataAdapter a = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dghoadon.DataSource = dt;
            //getMaHD();
            resetCTHD();
            btnluu.Enabled = true;
            if (cbbmahd.Text != null) btnhuy.Enabled = true;
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
       
            if (dghoadon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                {
                    dt.Clear();
                    loadDL();
                    MessageBox.Show("Xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");

                }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
