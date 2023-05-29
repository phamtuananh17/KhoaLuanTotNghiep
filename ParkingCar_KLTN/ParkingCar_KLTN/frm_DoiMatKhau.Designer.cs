
namespace ParkingCar_KLTN
{
    partial class frm_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiMatKhau));
            this.lblShowInfor = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtmkxn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmkms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmkht = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowInfor
            // 
            this.lblShowInfor.AutoSize = true;
            this.lblShowInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInfor.Location = new System.Drawing.Point(223, 230);
            this.lblShowInfor.Name = "lblShowInfor";
            this.lblShowInfor.Size = new System.Drawing.Size(46, 17);
            this.lblShowInfor.TabIndex = 42;
            this.lblShowInfor.Text = "label5";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(226, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 22);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Green;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Yellow;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(254, 302);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(89, 36);
            this.btnluu.TabIndex = 38;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            this.btnluu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnluu_KeyDown);
            // 
            // txtmkxn
            // 
            this.txtmkxn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkxn.Location = new System.Drawing.Point(244, 184);
            this.txtmkxn.Multiline = true;
            this.txtmkxn.Name = "txtmkxn";
            this.txtmkxn.PasswordChar = '*';
            this.txtmkxn.Size = new System.Drawing.Size(282, 32);
            this.txtmkxn.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(21, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nhập lại mật khẩu mới(*)";
            // 
            // txtmkms
            // 
            this.txtmkms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkms.Location = new System.Drawing.Point(244, 135);
            this.txtmkms.Multiline = true;
            this.txtmkms.Name = "txtmkms";
            this.txtmkms.PasswordChar = '*';
            this.txtmkms.Size = new System.Drawing.Size(282, 32);
            this.txtmkms.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mật khẩu mới(*)";
            // 
            // txttentk
            // 
            this.txttentk.Enabled = false;
            this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentk.Location = new System.Drawing.Point(244, 33);
            this.txttentk.Multiline = true;
            this.txttentk.Name = "txttentk";
            this.txttentk.ReadOnly = true;
            this.txttentk.Size = new System.Drawing.Size(282, 32);
            this.txttentk.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(58, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Username(*)";
            // 
            // txtmkht
            // 
            this.txtmkht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkht.Location = new System.Drawing.Point(244, 85);
            this.txtmkht.Multiline = true;
            this.txtmkht.Name = "txtmkht";
            this.txtmkht.PasswordChar = '*';
            this.txtmkht.Size = new System.Drawing.Size(282, 32);
            this.txtmkht.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(58, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mật khẩu cũ(*)";
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 352);
            this.Controls.Add(this.lblShowInfor);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtmkxn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmkms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttentk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmkht);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowInfor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtmkxn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmkms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmkht;
        private System.Windows.Forms.Label label1;
    }
}