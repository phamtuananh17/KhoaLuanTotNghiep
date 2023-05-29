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
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections;
using System.Threading;
using System.Globalization;

namespace ParkingCar_KLTN
{
    public partial class frm_MenuHT : Form
    {
        public frm_MenuHT()
        {
            InitializeComponent();
        }

        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private string _id;
        public string Id_User
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        private string Id_the;
        public string GetId_The
        {
            get { return Id_the; }
            set { Id_the = value; }
        }

        int getSoLuong()
        {
            string sql = "SELECT COUNT(*) FROM XeVao";
            cmd = new SqlCommand(sql, conn);
            int a = (int)(cmd.ExecuteScalar());
            return a;
        }

        void load_Data()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from Xe", conn);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            SqlDataAdapter da1 = new SqlDataAdapter("select *from KhuVuc", conn);
            DataTable dt1 = new System.Data.DataTable();
            da1.Fill(dt1);

            SqlDataAdapter da2 = new SqlDataAdapter("select *from The", conn);
            DataTable dt2 = new System.Data.DataTable();
            da2.Fill(dt2);

            SqlDataAdapter da3 = new SqlDataAdapter("select *from HoaDonXe", conn);
            DataTable dt3 = new System.Data.DataTable();
            da3.Fill(dt3);
        }

        void Load_Form()
        {
            cbo_loaixevao.SelectedIndex = 0;
            cb_mota.SelectedIndex = 0;
            txt_mathe.ResetText();
            txt_biensovao.ResetText();
            txt_bienso.ResetText();
            cbo_loaixevao.SelectedIndex = 0;
            cb_loaithein.SelectedIndex = 0;
            cb_mota.SelectedIndex = 0;
            cb_trangthai.SelectedIndex = 0;
            txt_cuocphi.ResetText();
            txt_thanhtoan.ResetText();
            txt_thera.ResetText();
            txt_thedc.ResetText();
            txt_duongdan.ResetText();
            cb_loaixera.SelectedIndex = 0;
            txt_phigui.ResetText();
            txt_biensodc.ResetText();
            ptb_anhin2.Image = null;
            ptb_camin.Image = null;
            ptb_camout.Image = null;
            ptb_anhout2.Image = null;
            pb_anhdc.Image = null;
            txt_vitricl.Text = (int.Parse(txt_tongvitri.Text) - getSoLuong()).ToString();
        }


