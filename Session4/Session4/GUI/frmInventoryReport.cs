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
    public partial class frmInventoryReport : Form
    {
        WarehouseBUS _wareHouseBUS = new WarehouseBUS();
        ReportBUS _reportBUS = new ReportBUS();

        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            radCurrentStock.Checked = true;
            colCurrentStock.Visible = true;
            colReceivedStock.Visible = false;
            colOutOfStock.Visible = false;

            dgvInventoryReport.AutoGenerateColumns = false;
            cboWarehouse.DataSource = _wareHouseBUS.GetAllWarehouse();
            cboWarehouse.DisplayMember = "Name";
            cboWarehouse.ValueMember = "ID";
            cboWarehouse.SelectedIndex = 0;

        }


        private void cboWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                long selectedValue = Convert.ToInt64(cboWarehouse.SelectedValue.ToString());
                if (selectedValue > 0)
                {
                    dgvInventoryReport.DataSource = _reportBUS.GetReportDTOs(selectedValue);
                }
            }
            catch
            {
            }
        }

        private void radCurrentStock_CheckedChanged(object sender, EventArgs e)
        {
            if (radCurrentStock.Checked)
            {
                colCurrentStock.Visible = true;
                colReceivedStock.Visible = false;
                colOutOfStock.Visible = false;
            }

        }

        private void radReceivedStock_CheckedChanged(object sender, EventArgs e)
        {
            if (radReceivedStock.Checked)
            {
                colReceivedStock.Visible = true;
                colCurrentStock.Visible = false;
                colOutOfStock.Visible = false;
            }
        }

        private void radOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            if (radOutOfStock.Checked)
            {
                colOutOfStock.Visible = true;
                colCurrentStock.Visible = false;
                colReceivedStock.Visible = false;
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                colOutOfStock.Visible = true;
                colCurrentStock.Visible = true;
                colReceivedStock.Visible = true;
            }
        }
    }
}
