using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoVan
{
    public partial class Form_Outgoing_Shipments : Form
    {
        public Form_Outgoing_Shipments()
        {
            InitializeComponent();
        }

        private void Form_Outgoing_Shipments_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        #region Xu li UI

        private void txt_ShipmentID_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.BackColor = Color.White;
            panel_ShipmentID.BackColor = Color.White;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_NgayXuatHang.BackColor = SystemColors.Control;
            panel_NgayXuatHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
        }

        private void txt_WarehouseID_Click(object sender, EventArgs e)
        {
            txt_WarehouseID.BackColor = Color.White;
            panel_WarehouseID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_NgayXuatHang.BackColor = SystemColors.Control;
            panel_NgayXuatHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
        }

        private void txt_SupplierID_Click(object sender, EventArgs e)
        {
            txt_SupplierID.BackColor = Color.White;
            panel_SupplierID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayXuatHang.BackColor = SystemColors.Control;
            panel_NgayXuatHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
        }

        private void txt_NgayXuatHang_Click(object sender, EventArgs e)
        {
            txt_NgayXuatHang.BackColor = Color.White;
            panel_NgayXuatHang.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
        }
        private void txt_status_Click(object sender, EventArgs e)
        {
            txt_status.BackColor = Color.White;
            panel_status.BackColor = Color.White;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_NgayXuatHang.BackColor = SystemColors.Control;
            panel_NgayXuatHang.BackColor = SystemColors.Control;
        }

        #endregion


        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method
        void ClearTextBox()
        {
            txt_ShipmentID.Text = "";
            txt_WarehouseID.Text = "";
            txt_SupplierID.Text = "";
            txt_NgayXuatHang.Text = "";
            txt_status.Text = "";

        }
        void LoadData()
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
        }

        void AddOutgoing_Shipments()
        {
            Outgoing_Shipments outgoing_Shipments = new Outgoing_Shipments();
            outgoing_Shipments.Shipment_ID = int.Parse(txt_ShipmentID.Text);
            outgoing_Shipments.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            outgoing_Shipments.Supplier_ID = int.Parse(txt_SupplierID.Text);
            outgoing_Shipments.NgayXuatHang = DateTime.Parse(txt_NgayXuatHang.Text);
            outgoing_Shipments.status = txt_status.Text;
            db.Outgoing_Shipments.Add(outgoing_Shipments);
            db.SaveChanges();
            LoadData();
            ClearTextBox();
               
        }
        void UpdateOutgoing_Shipments()
        {
            int id = int.Parse(txt_ShipmentID.Text);
            Outgoing_Shipments outgoing_Shipments = db.Outgoing_Shipments.Where(p => p.Shipment_ID == id).FirstOrDefault();
            outgoing_Shipments.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            outgoing_Shipments.Supplier_ID = int.Parse(txt_SupplierID.Text);
            outgoing_Shipments.NgayXuatHang = DateTime.Parse(txt_NgayXuatHang.Text);
            outgoing_Shipments.status = txt_status.Text;
            db.SaveChanges();
            LoadData();
            ClearTextBox();
        }

        void DeleteOutgoing_Shipments()
        {
            int id = int.Parse(txt_ShipmentID.Text);
            Outgoing_Shipments outgoing_Shipments = db.Outgoing_Shipments.Where(p => p.Shipment_ID == id).FirstOrDefault();
            db.Outgoing_Shipments.Remove(outgoing_Shipments);
            db.SaveChanges();
            LoadData();
            ClearTextBox();
        }


        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_ShipmentID.Text == "" || txt_WarehouseID.Text == "" || txt_SupplierID.Text == "" || txt_NgayXuatHang.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    AddOutgoing_Shipments();
                    MessageBox.Show("Thêm thành công ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex);
                }
                
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật");
            }
            else
            {
                try
                {
                    UpdateOutgoing_Shipments();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại" + ex);
                }
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa");
            }
            else
            {
                try
                {
                    DeleteOutgoing_Shipments();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại" + ex);
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_WarehouseID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SupplierID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_NgayXuatHang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }
    }
}
