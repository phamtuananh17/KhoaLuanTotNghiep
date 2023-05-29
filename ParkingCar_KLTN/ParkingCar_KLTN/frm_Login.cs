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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();

        public void set_lableandpicture()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
        }

        public bool kiemtra()
        {
            if (String.IsNullOrEmpty(tb_user.Text.Trim()))
            {
                MessageBox.Show("Please enter Username!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                tb_user.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                MessageBox.Show("Please enter Password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtpass.Focus();
                return false;
            }
            return true;
        }

        private void load()
        {
            set_lableandpicture();
            this.KeyPreview = true;
            this.KeyDown += btnlogin_KeyDown;
            tb_user.Text = "";
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           if (kiemtra())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "User_login";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@Username", tb_user.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtpass.Text);
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
                    if (code == 1)
                    {
                        string strad = "SELECT HoTen FROM NhanVien WHERE Username = '" + tb_user.Text + "'";
                        cmd = new SqlCommand(strad, conn);
                        string sqlad = (string)cmd.ExecuteScalar();
                        string strID = "SELECT Id_NV FROM NhanVien WHERE Username = '" + tb_user.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(strID, conn);
                        int MAD = Convert.ToInt32(cmd1.ExecuteScalar());
                        MessageBox.Show("Chào mừng " + sqlad + " đến với hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.quyensudung = 1;
                        frm_MenuHT Child = new frm_MenuHT();
                        Child.Message = sqlad;
                        Child.Id_User = MAD.ToString();
                        Child.Show();
                        this.Hide();
                    }
                    else if (code == 2)
                    {
                        string strNV = "SELECT HoTen FROM NhanVien WHERE Username = '" + tb_user.Text + "'";
                        cmd = new SqlCommand(strNV, conn);
                        string sqlnv = (string)cmd.ExecuteScalar();
                        string strID = "SELECT Id_NV FROM NhanVien WHERE Username = '" + tb_user.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(strID, conn);
                        int MNV = Convert.ToInt32(cmd1.ExecuteScalar());
                        MessageBox.Show("Chào mừng " + sqlnv + " đến với hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.quyensudung = 2;
                        frm_MenuHT Child = new frm_MenuHT();
                        Child.Message = sqlnv;
                        Child.Id_User = MNV.ToString();
                        Child.Show();
                        this.Hide();
                    }
                    else if (code == 3)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.quyensudung = 3;
                        tb_user.Text = "";
                        txtpass.Text = "";
                        tb_user.Focus();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienthi.Checked)
            {
                txtpass.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}
