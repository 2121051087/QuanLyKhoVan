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
    public partial class Form_ForgetPassword : Form
    {
        public Form_ForgetPassword()
        {
            InitializeComponent();
            lb_KetQua.Text = "";
        }
        #region Xu ly UI
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            panel_Email.BackColor = Color.White;
            lb_Email.BackColor = Color.FromArgb(33, 121, 184);
            lb_Email.ForeColor = Color.White;
            txt_Email.BackColor = Color.White;
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan(); // tao doi tuong db 


        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                lb_KetQua.Text = "Vui lòng nhập Email";
                lb_KetQua.ForeColor = Color.Red;
            }
            else
            {
                var check = db.Account.Where(s => s.Email == txt_Email.Text).FirstOrDefault();
                if (check == null)
                {
                    lb_KetQua.Text = "Email chưa được đăng kí ";
                    lb_KetQua.ForeColor = Color.Red;
                }
                else
                {
                    lb_KetQua.Text = "Mật khẩu của bạn là: " + check.MatKhau;
                    lb_KetQua.ForeColor = Color.Green;
                }
            }
        }

    }
}
