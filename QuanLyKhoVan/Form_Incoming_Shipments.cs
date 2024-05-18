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
    public partial class Form_Incoming_Shipments : Form
    {
        public Form_Incoming_Shipments()
        {
            InitializeComponent();
        }

        private void Form_Incoming_Shipments_Load(object sender, EventArgs e)
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
            txt_NgayNhapHang.BackColor = SystemColors.Control;
            panel_NgayNhapHang.BackColor = SystemColors.Control;
          

        }

        private void txt_WarehouseID_Click(object sender, EventArgs e)
        {
            txt_WarehouseID.BackColor = Color.White;
            panel_WarehouseID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_NgayNhapHang.BackColor = SystemColors.Control;
            panel_NgayNhapHang.BackColor = SystemColors.Control;
           
                

        }

        private void txt_SupplierID_Click(object sender, EventArgs e)
        {
            txt_SupplierID.BackColor = Color.White;
            panel_SupplierID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayNhapHang.BackColor = SystemColors.Control;
            panel_NgayNhapHang.BackColor = SystemColors.Control;
       
        }

        private void txt_NgayNhapHang_Click(object sender, EventArgs e)
        {
            txt_NgayNhapHang.BackColor = Color.White;
            panel_NgayNhapHang.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
         
        }

       
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();
        #region Method

        void ClearTextBox()
        {
            txt_NgayNhapHang.Text = "";
            txt_ShipmentID.Text = "";
            txt_WarehouseID.Text = "";
            txt_SupplierID.Text = "";
         
        }
        void LoadData()
        {
            var data = from p in db.Incoming_Shipments
                       select new
                       {
                           ShipmentID = p.Shipment_ID,
                           WarehouseID = p.Warehouse_ID,
                           SupplierID = p.Supplier_ID,
                           NgayNhapHang = p.NgayNhapHang,
                         
                       };
            dataGridView1.DataSource = data.ToList();
        }

        void AddIncoming_Shipments()
        {
            Incoming_Shipments incoming_Shipments = new Incoming_Shipments();
            incoming_Shipments.Shipment_ID = int.Parse(txt_ShipmentID.Text);
            incoming_Shipments.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            incoming_Shipments.Supplier_ID = int.Parse(txt_SupplierID.Text);
            incoming_Shipments.NgayNhapHang = DateTime.Parse(txt_NgayNhapHang.Text);
        
            db.Incoming_Shipments.Add(incoming_Shipments);
            db.SaveChanges();
            LoadData();
            ClearTextBox();
        }

        void UpdateIncoming_Shipments()
        {
            int id = int.Parse(txt_ShipmentID.Text);
            Incoming_Shipments incoming_Shipments = db.Incoming_Shipments.Where(p => p.Shipment_ID == id).FirstOrDefault();
            incoming_Shipments.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            incoming_Shipments.Supplier_ID = int.Parse(txt_SupplierID.Text);
            incoming_Shipments.NgayNhapHang = DateTime.Parse(txt_NgayNhapHang.Text);
          
            db.SaveChanges();
            LoadData();
            ClearTextBox();
        }

        void DeleteIncoming_Shipments()
        {
            int id = int.Parse(txt_ShipmentID.Text);
            Incoming_Shipments incoming_Shipments = db.Incoming_Shipments.Where(p => p.Shipment_ID == id).FirstOrDefault();
            db.Incoming_Shipments.Remove(incoming_Shipments);
            db.SaveChanges();
            LoadData();
            ClearTextBox();
        }
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_WarehouseID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SupplierID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_NgayNhapHang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_NgayNhapHang.Text == "" || txt_ShipmentID.Text == "" || txt_WarehouseID.Text == "" || txt_SupplierID.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {

                    AddIncoming_Shipments();
                    MessageBox.Show("Thêm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập hàng cần sửa");
            }
            else
            {
                try
                {
                    UpdateIncoming_Shipments();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại" + ex);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập hàng cần xóa");
            }
            else
            {
                try
                {
                    DeleteIncoming_Shipments();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại" + ex);
                }
            }
        }

        private void btn_ChiTietNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Incoming_Shipment_Detail form_Incoming_Shipment_Detail = new Form_Incoming_Shipment_Detail();
            form_Incoming_Shipment_Detail.ShowDialog();

            this.Show();
            form_Incoming_Shipment_Detail.FormClosed += (s,args) => this.Show();

        }
    }
}
