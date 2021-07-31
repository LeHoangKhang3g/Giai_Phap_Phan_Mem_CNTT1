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
    public partial class frmInventoryManagement : Form
    {
        private PartsBUS _part = new PartsBUS();
        private OrderItemBUS _orderItem = new OrderItemBUS();
        public static long orderID;
        public static decimal amountBeforeEdit;
        public static decimal amountAfterEdit;
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            dgvPartsManagement.AutoGenerateColumns = false;
            dgvPartsManagement.DataSource = _part.GetAllActivities();
        }

        private void dgvPurchaseOrderManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPartsManagement.Rows)
            {
                if(row.Cells[5].Value == null)
                {
                    row.Cells[4].Style.BackColor = Color.Lime;
                }
            }
        }

        private void purchaseOrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderManagement fPurchaseOrder = new frmPurchaseOrderManagement();
            this.Hide();
            fPurchaseOrder.ShowDialog();
            dgvPartsManagement.DataSource = _part.GetAllActivities();
            this.Show();
        }

        private void warehouseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderID = 0;
            frmWarehouseManagement fWarehouseManagement = new frmWarehouseManagement();
            this.Hide();
            fWarehouseManagement.ShowDialog();
            dgvPartsManagement.DataSource = _part.GetAllActivities();
            this.Show();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryReport fInventoryReport = new frmInventoryReport();
            this.Hide();
            fInventoryReport.ShowDialog();
            this.Show();
        }

        private void dgvPartsManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colEdit")
            {
                orderID = (long)dgvPartsManagement.Rows[e.RowIndex].Cells[9].Value;

                string transaction= dgvPartsManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(transaction.Equals("Purchase Order"))
                {
                    frmPurchaseOrderManagement frm = new frmPurchaseOrderManagement();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    frmWarehouseManagement frm = new frmWarehouseManagement();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colRemove")
            {
                long id = Convert.ToInt64(dgvPartsManagement.Rows[e.RowIndex].Cells[0].Value.ToString());
                String partName = dgvPartsManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal amount = Convert.ToDecimal(dgvPartsManagement.Rows[e.RowIndex].Cells[4].Value.ToString());
                String source;
                if (dgvPartsManagement.Rows[e.RowIndex].Cells[5].Value == null)
                    source = null;
                else
                    source = dgvPartsManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
                String destination = dgvPartsManagement.Rows[e.RowIndex].Cells[6].Value.ToString();
                decimal currentStockSource = source == null ? 0 : _orderItem.GetCurrentStock(source, partName);
                decimal currentStockDestination = _orderItem.GetCurrentStock(destination, partName);
                if(MessageBox.Show("Bạn có muốn xoá không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (currentStockDestination >= amount)
                    {
                        bool result = _orderItem.DeleteItem(id);
                        if (result)
                        {
                            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvPartsManagement.DataSource = _part.GetAllActivities();
                        }
                        else
                            MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá, vì tác vụ này khiến số lượng thành phần trong kho đích bị âm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void dgvPartsManagement_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvPartsManagement.Columns[e.ColumnIndex].Name == "colPartName")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(1);
                return;
            }

            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colTransactionType")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(2);
                return;
            }

            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colDate")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(3);
                return;
            }

            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colAmount")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(4);
                return;
            }

            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colSource")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(5);
                return;
            }

            if (dgvPartsManagement.Columns[e.ColumnIndex].Name == "colDestionation")
            {
                dgvPartsManagement.DataSource = _part.GetAllActivities(6);
                return;
            }
        }
    }   
}
