using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        public static EmployeeDTO employeeDTO_HienHanh = new EmployeeDTO();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EmployeeDTO EM = _employeeBUS.CheckAccount(txtUsername.Text, txtPass.Text);
            if (EM == null)
            {
                MessageBox.Show("Thông tin đăng nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeDTO_HienHanh = EM;
                this.Hide();
                if(EM.isAdmin==true)
                {
                    frmEM_Management_Admin fEM_Management_Admin = new frmEM_Management_Admin();
                    fEM_Management_Admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    frmEM_Management fEm_Management = new frmEM_Management();
                    fEm_Management.ShowDialog();
                    this.Show();
                }    
            }
        }
    }
}
