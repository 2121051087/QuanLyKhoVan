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
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
          
        }
        #region Xu li UI
        private void txt_OrderID_Click(object sender, EventArgs e)
        {
            txt_OrderID.BackColor = Color.White;
            panel_OrderID.BackColor = Color.White;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_NgayDatHang.BackColor = SystemColors.Control;
            panel_NgayDatHang.BackColor = SystemColors.Control;
            txt_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            panel_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;


        }

        private void txt_CustomerID_Click(object sender, EventArgs e)
        {
            txt_OrderID.BackColor = SystemColors.Control;
            panel_OrderID.BackColor = SystemColors.Control;
            txt_CustomerID.BackColor = Color.White;
            panel_CustomerID.BackColor =    Color.White;
            txt_NgayDatHang.BackColor = SystemColors.Control;
            panel_NgayDatHang.BackColor = SystemColors.Control;
            txt_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            panel_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
        }

        private void txt_NgayDatHang_Click(object sender, EventArgs e)
        {
            txt_OrderID.BackColor = SystemColors.Control;
            panel_OrderID.BackColor = SystemColors.Control;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_NgayDatHang.BackColor = Color.White;
            panel_NgayDatHang.BackColor = Color.White;
            txt_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            panel_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
        }

        private void txt_TongSoTienGiaoHang_Click(object sender, EventArgs e)
        {
            txt_OrderID.BackColor = SystemColors.Control;
            panel_OrderID.BackColor = SystemColors.Control;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_NgayDatHang.BackColor = SystemColors.Control;
            panel_NgayDatHang.BackColor = SystemColors.Control;
            txt_TongSoTienGiaoHang.BackColor = Color.White;
            panel_TongSoTienGiaoHang.BackColor = Color.White;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
        }

        private void txt_DiaChi_Click(object sender, EventArgs e)
        {
            txt_OrderID.BackColor = SystemColors.Control;
            panel_OrderID.BackColor = SystemColors.Control;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_NgayDatHang.BackColor = SystemColors.Control;
            panel_NgayDatHang.BackColor = SystemColors.Control;
            txt_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            panel_TongSoTienGiaoHang.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = Color.White;
            panel_DiaChi.BackColor = Color.White;
        }
        #endregion 

        QuanLyKhoVan db = new QuanLyKhoVan(); // khoi tao doi tuong db

        #region Method 

        void LoadDataOrder()
        {
            var data = from p in db.Order
                       select new
                       {
                           OrderID = p.Order_ID,
                           CustomerID = p.Customer_ID,
                           NgayDatHang = p.NgayDatHang,
                           TongSoTienGiaoHang = p.TongSoTienGiaoHang,
                           DiaChi = p.DiaChi
                       };
           dataGridView1.DataSource = data.ToList();
        }

        void AddOrder()
        {
            Order order = new Order();
           if (txt_OrderID.Text == "" || txt_CustomerID.Text == "" || txt_NgayDatHang.Text == "" || txt_TongSoTienGiaoHang.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                order.Order_ID = int.Parse(txt_OrderID.Text);
            }catch{
                MessageBox.Show("Mã đơn hàng đã tồn tại. Vui lòng chọn mã khác");
                return;

            }
            try
            {
                order.Customer_ID = int.Parse(txt_CustomerID.Text);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng chọn mã khác");
                return;

            }
            try
            {
                order.NgayDatHang = DateTime.Parse(txt_NgayDatHang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng ngày không hợp lệ. Vui lòng sử dụng YYYY-MM-DD.");
                return;
            }
            //order.NgayDatHang = DateTime.Parse(txt_NgayDatHang.Text);
           try
            {
                order.TongSoTienGiaoHang = txt_TongSoTienGiaoHang.Text;
            }
            catch
            {
                MessageBox.Show("lỗi tại số tiền giao hàng");
                return;
            }
            try
            {
                order.DiaChi = txt_DiaChi.Text;
            }
            catch
            {
             MessageBox.Show("lỗi tại địa chỉ");
                return;
            }
           db.Order.Add(order);
            db.SaveChanges();
            LoadDataOrder();
            ClearTextBox();

        }


        void UpdateOrder()
        {
            int id = int.Parse(txt_OrderID.Text);
            Order order = db.Order.Find(id);
            order.Customer_ID = int.Parse(txt_CustomerID.Text);
            order.NgayDatHang = DateTime.Parse(txt_NgayDatHang.Text);
            order.TongSoTienGiaoHang = txt_TongSoTienGiaoHang.Text;
            order.DiaChi = txt_DiaChi.Text;
            db.SaveChanges();
            LoadDataOrder();
            ClearTextBox();
        }

        void DeleteOrder()
        {
            int id = int.Parse(txt_OrderID.Text);
          
            Order d = db.Order.Where(s => s.Order_ID == id).FirstOrDefault();
            db.Order.Remove(d);
            db.SaveChanges();
            LoadDataOrder();
            ClearTextBox();
        }

        void ClearTextBox()
        {
            txt_OrderID.Text = "";
            txt_CustomerID.Text = "";
            txt_NgayDatHang.Text = "";
            txt_TongSoTienGiaoHang.Text = "";
            txt_DiaChi.Text = "";
        }
        #endregion

        private void Form_Order_Load(object sender, EventArgs e)
        {
            LoadDataOrder();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddOrder();
            MessageBox.Show("Thêm thành công");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_OrderID.Text == "" || txt_CustomerID.Text == "" || txt_NgayDatHang.Text == "" || txt_TongSoTienGiaoHang.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa");
            }
            else
            {
                try
                {
                    UpdateOrder();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật không thành công : " + ex.Message);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if ( txt_OrderID.Text == "") {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa");
            }
            else
            {
                DeleteOrder();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           txt_OrderID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           txt_CustomerID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           txt_NgayDatHang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           txt_TongSoTienGiaoHang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txt_DiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
