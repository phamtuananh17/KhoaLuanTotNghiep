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
    public partial class frm_HoaDonDV : Form
    {
        public frm_HoaDonDV()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnection.getDBConnection();
        SqlCommand cmd;

        void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT SoTheVao.BienSo FROM SoTheVao, The WHERE SoTheVao.Id_The = The.Id_The and The.LoaiThe like N'%Thẻ tháng%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_bienso.DataSource = dt;
            cb_bienso.DisplayMember = "BienSo";
        }

        void load_DonGia()
        {
            cmd = new SqlCommand("select CuocPhi FROM Xe where BienSo = '" + cb_bienso.Text + "'", conn);
            cmd.CommandType = CommandType.Text;
            decimal CuocPhi = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string cuocphi = dr["CuocPhi"].ToString();
                CuocPhi = decimal.Parse(cuocphi);
            }
            dr.Close(); // <- too easy to forget
            dr.Dispose(); // <- too easy to forget

            SqlCommand cmd1 = new SqlCommand("select DonGia FROM PhieuDKDV where BienSo = '" + cb_bienso.Text + "'", conn);
            cmd1.CommandType = CommandType.Text;
            decimal DonGia = 0;
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                string dongia = dr1["DonGia"].ToString();
                DonGia += decimal.Parse(dongia);
            }
            txt_doanhthu.Text = (CuocPhi + DonGia).ToString();
            dr1.Close(); // <- too easy to forget
            dr1.Dispose(); // <- too easy to forget
        }

        private void frm_HoaDonDV_Load(object sender, EventArgs e)
        {
            conn.Open();
            load_data();
            this.reportViewer1.RefreshReport();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Ds_HoaDonDV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BienSo", cb_bienso.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "rp_HDDichVu.rdlc";
            // tạo tham số và truyền dl cho tham số
            ReportParameter rp1 = new ReportParameter(@"ReportParameterBienSo", "Biển số xe: " + cb_bienso.Text);
            reportViewer1.LocalReport.SetParameters(rp1);
            //tạo nguồn dl cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DS_HoaDonDV";
            rds.Value = dt;
            load_DonGia();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
