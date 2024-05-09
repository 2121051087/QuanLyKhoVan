using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoVan
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }




        QuanLyKhoVan db = new QuanLyKhoVan();


        #region Method Load Data table
        void LoadDataCustomer()
        {
            var data = from c in db.Customers
                       select new
                       {
                           c.Customer_ID,
                           c.TenKhachHang,
                           c.SDT,
                           c.DiaChi
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        void LoadDataProduct()
        {
            var data = db.Products.Select(s => new
            {
                ProductID = s.Product_ID,
                TenSanPham = s.TenSanPham,
                MoTa = s.MoTa,
                Gia = s.Gia,
                SoLuong = s.SoLuong,
                CategoryID = s.Category_ID,

            }).ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        void LoadDataCategory()
        {
            var data = db.Categories.Select(s => new
            {
                CategoryID = s.Category_ID,
                TenDanhMuc = s.TenDanhMuc
            }).ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        void LoadDataEmployees()
        {
            var data = db.Employees.Select(s => new
            {
                EmployeeID = s.Employee_ID,
                TenNhanVien = s.TenNhanVien,
                SDT = s.SDT
            });
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataIncomingShipment()
        {
            var data = from p in db.Incoming_Shipments
                       select new
                       {
                           ShipmentID = p.Shipment_ID,
                           WarehouseID = p.Warehouse_ID,
                           SupplierID = p.Supplier_ID,
                           NgayNhapHang = p.NgayNhapHang,
                           status = p.status
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataInventoryChecks()
        {
            var data = db.Inventory_Checks.Select(s => new
            {
                CheckID = s.Check_ID,
                WarehouseID = s.Warehouse_ID,
                NgayKiemKe = s.NgayKiemKe,
                EmployeeID = s.Employee_ID,
                status = s.status
            });
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataOrder()
        {
            var data = from p in db.Order
                       select new
                       {
                           OrderID = p.Order_ID,
                           CustomerID = p.Customer_ID,
                           NgayDatHang = p.NgayDatHang,
                           TongSoTienGiaoHang = p.TongSoTienGiaoHang,
                           DiaChi = p.DiaChi
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataOrderDetails()
        {
            var data = db.Order_Details.Select(s => new
            {
                Order_Detail_ID = s.Order_Detail_ID,
                Order_ID = s.Order_ID,
                Product_ID = s.Product_ID,
                SoLuongSanPham = s.SoLuongSanPham,
                Gia = s.Gia
            }).ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        void LoadDataOutgoingShipment()
        {
            var data = db.Outgoing_Shipments.Select(s => new
            {
                ShipmentID = s.Shipment_ID,
                WarehouseID = s.Warehouse_ID,
                SupplierID = s.Supplier_ID,
                NgayXuatHang = s.NgayXuatHang,
                status = s.status
            });
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataShipment()
        {
            var data = from s in db.Shipments
                       select new
                       {
                           s.Shipment_ID,
                           s.Order_ID,
                           s.Employee_ID,
                           s.NgayGiao,
                           s.status
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadDataSuppliers()
        {
            var data = from s in db.Suppliers
                       select new
                       {
                           SupplierID = s.Supplier_ID,
                           TenNCC = s.TenNhaCungCap,
                           ThongTinLienHe = s.ThongTinLienHe
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        void LoadDataWarehouse()
        {
            var data = from p in db.Warehouses
                       select new
                       {
                           WarehouseID = p.Warehouse_ID,
                           DiaDiem = p.DiaDiem
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        #endregion







        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    LoadDataProduct();
                    break;

                case 1:
                    LoadDataCategory();
                    break;
                case 2:
                    LoadDataOrder();
                    break;
                case 3:
                    LoadDataOrderDetails();
                    break;
                case 4:
                    LoadDataCustomer();
                    break;
                case 5:
                    LoadDataEmployees();
                    break;
                case 6:
                    LoadDataShipment();
                    break;
                case 7:
                    LoadDataWarehouse();
                    break;
                case 8:
                    LoadDataSuppliers();
                    break;
                case 9:
                    LoadDataIncomingShipment();
                    break;
                case 10:
                    LoadDataOutgoingShipment();
                    break;
                case 11:
                    LoadDataInventoryChecks();
                    break;


            }
            
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();

            
        }
        #region Xu li UI 

        private void ShowAboutInfo()
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }
        private void ShowQuanLy()
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        #endregion
        private bool check;




        private void btn_About_Click(object sender, EventArgs e)
        {
            ShowAboutInfo();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            ShowQuanLy();
            timer1.Start();
        }


        #region Xử lí  điều hướng form quản lí 

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Products form_Products = new Form_Products();
            form_Products.ShowDialog();

            this.Show();
            form_Products.FormClosed += (s, args) => this.Show();
        }

      

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Categories form_Categories = new Form_Categories();
            form_Categories.ShowDialog();

            this.Show();
            form_Categories.FormClosed += (s, args) => this.Show();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Order form_Orders = new Form_Order();
            form_Orders.ShowDialog();

            this.Show();
            form_Orders.FormClosed += (s, args) => this.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Customers form_Customers = new Form_Customers();
            form_Customers.ShowDialog();

            this.Show();
            form_Customers.FormClosed += (s, args) => this.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Employees form_Employees = new Form_Employees();
            form_Employees.ShowDialog();

            this.Show();
            form_Employees.FormClosed += (s, args) => this.Show();
        }

        private void btn_VanChuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Shipment form_Shipments = new Form_Shipment();
            form_Shipments.ShowDialog();

            this.Show();
            form_Shipments.FormClosed += (s, args) => this.Show();

        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Warehouses form_Warehouses = new Form_Warehouses();
            form_Warehouses.ShowDialog();

            this.Show();
            form_Warehouses.FormClosed += (s, args) => this.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Supplies form_Suppliers = new Form_Supplies();
            form_Suppliers.ShowDialog();

            this.Show();
            form_Suppliers.FormClosed += (s, args) => this.Show();
        }

        private void btn_PhieuNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Incoming_Shipments form_Incoming_Shipments = new Form_Incoming_Shipments();
            form_Incoming_Shipments.ShowDialog();

            this.Show();
            form_Incoming_Shipments.FormClosed += (s, args) => this.Show();

        }

        private void btn_PhieuXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Outgoing_Shipments form_Outgoing_Shipments = new Form_Outgoing_Shipments();
            form_Outgoing_Shipments.ShowDialog();

            this.Show();
            form_Outgoing_Shipments.FormClosed += (s, args) => this.Show();

        }

        private void btn_KiemKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InventoryChecks form_Inventory_Checks = new Form_InventoryChecks();
            form_Inventory_Checks.ShowDialog();

            this.Show();
            form_Inventory_Checks.FormClosed += (s, args) => this.Show();

        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Invoke((MethodInvoker)(() =>
            {
                if (check)
                {
                    panel3.Left -= 200;
                }
                else
                {
                    panel3.Left += 200;
                }

                timer1.Stop();
                check = !check;
            }));
        }
        void CountEmployess()
        {
            var data = db.Employees.Count();
            lb_KqSoNhanVien.Text = data.ToString();

        }
        void CountWarehouses()
        {
            var data = db.Warehouses.Count();
            lb_KqSoKhoHang.Text = data.ToString();
        }
        void CountOrder()
        {
            var data = db.Order.Count();
            lb_KqSoDonHang.Text = data.ToString();
        }

        void CountCategories()
        {
            var data = db.Categories.Count();
            lb_SoLoaiSanPham.Text = data.ToString();

        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            CountEmployess();
            CountWarehouses();
            CountOrder();
            CountCategories();
        }
    }
}
