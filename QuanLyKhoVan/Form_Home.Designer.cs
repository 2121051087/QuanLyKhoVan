namespace QuanLyKhoVan
{
    partial class Form_Home
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_KiemKe = new System.Windows.Forms.Button();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_PhieuXuat = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_PhieuNhap = new System.Windows.Forms.Button();
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.btn_Kho = new System.Windows.Forms.Button();
            this.btn_VanChuyen = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_QuanLy = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.lb_KqSoNhanVien = new System.Windows.Forms.Label();
            this.lb_KqSoKhoHang = new System.Windows.Forms.Label();
            this.lb_KqSoDonHang = new System.Windows.Forms.Label();
            this.lb_SoLoaiSanPham = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.btn_LogOut);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btn_account);
            this.panel4.Location = new System.Drawing.Point(1366, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 151);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_LogOut.Location = new System.Drawing.Point(3, 103);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(122, 45);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.button4.Location = new System.Drawing.Point(3, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.White;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_account.Location = new System.Drawing.Point(3, 3);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(121, 48);
            this.btn_account.TabIndex = 0;
            this.btn_account.Text = "Account";
            this.btn_account.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 300);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Danh sách sản phẩm ",
            "Danh sách danh mục ",
            "Danh sách đơn hàng ",
            "Danh sách đơn hàng chi tiết ",
            "Danh sách khách hàng ",
            "Danh sách nhân viên ",
            "Danh sách vận chuyển",
            "Danh sách kho hàng ",
            "Danh sách nhà cung cấp ",
            "Danh sách Phiếu nhập",
            "Danh sách Phiếu xuất ",
            "Danh sách Kiểm Kê"});
            this.comboBox1.Location = new System.Drawing.Point(121, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(371, 33);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(92, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 400);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.btn_KiemKe);
            this.panel2.Controls.Add(this.btn_NhaCungCap);
            this.panel2.Controls.Add(this.btn_PhieuXuat);
            this.panel2.Controls.Add(this.btn_SanPham);
            this.panel2.Controls.Add(this.btn_KhachHang);
            this.panel2.Controls.Add(this.btn_PhieuNhap);
            this.panel2.Controls.Add(this.btn_DonHang);
            this.panel2.Controls.Add(this.btn_DanhMuc);
            this.panel2.Controls.Add(this.btn_Kho);
            this.panel2.Controls.Add(this.btn_VanChuyen);
            this.panel2.Controls.Add(this.btn_NhanVien);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 803);
            this.panel2.TabIndex = 0;
            // 
            // btn_KiemKe
            // 
            this.btn_KiemKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_KiemKe.FlatAppearance.BorderSize = 0;
            this.btn_KiemKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemKe.ForeColor = System.Drawing.Color.White;
            this.btn_KiemKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KiemKe.Location = new System.Drawing.Point(0, 640);
            this.btn_KiemKe.Name = "btn_KiemKe";
            this.btn_KiemKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_KiemKe.Size = new System.Drawing.Size(250, 64);
            this.btn_KiemKe.TabIndex = 12;
            this.btn_KiemKe.Text = "Quản lý kiểm kê";
            this.btn_KiemKe.UseVisualStyleBackColor = false;
            this.btn_KiemKe.Click += new System.EventHandler(this.btn_KiemKe_Click);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_NhaCungCap.FlatAppearance.BorderSize = 0;
            this.btn_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(0, 448);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_NhaCungCap.Size = new System.Drawing.Size(250, 64);
            this.btn_NhaCungCap.TabIndex = 13;
            this.btn_NhaCungCap.Text = "Nhà cung cấp";
            this.btn_NhaCungCap.UseVisualStyleBackColor = false;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_PhieuXuat
            // 
            this.btn_PhieuXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_PhieuXuat.FlatAppearance.BorderSize = 0;
            this.btn_PhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhieuXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuXuat.ForeColor = System.Drawing.Color.White;
            this.btn_PhieuXuat.Location = new System.Drawing.Point(0, 576);
            this.btn_PhieuXuat.Name = "btn_PhieuXuat";
            this.btn_PhieuXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_PhieuXuat.Size = new System.Drawing.Size(250, 64);
            this.btn_PhieuXuat.TabIndex = 11;
            this.btn_PhieuXuat.Text = "Phiếu xuất ";
            this.btn_PhieuXuat.UseVisualStyleBackColor = false;
            this.btn_PhieuXuat.Click += new System.EventHandler(this.btn_PhieuXuat_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.White;
            this.btn_SanPham.Location = new System.Drawing.Point(0, 0);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(250, 64);
            this.btn_SanPham.TabIndex = 3;
            this.btn_SanPham.Text = "Quản lý sản phẩm ";
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 192);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_KhachHang.Size = new System.Drawing.Size(250, 64);
            this.btn_KhachHang.TabIndex = 7;
            this.btn_KhachHang.Text = "Quản lý khách hàng ";
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_PhieuNhap
            // 
            this.btn_PhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_PhieuNhap.FlatAppearance.BorderSize = 0;
            this.btn_PhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_PhieuNhap.Location = new System.Drawing.Point(0, 512);
            this.btn_PhieuNhap.Name = "btn_PhieuNhap";
            this.btn_PhieuNhap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_PhieuNhap.Size = new System.Drawing.Size(250, 64);
            this.btn_PhieuNhap.TabIndex = 8;
            this.btn_PhieuNhap.Text = "Phiếu nhập ";
            this.btn_PhieuNhap.UseVisualStyleBackColor = false;
            this.btn_PhieuNhap.Click += new System.EventHandler(this.btn_PhieuNhap_Click);
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_DonHang.FlatAppearance.BorderSize = 0;
            this.btn_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHang.ForeColor = System.Drawing.Color.White;
            this.btn_DonHang.Location = new System.Drawing.Point(0, 128);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_DonHang.Size = new System.Drawing.Size(250, 64);
            this.btn_DonHang.TabIndex = 6;
            this.btn_DonHang.Text = "Quản lý đơn hàng ";
            this.btn_DonHang.UseVisualStyleBackColor = false;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_DanhMuc.FlatAppearance.BorderSize = 0;
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhMuc.ForeColor = System.Drawing.Color.White;
            this.btn_DanhMuc.Location = new System.Drawing.Point(0, 64);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_DanhMuc.Size = new System.Drawing.Size(250, 64);
            this.btn_DanhMuc.TabIndex = 5;
            this.btn_DanhMuc.Text = "Quản lý danh mục ";
            this.btn_DanhMuc.UseVisualStyleBackColor = false;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // btn_Kho
            // 
            this.btn_Kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_Kho.FlatAppearance.BorderSize = 0;
            this.btn_Kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kho.ForeColor = System.Drawing.Color.White;
            this.btn_Kho.Location = new System.Drawing.Point(0, 384);
            this.btn_Kho.Name = "btn_Kho";
            this.btn_Kho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Kho.Size = new System.Drawing.Size(250, 64);
            this.btn_Kho.TabIndex = 9;
            this.btn_Kho.Text = "Quản lý kho ";
            this.btn_Kho.UseVisualStyleBackColor = false;
            this.btn_Kho.Click += new System.EventHandler(this.btn_Kho_Click);
            // 
            // btn_VanChuyen
            // 
            this.btn_VanChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_VanChuyen.FlatAppearance.BorderSize = 0;
            this.btn_VanChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VanChuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VanChuyen.ForeColor = System.Drawing.Color.White;
            this.btn_VanChuyen.Location = new System.Drawing.Point(0, 320);
            this.btn_VanChuyen.Name = "btn_VanChuyen";
            this.btn_VanChuyen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_VanChuyen.Size = new System.Drawing.Size(250, 64);
            this.btn_VanChuyen.TabIndex = 10;
            this.btn_VanChuyen.Text = "Quản lý vận chuyển ";
            this.btn_VanChuyen.UseVisualStyleBackColor = false;
            this.btn_VanChuyen.Click += new System.EventHandler(this.btn_VanChuyen_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 256);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(250, 64);
            this.btn_NhanVien.TabIndex = 4;
            this.btn_NhanVien.Text = "Quản lý nhân viên ";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 757);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.btn_QuanLy);
            this.panel5.Controls.Add(this.btn_About);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1582, 65);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel6.Controls.Add(this.lb_KqSoNhanVien);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(62, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 140);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel7.Controls.Add(this.lb_SoLoaiSanPham);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(450, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 140);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel8.Controls.Add(this.lb_KqSoKhoHang);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(1226, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 140);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel9.Controls.Add(this.lb_KqSoDonHang);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(838, 117);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(293, 140);
            this.panel9.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số đơn hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(130, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số nhân viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số loại sản phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số kho hàng ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhoVan.Properties.Resources.ic_warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(3, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyKhoVan.Properties.Resources.ic_Orders;
            this.pictureBox2.Location = new System.Drawing.Point(3, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLyKhoVan.Properties.Resources.ic_Invetory;
            this.pictureBox4.Location = new System.Drawing.Point(3, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyKhoVan.Properties.Resources.ic_people;
            this.pictureBox3.Location = new System.Drawing.Point(3, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.ForeColor = System.Drawing.Color.White;
            this.btn_QuanLy.Image = global::QuanLyKhoVan.Properties.Resources.ic_menu_white;
            this.btn_QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.Location = new System.Drawing.Point(8, 7);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_QuanLy.Size = new System.Drawing.Size(244, 48);
            this.btn_QuanLy.TabIndex = 2;
            this.btn_QuanLy.Text = "Quản lý ";
            this.btn_QuanLy.UseVisualStyleBackColor = false;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Image = global::QuanLyKhoVan.Properties.Resources.ic_about_white;
            this.btn_About.Location = new System.Drawing.Point(1446, 12);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(48, 48);
            this.btn_About.TabIndex = 1;
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // lb_KqSoNhanVien
            // 
            this.lb_KqSoNhanVien.AutoSize = true;
            this.lb_KqSoNhanVien.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KqSoNhanVien.ForeColor = System.Drawing.Color.White;
            this.lb_KqSoNhanVien.Location = new System.Drawing.Point(165, 22);
            this.lb_KqSoNhanVien.Name = "lb_KqSoNhanVien";
            this.lb_KqSoNhanVien.Size = new System.Drawing.Size(69, 54);
            this.lb_KqSoNhanVien.TabIndex = 24;
            this.lb_KqSoNhanVien.Text = "33";
            // 
            // lb_KqSoKhoHang
            // 
            this.lb_KqSoKhoHang.AutoSize = true;
            this.lb_KqSoKhoHang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KqSoKhoHang.ForeColor = System.Drawing.Color.White;
            this.lb_KqSoKhoHang.Location = new System.Drawing.Point(199, 22);
            this.lb_KqSoKhoHang.Name = "lb_KqSoKhoHang";
            this.lb_KqSoKhoHang.Size = new System.Drawing.Size(69, 54);
            this.lb_KqSoKhoHang.TabIndex = 25;
            this.lb_KqSoKhoHang.Text = "33";
            // 
            // lb_KqSoDonHang
            // 
            this.lb_KqSoDonHang.AutoSize = true;
            this.lb_KqSoDonHang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KqSoDonHang.ForeColor = System.Drawing.Color.White;
            this.lb_KqSoDonHang.Location = new System.Drawing.Point(197, 22);
            this.lb_KqSoDonHang.Name = "lb_KqSoDonHang";
            this.lb_KqSoDonHang.Size = new System.Drawing.Size(69, 54);
            this.lb_KqSoDonHang.TabIndex = 26;
            this.lb_KqSoDonHang.Text = "33";
            // 
            // lb_SoLoaiSanPham
            // 
            this.lb_SoLoaiSanPham.AutoSize = true;
            this.lb_SoLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.lb_SoLoaiSanPham.Location = new System.Drawing.Point(201, 22);
            this.lb_SoLoaiSanPham.Name = "lb_SoLoaiSanPham";
            this.lb_SoLoaiSanPham.Size = new System.Drawing.Size(69, 54);
            this.lb_SoLoaiSanPham.TabIndex = 27;
            this.lb_SoLoaiSanPham.Text = "33";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(854, 378);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(650, 400);
            this.panel10.TabIndex = 16;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1582, 822);
            this.ControlBox = false;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_KiemKe;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_PhieuXuat;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_PhieuNhap;
        private System.Windows.Forms.Button btn_DonHang;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.Button btn_Kho;
        private System.Windows.Forms.Button btn_VanChuyen;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_QuanLy;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_KqSoNhanVien;
        private System.Windows.Forms.Label lb_SoLoaiSanPham;
        private System.Windows.Forms.Label lb_KqSoKhoHang;
        private System.Windows.Forms.Label lb_KqSoDonHang;
        private System.Windows.Forms.Panel panel10;
    }
}