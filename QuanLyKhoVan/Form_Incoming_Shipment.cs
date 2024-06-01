using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhoVan
{
    public partial class Form_Incoming_Shipment : Form
    {
        public Form_Incoming_Shipment()
        {
            InitializeComponent();
            txt_Search.Text = "0"; // Khởi tạo giá trị tìm kiếm ban đầu
            UpdateTongTienTraNCC(); // Cập nhật tổng tiền khi form được load
        }

        QuanLyKhoVan db = new QuanLyKhoVan();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Incoming_Shipment_Detail form_Incoming_Shipment_Detail = new Form_Incoming_Shipment_Detail();
            form_Incoming_Shipment_Detail.ShowDialog();
            this.Show();
        }

        private void Form_Partner_Load(object sender, EventArgs e)
        {
            LoadIncomingShipments();
        }

        private void LoadIncomingShipments()
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa các item cũ trước khi tải lại

            var shipmentIds = db.Incoming_Shipments
                .Select(p => p.Shipment_ID)
                .Distinct()
                .ToList();

            foreach (var shipmentId in shipmentIds)
            {
                Form_Item_IncomingShipment item = new Form_Item_IncomingShipment(shipmentId);
                item.TopLevel = false;
                flowLayoutPanel1.Controls.Add(item);
                item.Show();

                // Đăng ký sự kiện ThanhTienChanged (hoặc sự kiện tương tự)
                item.ThanhTienChanged += (s, args) =>
                {
                    UpdateTongTienTraNCC();
                    flowLayoutPanel1.Refresh();
                };
            }
            UpdateTongTienTraNCC(); // Cập nhật tổng tiền sau khi tải xong
        }

        void loadSearch()
        {
            int IdSearch;
            if (int.TryParse(txt_Search.Text, out IdSearch))
            {
                var data = db.Incoming_Shipment_Detail
                              .Where(detail => detail.Shipment_ID == IdSearch)
                              .ToList();

                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số Shipment_ID hợp lệ.");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                LoadIncomingShipments();
            }
            else
            {
                loadSearch();
            }
        }

        void UpdateTongTienTraNCC()
        {
            decimal tongTienTraNCC = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Form_Item_IncomingShipment itemIS)
                {
                    tongTienTraNCC += itemIS.ThanhTien; // Sử dụng thuộc tính ThanhTien
                }
            }
            lb_KQTongCanTraNCC.Text = tongTienTraNCC.ToString();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Home form_Home = new Form_Home();
            form_Home.ShowDialog();

            this.Close();
            form_Home.FormClosed += (s, args) => this.Close();
        }

        private void Form_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
