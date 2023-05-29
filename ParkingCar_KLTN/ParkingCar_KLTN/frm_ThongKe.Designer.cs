
namespace ParkingCar_KLTN
{
    partial class frm_ThongKe
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
            this.bt_xevao = new System.Windows.Forms.Button();
            this.bt_hoadondv = new System.Windows.Forms.Button();
            this.bt_hdxe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_xevao
            // 
            this.bt_xevao.BackColor = System.Drawing.Color.Maroon;
            this.bt_xevao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xevao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xevao.ForeColor = System.Drawing.Color.White;
            this.bt_xevao.Location = new System.Drawing.Point(66, 37);
            this.bt_xevao.Name = "bt_xevao";
            this.bt_xevao.Size = new System.Drawing.Size(299, 43);
            this.bt_xevao.TabIndex = 0;
            this.bt_xevao.Text = "Thống kê dữ liệu xe";
            this.bt_xevao.UseVisualStyleBackColor = false;
            this.bt_xevao.Click += new System.EventHandler(this.bt_xevao_Click);
            // 
            // bt_hoadondv
            // 
            this.bt_hoadondv.BackColor = System.Drawing.Color.Maroon;
            this.bt_hoadondv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hoadondv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoadondv.ForeColor = System.Drawing.Color.White;
            this.bt_hoadondv.Location = new System.Drawing.Point(66, 98);
            this.bt_hoadondv.Name = "bt_hoadondv";
            this.bt_hoadondv.Size = new System.Drawing.Size(299, 43);
            this.bt_hoadondv.TabIndex = 0;
            this.bt_hoadondv.Text = "Hóa đơn dịch vụ";
            this.bt_hoadondv.UseVisualStyleBackColor = false;
            this.bt_hoadondv.Click += new System.EventHandler(this.bt_hoadondv_Click);
            // 
            // bt_hdxe
            // 
            this.bt_hdxe.BackColor = System.Drawing.Color.Maroon;
            this.bt_hdxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hdxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hdxe.ForeColor = System.Drawing.Color.White;
            this.bt_hdxe.Location = new System.Drawing.Point(66, 158);
            this.bt_hdxe.Name = "bt_hdxe";
            this.bt_hdxe.Size = new System.Drawing.Size(299, 43);
            this.bt_hdxe.TabIndex = 0;
            this.bt_hdxe.Text = "Hóa đơn xe";
            this.bt_hdxe.UseVisualStyleBackColor = false;
            this.bt_hdxe.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(435, 245);
            this.Controls.Add(this.bt_hdxe);
            this.Controls.Add(this.bt_hoadondv);
            this.Controls.Add(this.bt_xevao);
            this.Name = "frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng thống kê";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_xevao;
        private System.Windows.Forms.Button bt_hoadondv;
        private System.Windows.Forms.Button bt_hdxe;
    }
}