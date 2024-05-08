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
    public partial class Form_Shipment : Form
    {
        public Form_Shipment()
        {
            InitializeComponent();
        }
        #region Xu ly UI

        private void txt_ShipmentID_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.BackColor = Color.White;
            panel_ShipmentID.BackColor = Color.White;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_NgayGiaoHang.BackColor = SystemColors.Control;
            panel_NgayGiaoHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_Status.BackColor = SystemColors.Control;

        }

        private void txt_Order_ID_Click(object sender, EventArgs e)
        {
            txt_Order_ID.BackColor = Color.White;
            panel_Order_ID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_NgayGiaoHang.BackColor = SystemColors.Control;
            panel_NgayGiaoHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_Status.BackColor = SystemColors.Control;

        }

        private void txt_EmployeeID_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.BackColor = Color.White;
            panel_EmployeeID.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_NgayGiaoHang.BackColor = SystemColors.Control;
            panel_NgayGiaoHang.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_Status.BackColor = SystemColors.Control;
                
        }

        private void txt_NgayGiaoHang_Click(object sender, EventArgs e)
        {
            txt_NgayGiaoHang.BackColor = Color.White;
            panel_NgayGiaoHang.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_Status.BackColor = SystemColors.Control;

        }

        private void txt_status_Click(object sender, EventArgs e)
        {
            txt_status.BackColor = Color.White;
            panel_Status.BackColor = Color.White;
            txt_ShipmentID.BackColor = SystemColors.Control;
            panel_ShipmentID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_NgayGiaoHang.BackColor = SystemColors.Control;
            panel_NgayGiaoHang.BackColor = SystemColors.Control;

        }
        #endregion 

         QuanLyKhoVan   db = new QuanLyKhoVan();

        #region Method 
        void ClearTextBox()
        {
            txt_NgayGiaoHang.Text = "";
            txt_ShipmentID.Text = "";
            txt_EmployeeID.Text = "";
            txt_Order_ID.Text = "";
            txt_status.Text = "";
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
        }
        void AddShipment()
        {
            if (txt_ShipmentID.Text == "" || txt_Order_ID.Text == "" || txt_EmployeeID.Text == "" || txt_NgayGiaoHang.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                Shipments shipment = new Shipments();
                shipment.Shipment_ID = int.Parse(txt_ShipmentID.Text);
                shipment.Order_ID = int.Parse(txt_Order_ID.Text);
                shipment.Employee_ID = int.Parse(txt_EmployeeID.Text);
                shipment.NgayGiao = DateTime.Parse(txt_NgayGiaoHang.Text);
                shipment.status = txt_status.Text;
                db.Shipments.Add(shipment);
                db.SaveChanges();
                LoadDataShipment();
                ClearTextBox();
            }

        }
        void UpdateShipment()
        {
            if (txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần sửa");
            }
            else
            {
                int id = int.Parse(txt_ShipmentID.Text);
                Shipments shipment = db.Shipments.Where(s => s.Shipment_ID == id).FirstOrDefault();
                shipment.Order_ID = int.Parse(txt_Order_ID.Text);
                shipment.Employee_ID = int.Parse(txt_EmployeeID.Text);
                shipment.NgayGiao = DateTime.Parse(txt_NgayGiaoHang.Text);
                shipment.status = txt_status.Text;
                db.SaveChanges();
                LoadDataShipment();
                ClearTextBox();
            }
        }
        void DeleteShipment()
        {
            if (txt_ShipmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa");
            }
            else
            {
                int id = int.Parse(txt_ShipmentID.Text);
                Shipments shipment = db.Shipments.Where(s => s.Shipment_ID == id).FirstOrDefault();
                db.Shipments.Remove(shipment);
                db.SaveChanges();
                LoadDataShipment();
                ClearTextBox();
            }
        }
        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                AddShipment();
                MessageBox.Show("Thêm  thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateShipment();
                MessageBox.Show("Cập nhật thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteShipment();
                MessageBox.Show("Xóa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa thất bại" + ex);
            }
        }

        private void Form_Shipment_Load(object sender, EventArgs e)
        {
            LoadDataShipment();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ShipmentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Order_ID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_EmployeeID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_NgayGiaoHang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
