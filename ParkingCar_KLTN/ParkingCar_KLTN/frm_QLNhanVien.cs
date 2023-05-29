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
using Microsoft.Office.Interop.Excel;

namespace ParkingCar_KLTN
{
    public partial class frm_QLNhanVien : Form
    {
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection conn = DBConnection.getDBConnection();

        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }

        void load_data()
        {

            SqlDataAdapter da1 = new SqlDataAdapter("select *from NhanVien", conn);
            System.Data.DataTable dt1 = new System.Data.DataTable();
            da1.Fill(dt1);
            this.dgv_showNV.DataSource = dt1;

            SqlCommand cmd = new SqlCommand("select DISTINCT Users.Username from Users, NhanVien where Users.Username != NhanVien.Username", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cb_user.DataSource = dt;
            cb_user.DisplayMember = "Username";
        }

        private void dgv_showNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dongchon = -1;
                dongchon = dgv_showNV.CurrentRow.Index;
                if (dongchon >= 0)
                {
                    txt_maNV.Text = dgv_showNV.Rows[dongchon].Cells["Id_NV"].Value.ToString();
                    txt_hoTen.Text = dgv_showNV.Rows[dongchon].Cells["HoTen"].Value.ToString();
                    cb_user.Text = dgv_showNV.Rows[dongchon].Cells["Username"].Value.ToString();
                    txt_email.Text = dgv_showNV.Rows[dongchon].Cells["Email"].Value.ToString();
                    txt_diaChi.Text = dgv_showNV.Rows[dongchon].Cells["DiaChi"].Value.ToString();
                    cb_calam.Text = dgv_showNV.Rows[dongchon].Cells["CaLam"].Value.ToString();
                    txt_sdt.Text = dgv_showNV.Rows[dongchon].Cells["SoDT"].Value.ToString();
                    if (Convert.ToBoolean(dgv_showNV.Rows[dongchon].Cells["GioiTinh"].Value) == true)
                        rb_nu.Checked = true;
                    else
                        rb_nam.Checked = true;
                    dtp_ngaySinh.Value = Convert.ToDateTime(dgv_showNV.Rows[dongchon].Cells["NgaySinh"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DataGridView_colorText()
        {
            this.dgv_showNV.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_showNV.DefaultCellStyle.BackColor = Color.LightSkyBlue;
        }
        private void DataGridView_CentreHeaders()
        {
            dgv_showNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_showNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_showNV.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void DataGridView_AutoSize()
        {
            var col = dgv_showNV.Columns;

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
            }
        }

        private void dgv_showNV_VisibleChanged(object sender, EventArgs e)
        {
            if (dgv_showNV.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_CentreHeaders();
                DataGridView_colorText();
            }
        }

        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txt_hoTen.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên nhân viên");
                txt_hoTen.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_email.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập email nhân viên");
                txt_email.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_diaChi.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập địa chỉ nhân viên");
                txt_diaChi.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cb_user.Text.Trim()))
            {
                MessageBox.Show("Hãy chọn user");
                cb_user.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_sdt.Text.Trim()))
            {
                MessageBox.Show("Hãy chọn user");
                if (txt_sdt.Text.Length >= 10)
                {
                    MessageBox.Show("Số điện thoại >10, Vui lòng nhập đủ 10 ký tự");
                    txt_sdt.Focus();
                }
                return false;
            }
            return true;
        }

