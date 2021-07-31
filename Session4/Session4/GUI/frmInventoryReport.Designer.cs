
namespace GUI
{
    partial class frmInventoryReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInventoryReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radOutOfStock = new System.Windows.Forms.RadioButton();
            this.radReceivedStock = new System.Windows.Forms.RadioButton();
            this.radCurrentStock = new System.Windows.Forms.RadioButton();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutOfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInventoryReport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboWarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 500);
            this.panel1.TabIndex = 0;
            // 
            // dgvInventoryReport
            // 
            this.dgvInventoryReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartName,
            this.colCurrentStock,
            this.colReceivedStock,
            this.colOutOfStock,
            this.colAction,
            this.ID});
            this.dgvInventoryReport.Location = new System.Drawing.Point(18, 100);
            this.dgvInventoryReport.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventoryReport.Name = "dgvInventoryReport";
            this.dgvInventoryReport.ReadOnly = true;
            this.dgvInventoryReport.Size = new System.Drawing.Size(878, 380);
            this.dgvInventoryReport.TabIndex = 10;
            this.dgvInventoryReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryReport_CellContentClick);
            this.dgvInventoryReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInventoryReport_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Result:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAll);
            this.groupBox1.Controls.Add(this.radOutOfStock);
            this.groupBox1.Controls.Add(this.radReceivedStock);
            this.groupBox1.Controls.Add(this.radCurrentStock);
            this.groupBox1.Location = new System.Drawing.Point(373, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(452, 25);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(41, 20);
            this.radAll.TabIndex = 3;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radOutOfStock
            // 
            this.radOutOfStock.AutoSize = true;
            this.radOutOfStock.Location = new System.Drawing.Point(311, 24);
            this.radOutOfStock.Margin = new System.Windows.Forms.Padding(2);
            this.radOutOfStock.Name = "radOutOfStock";
            this.radOutOfStock.Size = new System.Drawing.Size(97, 20);
            this.radOutOfStock.TabIndex = 2;
            this.radOutOfStock.TabStop = true;
            this.radOutOfStock.Text = "Out of Stock";
            this.radOutOfStock.UseVisualStyleBackColor = true;
            this.radOutOfStock.CheckedChanged += new System.EventHandler(this.radOutOfStock_CheckedChanged);
            // 
            // radReceivedStock
            // 
            this.radReceivedStock.AutoSize = true;
            this.radReceivedStock.Location = new System.Drawing.Point(150, 24);
            this.radReceivedStock.Margin = new System.Windows.Forms.Padding(2);
            this.radReceivedStock.Name = "radReceivedStock";
            this.radReceivedStock.Size = new System.Drawing.Size(122, 20);
            this.radReceivedStock.TabIndex = 1;
            this.radReceivedStock.TabStop = true;
            this.radReceivedStock.Text = "Received Stock";
            this.radReceivedStock.UseVisualStyleBackColor = true;
            this.radReceivedStock.CheckedChanged += new System.EventHandler(this.radReceivedStock_CheckedChanged);
            // 
            // radCurrentStock
            // 
            this.radCurrentStock.AutoSize = true;
            this.radCurrentStock.Checked = true;
            this.radCurrentStock.Location = new System.Drawing.Point(14, 25);
            this.radCurrentStock.Margin = new System.Windows.Forms.Padding(2);
            this.radCurrentStock.Name = "radCurrentStock";
            this.radCurrentStock.Size = new System.Drawing.Size(105, 20);
            this.radCurrentStock.TabIndex = 0;
            this.radCurrentStock.TabStop = true;
            this.radCurrentStock.Text = "Current Stock";
            this.radCurrentStock.UseVisualStyleBackColor = true;
            this.radCurrentStock.CheckedChanged += new System.EventHandler(this.radCurrentStock_CheckedChanged);
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(18, 43);
            this.cboWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(307, 23);
            this.cboWarehouse.TabIndex = 7;
            this.cboWarehouse.SelectedValueChanged += new System.EventHandler(this.cboWarehouse_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Warehouse:";
            // 
            // colPartName
            // 
            this.colPartName.DataPropertyName = "PartName";
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            this.colPartName.ReadOnly = true;
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.DataPropertyName = "CurrentStock";
            this.colCurrentStock.HeaderText = "Current Stock";
            this.colCurrentStock.Name = "colCurrentStock";
            this.colCurrentStock.ReadOnly = true;
            // 
            // colReceivedStock
            // 
            this.colReceivedStock.DataPropertyName = "ReceivedStock";
            this.colReceivedStock.HeaderText = "Received Stock";
            this.colReceivedStock.Name = "colReceivedStock";
            this.colReceivedStock.ReadOnly = true;
            // 
            // colOutOfStock
            // 
            this.colOutOfStock.DataPropertyName = "OutOfStock";
            this.colOutOfStock.HeaderText = "Out of Stock";
            this.colOutOfStock.Name = "colOutOfStock";
            this.colOutOfStock.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Text = "View Batch Numbers";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Report";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOutOfStock;
        private System.Windows.Forms.RadioButton radReceivedStock;
        private System.Windows.Forms.RadioButton radCurrentStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInventoryReport;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutOfStock;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}