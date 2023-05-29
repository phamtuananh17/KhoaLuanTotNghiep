
namespace ParkingCar_KLTN
{
    partial class frm_HoaDonDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDonDV));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_bienso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(945, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tổng hóa đơn:";
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhthu.ForeColor = System.Drawing.Color.Red;
            this.txt_doanhthu.Location = new System.Drawing.Point(1093, 58);
            this.txt_doanhthu.Multiline = true;
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.ReadOnly = true;
            this.txt_doanhthu.Size = new System.Drawing.Size(192, 30);
            this.txt_doanhthu.TabIndex = 78;
            this.txt_doanhthu.Text = "0";
            // 
            // bt_thongke
            // 
            this.bt_thongke.BackColor = System.Drawing.Color.Maroon;
            this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thongke.Image = ((System.Drawing.Image)(resources.GetObject("bt_thongke.Image")));
            this.bt_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thongke.Location = new System.Drawing.Point(615, 55);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(137, 40);
            this.bt_thongke.TabIndex = 77;
            this.bt_thongke.Text = "Export";
            this.bt_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thongke.UseVisualStyleBackColor = false;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 46);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN DỊCH VỤ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 524);
            this.reportViewer1.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(132, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tìm kiếm biển số:";
            // 
            // cb_bienso
            // 
            this.cb_bienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bienso.FormattingEnabled = true;
            this.cb_bienso.Location = new System.Drawing.Point(300, 61);
            this.cb_bienso.Name = "cb_bienso";
            this.cb_bienso.Size = new System.Drawing.Size(278, 26);
            this.cb_bienso.TabIndex = 80;
            // 
            // frm_HoaDonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 697);
            this.Controls.Add(this.cb_bienso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_doanhthu);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_HoaDonDV";
            this.Text = "Hóa đơn đăng ký dịch vụ";
            this.Load += new System.EventHandler(this.frm_HoaDonDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_bienso;
    }
}