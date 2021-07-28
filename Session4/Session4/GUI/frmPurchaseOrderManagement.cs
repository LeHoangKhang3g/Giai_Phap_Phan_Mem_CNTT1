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
    public partial class frmPurchaseOrderManagement : Form
    {
        private bool flag;
        private long orderID;
        private SuppliersBUS _supp = new SuppliersBUS();
        private WarehouseBUS _ware = new WarehouseBUS();
        private PartsBUS _part = new PartsBUS();
        private OrderBUS _order = new OrderBUS();
        private OrderItemBUS _item = new OrderItemBUS();
        public frmPurchaseOrderManagement()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrderManagement_Load(object sender, EventArgs e)
        {
            flag = false;
            frmInventoryManagement frm = new frmInventoryManagement();
            orderID = frm.orderID;
            cbbSupplier.DataSource = _supp.GetAllSuppliers();
            cbbSupplier.DisplayMember = "Name";
            cbbSupplier.ValueMember = "ID";

            cboWarehouse.DataSource = _ware.GetAllWarehouse();
            cboWarehouse.DisplayMember = "Name";
            cboWarehouse.ValueMember = "ID";

            cboPartName.DataSource = _part.GetAllPart();
            cboPartName.DisplayMember = "Name";
            cboPartName.ValueMember = "ID";

            if (_part.CheckPart(Int64.Parse(cboPartName.SelectedValue.ToString())) == true)
            {
                txtBatchNumber.Enabled = true;
            }
            else
            {
                txtBatchNumber.Enabled = false;
            }
        }

        private void cboPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboPartName.SelectedValue.ToString().Equals("DTO.PartDTO"))
            {
                if (_part.CheckPart(Int64.Parse(cboPartName.SelectedValue.ToString())) == true)
                {
                    txtBatchNumber.Enabled = true;
                }
                else
                {
                    txtBatchNumber.Enabled = false;
                    txtBatchNumber.Text = string.Empty;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _order.DeleteOrder(orderID);
            this.Close();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                if (_order.AddOrder2(1, Int64.Parse(cbbSupplier.SelectedValue.ToString()), Int64.Parse(cboWarehouse.SelectedValue.ToString()), dtpDate.Value))
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Add faled");
                }
            }

            if (orderID == 0)
            {
                orderID = _order.Max();
            }

            if (_item.AddOrderItem(orderID, Int64.Parse(cboPartName.SelectedValue.ToString()), txtBatchNumber.Text, nrAmount.Value))
            {
                dgvPartsList.DataSource = _item.ListItem(orderID);
            }
            else
            {
                MessageBox.Show("Add faled");
                return;
            }
        }

        private void dgvPartsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPartsList.Columns[e.ColumnIndex].Name =="colAction")
            {
                DataGridViewRow row = dgvPartsList.Rows[dgvPartsList.CurrentCell.RowIndex];

                if (MessageBox.Show("Ban con muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (_item.DeleteItem(Int64.Parse(row.Cells[4].Value.ToString())))
                    {
                        dgvPartsList.DataSource = _item.ListItem(orderID);
                    }
                    else
                    {
                        MessageBox.Show("Xoa Ko thanh cong!");
                        return;
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
