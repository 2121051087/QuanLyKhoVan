namespace QuanLyKhoVan
{
    partial class Form_ForgetPassword
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
            this.panel_Email = new System.Windows.Forms.Panel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.btn_LayLaiMatKhau = new System.Windows.Forms.Button();
            this.panel_Email.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Email
            // 
            this.panel_Email.BackColor = System.Drawing.Color.White;
            this.panel_Email.Controls.Add(this.txt_Email);
            this.panel_Email.Controls.Add(this.lb_Email);
            this.panel_Email.Location = new System.Drawing.Point(9, 21);
            this.panel_Email.Name = "panel_Email";
            this.panel_Email.Size = new System.Drawing.Size(506, 44);
            this.panel_Email.TabIndex = 26;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Email.Location = new System.Drawing.Point(169, 8);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(321, 27);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.lb_Email.Location = new System.Drawing.Point(0, 0);
            this.lb_Email.MinimumSize = new System.Drawing.Size(138, 44);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(138, 44);
            this.lb_Email.TabIndex = 21;
            this.lb_Email.Text = "Email đăng kí :";
            this.lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KetQua.ForeColor = System.Drawing.Color.Blue;
            this.lb_KetQua.Location = new System.Drawing.Point(59, 92);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(88, 28);
            this.lb_KetQua.TabIndex = 28;
            this.lb_KetQua.Text = "Kết quả :";
            // 
            // btn_LayLaiMatKhau
            // 
            this.btn_LayLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_LayLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_LayLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LayLaiMatKhau.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_LayLaiMatKhau.Location = new System.Drawing.Point(41, 170);
            this.btn_LayLaiMatKhau.Name = "btn_LayLaiMatKhau";
            this.btn_LayLaiMatKhau.Size = new System.Drawing.Size(447, 39);
            this.btn_LayLaiMatKhau.TabIndex = 27;
            this.btn_LayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btn_LayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_LayLaiMatKhau.Click += new System.EventHandler(this.btn_LayLaiMatKhau_Click);
            // 
            // Form_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 231);
            this.Controls.Add(this.panel_Email);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.btn_LayLaiMatKhau);
            this.Name = "Form_ForgetPassword";
            this.Text = "Form_ForgetPassword";
            this.panel_Email.ResumeLayout(false);
            this.panel_Email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_KetQua;
        private System.Windows.Forms.Button btn_LayLaiMatKhau;
    }
}