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
    public partial class frm_GiaLapTheRa : Form
    {
        public frm_GiaLapTheRa()
        {
            InitializeComponent();
        }

        SqlConnection conn = DBConnection.getDBConnection();


        void load_data()
        {
            SqlCommand cmd = new SqlCommand("select Id_The from The where LoaiThe is not null", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_thexe.DataSource = dt;
            cb_thexe.DisplayMember = "Id_The";
        }

        private void frm_GiaLapTheRa_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_data();
        }

        public delegate void Getstring1(string s);/*Tạo Thư viện Getstring trong delegate */
        public Getstring1 content;/*Tạo Methol Value Trong Thư Viện mới tạo Getstring*/

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (content != null)/*Điều kiện để Gán Giá Trị*/
                content(cb_thexe.Text);/*Gán giá trị*/
            this.Hide();
        }
    }
}
