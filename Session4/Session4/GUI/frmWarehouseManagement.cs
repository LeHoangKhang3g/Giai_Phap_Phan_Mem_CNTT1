using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmWarehouseManagement : Form
    {
        private bool flag;
        private long orderID;
        private WarehouseBUS _ware = new WarehouseBUS();
        private PartsBUS _part = new PartsBUS();
        private OrderBUS _order = new OrderBUS();
        private OrderItemBUS _item = new OrderItemBUS(); 
        public frmWarehouseManagement()
        {
            InitializeComponent();

            cboPartName.DataSource = _part.GetAllPart();
            cboPartName.DisplayMember = "Name";
            cboPartName.ValueMember = "ID";
        }

        private void frmWarehouseManagement_Load(object sender, EventArgs e)
        {
            flag = false;
            frmInventoryManagement frm = new frmInventoryManagement();
            orderID = frm.orderID;

            cboSourceWarehouse.DataSource = _ware.GetAllWarehouse();
            cboSourceWarehouse.DisplayMember = "Name";
            cboSourceWarehouse.ValueMember = "ID";

            cboDestinationWarehouse.DataSource = _ware.GetAllWarehouse();
            cboDestinationWarehouse.DisplayMember = "Name";
            cboDestinationWarehouse.ValueMember = "ID";

            cboSourceWarehouse.SelectedIndex = 0;
            cboDestinationWarehouse.SelectedIndex = 1;

            if (_part.CheckPart(Int64.Parse(cboPartName.SelectedValue.ToString())) == true)
            {
                txtBatchNumber.Enabled = true;
            }
            else
            {
                txtBatchNumber.Enabled = false;
            }
        }

        private void cboSourceWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSourceWarehouse.Text.Equals("Central Warehouse"))
            {
                cboDestinationWarehouse.Text = "Volka  Warehouse";
            }
            else
            {
                cboDestinationWarehouse.Text = "Central Warehouse";
            }
        }

        private void cboDestinationWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDestinationWarehouse.Text.Equals("Central Warehouse"))
            {
                cboSourceWarehouse.Text = "Volka  Warehouse";
            }
            else
            {
                cboSourceWarehouse.Text = "Central Warehouse";
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                if (_order.AddOrder(2, Int64.Parse(cboSourceWarehouse.SelectedValue.ToString()), Int64.Parse(cboDestinationWarehouse.SelectedValue.ToString()), dtpDate.Value))
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Add faled");
                }
            }

            if(orderID == 0)
            {
                orderID = _order.Max();
            }

            if (txtBatchNumber.Enabled == true && string.IsNullOrEmpty(txtBatchNumber.Text))
            {
                MessageBox.Show("Please enter batch number");
                return;
            }

            //kiem tra xem item da ton tai hay chua
            if ((!_item.CheckOrder((long)cboPartName.SelectedValue, txtBatchNumber.Text) && txtBatchNumber.Text.Length>0) || (!_item.CheckOrder2((long)cboPartName.SelectedValue, orderID) && txtBatchNumber.Text.Length == 0))
            {
                MessageBox.Show("This item already exists");
                return;
            }
            //kiem tra so luong ton
            if(_part.CheckAmount((long)cboSourceWarehouse.SelectedValue, (long)cboPartName.SelectedValue) < (long)nrAmount.Value)
            {
                MessageBox.Show("The number of items is not enough");
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

        private void dgvPartsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPartsList.Columns[e.ColumnIndex].Name== "colAction")
            {
                DataGridViewRow row= dgvPartsList.Rows[dgvPartsList.CurrentCell.RowIndex];
               if( MessageBox.Show("Ban con muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               {
                   if(_item.DeleteItem(Int64.Parse(row.Cells[4].Value.ToString())))
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
