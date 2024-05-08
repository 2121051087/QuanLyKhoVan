namespace QuanLyKhoVan
{
    partial class Form_Supplies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel_thongtinlienhe = new System.Windows.Forms.Panel();
            this.txt_thongtinlienhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel_SupplierID = new System.Windows.Forms.Panel();
            this.txt_SupplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel_TenNCC = new System.Windows.Forms.Panel();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_thongtinlienhe.SuspendLayout();
            this.panel_SupplierID.SuspendLayout();
            this.panel_TenNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 639);
            this.panel1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(24, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhà cung cấp : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.panel_thongtinlienhe);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.panel_SupplierID);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.panel_TenNCC);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 210);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(515, 143);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(128, 48);
            this.btn_Xoa.TabIndex = 50;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel_thongtinlienhe
            // 
            this.panel_thongtinlienhe.BackColor = System.Drawing.Color.White;
            this.panel_thongtinlienhe.Controls.Add(this.txt_thongtinlienhe);
            this.panel_thongtinlienhe.Controls.Add(this.label3);
            this.panel_thongtinlienhe.Location = new System.Drawing.Point(9, 141);
            this.panel_thongtinlienhe.Name = "panel_thongtinlienhe";
            this.panel_thongtinlienhe.Size = new System.Drawing.Size(421, 46);
            this.panel_thongtinlienhe.TabIndex = 22;
            // 
            // txt_thongtinlienhe
            // 
            this.txt_thongtinlienhe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_thongtinlienhe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thongtinlienhe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_thongtinlienhe.Location = new System.Drawing.Point(116, 7);
            this.txt_thongtinlienhe.Name = "txt_thongtinlienhe";
            this.txt_thongtinlienhe.Size = new System.Drawing.Size(302, 32);
            this.txt_thongtinlienhe.TabIndex = 1;
            this.txt_thongtinlienhe.Click += new System.EventHandler(this.txt_thongtinlienhe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Liên hệ :";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(515, 89);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(128, 48);
            this.btn_Sua.TabIndex = 51;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel_SupplierID
            // 
            this.panel_SupplierID.BackColor = System.Drawing.Color.White;
            this.panel_SupplierID.Controls.Add(this.txt_SupplierID);
            this.panel_SupplierID.Controls.Add(this.label2);
            this.panel_SupplierID.Location = new System.Drawing.Point(9, 29);
            this.panel_SupplierID.Name = "panel_SupplierID";
            this.panel_SupplierID.Size = new System.Drawing.Size(421, 46);
            this.panel_SupplierID.TabIndex = 22;
            // 
            // txt_SupplierID
            // 
            this.txt_SupplierID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SupplierID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SupplierID.Location = new System.Drawing.Point(167, 6);
            this.txt_SupplierID.Name = "txt_SupplierID";
            this.txt_SupplierID.Size = new System.Drawing.Size(251, 32);
            this.txt_SupplierID.TabIndex = 1;
            this.txt_SupplierID.Click += new System.EventHandler(this.txt_SupplierID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Supplier_ID :";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(515, 29);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 48);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel_TenNCC
            // 
            this.panel_TenNCC.BackColor = System.Drawing.Color.White;
            this.panel_TenNCC.Controls.Add(this.txt_TenNCC);
            this.panel_TenNCC.Controls.Add(this.label7);
            this.panel_TenNCC.Location = new System.Drawing.Point(9, 85);
            this.panel_TenNCC.Name = "panel_TenNCC";
            this.panel_TenNCC.Size = new System.Drawing.Size(421, 46);
            this.panel_TenNCC.TabIndex = 21;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenNCC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_TenNCC.Location = new System.Drawing.Point(116, 7);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(302, 32);
            this.txt_TenNCC.TabIndex = 1;
            this.txt_TenNCC.Click += new System.EventHandler(this.txt_TenNCC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên NCC :";
            // 
            // Form_Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 618);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Supplies";
            this.Text = "Form_Supplies";
            this.Load += new System.EventHandler(this.Form_Supplies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_thongtinlienhe.ResumeLayout(false);
            this.panel_thongtinlienhe.PerformLayout();
            this.panel_SupplierID.ResumeLayout(false);
            this.panel_SupplierID.PerformLayout();
            this.panel_TenNCC.ResumeLayout(false);
            this.panel_TenNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel_thongtinlienhe;
        private System.Windows.Forms.TextBox txt_thongtinlienhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel_SupplierID;
        private System.Windows.Forms.TextBox txt_SupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel_TenNCC;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.Label label7;
    }
}