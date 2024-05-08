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
    public partial class Form_Supplies : Form
    {
        public Form_Supplies()
        {
            InitializeComponent();
        }
        QuanLyKhoVan db = new QuanLyKhoVan();


        #region Method 

        void ClearTextBox()
        {
            txt_SupplierID.Text = "";
            txt_TenNCC.Text = "";
            txt_thongtinlienhe.Text = "";
        }
        void LoadData()
        {
            var data = from s in db.Suppliers
                       select new
                       {
                           SupplierID = s.Supplier_ID,
                           TenNCC = s.TenNhaCungCap,
                           ThongTinLienHe = s.ThongTinLienHe
                       };
            dataGridView1.DataSource = data.ToList();
        }
        void AddSupplier()
        {
            if (txt_SupplierID.Text == "" || txt_TenNCC.Text == "" || txt_thongtinlienhe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Suppliers s = new Suppliers();
                s.Supplier_ID = int.Parse(txt_SupplierID.Text);
                s.TenNhaCungCap = txt_TenNCC.Text;
                s.ThongTinLienHe = txt_thongtinlienhe.Text;
                db.Suppliers.Add(s);
                db.SaveChanges();
                LoadData();
                ClearTextBox();
            }
        }

        void UpdateSupplier()
        {
            if (txt_SupplierID.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập thông tin ID Nhà cung cấp cần cập nhật ");
            }
            else
            {
                int id = int.Parse(txt_SupplierID.Text);
                Suppliers s = db.Suppliers.Where(p => p.Supplier_ID == id).FirstOrDefault();
                s.TenNhaCungCap = txt_TenNCC.Text;
                s.ThongTinLienHe = txt_thongtinlienhe.Text;
                db.SaveChanges();
                LoadData();
                ClearTextBox();
            }
        }

        void DeleteSupplier()
        {
            if (txt_SupplierID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin ID Nhà cung cấp cần xóa ");
            }
            else
            {
                int id = int.Parse(txt_SupplierID.Text);
                Suppliers s = db.Suppliers.Where(p => p.Supplier_ID == id).FirstOrDefault();
                db.Suppliers.Remove(s);
                db.SaveChanges();
                LoadData();
                ClearTextBox();
            }
        }
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_SupplierID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_thongtinlienhe.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void Form_Supplies_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                AddSupplier();
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
                UpdateSupplier();
                MessageBox.Show("Cập nhật thành công");
            }catch(Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSupplier();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại" + ex);
            }

        }
        #region Xu li UI
        private void txt_SupplierID_Click(object sender, EventArgs e)
        {
            txt_SupplierID.BackColor = Color.White;
            panel_SupplierID.BackColor = Color.White;
            txt_TenNCC.BackColor = SystemColors.Control;
            panel_TenNCC.BackColor = SystemColors.Control;
            txt_thongtinlienhe.BackColor = SystemColors.Control;
            panel_thongtinlienhe.BackColor = SystemColors.Control;

        }

        private void txt_TenNCC_Click(object sender, EventArgs e)
        {
            txt_TenNCC.BackColor = Color.White;
            panel_TenNCC.BackColor = Color.White;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_thongtinlienhe.BackColor = SystemColors.Control;
            panel_thongtinlienhe.BackColor = SystemColors.Control;

        }

        private void txt_thongtinlienhe_Click(object sender, EventArgs e)
        {
            txt_thongtinlienhe.BackColor = Color.White;
            panel_thongtinlienhe.BackColor = Color.White;
            txt_SupplierID.BackColor = SystemColors.Control;
            panel_SupplierID.BackColor = SystemColors.Control;
            txt_TenNCC.BackColor = SystemColors.Control;
            panel_TenNCC.BackColor = SystemColors.Control;

        }
        #endregion
    }
}
