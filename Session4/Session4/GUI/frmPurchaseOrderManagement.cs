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
        private bool flag2;
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
            orderID = frmInventoryManagement.orderID;
            flag2 = orderID > 0;
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

            if (flag2 == true)
            {
                dgvPartsList.DataSource = _item.ListItem(orderID);

                OrderDTO order = _order.SelectOrder(orderID);

                cboWarehouse.SelectedValue = order.DestinationWarehouseID;
                cbbSupplier.SelectedValue = order.SupplierID;
                dtpDate.Value = order.Date;

                cboWarehouse.Enabled = false;
                cbbSupplier.Enabled = false;
                dtpDate.Enabled = false;
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
            if (flag2 == false)
            {
                _order.DeleteOrder(orderID);
            }
            this.Close();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (flag == false && flag2 == false)
            {
                if (_order.AddOrder2(1, (long)cbbSupplier.SelectedValue, Int64.Parse(cboWarehouse.SelectedValue.ToString()), dtpDate.Value))
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

            if(txtBatchNumber.Enabled == true && string.IsNullOrEmpty(txtBatchNumber.Text))
            {
                MessageBox.Show("Please enter batch number");
                return;
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
            if(dgvPartsList.Rows.Count==0)
            {
                _order.DeleteOrder(orderID);
            }
            this.Close();
        }

    }
}
