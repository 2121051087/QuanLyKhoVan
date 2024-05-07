namespace QuanLyKhoVan
{
    partial class Form_Order
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_OrderID = new System.Windows.Forms.Panel();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_CustomerID = new System.Windows.Forms.Panel();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_DiaChi = new System.Windows.Forms.Panel();
            this.txt_NgayDatHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_NgayDatHang = new System.Windows.Forms.Panel();
            this.txt_TongSoTienGiaoHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_TongSoTienGiaoHang = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_OrderID.SuspendLayout();
            this.panel_CustomerID.SuspendLayout();
            this.panel_DiaChi.SuspendLayout();
            this.panel_NgayDatHang.SuspendLayout();
            this.panel_TongSoTienGiaoHang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(1116, 473);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 48);
            this.btn_Xoa.TabIndex = 40;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OrderID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_OrderID.Location = new System.Drawing.Point(137, 7);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(281, 32);
            this.txt_OrderID.TabIndex = 1;
            this.txt_OrderID.Click += new System.EventHandler(this.txt_OrderID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Order_ID :";
            // 
            // panel_OrderID
            // 
            this.panel_OrderID.BackColor = System.Drawing.Color.White;
            this.panel_OrderID.Controls.Add(this.txt_OrderID);
            this.panel_OrderID.Controls.Add(this.label7);
            this.panel_OrderID.Location = new System.Drawing.Point(12, 39);
            this.panel_OrderID.Name = "panel_OrderID";
            this.panel_OrderID.Size = new System.Drawing.Size(421, 46);
            this.panel_OrderID.TabIndex = 21;
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
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer_ID";
            // 
            // panel_CustomerID
            // 
            this.panel_CustomerID.BackColor = System.Drawing.Color.White;
            this.panel_CustomerID.Controls.Add(this.txt_CustomerID);
            this.panel_CustomerID.Controls.Add(this.label2);
            this.panel_CustomerID.Location = new System.Drawing.Point(12, 111);
            this.panel_CustomerID.Name = "panel_CustomerID";
            this.panel_CustomerID.Size = new System.Drawing.Size(421, 46);
            this.panel_CustomerID.TabIndex = 22;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(112, 7);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(306, 32);
            this.txt_DiaChi.TabIndex = 1;
            this.txt_DiaChi.Click += new System.EventHandler(this.txt_DiaChi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Địa chỉ :";
            // 
            // panel_DiaChi
            // 
            this.panel_DiaChi.BackColor = System.Drawing.Color.White;
            this.panel_DiaChi.Controls.Add(this.txt_DiaChi);
            this.panel_DiaChi.Controls.Add(this.label5);
            this.panel_DiaChi.Location = new System.Drawing.Point(12, 327);
            this.panel_DiaChi.Name = "panel_DiaChi";
            this.panel_DiaChi.Size = new System.Drawing.Size(421, 46);
            this.panel_DiaChi.TabIndex = 22;
            // 
            // txt_NgayDatHang
            // 
            this.txt_NgayDatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NgayDatHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayDatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_NgayDatHang.Location = new System.Drawing.Point(173, 7);
            this.txt_NgayDatHang.Name = "txt_NgayDatHang";
            this.txt_NgayDatHang.Size = new System.Drawing.Size(245, 32);
            this.txt_NgayDatHang.TabIndex = 1;
            this.txt_NgayDatHang.Click += new System.EventHandler(this.txt_NgayDatHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày đặt hàng :";
            // 
            // panel_NgayDatHang
            // 
            this.panel_NgayDatHang.BackColor = System.Drawing.Color.White;
            this.panel_NgayDatHang.Controls.Add(this.txt_NgayDatHang);
            this.panel_NgayDatHang.Controls.Add(this.label3);
            this.panel_NgayDatHang.Location = new System.Drawing.Point(12, 183);
            this.panel_NgayDatHang.Name = "panel_NgayDatHang";
            this.panel_NgayDatHang.Size = new System.Drawing.Size(421, 46);
            this.panel_NgayDatHang.TabIndex = 22;
            // 
            // txt_TongSoTienGiaoHang
            // 
            this.txt_TongSoTienGiaoHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TongSoTienGiaoHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSoTienGiaoHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_TongSoTienGiaoHang.Location = new System.Drawing.Point(210, 7);
            this.txt_TongSoTienGiaoHang.Name = "txt_TongSoTienGiaoHang";
            this.txt_TongSoTienGiaoHang.Size = new System.Drawing.Size(208, 32);
            this.txt_TongSoTienGiaoHang.TabIndex = 1;
            this.txt_TongSoTienGiaoHang.Click += new System.EventHandler(this.txt_TongSoTienGiaoHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tổng số tiền giao :";
            // 
            // panel_TongSoTienGiaoHang
            // 
            this.panel_TongSoTienGiaoHang.BackColor = System.Drawing.Color.White;
            this.panel_TongSoTienGiaoHang.Controls.Add(this.txt_TongSoTienGiaoHang);
            this.panel_TongSoTienGiaoHang.Controls.Add(this.label4);
            this.panel_TongSoTienGiaoHang.Location = new System.Drawing.Point(12, 255);
            this.panel_TongSoTienGiaoHang.Name = "panel_TongSoTienGiaoHang";
            this.panel_TongSoTienGiaoHang.Size = new System.Drawing.Size(421, 46);
            this.panel_TongSoTienGiaoHang.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_TongSoTienGiaoHang);
            this.groupBox1.Controls.Add(this.panel_NgayDatHang);
            this.groupBox1.Controls.Add(this.panel_DiaChi);
            this.groupBox1.Controls.Add(this.panel_CustomerID);
            this.groupBox1.Controls.Add(this.panel_OrderID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(695, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 414);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đơn hàng :";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(1045, 474);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 48);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 509);
            this.panel1.TabIndex = 37;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(695, 473);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 48);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 542);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Them);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_OrderID.ResumeLayout(false);
            this.panel_OrderID.PerformLayout();
            this.panel_CustomerID.ResumeLayout(false);
            this.panel_CustomerID.PerformLayout();
            this.panel_DiaChi.ResumeLayout(false);
            this.panel_DiaChi.PerformLayout();
            this.panel_NgayDatHang.ResumeLayout(false);
            this.panel_NgayDatHang.PerformLayout();
            this.panel_TongSoTienGiaoHang.ResumeLayout(false);
            this.panel_TongSoTienGiaoHang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_OrderID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_CustomerID;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_DiaChi;
        private System.Windows.Forms.TextBox txt_NgayDatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_NgayDatHang;
        private System.Windows.Forms.TextBox txt_TongSoTienGiaoHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_TongSoTienGiaoHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Them;
    }
}