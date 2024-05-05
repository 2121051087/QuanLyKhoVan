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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        #region Xu ly UI
        private void txt_account_Click(object sender, EventArgs e)
        {
            txt_account.BackColor = Color.White;
            panel_account.BackColor = Color.White;
            panel_password.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {

            txt_password.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            panel_account.BackColor = SystemColors.Control;
            txt_account.BackColor = SystemColors.Control;
        }

        private void pic_password_MouseUp(object sender, MouseEventArgs e) // hien mat khau
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void pic_password_MouseDown(object sender, MouseEventArgs e) // an mat khau
        {
            txt_password.UseSystemPasswordChar = false;
        }
        #endregion


        #region Xu ly dieu huong form

        private void btn_SignUp_Click(object sender, EventArgs e) // form dang ky
        {
            this.Hide();
            Form_SignUp form_SignUp = new Form_SignUp();
            form_SignUp.ShowDialog();

            this.Show();
            form_SignUp.FormClosed += (s, args) => this.Show();
        }

        private void btn_ForgetPassWord_Click(object sender, EventArgs e)// form quen mat khau
        {
            this.Hide();
            Form_ForgetPassword form_ForgetPassword = new Form_ForgetPassword();
            form_ForgetPassword.ShowDialog();

            this.Show();
            form_ForgetPassword.FormClosed += (s, args) => this.Show();
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan(); // tao doi tuong db de truy cap vao database

        #region Method 


        void checkTaiKhoan()
        {
            var user = db.Account.Where(s => s.TenTaiKhoan == txt_account.Text && s.MatKhau == txt_password.Text).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form_Home form_Home = new Form_Home();
                form_Home.ShowDialog();
                this.Show();
                form_Home.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e) // dang nhap
        {
            checkTaiKhoan();
        }
    }
}
