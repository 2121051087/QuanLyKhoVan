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
    public partial class Form_InventoryChecks : Form
    {
        public Form_InventoryChecks()
        {
            InitializeComponent();
        }
        #region Xu li UI

        private void txt_CheckID_Click(object sender, EventArgs e)
        {
            txt_CheckID.BackColor = Color.White;
            panel_CheckID.BackColor = Color.White;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayKiemKe.BackColor = SystemColors.Control;
            panel_NgayKiemKe.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;
        }

        private void txt_WarehouseID_Click(object sender, EventArgs e)
        {
            txt_CheckID.BackColor = SystemColors.Control;
            panel_CheckID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = Color.White;
            panel_WarehouseID.BackColor = Color.White;
            txt_NgayKiemKe.BackColor = SystemColors.Control;
            panel_NgayKiemKe.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;

        }

        private void txt_NgayKiemKe_Click(object sender, EventArgs e)
        {
            txt_CheckID.BackColor = SystemColors.Control;
            panel_CheckID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayKiemKe.BackColor = Color.White;
            panel_NgayKiemKe.BackColor = Color.White;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;

        }
        private void txt_EmployeeID_Click(object sender, EventArgs e)
        {
            txt_CheckID.BackColor = SystemColors.Control;
            panel_CheckID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayKiemKe.BackColor = SystemColors.Control;
            panel_NgayKiemKe.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = Color.White;
            panel_EmployeeID.BackColor = Color.White;
            txt_status.BackColor = SystemColors.Control;
            panel_status.BackColor = SystemColors.Control;

        }

        private void txt_status_Click(object sender, EventArgs e)
        {
            txt_CheckID.BackColor = SystemColors.Control;
            panel_CheckID.BackColor = SystemColors.Control;
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_NgayKiemKe.BackColor = SystemColors.Control;
            panel_NgayKiemKe.BackColor = SystemColors.Control;
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_status.BackColor = Color.White;
            panel_status.BackColor = Color.White;

        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method
        void ClearTextBox()
        {
            txt_CheckID.Text = "";
            txt_WarehouseID.Text = "";
            txt_NgayKiemKe.Text = "";
            txt_EmployeeID.Text = "";
            txt_status.Text = "";
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
        }   
        void AddInventoryChecks()
        {
            Inventory_Checks inventory_Checks = new Inventory_Checks();
            inventory_Checks.Check_ID = int.Parse(txt_CheckID.Text);
            inventory_Checks.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            inventory_Checks.NgayKiemKe = DateTime.Parse(txt_NgayKiemKe.Text);
            inventory_Checks.Employee_ID = int.Parse(txt_EmployeeID.Text);
            inventory_Checks.status = txt_status.Text;
            db.Inventory_Checks.Add(inventory_Checks);
            db.SaveChanges();
            LoadDataInventoryChecks();
            ClearTextBox();
        }
        void UpdateInventoryChecks()
        {
            Inventory_Checks inventory_Checks = db.Inventory_Checks.Find(int.Parse(txt_CheckID.Text));
            inventory_Checks.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            inventory_Checks.NgayKiemKe = DateTime.Parse(txt_NgayKiemKe.Text);
            inventory_Checks.Employee_ID = int.Parse(txt_EmployeeID.Text);
            inventory_Checks.status = txt_status.Text;
            db.SaveChanges();
            LoadDataInventoryChecks();
            ClearTextBox();
        }

        void DeleteInventoryChecks()
        {
            Inventory_Checks inventory_Checks = db.Inventory_Checks.Find(int.Parse(txt_CheckID.Text));
            db.Inventory_Checks.Remove(inventory_Checks);
            db.SaveChanges();
            LoadDataInventoryChecks();
            ClearTextBox();
        }
        #endregion
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_CheckID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_WarehouseID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_NgayKiemKe.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_EmployeeID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_CheckID.Text == "" || txt_WarehouseID.Text == "" || txt_NgayKiemKe.Text == "" || txt_EmployeeID.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
               try
                {
                    AddInventoryChecks();
                    MessageBox.Show("thêm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại " + ex.Message);

                }
               
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_CheckID.Text == "") { 
                MessageBox.Show("Vui lòng chọn Check ID cần cập nhật");
            
            }
            else
            {
                try
                {
                    UpdateInventoryChecks();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cập nhật không thành công : " + ex.Message);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_CheckID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Check ID cần xóa");
            }
            else
            {
                try
                {
                    DeleteInventoryChecks();
                    MessageBox.Show("Xóa thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa không thành công : " + ex.Message);
                }
                
            }
        }

        private void Form_InventoryChecks_Load(object sender, EventArgs e)
        {
            LoadDataInventoryChecks();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
    }
}
