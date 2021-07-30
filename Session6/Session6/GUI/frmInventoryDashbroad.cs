using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInventoryDashbroad : Form
    {
        public frmInventoryDashbroad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TRANSLATE SCREEN IN HERE
            lblHeaderInventoryDashbroad.Text = "Inventory Dashbroad";
            lblLanguage.Text = "Language:";
            btnInventoryControl.Text = "Inventory Control";
            btnClose.Text = "Close";
            grbEMSpendingByDepartment.Text = "EM Spending by Department";
            grbDepartmentSpendingRatio.Text = "Department Spending Ratio";
            grbMonthlyDepartmentSpending.Text = "Monthly Department Spending";
            grbMonthlyReportForMostUsedParts.Text = "Monthly Report for Most-Used Parts";
            grbMonthlyReportOfCostlyAssets.Text = "Monthly Report of Costly Assets";
            #endregion
        }

        private void btnInventoryControl_Click(object sender, EventArgs e)
        {
            frmInventoryControl fInventoryControl = new frmInventoryControl();
            this.Hide();
            fInventoryControl.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
