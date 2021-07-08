using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmEM_Request : Form
    {
        public frmEM_Request()
        {
            InitializeComponent();
        }

        private void frmEM_Request_Load(object sender, EventArgs e)
        {
            frmEM_Management_Admin frmManagement= new frmEM_Management_Admin();
            lblAssetSN.Text = frmManagement.getAssetSN();
            lblAssetName.Text = frmManagement.getAssetName();
            lblDepartment.Text = frmManagement.getDepartment();
        }
    }
}
