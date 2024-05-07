namespace QuanLyKhoVan
{
    partial class Form_Customers
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_DiaChi = new System.Windows.Forms.Panel();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_SDT = new System.Windows.Forms.Panel();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_CustomerID = new System.Windows.Forms.Panel();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_TenKhachHang = new System.Windows.Forms.Panel();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel_DiaChi.SuspendLayout();
            this.panel_SDT.SuspendLayout();
            this.panel_CustomerID.SuspendLayout();
            this.panel_TenKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(1000, 411);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 48);
            this.btn_Sua.TabIndex = 46;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(633, 410);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 48);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khách hàng : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_DiaChi);
            this.groupBox1.Controls.Add(this.panel_SDT);
            this.groupBox1.Controls.Add(this.panel_CustomerID);
            this.groupBox1.Controls.Add(this.panel_TenKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(633, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 360);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_DiaChi
            // 
            this.panel_DiaChi.BackColor = System.Drawing.Color.White;
            this.panel_DiaChi.Controls.Add(this.txt_DiaChi);
            this.panel_DiaChi.Controls.Add(this.label4);
            this.panel_DiaChi.Location = new System.Drawing.Point(12, 254);
            this.panel_DiaChi.Name = "panel_DiaChi";
            this.panel_DiaChi.Size = new System.Drawing.Size(421, 46);
            this.panel_DiaChi.TabIndex = 22;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(123, 7);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(295, 32);
            this.txt_DiaChi.TabIndex = 1;
            this.txt_DiaChi.Click += new System.EventHandler(this.txt_DiaChi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Địa chỉ :";
            // 
            // panel_SDT
            // 
            this.panel_SDT.BackColor = System.Drawing.Color.White;
            this.panel_SDT.Controls.Add(this.txt_SDT);
            this.panel_SDT.Controls.Add(this.label3);
            this.panel_SDT.Location = new System.Drawing.Point(12, 184);
            this.panel_SDT.Name = "panel_SDT";
            this.panel_SDT.Size = new System.Drawing.Size(421, 46);
            this.panel_SDT.TabIndex = 22;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SDT.Location = new System.Drawing.Point(83, 7);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(335, 32);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.Click += new System.EventHandler(this.txt_SDT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "SDT :";
            // 
            // panel_CustomerID
            // 
            this.panel_CustomerID.BackColor = System.Drawing.Color.White;
            this.panel_CustomerID.Controls.Add(this.txt_CustomerID);
            this.panel_CustomerID.Controls.Add(this.label2);
            this.panel_CustomerID.Location = new System.Drawing.Point(12, 44);
            this.panel_CustomerID.Name = "panel_CustomerID";
            this.panel_CustomerID.Size = new System.Drawing.Size(421, 46);
            this.panel_CustomerID.TabIndex = 22;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CustomerID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_CustomerID.Location = new System.Drawing.Point(167, 6);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(251, 32);
            this.txt_CustomerID.TabIndex = 1;
            this.txt_CustomerID.Click += new System.EventHandler(this.txt_CustomerID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer_ID :";
            // 
            // panel_TenKhachHang
            // 
            this.panel_TenKhachHang.BackColor = System.Drawing.Color.White;
            this.panel_TenKhachHang.Controls.Add(this.txt_TenKhachHang);
            this.panel_TenKhachHang.Controls.Add(this.label7);
            this.panel_TenKhachHang.Location = new System.Drawing.Point(12, 114);
            this.panel_TenKhachHang.Name = "panel_TenKhachHang";
            this.panel_TenKhachHang.Size = new System.Drawing.Size(421, 46);
            this.panel_TenKhachHang.TabIndex = 21;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenKhachHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_TenKhachHang.Location = new System.Drawing.Point(197, 7);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(221, 32);
            this.txt_TenKhachHang.TabIndex = 1;
            this.txt_TenKhachHang.Click += new System.EventHandler(this.txt_TenKhachHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên Khách hàng  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(1054, 411);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 48);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 451);
            this.panel1.TabIndex = 42;
            // 
            // Form_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 488);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Customers";
            this.Text = "Form_Customers";
            this.Load += new System.EventHandler(this.Form_Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel_DiaChi.ResumeLayout(false);
            this.panel_DiaChi.PerformLayout();
            this.panel_SDT.ResumeLayout(false);
            this.panel_SDT.PerformLayout();
            this.panel_CustomerID.ResumeLayout(false);
            this.panel_CustomerID.PerformLayout();
            this.panel_TenKhachHang.ResumeLayout(false);
            this.panel_TenKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_SDT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_CustomerID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_TenKhachHang;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel1;
    }
}