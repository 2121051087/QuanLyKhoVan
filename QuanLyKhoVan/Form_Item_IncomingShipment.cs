using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhoVan
{
    public partial class Form_Item_IncomingShipment : Form
    {
        // Sự kiện được kích hoạt khi giá trị ThanhTien thay đổi
        public event EventHandler ThanhTienChanged; 


        // Hàm khởi tạo cho lớp Form_Item_IncomingShipment
        public Form_Item_IncomingShipment(int shipmentId)
        {
            InitializeComponent();
            lb_KQ_IDPhieuNhap.Text = shipmentId.ToString();
            LoadData();
        }
        // Đối tượng kết nối tới cơ sở dữ liệu QuanLyKhoVan
        QuanLyKhoVan db = new QuanLyKhoVan();

        public decimal ThanhTien => GetThanhTien();  // Thuộc tính tính toán ThanhTien

        // Phương thức tải dữ liệu vào form
        public void LoadData()
        {
            int shipmentId = int.Parse(lb_KQ_IDPhieuNhap.Text);
            var shipment = db.Incoming_Shipments.FirstOrDefault(s => s.Shipment_ID == shipmentId);

            if (shipment != null)
            {
                lb_KQTime.Text = shipment.NgayNhapHang?.ToString("dd/MM/yyyy") ?? "N/A";

                var supplierName = db.Suppliers
                    .Where(s => s.Supplier_ID == shipment.Supplier_ID)
                    .Select(s => s.TenNhaCungCap)
                    .FirstOrDefault() ?? "N/A";

                lb_TenNCC.Text = supplierName;

                var warehouseName = db.Warehouses
                    .Where(s => s.Warehouse_ID == shipment.Warehouse_ID)
                    .Select(s => s.TenKho)
                    .FirstOrDefault() ?? "N/A";

                lb_TenKho.Text = warehouseName;

                var Tien = db.Incoming_Shipment_Detail
                    .Where(s => s.Shipment_ID == shipmentId)
                    .Select(s => s.ThanhTien)
                    .FirstOrDefault();
                lb_TienTraNCC.Text = Tien.ToString();
            }
                
        }

        // Phương thức tính tổng giá trị ThanhTien cho một lô hà
        private decimal GetThanhTien()
        {
            int shipmentId = int.Parse(lb_KQ_IDPhieuNhap.Text);
            var total = db.Incoming_Shipment_Detail
                .Where(s => s.Shipment_ID == shipmentId)
                .Sum(s => s.ThanhTien) ?? 0;
            
            return total;
          
        }

       
    }
}
