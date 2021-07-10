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
    public partial class frmEM_Management_Admin : Form
    {
        private AssetBUS _assBUS = new AssetBUS();
        public static string _assetSN;
        public static string _assetName;
        public static string _department;
        public static long _id;

        public frmEM_Management_Admin()
        {
            InitializeComponent();
            dgvListOfRequestingEM.AutoGenerateColumns = false;
        }

        private void frmEMManagement_Load(object sender, EventArgs e)
        {
            dgvListOfRequestingEM.DataSource = _assBUS.GetListEM();
        }

        private void btnManageRequest_Click(object sender, EventArgs e)
        {
            
                if(dgvListOfRequestingEM.Rows.Count>0)
                {
                    DataGridViewRow row = dgvListOfRequestingEM.Rows[dgvListOfRequestingEM.CurrentCell.RowIndex];
                    _assetSN = row.Cells[0].Value.ToString();
                    _assetName = row.Cells[1].Value.ToString();
                    _department = row.Cells[4].Value.ToString();
                    _id = Int64.Parse(row.Cells[5].Value.ToString());
                    frmEM_RequestDetails frmRequest = new frmEM_RequestDetails();
                    frmRequest.ShowDialog();
                    dgvListOfRequestingEM.DataSource = _assBUS.GetListEM();
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
