namespace QuanLyKhoVan
{
    partial class Form_Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_CategoryID = new System.Windows.Forms.Panel();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Gia = new System.Windows.Forms.Panel();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_MoTa = new System.Windows.Forms.Panel();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_SoLuong = new System.Windows.Forms.Panel();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_TenSanPham = new System.Windows.Forms.Panel();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ProductID = new System.Windows.Forms.Panel();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel_CategoryID.SuspendLayout();
            this.panel_Gia.SuspendLayout();
            this.panel_MoTa.SuspendLayout();
            this.panel_SoLuong.SuspendLayout();
            this.panel_TenSanPham.SuspendLayout();
            this.panel_ProductID.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(880, 514);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 48);
            this.btn_Sua.TabIndex = 36;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sản phẩm :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_CategoryID);
            this.groupBox1.Controls.Add(this.panel_Gia);
            this.groupBox1.Controls.Add(this.panel_MoTa);
            this.groupBox1.Controls.Add(this.panel_SoLuong);
            this.groupBox1.Controls.Add(this.panel_TenSanPham);
            this.groupBox1.Controls.Add(this.panel_ProductID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(526, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 484);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_CategoryID
            // 
            this.panel_CategoryID.BackColor = System.Drawing.Color.White;
            this.panel_CategoryID.Controls.Add(this.txt_CategoryID);
            this.panel_CategoryID.Controls.Add(this.label6);
            this.panel_CategoryID.Location = new System.Drawing.Point(12, 399);
            this.panel_CategoryID.Name = "panel_CategoryID";
            this.panel_CategoryID.Size = new System.Drawing.Size(421, 46);
            this.panel_CategoryID.TabIndex = 23;
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CategoryID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_CategoryID.Location = new System.Drawing.Point(167, 6);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(251, 32);
            this.txt_CategoryID.TabIndex = 1;
            this.txt_CategoryID.Click += new System.EventHandler(this.txt_CategoryID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Category_ID :";
            // 
            // panel_Gia
            // 
            this.panel_Gia.BackColor = System.Drawing.Color.White;
            this.panel_Gia.Controls.Add(this.txt_Gia);
            this.panel_Gia.Controls.Add(this.label4);
            this.panel_Gia.Location = new System.Drawing.Point(12, 255);
            this.panel_Gia.Name = "panel_Gia";
            this.panel_Gia.Size = new System.Drawing.Size(421, 46);
            this.panel_Gia.TabIndex = 22;
            // 
            // txt_Gia
            // 
            this.txt_Gia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Gia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Gia.Location = new System.Drawing.Point(81, 6);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(337, 32);
            this.txt_Gia.TabIndex = 1;
            this.txt_Gia.Click += new System.EventHandler(this.txt_Gia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giá :";
            // 
            // panel_MoTa
            // 
            this.panel_MoTa.BackColor = System.Drawing.Color.White;
            this.panel_MoTa.Controls.Add(this.txt_Mota);
            this.panel_MoTa.Controls.Add(this.label3);
            this.panel_MoTa.Location = new System.Drawing.Point(12, 183);
            this.panel_MoTa.Name = "panel_MoTa";
            this.panel_MoTa.Size = new System.Drawing.Size(421, 46);
            this.panel_MoTa.TabIndex = 22;
            // 
            // txt_Mota
            // 
            this.txt_Mota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Mota.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Mota.Location = new System.Drawing.Point(99, 6);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(304, 32);
            this.txt_Mota.TabIndex = 1;
            this.txt_Mota.Click += new System.EventHandler(this.txt_Mota_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mô tả :";
            // 
            // panel_SoLuong
            // 
            this.panel_SoLuong.BackColor = System.Drawing.Color.White;
            this.panel_SoLuong.Controls.Add(this.txt_SoLuong);
            this.panel_SoLuong.Controls.Add(this.label5);
            this.panel_SoLuong.Location = new System.Drawing.Point(12, 327);
            this.panel_SoLuong.Name = "panel_SoLuong";
            this.panel_SoLuong.Size = new System.Drawing.Size(421, 46);
            this.panel_SoLuong.TabIndex = 22;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(137, 6);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(281, 32);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.Click += new System.EventHandler(this.txt_SoLuong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng :";
            // 
            // panel_TenSanPham
            // 
            this.panel_TenSanPham.BackColor = System.Drawing.Color.White;
            this.panel_TenSanPham.Controls.Add(this.txt_TenSanPham);
            this.panel_TenSanPham.Controls.Add(this.label2);
            this.panel_TenSanPham.Location = new System.Drawing.Point(12, 111);
            this.panel_TenSanPham.Name = "panel_TenSanPham";
            this.panel_TenSanPham.Size = new System.Drawing.Size(421, 46);
            this.panel_TenSanPham.TabIndex = 22;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_TenSanPham.Location = new System.Drawing.Point(167, 6);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(251, 32);
            this.txt_TenSanPham.TabIndex = 1;
            this.txt_TenSanPham.Click += new System.EventHandler(this.txt_TenSanPham_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên sản phẩm : ";
            // 
            // panel_ProductID
            // 
            this.panel_ProductID.BackColor = System.Drawing.Color.White;
            this.panel_ProductID.Controls.Add(this.txt_ProductID);
            this.panel_ProductID.Controls.Add(this.label7);
            this.panel_ProductID.Location = new System.Drawing.Point(12, 39);
            this.panel_ProductID.Name = "panel_ProductID";
            this.panel_ProductID.Size = new System.Drawing.Size(421, 46);
            this.panel_ProductID.TabIndex = 21;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProductID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_ProductID.Location = new System.Drawing.Point(137, 6);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(281, 32);
            this.txt_ProductID.TabIndex = 1;
            this.txt_ProductID.Click += new System.EventHandler(this.txt_ProductID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product_ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 555);
            this.panel1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(538, 510);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 48);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(947, 514);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 48);
            this.btn_Xoa.TabIndex = 35;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Name = "Form_Products";
            this.Text = "Form_Products";
            this.Load += new System.EventHandler(this.Form_Products_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel_CategoryID.ResumeLayout(false);
            this.panel_CategoryID.PerformLayout();
            this.panel_Gia.ResumeLayout(false);
            this.panel_Gia.PerformLayout();
            this.panel_MoTa.ResumeLayout(false);
            this.panel_MoTa.PerformLayout();
            this.panel_SoLuong.ResumeLayout(false);
            this.panel_SoLuong.PerformLayout();
            this.panel_TenSanPham.ResumeLayout(false);
            this.panel_TenSanPham.PerformLayout();
            this.panel_ProductID.ResumeLayout(false);
            this.panel_ProductID.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_ProductID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel_CategoryID;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Gia;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_MoTa;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_SoLuong;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_TenSanPham;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label label2;
    }
}