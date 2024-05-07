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
    public partial class Form_OrderDetails : Form
    {
        public Form_OrderDetails()
        {
            InitializeComponent();
            
        }
        #region Xu li UI
        private void txt_OrderDetail_ID_Click(object sender, EventArgs e)
        {
            txt_OrderDetail_ID.BackColor = Color.White;
            panel_OrderDetail_ID.BackColor = Color.White;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_SoLuongSanPham.BackColor = SystemColors.Control;
        }

        private void txt_Order_ID_Click(object sender, EventArgs e)
        {
            txt_Order_ID.BackColor = Color.White;
            panel_Order_ID.BackColor = Color.White;
            txt_OrderDetail_ID.BackColor = SystemColors.Control;
            panel_OrderDetail_ID.BackColor = SystemColors.Control;
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_SoLuongSanPham.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
        }

        private void txt_ProductID_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = Color.White;
            panel_ProductID.BackColor = Color.White;
            txt_OrderDetail_ID.BackColor = SystemColors.Control;
            panel_OrderDetail_ID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_SoLuongSanPham.BackColor = SystemColors.Control;
            panel_SoLuongSanPham.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
                
        }

        private void txt_SoLuongSanPham_Click(object sender, EventArgs e)
        {
            txt_SoLuongSanPham.BackColor = Color.White;
            panel_SoLuongSanPham.BackColor = Color.White;
            txt_OrderDetail_ID.BackColor = SystemColors.Control;
            panel_OrderDetail_ID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;

        }

        private void txt_Gia_Click(object sender, EventArgs e)
        {
            txt_Gia.BackColor = Color.White;
            panel_Gia.BackColor = Color.White;
            txt_OrderDetail_ID.BackColor = SystemColors.Control; 
            panel_OrderDetail_ID.BackColor = SystemColors.Control;
            txt_Order_ID.BackColor = SystemColors.Control;
            panel_Order_ID.BackColor = SystemColors.Control;               
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;               
            txt_SoLuongSanPham.BackColor = SystemColors.Control;
            panel_SoLuongSanPham.BackColor = SystemColors.Control;

        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();


        #region Method 

        void LoadDataOrderDetails()
        {
            var data = db.Order_Details.Select(s => new
            {
                Order_Detail_ID = s.Order_Detail_ID,
                Order_ID =  s.Order_ID,
                Product_ID = s.Product_ID,
                SoLuongSanPham = s.SoLuongSanPham,
                Gia = s.Gia
            }).ToList();    
            dataGridView1.DataSource = data;
        }
        void ClearTextBox()
        {
            txt_OrderDetail_ID.Text = "";
            txt_Order_ID.Text = "";
            txt_ProductID.Text = "";
            txt_SoLuongSanPham.Text = "";
            txt_Gia.Text = "";
        }
        void AddOrderDetails()
        {
            if (txt_OrderDetail_ID.Text == "" || txt_Order_ID.Text == "" || txt_ProductID.Text == "" || txt_SoLuongSanPham.Text == "" || txt_Gia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Order_Details order_Detail = new Order_Details();
                order_Detail.Order_Detail_ID = int.Parse(txt_OrderDetail_ID.Text);
                order_Detail.Order_ID = int.Parse(txt_Order_ID.Text);
                order_Detail.Product_ID = int.Parse(txt_ProductID.Text);
                order_Detail.SoLuongSanPham = int.Parse(txt_SoLuongSanPham.Text);
                order_Detail.Gia = int.Parse(txt_Gia.Text);
                db.Order_Details.Add(order_Detail);
                db.SaveChanges();
                LoadDataOrderDetails();
                ClearTextBox();
            }
           
        }   
        void UpdateOrderDetails()
        {
            if (txt_OrderDetail_ID.Text == "" || txt_Order_ID.Text == "" || txt_ProductID.Text == "" || txt_SoLuongSanPham.Text == "" || txt_Gia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                int id = int.Parse(txt_OrderDetail_ID.Text);
                Order_Details order_Detail = db.Order_Details.Where(s => s.Order_Detail_ID == id).FirstOrDefault();
                order_Detail.Order_ID = int.Parse(txt_Order_ID.Text);
                order_Detail.Product_ID = int.Parse(txt_ProductID.Text);
                order_Detail.SoLuongSanPham = int.Parse(txt_SoLuongSanPham.Text);
                order_Detail.Gia = int.Parse(txt_Gia.Text);
                db.SaveChanges();
                LoadDataOrderDetails();
                ClearTextBox();
            }
        }
        void DeleteOrderDetails()
        {
            if (txt_OrderDetail_ID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
            else
            {
                int id = int.Parse(txt_OrderDetail_ID.Text);
                Order_Details order_Detail = db.Order_Details.Where(s => s.Order_Detail_ID == id).FirstOrDefault();
                db.Order_Details.Remove(order_Detail);
                db.SaveChanges();
                LoadDataOrderDetails();
                ClearTextBox();
            }
        }

    
        #endregion

        private void Form_OrderDetails_Load(object sender, EventArgs e)
        {
            LoadDataOrderDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_OrderDetail_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Order_ID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ProductID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_SoLuongSanPham.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                AddOrderDetails();
                MessageBox.Show("Thêm đơn hàng chi tiết thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm đơn hàng chi tiết thất bại : " + ex.Message);
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOrderDetails();
                MessageBox.Show("Cập nhật đơn hàng chi tiết thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật đơn hàng chi tiết thất bại : " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteOrderDetails();
                MessageBox.Show("Xóa đơn hàng chi tiết thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đơn hàng chi tiết thất bại : " + ex.Message);
            }
        }

    }
}
