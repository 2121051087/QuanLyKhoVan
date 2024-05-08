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
            txt_NgayNhapHang.BackColor = SystemColors.Control;
            panel_NgayNhapHang.BackColor = SystemColors.Control;
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
            txt_NgayNhapHang.BackColor = SystemColors.Control;
            panel_NgayNhapHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
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
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();
        #region Method

        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_WarehouseID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SupplierID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_NgayNhapHang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
