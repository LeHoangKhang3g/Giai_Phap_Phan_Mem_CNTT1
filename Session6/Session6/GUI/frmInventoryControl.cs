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
    public partial class frmInventoryControl : Form
    {
        CultureInfo culture;

        public frmInventoryControl()
        {
            InitializeComponent();
        }

        private void frmInventoryControl_Load(object sender, EventArgs e)
        {
            SetLanguage(frmInventoryDashbroad.languageSelect);
           
        }
        private void SetLanguage(String cultureName)
        {
            culture = CultureInfo.GetCultureInfo(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Properties.Resources", typeof(frmInventoryControl).Assembly);

            lblAllocationMethod.Text = rm.GetString("Allocation Method:", culture);
            lblAmount.Text = rm.GetString("Amount:", culture);
            lblAssetName.Text = rm.GetString("Asset Name (EM Number):", culture);
            lblDate.Text = rm.GetString("Date:", culture);
            lblHeaderInventoryControl.Text = rm.GetString("Inventory Control", culture);
            lblPartName.Text = rm.GetString("Part Name:", culture);
            lblWarehouse.Text = rm.GetString("Warehouse:", culture);

            grbAllocatedParts.Text = rm.GetString("Allocated Parts", culture);
            grbSearchForParts.Text = rm.GetString("Search for Parts", culture);
            grbAssignedParts.Text = rm.GetString("Assigned Parts", culture);

            btnAllocate.Text = rm.GetString("Allocate", culture);
            btnAssignToEM.Text = rm.GetString("Assign to EM", culture);
            btnCancel.Text = rm.GetString("Cancel", culture);
            btnSubmit.Text = rm.GetString("Submit", culture);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
