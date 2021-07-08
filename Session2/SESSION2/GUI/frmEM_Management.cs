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
    public partial class frmEMManagement : Form
    {
        private AssetBUS _assBUS = new AssetBUS();
        private static string _assetSN;
        private static string _assetName;
        private static string _department;

        public frmEMManagement()
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
                    frmEM_Request frmRequest = new frmEM_Request();
                    frmRequest.Show();
                }
        }
        public string getAssetSN()
        {
            return _assetSN;
        }
        //
        public string getAssetName()
        {
            return _assetName;
        }

        public string getDepartment()
        {
            return _department;
        }
    }
}
