
namespace ParkingCar_KLTN
{
    partial class frm_DKDichVu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_bienso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_khuvuc = new System.Windows.Forms.ComboBox();
            this.txt_cuocphi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_loaixe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_phieuDV = new System.Windows.Forms.DataGridView();
            this.Id_PhieuDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_loaiDV = new System.Windows.Forms.TextBox();
            this.txt_mtdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_IdDV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_export = new System.Windows.Forms.Button();
            this.txt_sophieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuDV)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 57);
            this.panel1.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(392, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(559, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "ĐĂNG KÝ DỊCH VỤ DÀNH CHO THẺ THÁNG";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_bienso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 114);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm biển số đăng ký dịch vụ";
            // 
            // cb_bienso
            // 
            this.cb_bienso.FormattingEnabled = true;
            this.cb_bienso.Items.AddRange(new object[] {
            "<----Choose item----->"});
            this.cb_bienso.Location = new System.Drawing.Point(103, 46);
            this.cb_bienso.Name = "cb_bienso";
            this.cb_bienso.Size = new System.Drawing.Size(265, 26);
            this.cb_bienso.TabIndex = 2;
            this.cb_bienso.SelectedIndexChanged += new System.EventHandler(this.cb_bienso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biển số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_khuvuc);
            this.groupBox2.Controls.Add(this.txt_cuocphi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_mota);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbo_loaixe);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 204);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe đăng ký";
            // 
            // cb_khuvuc
            // 
            this.cb_khuvuc.Enabled = false;
            this.cb_khuvuc.FormattingEnabled = true;
            this.cb_khuvuc.Location = new System.Drawing.Point(103, 74);
            this.cb_khuvuc.Name = "cb_khuvuc";
            this.cb_khuvuc.Size = new System.Drawing.Size(265, 26);
            this.cb_khuvuc.TabIndex = 62;
            // 
            // txt_cuocphi
            // 
            this.txt_cuocphi.Enabled = false;
            this.txt_cuocphi.Location = new System.Drawing.Point(103, 150);
            this.txt_cuocphi.Name = "txt_cuocphi";
            this.txt_cuocphi.ReadOnly = true;
            this.txt_cuocphi.Size = new System.Drawing.Size(265, 24);
            this.txt_cuocphi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Cước phí: ";
            // 
            // txt_mota
            // 
            this.txt_mota.Enabled = false;
            this.txt_mota.Location = new System.Drawing.Point(103, 113);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.ReadOnly = true;
            this.txt_mota.Size = new System.Drawing.Size(265, 24);
            this.txt_mota.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mô tả xe: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 60;
            this.label10.Text = "Khu vực: ";
            // 
            // cbo_loaixe
            // 
            this.cbo_loaixe.Enabled = false;
            this.cbo_loaixe.FormattingEnabled = true;
            this.cbo_loaixe.Items.AddRange(new object[] {
            "Xe máy",
            "4- 7 chỗ",
            "10- 16 chỗ",
            "17- 19 chỗ",
            "30 chỗ trở lên"});
            this.cbo_loaixe.Location = new System.Drawing.Point(103, 37);
            this.cbo_loaixe.Name = "cbo_loaixe";
            this.cbo_loaixe.Size = new System.Drawing.Size(265, 26);
            this.cbo_loaixe.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Loại xe: ";
            // 
            // bt_dangky
            // 
            this.bt_dangky.BackColor = System.Drawing.Color.Maroon;
            this.bt_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_dangky.Location = new System.Drawing.Point(425, 279);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(133, 38);
            this.bt_dangky.TabIndex = 62;
            this.bt_dangky.Text = "Đăng ký";
            this.bt_dangky.UseVisualStyleBackColor = false;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.Maroon;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_huy.Location = new System.Drawing.Point(425, 334);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(133, 36);
            this.bt_huy.TabIndex = 62;
            this.bt_huy.Text = "Hủy đăng ký";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_phieuDV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(578, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 499);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách xe đăng ký dịch vụ";
            // 
            // dgv_phieuDV
            // 
            this.dgv_phieuDV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_phieuDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_PhieuDV,
            this.BienSo,
            this.Id_DV,
            this.DonGia,
            this.NgayDK});
            this.dgv_phieuDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phieuDV.Location = new System.Drawing.Point(3, 20);
            this.dgv_phieuDV.Name = "dgv_phieuDV";
            this.dgv_phieuDV.RowHeadersWidth = 51;
            this.dgv_phieuDV.RowTemplate.Height = 24;
            this.dgv_phieuDV.Size = new System.Drawing.Size(745, 476);
            this.dgv_phieuDV.TabIndex = 0;
            this.dgv_phieuDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuDV_CellContentClick);
            // 
            // Id_PhieuDV
            // 
            this.Id_PhieuDV.DataPropertyName = "Id_PhieuDV";
            this.Id_PhieuDV.HeaderText = "Số phiếu";
            this.Id_PhieuDV.MinimumWidth = 6;
            this.Id_PhieuDV.Name = "Id_PhieuDV";
            this.Id_PhieuDV.Width = 125;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.Width = 125;
            // 
            // Id_DV
            // 
            this.Id_DV.DataPropertyName = "Id_DV";
            this.Id_DV.HeaderText = "Số dịch vụ";
            this.Id_DV.MinimumWidth = 6;
            this.Id_DV.Name = "Id_DV";
            this.Id_DV.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá dịch vụ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // NgayDK
            // 
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "Ngày đăng ký";
            this.NgayDK.MinimumWidth = 6;
            this.NgayDK.Name = "NgayDK";
            this.NgayDK.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_dongia);
            this.groupBox4.Controls.Add(this.txt_loaiDV);
            this.groupBox4.Controls.Add(this.txt_mtdv);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cb_IdDV);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 204);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin dịch vụ đăng ký";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(103, 154);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(265, 24);
            this.txt_dongia.TabIndex = 0;
            // 
            // txt_loaiDV
            // 
            this.txt_loaiDV.Enabled = false;
            this.txt_loaiDV.Location = new System.Drawing.Point(103, 76);
            this.txt_loaiDV.Name = "txt_loaiDV";
            this.txt_loaiDV.ReadOnly = true;
            this.txt_loaiDV.Size = new System.Drawing.Size(265, 24);
            this.txt_loaiDV.TabIndex = 0;
            // 
            // txt_mtdv
            // 
            this.txt_mtdv.Enabled = false;
            this.txt_mtdv.Location = new System.Drawing.Point(103, 113);
            this.txt_mtdv.Name = "txt_mtdv";
            this.txt_mtdv.ReadOnly = true;
            this.txt_mtdv.Size = new System.Drawing.Size(265, 24);
            this.txt_mtdv.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id_DV: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Đơn giá: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Mô tả DV: ";
            // 
            // cb_IdDV
            // 
            this.cb_IdDV.FormattingEnabled = true;
            this.cb_IdDV.Items.AddRange(new object[] {
            "Xe máy",
            "4- 7 chỗ",
            "10- 16 chỗ",
            "17- 19 chỗ",
            "30 chỗ trở lên"});
            this.cb_IdDV.Location = new System.Drawing.Point(103, 37);
            this.cb_IdDV.Name = "cb_IdDV";
            this.cb_IdDV.Size = new System.Drawing.Size(265, 26);
            this.cb_IdDV.TabIndex = 6;
            this.cb_IdDV.SelectedIndexChanged += new System.EventHandler(this.cb_IdDV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Loại DV: ";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_date.Location = new System.Drawing.Point(577, 62);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(59, 20);
            this.lb_date.TabIndex = 64;
            this.lb_date.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_export
            // 
            this.bt_export.BackColor = System.Drawing.Color.Maroon;
            this.bt_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_export.Location = new System.Drawing.Point(425, 390);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(133, 36);
            this.bt_export.TabIndex = 62;
            this.bt_export.Text = "Xuất hóa đơn";
            this.bt_export.UseVisualStyleBackColor = false;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // txt_sophieu
            // 
            this.txt_sophieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sophieu.Location = new System.Drawing.Point(425, 125);
            this.txt_sophieu.Multiline = true;
            this.txt_sophieu.Name = "txt_sophieu";
            this.txt_sophieu.ReadOnly = true;
            this.txt_sophieu.Size = new System.Drawing.Size(133, 39);
            this.txt_sophieu.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số phiếu: ";
            // 
            // frm_DKDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1350, 629);
            this.Controls.Add(this.txt_sophieu);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DKDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký dịch vụ dành cho thẻ tháng";
            this.Load += new System.EventHandler(this.frm_DKDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuDV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_dangky;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_phieuDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbo_loaixe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_khuvuc;
        private System.Windows.Forms.TextBox txt_cuocphi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_loaiDV;
        private System.Windows.Forms.TextBox txt_mtdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_IdDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cb_bienso;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_PhieuDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
        private System.Windows.Forms.TextBox txt_sophieu;
        private System.Windows.Forms.Label label8;
    }
}