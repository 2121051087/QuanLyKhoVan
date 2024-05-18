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
            loadComboboxShipmentID();
           
        }

        QuanLyKhoVan db = new QuanLyKhoVan();
        #region Method 
        void loadComboboxShipmentID()
        {
            var shipmentID = (from s in db.Incoming_Shipments
                              select s.Shipment_ID).ToList();
            comboBox_ShipmentID.DataSource = shipmentID;


        }
        void loadDetailID()
        {
            int selectedShipmentId = int.Parse(comboBox_ShipmentID.SelectedItem.ToString());

            int detailID = selectedShipmentId + 11;

            lb_kqDetail_ID.Text = detailID.ToString();
        }

        #endregion

        private void comboBox_ShipmentID_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedShipmentId = int.Parse(comboBox_ShipmentID.SelectedItem.ToString());


            var shipment = (from p in db.Incoming_Shipments
                            where p.Shipment_ID == selectedShipmentId
                            select new
                            {
                                p.Shipment_ID,
                                p.Warehouse_ID,
                                p.Supplier_ID,
                                p.NgayNhapHang

                            }).ToList();

            dataGridView1.DataSource = shipment;

            loadDetailID();
            // Xóa tất cả các Form_itemShipmentDetail hiện tại từ panel_DanhSach
            foreach (Control control in panel_DanhSach.Controls.OfType<Form_itemShipmentDetail>().ToList())
            {
                panel_DanhSach.Controls.Remove(control);
                control.Dispose();
            }
        }
        


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

        void AddDetail()
        {
            

            var matHangIds = panel_DanhSach.Controls.OfType<Form_itemShipmentDetail>()
           .Select(item => item.GetMatHangId())
           .Distinct()
           .Count();
            Incoming_Shipment_Detail data = new Incoming_Shipment_Detail();

             data.Detail_ID = int.Parse(lb_kqDetail_ID.Text);
             data.Shipment_ID = int.Parse(comboBox_ShipmentID.Text);
             data.SoMatHangNhap = matHangIds;
             data.TongTIenHang = int.Parse(lb_TongTienHang.Text);

            db.Incoming_Shipment_Detail.Add(data);
            db.SaveChanges();



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
                UpdateProductQuantity();
                MessageBox.Show("Lưu thông tin thành công ");

            }
            catch
            {
                MessageBox.Show("Lỗi tại thông tin chi tiết");
                return;
            }
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
    }
}
