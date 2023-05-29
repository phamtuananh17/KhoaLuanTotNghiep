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
    public partial class frm_QlBaiXe : Form
    {
        public frm_QlBaiXe()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;

        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='KhuVuc'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cb_timkiem.DataSource = dt;
            cb_timkiem.DisplayMember = "column_name";
        }
        public void load_data()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from KhuVuc", conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "khuvuc");
            dgv_dsKV.DataSource = ds;
            dgv_dsKV.DataMember = "khuvuc";
        }
        private void resetValues()
        {
            txt_IdKV.ResetText();
            txt_loaiKV.ResetText();
            txt_tukhoa.ResetText();
            txt_IdKV.Focus();
        }

        private void frm_QlBaiXe_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_Colum();
            load_data();
            rb_ranh.Checked = true;
        }

        private void DataGridView_colorText()
        {
            this.dgv_dsKV.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_dsKV.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void DataGridView_CentreHeaders()
        {
            // Centre Column Cells Content
            dgv_dsKV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centre (Column and Row) Headers    
            dgv_dsKV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set Font Segoe UI, 14pt, style=Bold
            dgv_dsKV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void DataGridView_AutoSize()
        {
            var col = dgv_dsKV.Columns;

            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 3) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 4) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 5) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                // Etc...
            }
        }

        private void dgv_dsKV_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_dsKV.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void dgv_dsKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dgv_dsKV.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_IdKV.Text = dgv_dsKV.Rows[dongchon].Cells["Id_KV"].Value.ToString();
                this.txt_loaiKV.Text = dgv_dsKV.Rows[dongchon].Cells["LoaiKV"].Value.ToString();
                if (dgv_dsKV.Rows[dongchon].Cells["TrangThai"].Value.ToString() == "Bận")
                {
                    rb_ban.Checked = true;
                }
                else
                {
                    rb_ranh.Checked = true;
                }
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tukhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string strTimKiem = "SELECT * FROM KhuVuc WHERE " + cb_timkiem.Text + " like N'%" + txt_tukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_dsKV.DataSource = dt;
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            resetValues();
            load_data();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "INSERT INTO KhuVuc values (@Id_KV, @LoaiKV, @TrangThai)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@Id_KV", this.txt_IdKV.Text);
                cmd.Parameters.AddWithValue("@LoaiKV", this.txt_loaiKV.Text);
                if (rb_ban.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", "Bận");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrangThai", "Rảnh");
                }

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thông tin thành công");
                else
                    MessageBox.Show("Thêm thông tin thất bại");
                resetValues();
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "Update KhuVuc set LoaiKV  = @LoaiKV, TrangThai = @TrangThai where Id_KV = @Id_KV";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@Id_KV", this.txt_IdKV.Text);
                cmd.Parameters.AddWithValue("@LoaiKV", this.txt_loaiKV.Text);
                if (rb_ban.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", "Bận");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrangThai", "Rảnh");
                }
                
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
                    cmd = new SqlCommand("Delete from KhuVuc where Id_KV = @Id_KV", conn);
                    cmd.Parameters.AddWithValue("@Id_KV", this.txt_IdKV.Text);
                    cmd.Parameters.AddWithValue("@LoaiKV", this.txt_loaiKV.Text);
                    if (rb_ban.Checked)
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", "Bận");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", "Rảnh");
                    }

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa khu vực thành công");
                    else
                        MessageBox.Show("Xóa khu vực thất bại");
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
