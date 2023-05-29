
namespace ParkingCar_KLTN
{
    partial class frm_QLXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cachtim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_quanlixe = new System.Windows.Forms.DataGridView();
            this.bt_soxe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.cbo_loaixe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cuocphi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bienso = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_reset = new System.Windows.Forms.Button();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_KV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_khuvuc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlixe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 57);
            this.panel1.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(526, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "QUẢN LÝ XE VÀO RA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.txt_tukhoa);
            this.groupBox2.Controls.Add(this.bt_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_cachtim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 153);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm xe";
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tukhoa.Location = new System.Drawing.Point(143, 67);
            this.txt_tukhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(268, 24);
            this.txt_tukhoa.TabIndex = 33;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Maroon;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_search.Location = new System.Drawing.Point(184, 104);
            this.bt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(112, 37);
            this.bt_search.TabIndex = 25;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Từ khóa :";
            // 
            // cb_cachtim
            // 
            this.cb_cachtim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cachtim.FormattingEnabled = true;
            this.cb_cachtim.Location = new System.Drawing.Point(143, 28);
            this.cb_cachtim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cachtim.Name = "cb_cachtim";
            this.cb_cachtim.Size = new System.Drawing.Size(268, 26);
            this.cb_cachtim.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cách tìm :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_quanlixe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(1254, 493);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // dgv_quanlixe
            // 
            this.dgv_quanlixe.AllowUserToAddRows = false;
            this.dgv_quanlixe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_quanlixe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlixe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.LoaiXe,
            this.DuongDan,
            this.Id_KV,
            this.CuocPhi});
            this.dgv_quanlixe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_quanlixe.Location = new System.Drawing.Point(3, 20);
            this.dgv_quanlixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_quanlixe.Name = "dgv_quanlixe";
            this.dgv_quanlixe.RowHeadersWidth = 51;
            this.dgv_quanlixe.RowTemplate.Height = 28;
            this.dgv_quanlixe.Size = new System.Drawing.Size(1248, 463);
            this.dgv_quanlixe.TabIndex = 28;
            this.dgv_quanlixe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quanlixe_CellContentClick);
            this.dgv_quanlixe.VisibleChanged += new System.EventHandler(this.dgv_quanlixe_VisibleChanged);
            // 
            // bt_soxe
            // 
            this.bt_soxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_soxe.ForeColor = System.Drawing.Color.Navy;
            this.bt_soxe.Location = new System.Drawing.Point(919, 62);
            this.bt_soxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_soxe.Name = "bt_soxe";
            this.bt_soxe.Size = new System.Drawing.Size(85, 28);
            this.bt_soxe.TabIndex = 50;
            this.bt_soxe.Text = "Update....";
            this.bt_soxe.UseVisualStyleBackColor = true;
            this.bt_soxe.Click += new System.EventHandler(this.bt_soxe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(781, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Số xe trong bãi :";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.Navy;
            this.lb_time.Location = new System.Drawing.Point(1077, 68);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(52, 17);
            this.lb_time.TabIndex = 48;
            this.lb_time.Text = "label5";
            this.lb_time.Click += new System.EventHandler(this.lb_time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1021, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "TIME :";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Maroon;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(569, 111);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(112, 34);
            this.bt_sua.TabIndex = 57;
            this.bt_sua.Text = "Update";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.cb_khuvuc);
            this.groupBox3.Controls.Add(this.bt_open);
            this.groupBox3.Controls.Add(this.cbo_loaixe);
            this.groupBox3.Controls.Add(this.bt_sua);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_cuocphi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_duongdan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_bienso);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(497, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 153);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin xe";
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(332, 67);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(67, 30);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // cbo_loaixe
            // 
            this.cbo_loaixe.FormattingEnabled = true;
            this.cbo_loaixe.Items.AddRange(new object[] {
            "Xe máy",
            "4- 7 chỗ",
            "10- 16 chỗ",
            "17- 19 chỗ",
            "30 chỗ trở lên"});
            this.cbo_loaixe.Location = new System.Drawing.Point(134, 111);
            this.cbo_loaixe.Name = "cbo_loaixe";
            this.cbo_loaixe.Size = new System.Drawing.Size(265, 24);
            this.cbo_loaixe.TabIndex = 2;
            this.cbo_loaixe.SelectedIndexChanged += new System.EventHandler(this.cbo_loaixe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Picture ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Loại xe: ";
            // 
            // txt_cuocphi
            // 
            this.txt_cuocphi.Location = new System.Drawing.Point(535, 80);
            this.txt_cuocphi.Name = "txt_cuocphi";
            this.txt_cuocphi.Size = new System.Drawing.Size(243, 23);
            this.txt_cuocphi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Khu vực: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cước phí: ";
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Location = new System.Drawing.Point(134, 69);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(192, 23);
            this.txt_duongdan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Biển số: ";
            // 
            // txt_bienso
            // 
            this.txt_bienso.Location = new System.Drawing.Point(134, 33);
            this.txt_bienso.Name = "txt_bienso";
            this.txt_bienso.ReadOnly = true;
            this.txt_bienso.Size = new System.Drawing.Size(265, 23);
            this.txt_bienso.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_reset
            // 
            this.bt_reset.Image = ((System.Drawing.Image)(resources.GetObject("bt_reset.Image")));
            this.bt_reset.Location = new System.Drawing.Point(1257, 54);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(50, 44);
            this.bt_reset.TabIndex = 58;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.Width = 125;
            // 
            // LoaiXe
            // 
            this.LoaiXe.DataPropertyName = "LoaiXe";
            this.LoaiXe.HeaderText = "Loại xe";
            this.LoaiXe.MinimumWidth = 6;
            this.LoaiXe.Name = "LoaiXe";
            this.LoaiXe.Width = 125;
            // 
            // DuongDan
            // 
            this.DuongDan.DataPropertyName = "DuongDan";
            this.DuongDan.HeaderText = "Đường dẫn";
            this.DuongDan.MinimumWidth = 6;
            this.DuongDan.Name = "DuongDan";
            this.DuongDan.Width = 125;
            // 
            // Id_KV
            // 
            this.Id_KV.DataPropertyName = "Id_KV";
            this.Id_KV.HeaderText = "Khu vực";
            this.Id_KV.MinimumWidth = 6;
            this.Id_KV.Name = "Id_KV";
            this.Id_KV.Width = 125;
            // 
            // CuocPhi
            // 
            this.CuocPhi.DataPropertyName = "CuocPhi";
            this.CuocPhi.HeaderText = "Cước phí";
            this.CuocPhi.MinimumWidth = 6;
            this.CuocPhi.Name = "CuocPhi";
            this.CuocPhi.Width = 125;
            // 
            // cb_khuvuc
            // 
            this.cb_khuvuc.FormattingEnabled = true;
            this.cb_khuvuc.Location = new System.Drawing.Point(535, 36);
            this.cb_khuvuc.Name = "cb_khuvuc";
            this.cb_khuvuc.Size = new System.Drawing.Size(243, 24);
            this.cb_khuvuc.TabIndex = 58;
            // 
            // frm_QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1375, 821);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_soxe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe trong bãi";
            this.Load += new System.EventHandler(this.frm_QLXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlixe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_cachtim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_quanlixe;
        private System.Windows.Forms.Button bt_soxe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_loaixe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cuocphi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bienso;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_KV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuocPhi;
        private System.Windows.Forms.ComboBox cb_khuvuc;
    }
}