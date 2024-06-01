using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhoVan
{
    public partial class Form_Incoming_Shipment_Detail : Form
    {
        public Form_Incoming_Shipment_Detail()
        {
            InitializeComponent();
         
            lb_time.Text = DateTime.Now.ToString("dd/MM/yyyy");
            loadComboBoxWareName();
            loadComboboxSupplierName();
            btn_Them.Enabled = false;
            btn_Them.BackColor = SystemColors.Control;

        }

        QuanLyKhoVan db = new QuanLyKhoVan();

       
        #region  #region Method loadComboBox 

        void loadComboBoxWareName()
        {
            var warehouseName = (from w in db.Warehouses
                                 select w.TenKho).ToList();
            comboBox_Kho.DataSource = warehouseName;
        }
        void loadComboboxSupplierName ()
        {
            var supplierName = (from s in db.Suppliers
                                select s.TenNhaCungCap).ToList();
            comboBox_NCC.DataSource = supplierName;


        }

        #endregion



        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form_itemShipmentDetail item = new Form_itemShipmentDetail();
            item.TopLevel = false;
            item.RequestRemove += Item_RequestRemove;
            item.SoLuongChanged += UpdateTongTienHang;

            panel_DanhSach.Controls.Add(item);
            item.Show();
        }

        private void Item_RequestRemove(Form_itemShipmentDetail item)
        {
            panel_DanhSach.Controls.Remove(item);
            item.Dispose();
        }
        private void UpdateTongTienHang()
        {
            decimal tongTienHang = 0;

            foreach (Control control in panel_DanhSach.Controls)
            {
                if (control is Form_itemShipmentDetail item)
                {
                    tongTienHang += item.GetThanhTien();
                }
            }

            lb_TongTienHang.Text = tongTienHang.ToString();
        }
        public event Action SaveButtonClicked;

        void AddDetail()
        {


            var matHangIds = panel_DanhSach.Controls.OfType<Form_itemShipmentDetail>()
           .Select(item => item.GetMatHangId())
           .Distinct()
           .Count();
            
            Incoming_Shipments dataInComingShipments = new Incoming_Shipments();

            dataInComingShipments.Shipment_ID = int.Parse(txt_Shipment_ID.Text);

            var warehouse = db.Warehouses.SingleOrDefault(w => w.TenKho == comboBox_Kho.Text);
            if (warehouse != null)
            {
                dataInComingShipments.Warehouse_ID = warehouse.Warehouse_ID;

            }
            var supplier = db.Suppliers.SingleOrDefault(s => s.TenNhaCungCap == comboBox_NCC.Text);
            if (supplier != null)
            {
                dataInComingShipments.Supplier_ID = supplier.Supplier_ID;
            }
            dataInComingShipments.NgayNhapHang = DateTime.Now;
            dataInComingShipments.TongTienHang = int.Parse(lb_TongTienHang.Text);
            db.Incoming_Shipments.Add(dataInComingShipments);


            //  data.Detail_ID = int.Parse(lb_kqDetail_ID.Text);
            //  data.Shipment_ID = int.Parse(comboBox_ShipmentID.Text);
            dataInComingShipments.SoMatHangNhap = matHangIds;
            //  data.TongTIenHang = int.Parse(lb_TongTienHang.Text);
           
            db.Incoming_Shipments.Add(dataInComingShipments);
            db.SaveChanges();



        }


        public int GetShipmentID()
        {
            return int.Parse(txt_Shipment_ID.Text);
        }
        private void UpdateProductQuantity()
        {
          
            
                foreach (Control control in panel_DanhSach.Controls)
                {
                    if (control is Form_itemShipmentDetail item)
                    {
                      int productId = item.GetProductID();
                      int soLuong = int.Parse(item.GetSoLuong().ToString());

                        var product = db.Products.SingleOrDefault(p => p.Product_ID == productId);
                        if (product != null)
                        {
                            product.SoLuong += soLuong;
                        }
                    }
                }

                db.SaveChanges();
            
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                AddDetail();

                // Lặp qua các Form_itemShipmentDetail trong panel và gọi AddItemDetail cho từng item
                foreach (Control control in panel_DanhSach.Controls)
                {
                    if (control is Form_itemShipmentDetail itemDetailForm)
                    {
                        AddItemDetail(itemDetailForm); // Truyền đối tượng itemDetailForm vào đây
                    }
                }

                UpdateProductQuantity();
                MessageBox.Show("Lưu thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại thông tin chi tiết: " + ex.Message); // Hiển thị thông báo lỗi chi tiết
            }
        }

        void AddItemDetail(Form_itemShipmentDetail itemDetailForm)
        {
            Incoming_Shipment_Detail detail = new Incoming_Shipment_Detail();
            detail.Detail_ID = itemDetailForm.GetDetailID();
            detail.Product_ID = itemDetailForm.GetProductId();
            detail.SoLuong = itemDetailForm.GetSoLuong();
            detail.ThanhTien = itemDetailForm.GetThanhTien();
            detail.Shipment_ID = GetShipmentID(); // Lấy Shipment_ID từ form hiện tại

            db.Incoming_Shipment_Detail.Add(detail);
            db.SaveChanges();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            UpdateTongTienHang();
            // Xóa tất cả các Form_itemShipmentDetail hiện tại từ panel_DanhSach
            foreach (Control control in panel_DanhSach.Controls.OfType<Form_itemShipmentDetail>().ToList())
            {
                panel_DanhSach.Controls.Remove(control);
                control.Dispose();
            }
            
        }
        void UpdateTimeNow()
        {
            lb_time.Text = DateTime.Now.ToString("dd/MM/yyyy");
            

        }

        void ActivateButtonAdd()
        {
            if (txt_Shipment_ID != null && comboBox_Kho != null && comboBox_NCC != null)
            {
                btn_Them.Enabled = true;
                btn_Them.BackColor = Color.FromArgb(78, 189, 74);
            }
        }

        private void txt_Shipment_ID_TextChanged(object sender, EventArgs e)
        {
            ActivateButtonAdd();
        }

        private void txt_Shipment_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Incoming_Shipment form_Partner = new Form_Incoming_Shipment();
            form_Partner.ShowDialog();
           
            this.Show();

            form_Partner.FormClosed += (s, args) => this.Show();
        }
    }
}
