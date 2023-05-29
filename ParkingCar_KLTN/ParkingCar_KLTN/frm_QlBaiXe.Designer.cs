
namespace ParkingCar_KLTN
{
    partial class frm_QlBaiXe
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_dsKV = new System.Windows.Forms.DataGridView();
            this.Id_KV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ranh = new System.Windows.Forms.RadioButton();
            this.rb_ban = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_loaiKV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IdKV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsKV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.OldLace;
            this.groupBox4.Controls.Add(this.cb_timkiem);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.bt_reset);
            this.groupBox4.Controls.Add(this.txt_tukhoa);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.bt_search);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(12, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(1124, 106);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tìm kiếm";
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Location = new System.Drawing.Point(286, 25);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(399, 26);
            this.cb_timkiem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ khóa tìm kiếm";
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.BackColor = System.Drawing.Color.Maroon;
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_reset.Location = new System.Drawing.Point(956, 40);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(115, 36);
            this.bt_reset.TabIndex = 9;
            this.bt_reset.Text = "Refesh";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tukhoa.Location = new System.Drawing.Point(286, 63);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(399, 25);
            this.txt_tukhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm theo";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Maroon;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_search.Location = new System.Drawing.Point(772, 40);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(115, 36);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 49);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(332, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TỪNG KHU VỰC CỦA BÃI XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_dsKV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(657, 360);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // dgv_dsKV
            // 
            this.dgv_dsKV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dsKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsKV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_KV,
            this.LoaiKV,
            this.TrangThai});
            this.dgv_dsKV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsKV.Location = new System.Drawing.Point(3, 27);
            this.dgv_dsKV.Name = "dgv_dsKV";
            this.dgv_dsKV.RowHeadersWidth = 51;
            this.dgv_dsKV.RowTemplate.Height = 24;
            this.dgv_dsKV.Size = new System.Drawing.Size(651, 330);
            this.dgv_dsKV.TabIndex = 0;
            this.dgv_dsKV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsKV_CellContentClick);
            this.dgv_dsKV.VisibleChanged += new System.EventHandler(this.dgv_dsKV_VisibleChanged);
            // 
            // Id_KV
            // 
            this.Id_KV.DataPropertyName = "Id_KV";
            this.Id_KV.HeaderText = "Mã khu";
            this.Id_KV.MinimumWidth = 6;
            this.Id_KV.Name = "Id_KV";
            this.Id_KV.Width = 125;
            // 
            // LoaiKV
            // 
            this.LoaiKV.DataPropertyName = "LoaiKV";
            this.LoaiKV.HeaderText = "Loại khu";
            this.LoaiKV.MinimumWidth = 6;
            this.LoaiKV.Name = "LoaiKV";
            this.LoaiKV.Width = 250;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Controls.Add(this.bt_insert);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(675, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 139);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Maroon;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(176, 84);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(118, 37);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Maroon;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(271, 27);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(118, 37);
            this.bt_update.TabIndex = 6;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.BackColor = System.Drawing.Color.Maroon;
            this.bt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insert.ForeColor = System.Drawing.Color.White;
            this.bt_insert.Location = new System.Drawing.Point(80, 27);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(118, 37);
            this.bt_insert.TabIndex = 7;
            this.bt_insert.Text = "Thêm";
            this.bt_insert.UseVisualStyleBackColor = false;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.rb_ranh);
            this.groupBox1.Controls.Add(this.rb_ban);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_loaiKV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_IdKV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(675, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 215);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ mới";
            // 
            // rb_ranh
            // 
            this.rb_ranh.AutoSize = true;
            this.rb_ranh.Location = new System.Drawing.Point(293, 160);
            this.rb_ranh.Name = "rb_ranh";
            this.rb_ranh.Size = new System.Drawing.Size(68, 23);
            this.rb_ranh.TabIndex = 3;
            this.rb_ranh.TabStop = true;
            this.rb_ranh.Text = "Rảnh";
            this.rb_ranh.UseVisualStyleBackColor = true;
            // 
            // rb_ban
            // 
            this.rb_ban.AutoSize = true;
            this.rb_ban.Location = new System.Drawing.Point(156, 160);
            this.rb_ban.Name = "rb_ban";
            this.rb_ban.Size = new System.Drawing.Size(59, 23);
            this.rb_ban.TabIndex = 3;
            this.rb_ban.TabStop = true;
            this.rb_ban.Text = "Bận";
            this.rb_ban.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái";
            // 
            // txt_loaiKV
            // 
            this.txt_loaiKV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaiKV.Location = new System.Drawing.Point(156, 77);
            this.txt_loaiKV.Name = "txt_loaiKV";
            this.txt_loaiKV.Size = new System.Drawing.Size(271, 27);
            this.txt_loaiKV.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại khu";
            // 
            // txt_IdKV
            // 
            this.txt_IdKV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdKV.Location = new System.Drawing.Point(156, 37);
            this.txt_IdKV.Name = "txt_IdKV";
            this.txt_IdKV.Size = new System.Drawing.Size(271, 27);
            this.txt_IdKV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khu";
            // 
            // frm_QlBaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 552);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_QlBaiXe";
            this.Text = "frm_QlBaiXe";
            this.Load += new System.EventHandler(this.frm_QlBaiXe_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsKV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_dsKV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_loaiKV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IdKV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_ranh;
        private System.Windows.Forms.RadioButton rb_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_KV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}