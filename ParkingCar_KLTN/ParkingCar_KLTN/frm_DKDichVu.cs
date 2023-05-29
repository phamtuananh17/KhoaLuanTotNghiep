using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkingCar_KLTN
{
    public partial class frm_DKDichVu : Form
    {
        public frm_DKDichVu()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_date.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
        }

        void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT SoTheVao.BienSo FROM SoTheVao, The WHERE SoTheVao.Id_The = The.Id_The and The.LoaiThe like N'%Thẻ tháng%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_bienso.DataSource = dt;
            cb_bienso.DisplayMember = "BienSo";

            SqlCommand cmdd = new SqlCommand("SELECT Id_DV FROM DichVu", conn);
            SqlDataAdapter dad = new SqlDataAdapter(cmdd);
            DataTable dtd = new DataTable();
            dad.Fill(dtd);
            cb_IdDV.DataSource = dtd;
            cb_IdDV.DisplayMember = "Id_DV";

            SqlDataAdapter da1 = new SqlDataAdapter("select DISTINCT Id_PhieuDV, BienSo, Id_DV, DonGia, NgayDK from PhieuDKDV", conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "phieudk");
            dgv_phieuDV.DataSource = ds;
            dgv_phieuDV.DataMember = "phieudk";
        }

        private void frm_DKDichVu_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_data();
            timer1.Enabled = true;
            timer1.Start();
            lb_date.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");

            dgv_phieuDV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_phieuDV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_phieuDV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.dgv_phieuDV.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_phieuDV.DefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void cb_IdDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from DichVu where Id_DV like N'%" + cb_IdDV.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_dongia.Text = dr["DonGia"].ToString();
                txt_loaiDV.Text = dr["LoaiDV"].ToString();
                txt_mtdv.Text = dr["MoTaDV"].ToString();
            }
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            string sqlCKECKDV = "select count(*) Id_DV from PhieuDKDV where Id_DV = @Id_DV and BienSo = '" + cb_bienso.Text + "'";
            SqlCommand cmdldv = new SqlCommand(sqlCKECKDV, conn);
            try
            {
                cmdldv.Parameters.AddWithValue("@Id_DV", int.Parse(cb_IdDV.Text));
                int valx = (int)cmdldv.ExecuteScalar();
                if (valx > 0)
                {
                    MessageBox.Show("Dịch vụ này đã được đăng ký cho xe này! Vui lòng chọn dịch vụ khác");
                }
                else
                {
                    string sql = "INSERT INTO PhieuDKDV (BienSo, Id_DV, DonGia, NgayDK) values (@BienSo, @Id_DV, @DonGia, @NgayDK)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@BienSo", this.cb_bienso.Text);
                    cmd.Parameters.AddWithValue("@Id_DV", int.Parse(cb_IdDV.Text));
                    cmd.Parameters.AddWithValue("@DonGia", txt_dongia.Text);
                    cmd.Parameters.AddWithValue("@NgayDK", DateTime.Parse(lb_date.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đăng ký dịch vụ thành công");
                    }
                    load_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cb_bienso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select Xe.BienSo, Xe.Id_KV, Xe.LoaiXe, Xe.CuocPhi, XeVao.MoTa from Xe, XeVao where Xe.BienSo = XeVao.BienSo" +
                " and Xe.BienSo like N'%" + cb_bienso.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cbo_loaixe.Text = dr["LoaiXe"].ToString();
                cb_khuvuc.Text = dr["Id_KV"].ToString();
                txt_mota.Text = dr["MoTa"].ToString();
                txt_cuocphi.Text = dr["CuocPhi"].ToString();
            }
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Delete from PhieuDKDV where Id_PhieuDV = @Id_PhieuDV";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id_PhieuDV", this.txt_sophieu.Text);
                cmd.Parameters.AddWithValue("@BienSo", this.cb_bienso.Text);
                cmd.Parameters.AddWithValue("@Id_DV", int.Parse(cb_IdDV.Text));
                cmd.Parameters.AddWithValue("@DonGia", txt_dongia.Text);
                cmd.Parameters.AddWithValue("@NgayDK", DateTime.Parse(lb_date.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hủy đăng ký dịch vụ thành công");
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_phieuDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dgv_phieuDV.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_sophieu.Text = dgv_phieuDV.Rows[dongchon].Cells["Id_PhieuDV"].Value.ToString();
                this.cb_bienso.Text = dgv_phieuDV.Rows[dongchon].Cells["BienSo"].Value.ToString();
                this.cb_IdDV.Text = dgv_phieuDV.Rows[dongchon].Cells["Id_DV"].Value.ToString();
                this.txt_dongia.Text = dgv_phieuDV.Rows[dongchon].Cells["DonGia"].Value.ToString();
            }
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            new frm_HoaDonDV().Show();
        }
    }
}
