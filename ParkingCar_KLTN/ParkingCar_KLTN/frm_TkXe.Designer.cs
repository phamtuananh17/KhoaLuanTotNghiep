
namespace ParkingCar_KLTN
{
    partial class frm_TkXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TkXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_xetrongbai = new System.Windows.Forms.RadioButton();
            this.rb_xexuat = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 46);
            this.panel1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH XE TRONG BÃI/ ĐÃ XUẤT BÃI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rb_xetrongbai
            // 
            this.rb_xetrongbai.AutoSize = true;
            this.rb_xetrongbai.Location = new System.Drawing.Point(86, 27);
            this.rb_xetrongbai.Name = "rb_xetrongbai";
            this.rb_xetrongbai.Size = new System.Drawing.Size(120, 22);
            this.rb_xetrongbai.TabIndex = 87;
            this.rb_xetrongbai.TabStop = true;
            this.rb_xetrongbai.Text = "Xe trong bãi";
            this.rb_xetrongbai.UseVisualStyleBackColor = true;
            // 
            // rb_xexuat
            // 
            this.rb_xexuat.AutoSize = true;
            this.rb_xexuat.Location = new System.Drawing.Point(322, 27);
            this.rb_xexuat.Name = "rb_xexuat";
            this.rb_xexuat.Size = new System.Drawing.Size(135, 22);
            this.rb_xexuat.TabIndex = 87;
            this.rb_xexuat.TabStop = true;
            this.rb_xexuat.Text = "Xe đã xuất bãi";
            this.rb_xexuat.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(16, 133);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 485);
            this.reportViewer1.TabIndex = 81;
            // 
            // bt_thongke
            // 
            this.bt_thongke.BackColor = System.Drawing.Color.Maroon;
            this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thongke.Image = ((System.Drawing.Image)(resources.GetObject("bt_thongke.Image")));
            this.bt_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thongke.Location = new System.Drawing.Point(592, 68);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(157, 37);
            this.bt_thongke.TabIndex = 83;
            this.bt_thongke.Text = "Thống kê";
            this.bt_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thongke.UseVisualStyleBackColor = false;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhthu.ForeColor = System.Drawing.Color.Red;
            this.txt_doanhthu.Location = new System.Drawing.Point(898, 73);
            this.txt_doanhthu.Multiline = true;
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.ReadOnly = true;
            this.txt_doanhthu.Size = new System.Drawing.Size(172, 27);
            this.txt_doanhthu.TabIndex = 84;
            this.txt_doanhthu.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(781, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Doanh thu:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1103, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 24);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_xetrongbai);
            this.groupBox1.Controls.Add(this.rb_xexuat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 64);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo";
            // 
            // frm_TkXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_doanhthu);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_TkXe";
            this.Text = "Danh sách xe";
            this.Load += new System.EventHandler(this.frm_TkXeRa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_xetrongbai;
        private System.Windows.Forms.RadioButton rb_xexuat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}