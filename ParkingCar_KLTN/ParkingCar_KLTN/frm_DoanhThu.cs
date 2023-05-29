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
using Microsoft.Reporting.WinForms;

namespace ParkingCar_KLTN
{
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();

        void load_Data()
        {
            SqlCommand cmd = new SqlCommand("select Xe.CuocPhi FROM Xe, HoaDonXe where HoaDonXe.BienSo = Xe.BienSo", conn);
            cmd.CommandType = CommandType.Text;
            decimal tongHD = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string cuocphi = dr["CuocPhi"].ToString();
                tongHD += decimal.Parse(cuocphi);
            }
            txt_doanhthu.Text = tongHD.ToString();
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget
        }

        private void frm_QlHoaDon_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            this.reportViewer1.RefreshReport();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DoanhThu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "rp_DoanhThu.rdlc";
            //tạo nguồn dl cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DS_DoanhThu";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            load_Data();
            this.reportViewer1.RefreshReport();
        }
    }
}