        void reset_Value()
        {
            txt_diaChi.ResetText();
            txt_email.ResetText();
            txt_hoTen.ResetText();
            txt_maNV.ResetText();
            txt_sdt.ResetText();
            cb_chucvu.SelectedIndex = 0;
            cb_calam.SelectedIndex = 0;
            cb_user.SelectedIndex = 0;
            txt_Search.ResetText();
            txt_maNV.Focus();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sqlCKECK = "select count(*) Username from NhanVien where Username = @Username";
            SqlCommand cmdl = new SqlCommand(sqlCKECK, conn);
            if (kiemtra())
            {
                try
                {
                    cmdl.Parameters.AddWithValue("@Username", cb_user.Text);
                    int val = (int)cmdl.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("User này đã tồn tại!!, Vui lòng thêm user khác");
                    }
                    else
                    {
                        int index = dgv_showNV.CurrentRow.Index;
                        SqlCommand cmd = new SqlCommand("Insert into NhanVien( Username, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, Email, ChucVu, CaLam) " +
                            "values (@Username, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDT, @Email, @ChucVu , @CaLam)", conn);
                        cmd.Parameters.AddWithValue("@Username", cb_user.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txt_hoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
                        cmd.Parameters.AddWithValue("@SoDT", txt_sdt.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cb_chucvu.Text);
                        cmd.Parameters.AddWithValue("@CaLam", cb_calam.Text);
                        if (rb_nam.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        if (rb_nu.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }
                        if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm nhân viên thành công!!");
                        else MessageBox.Show("Thêm nhân viên thất bại");
                        load_data();
                        reset_Value();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int dongchon = dgv_showNV.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("update NhanVien set Username= @Username," +
                "HoTen= @HoTen, NgaySinh= @NgaySinh, GioiTinh= @GioiTinh, DiaChi= @DiaChi, SoDT= @SoDT, Email= @Email, ChucVu= @ChucVu, CaLam= @CaLam " +
                "where Id_NV=@maNhanViencu", conn);
            cmd.Parameters.AddWithValue("@Username", cb_user.Text);
            cmd.Parameters.AddWithValue("@HoTen", txt_hoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
            cmd.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
            cmd.Parameters.AddWithValue("@SoDT", txt_sdt.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@ChucVu", cb_chucvu.Text);
            cmd.Parameters.AddWithValue("@CaLam", cb_calam.Text);
            cmd.Parameters.AddWithValue("@maNhanViencu", dgv_showNV.Rows[dongchon].Cells["Id_NV"].Value);
            if (rb_nu.Checked)
                cmd.Parameters.AddWithValue("@GioiTinh", true);
            else
                cmd.Parameters.AddWithValue("@GioiTinh", false);
            if
                (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa nhân viên thành công!!!");
            else
                MessageBox.Show("Sửa thất bại !!!");
            load_data();
            reset_Value();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int dongchon = dgv_showNV.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("delete from NhanVien where Id_NV=@Id_NV", conn);
            cmd.Parameters.AddWithValue("@Id_NV", dgv_showNV.Rows[dongchon].Cells["Id_NV"].Value);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Xóa thành công !!!");
            else
                MessageBox.Show("Xóa thất bại !!!");
            load_data();
            reset_Value();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (rb_hoTen.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("select * from NhanVien where HoTen like '%" + txt_Search.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgv_showNV.DataSource = dt;
            }
            else if (rb_MaNV.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("select * from NhanVien where Id_NV like '%" + txt_Search.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgv_showNV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên này!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose_form.setLeggee(1);
            new frm_QLTaiKhoan().Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            frm_MenuHT frm_menu = new frm_MenuHT();
            frm_menu.Show();
            this.Hide();
        }

        private void frm_QLNhanVien_Load_1(object sender, EventArgs e)
        {
            load_data();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cb_calam.SelectedIndex = 0;
            cb_chucvu.SelectedIndex = 0;
            txt_TongSV.Text = dgv_showNV.Rows.Count.ToString();
        }

        private void ToExcel(DataGridView g, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý nhân viên";

                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe = worksheet.get_Range("A1", "E1");
                row1_TieuDe.Merge();
                row1_TieuDe.Font.Size = fontSizeTieuDe;
                row1_TieuDe.Font.Name = fontName;
                row1_TieuDe.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1_TieuDe.Value2 = "Danh sách nhân viên";

                // export header trong DataGridView
                for (int i = 0; i < g.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = g.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < g.RowCount; i++)
                {
                    for (int j = 0; j < g.ColumnCount; j++)
                    {
                        Convert.ToString(worksheet.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value);
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgv_showNV, saveFileDialog1.FileName);
            }
        }
    }
}
