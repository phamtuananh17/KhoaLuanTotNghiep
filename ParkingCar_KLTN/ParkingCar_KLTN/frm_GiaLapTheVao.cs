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
    public partial class frm_GiaLapTheVao : Form
    {
        public frm_GiaLapTheVao()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();
        

        void load_data()
        {
            SqlCommand cmd = new SqlCommand("select Id_The from The where LoaiThe is null", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_thexe.DataSource = dt;
            cb_thexe.DisplayMember = "Id_The";
        }

        private void frm_GiaLap_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_data();
        }

        public delegate void Getstring(string s);/*Tạo Thư viện Getstring trong delegate */
        public Getstring value;/*Tạo Methol Value Trong Thư Viện mới tạo Getstring*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (value != null)/*Điều kiện để Gán Giá Trị*/
                value(cb_thexe.Text);/*Gán giá trị*/
            this.Hide();
        }
    }
}
