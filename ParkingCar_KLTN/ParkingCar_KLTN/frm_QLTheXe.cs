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
    public partial class frm_QLTheXe : Form
    {
        public frm_QLTheXe()
        {
            InitializeComponent();
        }

        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void bt_exit_Click(object sender, EventArgs e)
        {
            frm_MenuHT frm_menu = new frm_MenuHT();
            frm_menu.Show();
            this.Hide();
        }

        void load_data()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from The";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_DSThe.DataSource = table;
        }

        public void load_column()
        {
            SqlCommand cmd = new SqlCommand("Select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='The'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_timkiem.DataSource = dt;
            cb_timkiem.DisplayMember = "column_name";
        }

        private void frm_QLTheXe_Load(object sender, EventArgs e)
        {
            conn.Open();
            txt_mathe.Focus();
            cb_loaithe.SelectedIndex = 0;
            load_data();
            load_column();
        }

        private void DataGridView_colorText()
        {
            this.dgv_DSThe.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_DSThe.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void DataGridView_CentreHeaders()
        {
            dgv_DSThe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_DSThe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DSThe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void DataGridView_AutoSize()
        {
            var col = dgv_DSThe.Columns;

            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 3) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
            }
        }

        private void dgv_DSThe_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_DSThe.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void dgv_DSThe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = dgv_DSThe.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_mathe.Text = dgv_DSThe.Rows[dongchon].Cells["Id_The"].Value.ToString();
                this.cb_loaithe.Text = dgv_DSThe.Rows[dongchon].Cells["LoaiThe"].Value.ToString();
            }
        }

        void reset_Value()
        {
            txt_mathe.ResetText();
            txt_tukhoa.ResetText();
            txt_mathe.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
            reset_Value();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tukhoa.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_tukhoa.Focus();
                return;
            }
            else
            {
                string strTimKiem = "SELECT * FROM The where " + cb_timkiem.Text + " like N'%" + txt_tukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_DSThe.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "INSERT INTO The (Id_The, LoaiThe) values(@Id_The, @LoaiThe)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@Id_The", this.txt_mathe.Text);
                cmd.Parameters.AddWithValue("@LoaiThe", this.cb_loaithe.Text);
                cmd.ExecuteNonQuery();
                reset_Value();
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Update The set LoaiThe = @LoaiThe where Id_The =@Id_The", conn);
            cmd.Parameters.AddWithValue("@Id_The", this.txt_mathe.Text);
            cmd.Parameters.AddWithValue("@LoaiThe", this.cb_loaithe.Text);
            cmd.ExecuteNonQuery();
            reset_Value();
            load_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thẻ xe này không??", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("Delete from The where Id_The = @Id_The", conn);
                    cmd.Parameters.AddWithValue("@Id_The", this.txt_mathe.Text);
                    cmd.Parameters.AddWithValue("@LoaiThe", this.cb_loaithe.Text);
                    cmd.ExecuteNonQuery();
                    reset_Value();
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