        private void frm_MenuHT_Load(object sender, EventArgs e)
        {
            conn.Open();
            lb_Name.Text = _message;
            lb_Id.Text = _id;
            txt_mathe.Text = Id_the;
            txt_tongvitri.Text = "300";
            this.IsMdiContainer = true;
            Load_Form();
            if(Program.quyensudung == 2)
            {
                bt_qltk.Enabled = false;
                bt_qlnhanvien.Enabled = false;
                bt_qlbaixe.Enabled = false;
            }

            UpdateDisplayTimer.Enabled = true;
            UpdateDisplayTimer.Start();
            lb_date.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        private void bt_htguixe_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn đăng xuất khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                new frm_Login().Show();
                this.Hide();
            }
        }

        public void GetName(string s)
        {
            lb_Name.Text = s;/*Gán Giá Trí chuỗi S(nhận giá trị từ bên form 2)vào textBox1*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_DoiMatKhau));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_DoiMatKhau f = new frm_DoiMatKhau();
                f.Message = lb_Name.Text;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txt_biensovao.Text.Trim()))
            {
                MessageBox.Show("Biển số chưa được xác nhận");
                txt_biensovao.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_mathe.Text.Trim()))
            {
                MessageBox.Show("Hãy chọn dữ liệu giả lập để thiết lập thẻ");
                return false;
            }
            return true;
        }

        private void bt_camin_Click(object sender, EventArgs e)
        {
            //thiết lập đuôi file có thể mở
            openFileDialog1.InitialDirectory = @"C:\ParkingCar_KLTN";
            openFileDialog1.Filter = "JPG (*.JPG), PNG (*.PNG), GIF (*.GIF), BMP (*.BMP)|*.jpg;*.png;*.gif;*.bmp";

            //Đọc ảnh vào Bitmap
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(openFileDialog1.FileName);
                txt_duongdan.Text = path;

                ptb_anhin2.Image = new Bitmap(@"C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/4.jpg");
                String fileName = openFileDialog1.FileName;
                ptb_anhin2.Image = null;
                Bitmap b = new Bitmap(fileName);
                ptb_camin.Image = b;
                Bitmap pic = new Bitmap(b);

                b.Save(@"C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/test/aaa.jpg");
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "cmd.exe";
                string k = "Hidden";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "start /b cmd /c py C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/demo.py";
                p.Start();

                String output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                int len = output.Split('\n').Length;
                string str = output.Split('\n')[len - 2];
                string num = output.Split('\n')[len - 3];
                txt_biensovao.Text = str;
                p.Close();
                Console.WriteLine("num = " + num.Replace("\n", "").Replace("\r", ""));
                Console.WriteLine("bien so = " + str);
                Bitmap a = new Bitmap("C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/" + num.Replace("\n", "").Replace("\r", "") + ".jpg");
                ptb_anhin2.Image = a;
            }
        }

        //chuyển img về dang byte để lưu trữ
        byte[] imageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, ImageFormat.Png);
            return m.ToArray();
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            byte[] b = imageToByteArray(ptb_camin.Image);
            string sqlCKECKBS = "select count(*) BienSo from Xe where BienSo = @BienSo";
            SqlCommand cmdlbs = new SqlCommand(sqlCKECKBS, conn);
            if (kiemtra())
            {
                try
                {
                    cmdlbs.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                    int val = (int)cmdlbs.ExecuteScalar();
                    if (val > 0)
                    {

                        string sql = "Update Xe set LoaiXe = @LoaiXe, DuongDan = @DuongDan, FileData = @FileData, Id_KV = @Id_KV, CuocPhi = @CuocPhi where BienSo = @BienSo";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@LoaiXe", cbo_loaixevao.Text);
                        cmd.Parameters.AddWithValue("@DuongDan", this.txt_duongdan.Text);
                        cmd.Parameters.AddWithValue("@Id_KV", this.cb_khuvucin.Text);
                        cmd.Parameters.AddWithValue("@FileData", b);
                        cmd.Parameters.AddWithValue("@CuocPhi", this.txt_cuocphi.Text);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string sql = "INSERT INTO Xe (BienSo, LoaiXe, DuongDan, FileData, Id_KV, CuocPhi) values (@BienSo, @LoaiXe, @DuongDan, @FileData, @Id_KV, @CuocPhi)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@LoaiXe", cbo_loaixevao.Text);
                        cmd.Parameters.AddWithValue("@DuongDan", this.txt_duongdan.Text);
                        cmd.Parameters.AddWithValue("@Id_KV", this.cb_khuvucin.Text);
                        cmd.Parameters.AddWithValue("@FileData", b);
                        cmd.Parameters.AddWithValue("@CuocPhi", this.txt_cuocphi.Text);
                        cmd.ExecuteNonQuery();
                    }
                        
                    string sqlxv = "INSERT INTO XeVao (BienSo, MoTa, ThoiGianVao) values (@BienSo, @MoTa, @ThoiGianVao)";
                    SqlCommand cmdxv = new SqlCommand(sqlxv, conn);
                    cmdxv.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                    cmdxv.Parameters.AddWithValue("@MoTa", cb_mota.Text);
                    cmdxv.Parameters.AddWithValue("@ThoiGianVao", DateTime.Parse(lb_date.Text));
                    cmdxv.ExecuteNonQuery();

                    string sqlsxv = "INSERT INTO SoTheVao (BienSo, Id_The) values (@BienSo, @Id_The)";
                    SqlCommand cmdsxv = new SqlCommand(sqlsxv, conn);
                    cmdsxv.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                    cmdsxv.Parameters.AddWithValue("@Id_The", txt_mathe.Text);
                    cmdsxv.ExecuteNonQuery();

                    string a = "Bận";
                    string sqlkv = "Update KhuVuc set TrangThai = @TrangThai where Id_KV = @Id_KV";
                    SqlCommand cmdkv = new SqlCommand(sqlkv, conn);
                    cmdkv.Parameters.AddWithValue("@Id_KV", cb_khuvucin.Text);
                    cmdkv.Parameters.AddWithValue("@TrangThai", a);
                    cmdkv.ExecuteNonQuery();

                    string sqlt = "Update The set LoaiThe = @LoaiThe where Id_The = @Id_The";
                    SqlCommand cmdt = new SqlCommand(sqlt, conn);
                    cmdt.Parameters.AddWithValue("@Id_The", this.txt_mathe.Text.ToUpper());
                    cmdt.Parameters.AddWithValue("@LoaiThe", this.cb_loaithein.Text);
                    cmdt.ExecuteNonQuery();

                    string sqlhd = "INSERT INTO HoaDonXe (BienSo) values (@BienSo)";
                    SqlCommand cmdhd = new SqlCommand(sqlhd, conn);
                    cmdhd.Parameters.AddWithValue("@BienSo", this.txt_biensovao.Text.ToUpper());
                    if (cmdhd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xe đã vào bến thành công");
                    }

                    bt_openin.Text = "Barrier đang mở";
                    bt_openin.BackColor = Color.Green;
                    load_Data();
                    Load_Form();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void cbo_loaixevao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaithein.SelectedIndex == 0)
            {
                if (cbo_loaixevao.SelectedIndex == 0)
                {
                    txt_cuocphi.Text = "15000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%4- 7 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 1)
                {
                    txt_cuocphi.Text = "20000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%10- 16 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 2)
                {
                    txt_cuocphi.Text = "30000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%17- 19 chỗ'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 3)
                {
                    txt_cuocphi.Text = "40000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%30 chỗ trở lên'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
            }
            else
            {
                if (cbo_loaixevao.SelectedIndex == 0)
                {
                    txt_cuocphi.Text = "500000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%4- 7 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 1)
                {
                    txt_cuocphi.Text = "800000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%10- 16 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 2)
                {
                    txt_cuocphi.Text = "1000000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%17- 19 chỗ'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 3)
                {
                    txt_cuocphi.Text = "1200000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%30 chỗ trở lên'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
            }
        }

        public void Getvalue(string s)
        {
            txt_mathe.Text = s;/*Gán Giá Trí chuỗi S(nhận giá trị từ bên form 2)vào textBox1*/
        }

        public void Getcontent(string s)
        {
            txt_thera.Text = s;/*Gán Giá Trí chuỗi S(nhận giá trị từ bên form 2)vào textBox1*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_qltk_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QLTaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QLTaiKhoan f = new frm_QLTaiKhoan();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_qlnhanvien_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QLNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QLNhanVien f = new frm_QLNhanVien();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_qlxe_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QLXe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QLXe f = new frm_QLXe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_luong_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QLTheXe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QLTheXe f = new frm_QLTheXe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_qlthexe_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QLDichVu));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QLDichVu f = new frm_QLDichVu();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        string get_Time()
        {
            cmd = new SqlCommand("select ThoiGianVao FROM XeVao where BienSo = '" + txt_bienso.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            DateTime TimeIn = new DateTime();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string timein = dr["ThoiGianVao"].ToString();
                TimeIn = DateTime.Parse(timein);
            }
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget

            SqlCommand cmd1 = new SqlCommand("select ThoiGianRa FROM XeRa where BienSo = '" + txt_bienso.Text + "'", conn);
            cmd1.CommandType = CommandType.Text;
            DateTime TimeOut = new DateTime();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                string timeout = dr1["ThoiGianRa"].ToString();
                TimeOut = DateTime.Parse(timeout);
            }
            dr1.Close(); // <- too easy to forget
            dr1.Dispose(); // <- too easy to forget

            TimeSpan ts = TimeOut - TimeIn;
            return ts.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(txt_thera.Text, txt_thedc.Text, true) == 0)
            {
                DialogResult dialog = MessageBox.Show("Đúng biển số khi vào, có muốn cho xe ra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        if (String.Compare(cb_loaithe.Text, "Thẻ tháng", true) == 0)
                        {
                            string sqlt = "Update The set LoaiThe = @LoaiThe where Id_The = @Id_The";
                            SqlCommand cmdt = new SqlCommand(sqlt, conn);
                            cmdt.Parameters.AddWithValue("@Id_The", this.txt_thera.Text);
                            cmdt.Parameters.AddWithValue("@LoaiThe", this.cb_loaithe.Text);
                            cmdt.ExecuteNonQuery();
                        }
                        if (String.Compare(cb_loaithe.Text, "Thẻ lượt", true) == 0)
                        {
                            string sqlt = "Update The set LoaiThe = NULL where Id_The = @Id_The";
                            SqlCommand cmdt = new SqlCommand(sqlt, conn);
                            cmdt.Parameters.AddWithValue("@Id_The", this.txt_thera.Text);
                            cmdt.ExecuteNonQuery();
                        }

                        string sqlxr = "INSERT INTO XeRa (BienSo, TrangThai, ThoiGianRa) values (@BienSo, @TrangThai, @ThoiGianRa)";
                        SqlCommand cmdxr = new SqlCommand(sqlxr, conn);
                        cmdxr.Parameters.AddWithValue("@BienSo", this.txt_bienso.Text);
                        cmdxr.Parameters.AddWithValue("@TrangThai", cb_trangthai.Text);
                        cmdxr.Parameters.AddWithValue("@ThoiGianRa", DateTime.Parse(lb_date.Text));
                        cmdxr.ExecuteNonQuery();

                        string a = "Rảnh";
                        string sqlkv = "Update KhuVuc set TrangThai = @TrangThai where Id_KV = @Id_KV";
                        SqlCommand cmdkv = new SqlCommand(sqlkv, conn);
                        cmdkv.Parameters.AddWithValue("@Id_KV", cb_kvra.Text);
                        cmdkv.Parameters.AddWithValue("@TrangThai", a);
                        cmdkv.ExecuteNonQuery();

                        SqlCommand cmdst = new SqlCommand("Delete from SoTheVao where BienSo = @BienSo and Id_The = @Id_The", conn);
                        cmdst.Parameters.AddWithValue("@BienSo", this.txt_bienso.Text);
                        cmdst.Parameters.AddWithValue("@Id_The", txt_thera.Text);
                        cmdst.ExecuteNonQuery();

                        string sqlx = "Delete from XeVao where BienSo = @BienSo";
                        SqlCommand cmdx = new SqlCommand(sqlx, conn);
                        cmdx.Parameters.AddWithValue("@BienSo", txt_bienso.Text);
                        if (cmdx.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xe đã xuất bến thành công");
                        }
                        bt_oout.Text = "Barrier đang mở";
                        bt_oout.BackColor = Color.Green;
                        load_Data();
                        Load_Form();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Biển số xe không khớp, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Image byteArraytoImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void bt_gialap_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_GiaLapTheRa));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_GiaLapTheRa f = new frm_GiaLapTheRa();
                f.content = new frm_GiaLapTheRa.Getstring1(Getcontent);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            
        }

        private void bt_glvao_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_GiaLapTheVao));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_GiaLapTheVao f = new frm_GiaLapTheVao();
                f.value = new frm_GiaLapTheVao.Getstring(Getvalue);/*gán Giá Trị Từ Methol value cua form 2 sang getvalue cua form 1 */
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void txt_bienso_TextChanged(object sender, EventArgs e)
        {
            string query = "Select Xe.BienSo, Xe.Id_KV, Xe.LoaiXe, Xe.CuocPhi, Xe.FileData, The.Id_The, The.LoaiThe from Xe, The, " +
                "SoTheVao where SoTheVao.BienSo = Xe.BienSo and The.Id_The = SoTheVao.Id_The and Xe.BienSo like N'%" + txt_bienso.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_biensodc.Text = dr["BienSo"].ToString();
                cb_loaixera.Text = dr["LoaiXe"].ToString();
                cb_kvra.Text = dr["Id_KV"].ToString();
                txt_phigui.Text = dr["CuocPhi"].ToString();
                byte[] b = (byte[])dr["FileData"];
                pb_anhdc.Image = byteArraytoImage(b);
                txt_thedc.Text = dr["Id_The"].ToString();
                cb_loaithe.Text = dr["LoaiThe"].ToString();
                if (String.Compare(dr["LoaiThe"].ToString(), "Thẻ tháng", true) == 0)
                {
                    txt_phigui.Text = "0";
                }
                txt_thanhtoan.Text = txt_phigui.Text;
            }
            else
            {
                MessageBox.Show("Không tìm thấy biển số này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget
        }

        private void openout_Click(object sender, EventArgs e)
        {
            //thiết lập đuôi file có thể mở
            openFileDialog1.InitialDirectory = @"C:\ParkingCar_KLTN";
            openFileDialog1.Filter = "JPG (*.JPG), PNG (*.PNG), GIF (*.GIF), BMP (*.BMP)|*.jpg;*.png;*.gif;*.bmp";

            //Đọc ảnh vào Bitmap
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptb_anhout2.Image = new Bitmap(@"C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/4.jpg");
                String fileName = openFileDialog1.FileName;
                ptb_anhout2.Image = null;
                Bitmap b = new Bitmap(fileName);
                ptb_camout.Image = b;
                Bitmap pic = new Bitmap(b);

                b.Save(@"C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/test/aaa.jpg");
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "cmd.exe";
                string k = "Hidden";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "start /b cmd /c py C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/demo.py";
                p.Start();

                String output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                int len = output.Split('\n').Length;
                string str = output.Split('\n')[len - 2];
                string num = output.Split('\n')[len - 3];
                txt_bienso.Text = str;
                p.Close();

                Console.WriteLine("num = " + num.Replace("\n", "").Replace("\r", ""));
                Console.WriteLine("bien so = " + str);
                Bitmap a = new Bitmap("C:/ParkingCar_KLTN/ParkingCar_KLTN/AI/" + num.Replace("\n", "").Replace("\r", "") + ".jpg");
                ptb_anhout2.Image = a;
            }
        }

        private void bt_openin_Click(object sender, EventArgs e)
        {
            bt_openin.Text = "Barrier đang đóng";
            bt_openin.BackColor = Color.Yellow;
        }

        private void bt_oout_Click(object sender, EventArgs e)
        {
            bt_oout.Text = "Barrier đang đóng";
            bt_oout.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bt_openin.Text = "Barrier đang đóng";
            bt_openin.BackColor = Color.Yellow;
            bt_oout.Text = "Barrier đang đóng";
            bt_oout.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_QlBaiXe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_QlBaiXe f = new frm_QlBaiXe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_ThongKe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_ThongKe f = new frm_ThongKe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void UpdateDisplayTimer_Tick(object sender, EventArgs e)
        {
            lb_date.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
        }

        private void bt_dkdv_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_DKDichVu));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_DKDichVu f = new frm_DKDichVu();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void cb_loaithein_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaithein.SelectedIndex == 0)
            {
                if (cbo_loaixevao.SelectedIndex == 0)
                {
                    txt_cuocphi.Text = "15000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%4- 7 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 1)
                {
                    txt_cuocphi.Text = "20000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%10- 16 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 2)
                {
                    txt_cuocphi.Text = "30000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%17- 19 chỗ'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 3)
                {
                    txt_cuocphi.Text = "40000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%30 chỗ trở lên'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
            }
            else
            {
                if (cbo_loaixevao.SelectedIndex == 0)
                {
                    txt_cuocphi.Text = "500000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%4- 7 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 1)
                {
                    txt_cuocphi.Text = "800000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%10- 16 chỗ%'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 2)
                {
                    txt_cuocphi.Text = "1000000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%17- 19 chỗ'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
                if (cbo_loaixevao.SelectedIndex == 3)
                {
                    txt_cuocphi.Text = "1200000";
                    SqlCommand cmd = new SqlCommand("SELECT Id_KV FROM KhuVuc WHERE TrangThai like N'%Rảnh%' and LoaiKV like N'%30 chỗ trở lên'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // đổ dữ liệu select được vào database dt
                    cb_khuvucin.DataSource = dt;
                    cb_khuvucin.DisplayMember = "Id_KV";
                }
            }
        }
    }
}
