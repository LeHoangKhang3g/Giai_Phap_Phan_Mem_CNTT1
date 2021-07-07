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
    public partial class frmEM_RequestDetails : Form
    {
        public frmEM_RequestDetails()
        {
            InitializeComponent();
            dgvParts.AutoGenerateColumns = false;
        }
    }
}
