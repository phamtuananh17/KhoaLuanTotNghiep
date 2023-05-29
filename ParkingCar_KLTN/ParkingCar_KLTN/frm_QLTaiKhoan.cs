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
    public partial class frm_QLTaiKhoan : Form
    {
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void load_data()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select *from Users";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_DSUser.DataSource = table;
        }

        public void load_column()
        {
            SqlCommand cmd = new SqlCommand("Select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Users'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_timkiem.DataSource = dt;
            cb_timkiem.DisplayMember = "column_name";
        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_data();
            load_column();
            txt_usser.Focus();
        }

        private void DataGridView_colorText()
        {
            this.dgv_DSUser.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_DSUser.DefaultCellStyle.BackColor = Color.AntiqueWhite;
        }
        private void DataGridView_CentreHeaders()
        {
            dgv_DSUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_DSUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DSUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void DataGridView_AutoSize()
        {
            var col = dgv_DSUser.Columns;

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
            txt_usser.ResetText();
            txt_pass.ResetText();
            txt_tukhoa.ResetText();
            txt_usser.Focus();
        }

        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txt_usser.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên user");
                txt_usser.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_pass.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mật khẩu");
                txt_pass.Focus();
                return false;
            }
            else if (txt_pass.Text.Length < 6 && txt_pass.Text.Length > 25)
            {
                MessageBox.Show("Hãy nhập mật khẩu đúng độ dài từ 6 -> 24 ký tự");
                txt_pass.Focus();
                return false;
            }
            return true;
        }

        private void dgv_DSUser_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_DSUser.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_CentreHeaders();
                DataGridView_colorText();
            }
        }

        private void dgv_DSUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = dgv_DSUser.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txt_usser.Text = dgv_DSUser.Rows[dongchon].Cells["Username"].Value.ToString();
                this.txt_pass.Text = dgv_DSUser.Rows[dongchon].Cells["Pass"].Value.ToString();
                this.cb_quyen.Text = dgv_DSUser.Rows[dongchon].Cells["LoaiNguoiDung"].Value.ToString();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string sqlCKECK = "Select count(*) Username from Users where Username = @Username";
            SqlCommand cmdl = new SqlCommand(sqlCKECK, conn);
            if (kiemtra())
            {
                try
                {
                    cmdl.Parameters.AddWithValue("@Username", txt_usser.Text);
                    int val = (int)cmdl.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("Users này đã tồn tại!!");
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO Users (Username, Pass, LoaiNguoiDung) values(@Username, @Pass, @LoaiNguoiDung)";
                        SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                        cmd.Parameters.AddWithValue("@Username", this.txt_usser.Text);
                        cmd.Parameters.AddWithValue("@Pass", this.txt_pass.Text);
                        cmd.Parameters.AddWithValue("@LoaiNguoiDung", this.cb_quyen.Text);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Thêm user thành công");
                        else
                            MessageBox.Show("Thêm user thất bại");
                        reset_Value();
                        load_data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin cần để thêm!!");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "Update Users set Pass  = @Pass, LoaiNguoiDung = @LoaiNguoiDung where Username = @Username";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@Username", this.txt_usser.Text);
                cmd.Parameters.AddWithValue("@Pass", this.txt_pass.Text);
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", this.cb_quyen.Text);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Update thông tin thành công");
                else
                    MessageBox.Show("Update thông tin thất bại");
                reset_Value();
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tukhoa.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_tukhoa.Focus();
                return;
            }
            else
            {
                string strTimKiem = "SELECT * FROM Users where " + cb_timkiem.Text + " like N'%" + txt_tukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_DSUser.DataSource = dt;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa user này không??", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("Delete from Users where Username = @Username", conn);
                    cmd.Parameters.AddWithValue("@Username", this.txt_usser.Text);
                    cmd.Parameters.AddWithValue("@Pass", this.txt_pass.Text);
                    cmd.Parameters.AddWithValue("@LoaiNguoiDung", this.cb_quyen.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa user thành công");
                    else
                        MessageBox.Show("Xóa user thất bại");
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
