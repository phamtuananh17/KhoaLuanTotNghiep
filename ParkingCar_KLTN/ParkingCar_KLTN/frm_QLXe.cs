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
using System.IO;

namespace ParkingCar_KLTN
{
    public partial class frm_QLXe : Form
    {
        public frm_QLXe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_MenuHT frm_menu = new frm_MenuHT();
            frm_menu.Show();
            this.Hide();
        }

        private void bt_qlxevao_Click(object sender, EventArgs e)
        {
        }

        private void bt_qlxera_Click(object sender, EventArgs e)
        {
        }

        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load_data()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Xe";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_quanlixe.DataSource = table;
        }

        public void load_column()
        {
            SqlCommand cmd = new SqlCommand("Select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Xe' and column_name != 'FileData' and column_name != 'MoTa' and column_name != 'DuongDan'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_cachtim.DataSource = dt;
            cb_cachtim.DisplayMember = "column_name";

            SqlCommand cmdkv = new SqlCommand("Select Id_KV from KhuVuc where TrangThai like N'%" + "Rảnh" + "%'", conn);
            SqlDataAdapter dakv = new SqlDataAdapter(cmdkv);
            DataTable dtkv = new DataTable();
            dakv.Fill(dtkv);
            cb_khuvuc.DataSource = dtkv;
            cb_khuvuc.DisplayMember = "Id_KV";
        }

        private void frm_QLXe_Load(object sender, EventArgs e)
        {
            conn.Open();
            txt_bienso.Focus();
            load_data();
            load_column();
            cbo_loaixe.SelectedIndex = 0;
            bt_soxe.Text = getSoLuong().ToString();
            lb_time.Text = DateTime.Now.ToString();
        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Update Xe set DuongDan= @DuongDan, LoaiXe= @LoaiXe, Id_KV= @Id_KV, CuocPhi= @CuocPhi where BienSo = @BienSo", conn);
                cmd.Parameters.AddWithValue("@BienSo", this.txt_bienso.Text);
                cmd.Parameters.AddWithValue("@DuongDan", this.txt_duongdan.Text);
                cmd.Parameters.AddWithValue("@LoaiXe", this.cbo_loaixe.Text);
                cmd.Parameters.AddWithValue("@Id_KV", this.cb_khuvuc.Text);
                cmd.Parameters.AddWithValue("@CuocPhi", this.txt_cuocphi.Text);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Sửa thông tin thành công");
                else
                    MessageBox.Show("Sửa thông tin thất bại");
                load_data();
                reset_Value();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            //thiết lập đuôi file có thể mở
            openFileDialog1.InitialDirectory = @"C:\Users\admin\source\repos\ParkingCar_KLTN";
            openFileDialog1.Filter = "JPG (*.JPG), PNG (*.PNG), GIF (*.GIF), BMP (*.BMP)|*.jpg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(openFileDialog1.FileName);
                txt_duongdan.Text = path;
            }
        }

        private void cbo_loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_loaixe.SelectedIndex == 0)
            {
                txt_cuocphi.Text = "10000";
            }
            else if (cbo_loaixe.SelectedIndex == 1)
            {
                txt_cuocphi.Text = "15000";
            }
            else if (cbo_loaixe.SelectedIndex == 2)
            {
                txt_cuocphi.Text = "20000";
            }
            else if (cbo_loaixe.SelectedIndex == 3)
            {
                txt_cuocphi.Text = "30000";
            }
            else
            {
                txt_cuocphi.Text = "40000";
            }
        }

        int getSoLuong()
        {
            string sql = "SELECT COUNT(*) FROM Xe";
            cmd = new SqlCommand(sql, conn);
            int a = (int)(cmd.ExecuteScalar());
            return a;
        }

        private void bt_soxe_Click(object sender, EventArgs e)
        {
        }

        private void DataGridView_colorText()
        {
            this.dgv_quanlixe.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_quanlixe.DefaultCellStyle.BackColor = Color.AntiqueWhite;
        }
        private void DataGridView_CentreHeaders()
        {
            dgv_quanlixe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_quanlixe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_quanlixe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void DataGridView_AutoSize()
        {
            var col = dgv_quanlixe.Columns;

            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 4) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 5) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
            }
        }

        void reset_Value()
        {
            txt_bienso.ResetText();
            txt_cuocphi.ResetText();
            txt_duongdan.ResetText();
            cb_khuvuc.SelectedIndex = 0;
            txt_tukhoa.ResetText();
            cbo_loaixe.SelectedIndex = 0;
            txt_bienso.Focus();
        }

        private void dgv_quanlixe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = dgv_quanlixe.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_bienso.Text = dgv_quanlixe.Rows[dongchon].Cells["BienSo"].Value.ToString();
                this.txt_duongdan.Text = dgv_quanlixe.Rows[dongchon].Cells["DuongDan"].Value.ToString();
                this.cbo_loaixe.Text = dgv_quanlixe.Rows[dongchon].Cells["LoaiXe"].Value.ToString();
                this.cb_khuvuc.Text = dgv_quanlixe.Rows[dongchon].Cells["Id_KV"].Value.ToString();
                this.txt_cuocphi.Text = dgv_quanlixe.Rows[dongchon].Cells["CuocPhi"].Value.ToString();
            }
        }

        private void dgv_quanlixe_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_quanlixe.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_CentreHeaders();
                DataGridView_colorText();
            }
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
                string strTimKiem = "Select BienSo, LoaiXe, DuongDan, Id_KV, CuocPhi from Xe where " + cb_cachtim.Text + " like N'%" + txt_tukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_quanlixe.DataSource = dt;
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset_Value();
            load_data();
        }
    }
}
