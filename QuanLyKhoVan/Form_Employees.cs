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
    public partial class Form_Employees : Form
    {
        public Form_Employees()
        {
            InitializeComponent();
           
        }
        #region Xu li UI
        private void txt_EmployeeID_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.BackColor = Color.White;
            panel_EmployeeID.BackColor = Color.White;
            txt_TenNhanVien.BackColor = SystemColors.Control;
            panel_TenNhanVien.BackColor = SystemColors.Control;
            txt_SDT.BackColor = SystemColors.Control;
            panel_SDT.BackColor = SystemColors.Control;
        }

        

        private void txt_SDT_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_TenNhanVien.BackColor = SystemColors.Control;
            panel_TenNhanVien.BackColor = SystemColors.Control;
           
            txt_SDT.BackColor = Color.White;
            panel_SDT.BackColor = Color.White;

        }
        private void txt_TenNhanVien_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.BackColor = SystemColors.Control;
            panel_EmployeeID.BackColor = SystemColors.Control;
            txt_TenNhanVien.BackColor = Color.White;
            panel_TenNhanVien.BackColor = Color.White;
            txt_SDT.BackColor = SystemColors.Control;
            panel_SDT.BackColor = SystemColors.Control;
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method 
        void ClearTextBox()
        {
            txt_EmployeeID.Text = "";
            txt_TenNhanVien.Text = "";
            txt_SDT.Text = "";
        }

        void  LoadDataEmployees()
        {
            var data = db.Employees.Select(s => new
            {
                EmployeeID = s.Employee_ID,
                TenNhanVien = s.TenNhanVien,
                SDT = s.SDT
            });          
            dataGridView1.DataSource = data.ToList();
        }

        void AddEmployees()
        {
            Employees employee = new Employees();
            employee.Employee_ID = int.Parse(txt_EmployeeID.Text);
            employee.TenNhanVien = txt_TenNhanVien.Text;
            employee.SDT = txt_SDT.Text;
            db.Employees.Add(employee);
            db.SaveChanges();
            LoadDataEmployees();
            ClearTextBox();
        }
        void UpdateEmployees()
        {
            int id = int.Parse(txt_EmployeeID.Text);
            Employees employee = db.Employees.Where(s => s.Employee_ID == id).FirstOrDefault();
            employee.TenNhanVien = txt_TenNhanVien.Text;
            employee.SDT = txt_SDT.Text;
            db.SaveChanges();
            LoadDataEmployees();
            ClearTextBox();
        }
        void DeleteEmployees()
        {
            int id = int.Parse(txt_EmployeeID.Text);
            Employees employee = db.Employees.Where(s => s.Employee_ID == id).FirstOrDefault();
            db.Employees.Remove(employee);
            db.SaveChanges();
            LoadDataEmployees();
            ClearTextBox();
        }   
        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_EmployeeID.Text == "" || txt_TenNhanVien.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
               try
                {
                    AddEmployees();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên thất bại" + ex);
                }
                
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_EmployeeID.Text == "" || txt_TenNhanVien.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần cập nhật ");
                return;
            }
            int id = int.Parse(txt_EmployeeID.Text);
            bool check = !db.Employees.Any(em => em.Employee_ID == id);
            if (check)
            {
                MessageBox.Show("ID nhân viên không tồn tại ");
            }
            else
            {
                try
                {
                    UpdateEmployees();
                    MessageBox.Show("Sửa nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa nhân viên thất bại" + ex);
                }

            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_EmployeeID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa ");
                return;

            }
            int id = int.Parse(txt_EmployeeID.Text);
            bool check = !db.Employees.Any(em => em.Employee_ID == id);

            if (check)
            {
                MessageBox.Show("ID nhân viên không tồn tại ");
            }
            else
            {
                try
                {
                    DeleteEmployees();
                    MessageBox.Show("Xóa nhân viên thành công ");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa nhân viên thất bại " + ex);

                }
            }
        }

        private void Form_Employees_Load(object sender, EventArgs e)
        {
            LoadDataEmployees();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenNhanVien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

    }
}
