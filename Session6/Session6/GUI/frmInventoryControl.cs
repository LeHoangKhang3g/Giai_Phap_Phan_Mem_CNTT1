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
using BUS;
using DTO;
namespace GUI
{
    public partial class frmInventoryControl : Form
    {
        private AllocatedPartBUS _allocatedPart = new AllocatedPartBUS();
        private List<AllocatedPartDTO> listPart_Result = new List<AllocatedPartDTO>();
        CultureInfo culture;

        public frmInventoryControl()
        {
            InitializeComponent();
        }

        private void frmInventoryControl_Load(object sender, EventArgs e)
        {
            SetLanguage(frmInventoryDashbroad.languageSelect);
            cboAllocationMethod.SelectedIndex = 0;
            cboWarehouse.DataSource = _allocatedPart.GetWarehouse();
            cboWarehouse.DisplayMember = "Name";
            cboWarehouse.ValueMember = "ID";

            cboPartName.DataSource = _allocatedPart.GetParts(1);
            cboPartName.DisplayMember = "NAME";
            cboPartName.ValueMember = "ID";

            cboAssetName.DataSource = _allocatedPart.GetAsset();
            cboAssetName.DisplayMember = "NAME";
            cboAssetName.ValueMember = "ID";

            dgvAllocatedParts.AutoGenerateColumns = false;
            dgvAssignedPart.AutoGenerateColumns = false;

            dgvAllocatedParts.DataSource = GetAllocated();
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

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id= (long)cboWarehouse.SelectedIndex +1;
           cboPartName.DataSource = _allocatedPart.GetParts(id);
        }

        private List<AllocatedPartDTO> GetAllocated()
        {
            int method = cboAllocationMethod.SelectedIndex;
            long part = (long)cboPartName.SelectedValue;
            long warehouse= (long)cboWarehouse.SelectedValue;
            int amount = (int)nrAmount.Value;

            List<AllocatedPartDTO> listPart = _allocatedPart.ListAllocatedPart(method, warehouse, part);
            List<AllocatedPartDTO> listPart_ = new List<AllocatedPartDTO>();
            foreach(AllocatedPartDTO item in listPart)
            {
                int flag = 0; 
                foreach(AllocatedPartDTO item2 in listPart_)
                {
                    if(item.ID == item2.ID && item.BatchNumber.Equals(item2.BatchNumber))
                    {
                        flag++;
                    }
                }
                if(flag == 0)
                {
                    if (item.Amount < amount)
                    {
                        listPart_.Add(item);
                    }
                    else
                    {
                        item.Amount = amount;
                        listPart_.Add(item);
                        flag = -1;
                    }
                }
                if (flag == -1) break;
            }

            return listPart_;
        }

        private void btnAssignToEM_Click(object sender, EventArgs e)
        {
            long idPart= (long)dgvAllocatedParts.Rows[0].Cells[0].Value;
            
            foreach (AllocatedPartDTO part in listPart_Result)
            {
                if(part.ID == idPart)
                {
                    MessageBox.Show("Part name already exist! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            {
                foreach (DataGridViewRow row in dgvAllocatedParts.Rows)
                {
                    AllocatedPartDTO part = new AllocatedPartDTO();

                    part.ID = (long)row.Cells[0].Value;
                    part.NAME = row.Cells[1].Value.ToString();
                    part.BatchNumber = row.Cells[2].Value.ToString();
                    part.UnitPrice = (decimal)row.Cells[3].Value;
                    part.Amount = (decimal)row.Cells[4].Value;

                    listPart_Result.Add(part);
                }

                dgvAssignedPart.DataSource = null;
                dgvAssignedPart.DataSource = listPart_Result;
            }
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            dgvAllocatedParts.DataSource = GetAllocated();
        }

        private void dgvAssignedPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAssignedPart.Columns[e.ColumnIndex].Name.Equals("colAction"))
            {
                long id= (long)dgvAssignedPart.Rows[e.RowIndex].Cells[0].Value;
                string batchNumber= dgvAssignedPart.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal price= (decimal)dgvAssignedPart.Rows[e.RowIndex].Cells[3].Value;
                foreach (AllocatedPartDTO part in listPart_Result)
                {
                    if(part.ID == id && part.BatchNumber.Equals(batchNumber) && part.UnitPrice== price)
                    {
                        listPart_Result.Remove(part);
                        dgvAssignedPart.DataSource = null;
                        dgvAssignedPart.DataSource = listPart_Result;
                        return;
                    }
                }
            }
        }
    }
}
