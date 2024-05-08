namespace QuanLyKhoVan
{
    partial class Form_Warehouses
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_DiaDiem = new System.Windows.Forms.Panel();
            this.txt_DiaDiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_WarehouseID = new System.Windows.Forms.Panel();
            this.txt_WarehouseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_DiaDiem.SuspendLayout();
            this.panel_WarehouseID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 223);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(442, 29);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(109, 48);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_DiaDiem);
            this.groupBox1.Controls.Add(this.panel_WarehouseID);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 164);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_DiaDiem
            // 
            this.panel_DiaDiem.BackColor = System.Drawing.Color.White;
            this.panel_DiaDiem.Controls.Add(this.txt_DiaDiem);
            this.panel_DiaDiem.Controls.Add(this.label1);
            this.panel_DiaDiem.Location = new System.Drawing.Point(15, 92);
            this.panel_DiaDiem.Name = "panel_DiaDiem";
            this.panel_DiaDiem.Size = new System.Drawing.Size(421, 46);
            this.panel_DiaDiem.TabIndex = 37;
            // 
            // txt_DiaDiem
            // 
            this.txt_DiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaDiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_DiaDiem.Location = new System.Drawing.Point(138, 7);
            this.txt_DiaDiem.Name = "txt_DiaDiem";
            this.txt_DiaDiem.Size = new System.Drawing.Size(280, 32);
            this.txt_DiaDiem.TabIndex = 1;
            this.txt_DiaDiem.Click += new System.EventHandler(this.txt_DiaDiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = " Địa điểm :";
            // 
            // panel_WarehouseID
            // 
            this.panel_WarehouseID.BackColor = System.Drawing.Color.White;
            this.panel_WarehouseID.Controls.Add(this.txt_WarehouseID);
            this.panel_WarehouseID.Controls.Add(this.label2);
            this.panel_WarehouseID.Location = new System.Drawing.Point(15, 29);
            this.panel_WarehouseID.Name = "panel_WarehouseID";
            this.panel_WarehouseID.Size = new System.Drawing.Size(421, 46);
            this.panel_WarehouseID.TabIndex = 36;
            // 
            // txt_WarehouseID
            // 
            this.txt_WarehouseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_WarehouseID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WarehouseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_WarehouseID.Location = new System.Drawing.Point(183, 7);
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
            this.label2.Text = "Warehouse_ID : ";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(503, 90);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 48);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(442, 90);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 48);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // Form_Warehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Warehouses";
            this.Text = "Form_Warehouses";
            this.Load += new System.EventHandler(this.Form_Warehouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_DiaDiem.ResumeLayout(false);
            this.panel_DiaDiem.PerformLayout();
            this.panel_WarehouseID.ResumeLayout(false);
            this.panel_WarehouseID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_DiaDiem;
        private System.Windows.Forms.TextBox txt_DiaDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_WarehouseID;
        private System.Windows.Forms.TextBox txt_WarehouseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}