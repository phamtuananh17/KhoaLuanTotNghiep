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
    public partial class frm_QLDichVu : Form
    {
        public frm_QLDichVu()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;

        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='DichVu' and column_name != 'MoTaDV'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cb_timkiem.DataSource = dt;
            cb_timkiem.DisplayMember = "column_name";
        }
        public void load_data()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from DichVu", conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "dichvu");
            dgv_dsDV.DataSource = ds;
            dgv_dsDV.DataMember = "dichvu";
        }
        private void resetValues()
        {
            txt_IdDV.Clear();
            txt_loaiDV.Clear();
            txt_mota.Clear();
            txt_dongia.Clear();
        }

        private void frm_QLDichVu_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_Colum();
            load_data();
        }

        private void DataGridView_colorText()
        {
            this.dgv_dsDV.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_dsDV.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void DataGridView_CentreHeaders()
        {
            // Centre Column Cells Content
            dgv_dsDV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centre (Column and Row) Headers    
            dgv_dsDV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set Font Segoe UI, 14pt, style=Bold
            dgv_dsDV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void DataGridView_AutoSize()
        {
            var col = dgv_dsDV.Columns;

            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 3) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 4) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 5) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 6) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 7) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 8) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 9) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 10) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                // Etc...
            }
        }

        private void dgv_dsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dgv_dsDV.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_IdDV.Text = dgv_dsDV.Rows[dongchon].Cells["Id_DV"].Value.ToString();
                this.txt_loaiDV.Text = dgv_dsDV.Rows[dongchon].Cells["LoaiDV"].Value.ToString();
                this.txt_dongia.Text = dgv_dsDV.Rows[dongchon].Cells["DonGia"].Value.ToString();
                this.txt_mota.Text = dgv_dsDV.Rows[dongchon].Cells["MoTaDV"].Value.ToString();
            }
        }

        private void bt_timma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tukhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_timkiem.Text == "DonGia")
            {
                string strTimKiem = "SELECT * FROM DichVu WHERE " + cb_timkiem.Text + " like '%" + Convert.ToDecimal(txt_tukhoa.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_dsDV.DataSource = dt;
            }
            else
            {
                string strTimKiem = "SELECT * FROM DichVu WHERE " + cb_timkiem.Text + " like N'%" + txt_tukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_dsDV.DataSource = dt;
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            resetValues();
            load_data();
        }

        private void dgv_dsDV_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_dsDV.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO DichVu values (@LoaiDV, @MoTaDV, @DonGia)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("@LoaiDV", this.txt_loaiDV.Text);
            cmd.Parameters.AddWithValue("@MoTaDV", this.txt_mota.Text);
            cmd.Parameters.AddWithValue("@DonGia", this.txt_dongia.Text);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm thành công");
            load_data();
            resetValues();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "Update DichVu set LoaiDV  = @LoaiDV, MoTaDV = @MoTaDV, DonGia = @DonGia where Id_DV = @Id_DV";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@Id_DV", this.txt_IdDV.Text);
                cmd.Parameters.AddWithValue("@LoaiDV", this.txt_loaiDV.Text);
                cmd.Parameters.AddWithValue("@MoTaDV", this.txt_mota.Text);
                cmd.Parameters.AddWithValue("@DonGia", this.txt_dongia.Text);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Update thông tin thành công");
                else
                    MessageBox.Show("Update thông tin thất bại");
                resetValues();
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không??", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("Delete from DichVu where Id_DV = @Id_DV", conn);
                    cmd.Parameters.AddWithValue("@Id_DV", this.txt_IdDV.Text);
                    cmd.Parameters.AddWithValue("@LoaiDV", this.txt_loaiDV.Text);
                    cmd.Parameters.AddWithValue("@MoTaDV", this.txt_mota.Text);
                    cmd.Parameters.AddWithValue("@DonGia", this.txt_dongia.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa dịch vụ thành công");
                    else
                        MessageBox.Show("Xóa dịch vụ thất bại");
                    resetValues();
                    load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
