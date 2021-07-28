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
    public partial class frmEditAmount : Form
    {
        public frmEditAmount()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmInventoryManagement.amountAfterEdit = Convert.ToDecimal(nbrAmount.Value.ToString());
            this.Close();
        }

        private void frmEditAmount_Load(object sender, EventArgs e)
        {
            nbrAmount.Value = frmInventoryManagement.amountBeforeEdit;
        }
    }
}
