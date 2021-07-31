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
    public partial class frmBarthNumber : Form
    {
        private PartsBUS part = new PartsBUS();
        private long partID;
        public frmBarthNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBarthNumber_Load(object sender, EventArgs e)
        {
            dgvBatchNumber.AutoGenerateColumns = false;
            partID = frmInventoryReport.partID;
            dgvBatchNumber.DataSource = part.SelectAllBatchNumber(partID);
        } 

    }
}
