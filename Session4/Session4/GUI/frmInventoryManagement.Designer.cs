
namespace GUI
{
    partial class frmInventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseOrderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPurchaseOrderManagement = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderManagementToolStripMenuItem,
            this.warehouseManagementToolStripMenuItem,
            this.inventoryReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseOrderManagementToolStripMenuItem
            // 
            this.purchaseOrderManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.purchaseOrderManagementToolStripMenuItem.Name = "purchaseOrderManagementToolStripMenuItem";
            this.purchaseOrderManagementToolStripMenuItem.Size = new System.Drawing.Size(247, 27);
            this.purchaseOrderManagementToolStripMenuItem.Text = "Purchase Order Management";
            this.purchaseOrderManagementToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderManagementToolStripMenuItem_Click);
            // 
            // warehouseManagementToolStripMenuItem
            // 
            this.warehouseManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.warehouseManagementToolStripMenuItem.Name = "warehouseManagementToolStripMenuItem";
            this.warehouseManagementToolStripMenuItem.Size = new System.Drawing.Size(214, 27);
            this.warehouseManagementToolStripMenuItem.Text = "Warehouse Management";
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            // 
            // dgvPurchaseOrderManagement
            // 
            this.dgvPurchaseOrderManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colPartName,
            this.colTransactionType,
            this.colDate,
            this.colAmount,
            this.colSource,
            this.colDestination,
            this.colEdit,
            this.colRemove});
            this.dgvPurchaseOrderManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrderManagement.Location = new System.Drawing.Point(0, 31);
            this.dgvPurchaseOrderManagement.Name = "dgvPurchaseOrderManagement";
            this.dgvPurchaseOrderManagement.ReadOnly = true;
            this.dgvPurchaseOrderManagement.Size = new System.Drawing.Size(984, 530);
            this.dgvPurchaseOrderManagement.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // colPartName
            // 
            this.colPartName.DataPropertyName = "Part_Name";
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            this.colPartName.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "Transaction_Type";
            this.colTransactionType.HeaderText = "Transaction Type";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Transaction_Date";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colSource
            // 
            this.colSource.DataPropertyName = "Source_Warehouse";
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            // 
            // colDestination
            // 
            this.colDestination.DataPropertyName = "Destination_Warehouse";
            this.colDestination.HeaderText = "Destination";
            this.colDestination.Name = "colDestination";
            this.colDestination.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "Remove";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvPurchaseOrderManagement);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
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

