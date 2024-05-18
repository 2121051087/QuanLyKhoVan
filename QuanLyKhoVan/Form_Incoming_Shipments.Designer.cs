namespace QuanLyKhoVan
{
    partial class Form_Incoming_Shipments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_NgayNhapHang = new System.Windows.Forms.Panel();
            this.txt_NgayNhapHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WarehouseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_SupplierID = new System.Windows.Forms.Panel();
            this.txt_SupplierID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_WarehouseID = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_ShipmentID = new System.Windows.Forms.Panel();
            this.txt_ShipmentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ChiTietNhap = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_NgayNhapHang.SuspendLayout();
            this.panel_SupplierID.SuspendLayout();
            this.panel_WarehouseID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_ShipmentID.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel_NgayNhapHang
            // 
            this.panel_NgayNhapHang.BackColor = System.Drawing.Color.White;
            this.panel_NgayNhapHang.Controls.Add(this.txt_NgayNhapHang);
            this.panel_NgayNhapHang.Controls.Add(this.label4);
            this.panel_NgayNhapHang.Location = new System.Drawing.Point(12, 255);
            this.panel_NgayNhapHang.Name = "panel_NgayNhapHang";
            this.panel_NgayNhapHang.Size = new System.Drawing.Size(421, 46);
            this.panel_NgayNhapHang.TabIndex = 22;
            // 
            // txt_NgayNhapHang
            // 
            this.txt_NgayNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NgayNhapHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayNhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_NgayNhapHang.Location = new System.Drawing.Point(188, 7);
            this.txt_NgayNhapHang.Name = "txt_NgayNhapHang";
            this.txt_NgayNhapHang.Size = new System.Drawing.Size(230, 32);
            this.txt_NgayNhapHang.TabIndex = 1;
            this.txt_NgayNhapHang.Click += new System.EventHandler(this.txt_NgayNhapHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày nhập hàng :";
            // 
            // txt_WarehouseID
            // 
            this.txt_WarehouseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_WarehouseID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WarehouseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_WarehouseID.Location = new System.Drawing.Point(183, 6);
            this.txt_WarehouseID.Name = "txt_WarehouseID";
            this.txt_WarehouseID.Size = new System.Drawing.Size(235, 32);
            this.txt_WarehouseID.TabIndex = 1;
            this.txt_WarehouseID.Click += new System.EventHandler(this.txt_WarehouseID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = " Warehouse_ID :";
            // 
            // panel_SupplierID
            // 
            this.panel_SupplierID.BackColor = System.Drawing.Color.White;
            this.panel_SupplierID.Controls.Add(this.txt_SupplierID);
            this.panel_SupplierID.Controls.Add(this.label3);
            this.panel_SupplierID.Location = new System.Drawing.Point(12, 183);
            this.panel_SupplierID.Name = "panel_SupplierID";
            this.panel_SupplierID.Size = new System.Drawing.Size(421, 46);
            this.panel_SupplierID.TabIndex = 22;
            // 
            // txt_SupplierID
            // 
            this.txt_SupplierID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SupplierID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SupplierID.Location = new System.Drawing.Point(155, 7);
            this.txt_SupplierID.Name = "txt_SupplierID";
            this.txt_SupplierID.Size = new System.Drawing.Size(263, 32);
            this.txt_SupplierID.TabIndex = 1;
            this.txt_SupplierID.Click += new System.EventHandler(this.txt_SupplierID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Supplier_ID :";
            // 
            // panel_WarehouseID
            // 
            this.panel_WarehouseID.BackColor = System.Drawing.Color.White;
            this.panel_WarehouseID.Controls.Add(this.txt_WarehouseID);
            this.panel_WarehouseID.Controls.Add(this.label2);
            this.panel_WarehouseID.Location = new System.Drawing.Point(12, 111);
            this.panel_WarehouseID.Name = "panel_WarehouseID";
            this.panel_WarehouseID.Size = new System.Drawing.Size(421, 46);
            this.panel_WarehouseID.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_ChiTietNhap);
            this.groupBox1.Controls.Add(this.panel_NgayNhapHang);
            this.groupBox1.Controls.Add(this.panel_SupplierID);
            this.groupBox1.Controls.Add(this.panel_WarehouseID);
            this.groupBox1.Controls.Add(this.panel_ShipmentID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(695, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 378);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_ShipmentID
            // 
            this.panel_ShipmentID.BackColor = System.Drawing.Color.White;
            this.panel_ShipmentID.Controls.Add(this.txt_ShipmentID);
            this.panel_ShipmentID.Controls.Add(this.label7);
            this.panel_ShipmentID.Location = new System.Drawing.Point(12, 39);
            this.panel_ShipmentID.Name = "panel_ShipmentID";
            this.panel_ShipmentID.Size = new System.Drawing.Size(421, 46);
            this.panel_ShipmentID.TabIndex = 21;
            // 
            // txt_ShipmentID
            // 
            this.txt_ShipmentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ShipmentID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShipmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_ShipmentID.Location = new System.Drawing.Point(151, 7);
            this.txt_ShipmentID.Name = "txt_ShipmentID";
            this.txt_ShipmentID.Size = new System.Drawing.Size(267, 32);
            this.txt_ShipmentID.TabIndex = 1;
            this.txt_ShipmentID.Click += new System.EventHandler(this.txt_ShipmentID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Shipment_ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phiếu nhập :";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(712, 482);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 48);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 509);
            this.panel1.TabIndex = 47;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(1116, 477);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 48);
            this.btn_Xoa.TabIndex = 50;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ChiTietNhap
            // 
            this.btn_ChiTietNhap.BackColor = System.Drawing.Color.Silver;
            this.btn_ChiTietNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiTietNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTietNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_ChiTietNhap.Image = global::QuanLyKhoVan.Properties.Resources.ic_down;
            this.btn_ChiTietNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChiTietNhap.Location = new System.Drawing.Point(12, 323);
            this.btn_ChiTietNhap.Name = "btn_ChiTietNhap";
            this.btn_ChiTietNhap.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_ChiTietNhap.Size = new System.Drawing.Size(421, 39);
            this.btn_ChiTietNhap.TabIndex = 52;
            this.btn_ChiTietNhap.Text = "Chi tiết phiếu nhập ";
            this.btn_ChiTietNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChiTietNhap.UseVisualStyleBackColor = false;
            this.btn_ChiTietNhap.Click += new System.EventHandler(this.btn_ChiTietNhap_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(1045, 478);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 48);
            this.btn_Sua.TabIndex = 51;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // Form_Incoming_Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 542);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Incoming_Shipments";
            this.Text = "Form_Incoming_Shipments";
            this.Load += new System.EventHandler(this.Form_Incoming_Shipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_NgayNhapHang.ResumeLayout(false);
            this.panel_NgayNhapHang.PerformLayout();
            this.panel_SupplierID.ResumeLayout(false);
            this.panel_SupplierID.PerformLayout();
            this.panel_WarehouseID.ResumeLayout(false);
            this.panel_WarehouseID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel_ShipmentID.ResumeLayout(false);
            this.panel_ShipmentID.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_NgayNhapHang;
        private System.Windows.Forms.TextBox txt_NgayNhapHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_WarehouseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_SupplierID;
        private System.Windows.Forms.TextBox txt_SupplierID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_WarehouseID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ShipmentID;
        private System.Windows.Forms.TextBox txt_ShipmentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ChiTietNhap;
    }
}