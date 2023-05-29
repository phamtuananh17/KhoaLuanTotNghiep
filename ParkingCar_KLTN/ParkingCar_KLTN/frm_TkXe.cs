﻿using System;
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
    public partial class frm_TkXe : Form
    {
        public frm_TkXe()
        {
            InitializeComponent();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            if (rb_xetrongbai.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * FROM Xe, XeVao where Xe.BienSo = XeVao.BienSo", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "rp_TTXeVao.rdlc";
                //tạo nguồn dl cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DS_TTXeVao";
                rds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                load_DataXV();
                this.reportViewer1.RefreshReport();
            }
            else if (rb_xexuat.Checked)
            {
                SqlCommand cmdl = new SqlCommand("select * FROM Xe, XeRa where Xe.BienSo = XeRa.BienSo", conn);
                cmdl.CommandType = CommandType.Text;
                SqlDataAdapter dal = new SqlDataAdapter(cmdl);
                DataTable dtl = new DataTable();
                dal.Fill(dtl);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "rp_TTXeRa.rdlc";
                //tạo nguồn dl cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DS_TTXeRa";
                rds.Value = dtl;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                load_DataXR();
                this.reportViewer1.RefreshReport();
            }
            
        }

        SqlConnection conn = DBConnection.getDBConnection();

        void load_DataXV()
        {
            SqlCommand cmd = new SqlCommand("select Xe.CuocPhi FROM Xe, XeVao where Xe.BienSo = XeVao.BienSo", conn);
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

        void load_DataXR()
        {
            SqlCommand cmd = new SqlCommand("select Xe.CuocPhi FROM Xe, XeRa where Xe.BienSo = XeRa.BienSo", conn);
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

        private void frm_TkXeRa_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            this.reportViewer1.RefreshReport();
        }
    }
}
