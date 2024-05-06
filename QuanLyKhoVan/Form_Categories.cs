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
    public partial class Form_Categories : Form
    {
        public Form_Categories()
        {
            InitializeComponent();
          
        }
        #region Xu ly UI
        private void txt_CategoryID_Click(object sender, EventArgs e)
        {
            txt_CategoryID.BackColor = Color.White;
            panel_Category_ID.BackColor = Color.White;
            txt_TenDanhMuc.BackColor = SystemColors.Control;
            panel_TenDanhMuc.BackColor = SystemColors.Control;
        }

        private void txt_TenDanhMuc_Click(object sender, EventArgs e)
        {
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_Category_ID.BackColor = SystemColors.Control;
            txt_TenDanhMuc.BackColor = Color.White;
            panel_TenDanhMuc.BackColor = Color.White;
        }
        #endregion

        QuanLyKhoVan db  = new QuanLyKhoVan(); // tao doi tuong db

        #region Method 
        

        void LoadDataCategory()
        {
            var data = db.Categories.Select(s => new
            {
                CategoryID = s.Category_ID,
                TenDanhMuc = s.TenDanhMuc
            }).ToList();
            dataGridView1.DataSource = data;
        }
        
        void AddCategory()
        {
         if (txt_CategoryID.Text == "" || txt_TenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin ");
            }
            else
            {
                Categories category = new Categories();
                category.TenDanhMuc = txt_TenDanhMuc.Text;
                category.Category_ID = int.Parse(txt_CategoryID.Text);
                db.Categories.Add(category);
                db.SaveChanges();
                LoadDataCategory();
                ClearTextBox();
            }
        }   

        void UpdateCategory()
        {
         if (txt_CategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Danh mục cần sửa");
            }
            else
            {
                int id = int.Parse(txt_CategoryID.Text);
                Categories category = db.Categories.Where(s => s.Category_ID == id).FirstOrDefault();
                category.TenDanhMuc = txt_TenDanhMuc.Text;
                db.SaveChanges();
                LoadDataCategory();
                ClearTextBox();
            }
        }

        void DeleteCategory()
        {
            if (txt_CategoryID.Text == "")
            {
                    MessageBox.Show("Vui lòng chọn Danh mục cần xóa");
                }
                else
            {
                    int id = int.Parse(txt_CategoryID.Text);
                    Categories category = db.Categories.Where(s => s.Category_ID == id).FirstOrDefault();
                    db.Categories.Remove(category);
                    db.SaveChanges();
                    LoadDataCategory();
                    ClearTextBox();
                }
        }

        void ClearTextBox ()
        {
            txt_CategoryID.Text = "";
            txt_TenDanhMuc.Text = "";
        }

        #endregion
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txt_CategoryID.Text, out int result) == false)
            {
                MessageBox.Show("Danh mục ID phải là số nguyên");
                return;
            }

            try
            {
                AddCategory();
                MessageBox.Show("Thêm danh mục thành công ");

            }catch(Exception ex)
            {
                MessageBox.Show("Thêm danh mục thất bại " + ex.Message);
            }
           

        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCategory();
                MessageBox.Show("Cập nhật danh mục thành công ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật danh mục thất bại " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteCategory();
                MessageBox.Show("Xóa danh mục thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa danh mục thất bại " + ex.Message);
            }
        }

        private void Form_Categories_Load(object sender, EventArgs e)
        {
            LoadDataCategory();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_CategoryID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenDanhMuc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
