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
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
            
        }

        #region Xu li UI

        private void txt_ProductID_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = Color.White;
            panel_ProductID.BackColor = Color.White;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;  
           
        }

        private void txt_TenSanPham_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = Color.White;
            panel_TenSanPham.BackColor = Color.White;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_Mota_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = Color.White;
            panel_MoTa.BackColor = Color.White;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_Gia_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = Color.White;
            panel_Gia.BackColor = Color.White;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_SoLuong_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = Color.White;
            panel_SoLuong.BackColor = Color.White;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_CategoryID_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = Color.White;
            panel_CategoryID.BackColor = Color.White;
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method
        
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
            
        }
        void AddProduct()
        {
            if(txt_ProductID.Text == "" || txt_TenSanPham.Text == "" || txt_Mota.Text == "" || txt_Gia.Text == "" || txt_SoLuong.Text == "" || txt_CategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Products product = new Products();
                product.Product_ID = int.Parse(txt_ProductID.Text);
                product.TenSanPham = txt_TenSanPham.Text;
                product.MoTa = txt_Mota.Text;
                product.Gia = txt_Gia.Text;
                product.SoLuong = txt_SoLuong.Text;
                product.Category_ID = int.Parse(txt_CategoryID.Text);
                db.Products.Add(product);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }   
        }
        void UpdateProduct()
        {
            if (txt_ProductID.Text == "" || txt_TenSanPham.Text == "" || txt_Mota.Text == "" || txt_Gia.Text == "" || txt_SoLuong.Text == "" || txt_CategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                int id = int.Parse(txt_ProductID.Text);
                Products product = db.Products.Where(s => s.Product_ID == id).FirstOrDefault();
                product.TenSanPham = txt_TenSanPham.Text;
                product.MoTa = txt_Mota.Text;
                product.Gia = txt_Gia.Text;
                product.SoLuong = txt_SoLuong.Text;
                product.Category_ID = int.Parse(txt_CategoryID.Text);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }
        }   

        void DeleteProduct ()
        {
            if (txt_ProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                int id = int.Parse(txt_ProductID.Text);
                Products product = db.Products.Where(s => s.Product_ID == id).FirstOrDefault();
                db.Products.Remove(product);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }
        }
        void ClearTextBox()
        {
            txt_CategoryID.Text = "";
            txt_Gia.Text = "";
            txt_Mota.Text = "";
            txt_SoLuong.Text = "";
            txt_TenSanPham.Text = "";
            txt_ProductID.Text = "";
               
        }
        #endregion



        private void Form_Products_Load(object sender, EventArgs e)
        {
            LoadDataProduct();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct();
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm sản phẩm thất bại " + ex);
            }
            
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
            }
            else
            {
                try
                {
                    UpdateProduct();
                    MessageBox.Show("Sửa sản phẩm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa sản phẩm thất bại " + ex);
                }
             
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProduct();
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa sản phẩm thất bại " + ex);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenSanPham.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Mota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_CategoryID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
