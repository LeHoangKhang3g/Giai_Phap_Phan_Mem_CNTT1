using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInventoryDashbroad : Form
    {
        CultureInfo culture;
        public static String languageSelect;
        public frmInventoryDashbroad()
        {
            InitializeComponent();
        }
        private void frmInventoryDashbroad_Load(object sender, EventArgs e)
        {
            cboLaguage.Items.Add("vi-VN");
            cboLaguage.Items.Add("en-US");
            cboLaguage.SelectedIndex = 0;
            languageSelect = cboLaguage.SelectedItem.ToString();
            SetLanguage(languageSelect);
        }
        private void SetLanguage(String cultureName)
        {
            culture = CultureInfo.GetCultureInfo(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Properties.Resources", typeof(frmInventoryControl).Assembly);

            lblHeaderInventoryDashbroad.Text = rm.GetString("Inventory Dashbroad", culture);
            lblLanguage.Text = rm.GetString("Language:", culture);
            btnInventoryControl.Text = rm.GetString("Inventory Control", culture);
            btnClose.Text = rm.GetString("Close", culture);
            grbEMSpendingByDepartment.Text = rm.GetString("EM Spending by Department", culture);
            grbDepartmentSpendingRatio.Text = rm.GetString("Department Spending Ratio", culture);
            grbMonthlyDepartmentSpending.Text = rm.GetString("Monthly Department Spending", culture);
            grbMonthlyReportForMostUsedParts.Text = rm.GetString("Monthly Report for Most-Used Parts", culture);
            grbMonthlyReportOfCostlyAssets.Text = rm.GetString("Monthly Report of Costly Assets", culture);

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

        private void cboLaguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                languageSelect = cboLaguage.SelectedItem.ToString();
                SetLanguage(languageSelect);
            }
            catch
            {

            }
        }
    }
}
