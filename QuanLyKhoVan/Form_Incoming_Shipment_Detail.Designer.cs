namespace QuanLyKhoVan
{
    partial class Form_Incoming_Shipment_Detail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_kqDetail_ID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_ShipmentID = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ShipmentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_ProductID = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_TenSanPham = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_SoLuong = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_DanhSach = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_TongTienHang = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_ShipmentID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_ProductID.SuspendLayout();
            this.panel_TenSanPham.SuspendLayout();
            this.panel_SoLuong.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_kqDetail_ID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel_ShipmentID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 80);
            this.panel1.TabIndex = 0;
            // 
            // lb_kqDetail_ID
            // 
            this.lb_kqDetail_ID.AutoSize = true;
            this.lb_kqDetail_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kqDetail_ID.ForeColor = System.Drawing.Color.Black;
            this.lb_kqDetail_ID.Location = new System.Drawing.Point(882, 30);
            this.lb_kqDetail_ID.Name = "lb_kqDetail_ID";
            this.lb_kqDetail_ID.Size = new System.Drawing.Size(60, 28);
            this.lb_kqDetail_ID.TabIndex = 23;
            this.lb_kqDetail_ID.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label11.Location = new System.Drawing.Point(738, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Detail_ID :";
            // 
            // panel_ShipmentID
            // 
            this.panel_ShipmentID.BackColor = System.Drawing.Color.White;
            this.panel_ShipmentID.Controls.Add(this.label2);
            this.panel_ShipmentID.Controls.Add(this.comboBox_ShipmentID);
            this.panel_ShipmentID.Location = new System.Drawing.Point(271, 20);
            this.panel_ShipmentID.Name = "panel_ShipmentID";
            this.panel_ShipmentID.Size = new System.Drawing.Size(421, 46);
            this.panel_ShipmentID.TabIndex = 22;
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
            this.label2.Text = "Shipment_ID :";
            // 
            // comboBox_ShipmentID
            // 
            this.comboBox_ShipmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ShipmentID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ShipmentID.FormattingEnabled = true;
            this.comboBox_ShipmentID.Location = new System.Drawing.Point(169, 3);
            this.comboBox_ShipmentID.Name = "comboBox_ShipmentID";
            this.comboBox_ShipmentID.Size = new System.Drawing.Size(242, 39);
            this.comboBox_ShipmentID.TabIndex = 21;
            this.comboBox_ShipmentID.SelectedValueChanged += new System.EventHandler(this.comboBox_ShipmentID_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 59);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel_ProductID
            // 
            this.panel_ProductID.BackColor = System.Drawing.Color.White;
            this.panel_ProductID.Controls.Add(this.label7);
            this.panel_ProductID.Location = new System.Drawing.Point(61, 184);
            this.panel_ProductID.Name = "panel_ProductID";
            this.panel_ProductID.Size = new System.Drawing.Size(135, 46);
            this.panel_ProductID.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product_ID ";
            // 
            // panel_TenSanPham
            // 
            this.panel_TenSanPham.BackColor = System.Drawing.Color.White;
            this.panel_TenSanPham.Controls.Add(this.label3);
            this.panel_TenSanPham.Location = new System.Drawing.Point(271, 184);
            this.panel_TenSanPham.Name = "panel_TenSanPham";
            this.panel_TenSanPham.Size = new System.Drawing.Size(170, 46);
            this.panel_TenSanPham.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên sản phẩm ";
            // 
            // panel_SoLuong
            // 
            this.panel_SoLuong.BackColor = System.Drawing.Color.White;
            this.panel_SoLuong.Controls.Add(this.label4);
            this.panel_SoLuong.Controls.Add(this.label5);
            this.panel_SoLuong.Location = new System.Drawing.Point(500, 184);
            this.panel_SoLuong.Name = "panel_SoLuong";
            this.panel_SoLuong.Size = new System.Drawing.Size(137, 46);
            this.panel_SoLuong.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(702, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 46);
            this.panel4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label8.Location = new System.Drawing.Point(60, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(932, 184);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 46);
            this.panel6.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label9.Location = new System.Drawing.Point(25, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thành tiền ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label10.Location = new System.Drawing.Point(26, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Thành tiền ";
            // 
            // panel_DanhSach
            // 
            this.panel_DanhSach.AutoScroll = true;
            this.panel_DanhSach.Location = new System.Drawing.Point(53, 257);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Size = new System.Drawing.Size(1220, 291);
            this.panel_DanhSach.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label6.Location = new System.Drawing.Point(985, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tổng tiền hàng :";
            // 
            // lb_TongTienHang
            // 
            this.lb_TongTienHang.AutoSize = true;
            this.lb_TongTienHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienHang.ForeColor = System.Drawing.Color.Black;
            this.lb_TongTienHang.Location = new System.Drawing.Point(1174, 581);
            this.lb_TongTienHang.Name = "lb_TongTienHang";
            this.lb_TongTienHang.Size = new System.Drawing.Size(24, 28);
            this.lb_TongTienHang.TabIndex = 22;
            this.lb_TongTienHang.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label12.Location = new System.Drawing.Point(1280, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 28);
            this.label12.TabIndex = 38;
            this.label12.Text = "VNĐ";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Image = global::QuanLyKhoVan.Properties.Resources.ic_cross;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(1158, 651);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(126, 42);
            this.btn_Huy.TabIndex = 43;
            this.btn_Huy.Text = "Hủy ";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Image = global::QuanLyKhoVan.Properties.Resources.ic_save_24;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(1018, 651);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 42);
            this.btn_Luu.TabIndex = 42;
            this.btn_Luu.Text = "Lưu ";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::QuanLyKhoVan.Properties.Resources.ic_add;
            this.btn_Them.Location = new System.Drawing.Point(1194, 181);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(59, 48);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Form_Incoming_Shipment_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 705);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_TongTienHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_SoLuong);
            this.Controls.Add(this.panel_TenSanPham);
            this.Controls.Add(this.panel_ProductID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Incoming_Shipment_Detail";
            this.Text = "Form_Incoming_Shipment_Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ShipmentID.ResumeLayout(false);
            this.panel_ShipmentID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_ProductID.ResumeLayout(false);
            this.panel_ProductID.PerformLayout();
            this.panel_TenSanPham.ResumeLayout(false);
            this.panel_TenSanPham.PerformLayout();
            this.panel_SoLuong.ResumeLayout(false);
            this.panel_SoLuong.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ShipmentID;
        private System.Windows.Forms.Panel panel_ShipmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_ProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.FlowLayoutPanel panel_DanhSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_TongTienHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_kqDetail_ID;
    }
}