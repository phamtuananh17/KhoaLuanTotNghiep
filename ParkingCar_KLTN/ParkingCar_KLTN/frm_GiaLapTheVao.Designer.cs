﻿
namespace ParkingCar_KLTN
{
    partial class frm_GiaLapTheVao
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
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.cb_thexe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã số thẻ:";
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Maroon;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ok.Location = new System.Drawing.Point(345, 24);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(44, 34);
            this.bt_ok.TabIndex = 38;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_thexe
            // 
            this.cb_thexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thexe.FormattingEnabled = true;
            this.cb_thexe.Location = new System.Drawing.Point(135, 29);
            this.cb_thexe.Name = "cb_thexe";
            this.cb_thexe.Size = new System.Drawing.Size(188, 26);
            this.cb_thexe.TabIndex = 39;
            // 
            // frm_GiaLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 82);
            this.Controls.Add(this.cb_thexe);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_GiaLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giả lập quẹt thẻ";
            this.Load += new System.EventHandler(this.frm_GiaLap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.ComboBox cb_thexe;
    }
}