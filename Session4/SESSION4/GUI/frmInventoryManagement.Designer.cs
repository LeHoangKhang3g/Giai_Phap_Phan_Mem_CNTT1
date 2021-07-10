
namespace GUI
{
    partial class frmInventoryManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiPurchaseOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarehouseManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventoryReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPurchaseOrderManagement = new System.Windows.Forms.DataGridView();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPurchaseOrderManagement,
            this.tsmiWarehouseManagement,
            this.tsmiInventoryReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1083, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPurchaseOrderManagement
            // 
            this.tsmiPurchaseOrderManagement.ForeColor = System.Drawing.Color.White;
            this.tsmiPurchaseOrderManagement.Name = "tsmiPurchaseOrderManagement";
            this.tsmiPurchaseOrderManagement.Size = new System.Drawing.Size(255, 27);
            this.tsmiPurchaseOrderManagement.Text = "Purchase Order Management";
            // 
            // tsmiWarehouseManagement
            // 
            this.tsmiWarehouseManagement.ForeColor = System.Drawing.Color.White;
            this.tsmiWarehouseManagement.Name = "tsmiWarehouseManagement";
            this.tsmiWarehouseManagement.Size = new System.Drawing.Size(220, 27);
            this.tsmiWarehouseManagement.Text = "Warehouse Management";
            this.tsmiWarehouseManagement.Click += new System.EventHandler(this.tsmiWarehouseManagement_Click);
            // 
            // tsmiInventoryReport
            // 
            this.tsmiInventoryReport.ForeColor = System.Drawing.Color.White;
            this.tsmiInventoryReport.Name = "tsmiInventoryReport";
            this.tsmiInventoryReport.Size = new System.Drawing.Size(159, 27);
            this.tsmiInventoryReport.Text = "Inventory Report";
            this.tsmiInventoryReport.Click += new System.EventHandler(this.tsmiInventoryReport_Click);
            // 
            // dgvPurchaseOrderManagement
            // 
            this.dgvPurchaseOrderManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartName,
            this.colTransactionType,
            this.colDate,
            this.colAmount,
            this.colSource,
            this.colDestination,
            this.colEdit,
            this.colRemove});
            this.dgvPurchaseOrderManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrderManagement.Location = new System.Drawing.Point(0, 33);
            this.dgvPurchaseOrderManagement.Name = "dgvPurchaseOrderManagement";
            this.dgvPurchaseOrderManagement.RowTemplate.Height = 25;
            this.dgvPurchaseOrderManagement.Size = new System.Drawing.Size(1083, 607);
            this.dgvPurchaseOrderManagement.TabIndex = 1;
            // 
            // colPartName
            // 
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            // 
            // colTransactionType
            // 
            this.colTransactionType.HeaderText = "Transaction Type";
            this.colTransactionType.Name = "colTransactionType";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // colSource
            // 
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            // 
            // colDestination
            // 
            this.colDestination.HeaderText = "Destination";
            this.colDestination.Name = "colDestination";
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "Remove";
            this.colRemove.Name = "colRemove";
            this.colRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 640);
            this.Controls.Add(this.dgvPurchaseOrderManagement);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventoryManagement";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.frmInventoryManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurchaseOrderManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehouseManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventoryReport;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    }
}

