﻿using System;
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
    public partial class Form_itemShipmentDetail : Form
    {
        public Form_itemShipmentDetail()
        {
            InitializeComponent();
            loadComboboxProductID();
            txt_Detail_ID.Text = "0";
            
        }
        QuanLyKhoVan db = new QuanLyKhoVan();

        private Form_Incoming_Shipment_Detail form_Incoming_Shipment_Detail;
        public Form_itemShipmentDetail(Form_Incoming_Shipment_Detail Form_Incoming_Shipment_Detail)
        {
            this.form_Incoming_Shipment_Detail = form_Incoming_Shipment_Detail;
            
        }
        public int MethodGetShipmentID()
        {
           var shipmentID = form_Incoming_Shipment_Detail.GetShipmentID();
            return shipmentID;
        }
        void loadComboboxProductID()
        {
            var productID = (from p in db.Products
                             select p.Product_ID).ToList();
            comboBox_ProductID.DataSource = productID;

        }
        private void comboBox_ProductID_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedProductId = int.Parse(comboBox_ProductID.SelectedItem.ToString());

            var sanpham = (from p in db.Products
                           where p.Product_ID == selectedProductId
                           select p.TenSanPham).FirstOrDefault();
            var Gia = (from p in db.Products
                       where p.Product_ID == selectedProductId
                       select p.Gia).FirstOrDefault();


            if ((sanpham != null) && (Gia != null))
            {
                lb_TenSP.Text = sanpham;
                lb_Gia.Text = Gia.ToString();

            }
            else
            {
                lb_TenSP.Text = "No product found";
            }
            txt_Soluong.Text = "0";
        }

        private void txt_Soluong_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Soluong.Text, out int soluong))
            {
                var Gia = int.Parse(lb_Gia.Text);
                var ThanhTien = soluong * Gia;
                lb_ThanhTien.Text = ThanhTien.ToString() + " ";
            }
            else
            {
                lb_ThanhTien.Text = "0 ";
            }
            // Thông báo cho Form_Incoming_Shipment_Detail
            SoLuongChanged?.Invoke();
        }


        #region Dat cho textbox chi nhap so 

        private void txt_Detail_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_Soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        public event Action<Form_itemShipmentDetail> RequestRemove;

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            RequestRemove?.Invoke(this);

            // Thông báo cho Form_Incoming_Shipment_Detail
            SoLuongChanged?.Invoke();

        }
        public event Action SoLuongChanged;

        public int GetThanhTien()
        {
            int  ThanhTien;
            if (int.TryParse(lb_ThanhTien.Text, out ThanhTien))
            {
                return ThanhTien;
            }
            else
            {
                return 0;
            }
        }

        public int GetMatHangId()
        {
            return int.Parse(comboBox_ProductID.Text);
        }
        public int GetProductId()
        { 
           return int.Parse(comboBox_ProductID.Text);
        }
        public int GetDetailID()
        {
            return int.Parse(txt_Detail_ID.Text);
        }
        public int GetProductID()
        {
            return int.Parse(comboBox_ProductID.Text);
        }
        public int GetSoLuong()
        {
            return int.Parse(txt_Soluong.Text);
        }

        

    }
}