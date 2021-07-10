
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWarehouse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCurrentStock = new System.Windows.Forms.RadioButton();
            this.radReceivedStock = new System.Windows.Forms.RadioButton();
            this.radOutOfStock = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dgvResult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbbWarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 605);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            // 
            // cbbWarehouse
            // 
            this.cbbWarehouse.FormattingEnabled = true;
            this.cbbWarehouse.Location = new System.Drawing.Point(16, 49);
            this.cbbWarehouse.Name = "cbbWarehouse";
            this.cbbWarehouse.Size = new System.Drawing.Size(348, 29);
            this.cbbWarehouse.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOutOfStock);
            this.groupBox1.Controls.Add(this.radReceivedStock);
            this.groupBox1.Controls.Add(this.radCurrentStock);
            this.groupBox1.Location = new System.Drawing.Point(399, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type:";
            // 
            // radCurrentStock
            // 
            this.radCurrentStock.AutoSize = true;
            this.radCurrentStock.Location = new System.Drawing.Point(15, 28);
            this.radCurrentStock.Name = "radCurrentStock";
            this.radCurrentStock.Size = new System.Drawing.Size(131, 27);
            this.radCurrentStock.TabIndex = 0;
            this.radCurrentStock.TabStop = true;
            this.radCurrentStock.Text = "Current Stock";
            this.radCurrentStock.UseVisualStyleBackColor = true;
            // 
            // radReceivedStock
            // 
            this.radReceivedStock.AutoSize = true;
            this.radReceivedStock.Location = new System.Drawing.Point(216, 26);
            this.radReceivedStock.Name = "radReceivedStock";
            this.radReceivedStock.Size = new System.Drawing.Size(140, 27);
            this.radReceivedStock.TabIndex = 1;
            this.radReceivedStock.TabStop = true;
            this.radReceivedStock.Text = "Received Stock";
            this.radReceivedStock.UseVisualStyleBackColor = true;
            // 
            // radOutOfStock
            // 
            this.radOutOfStock.AutoSize = true;
            this.radOutOfStock.Location = new System.Drawing.Point(419, 26);
            this.radOutOfStock.Name = "radOutOfStock";
            this.radOutOfStock.Size = new System.Drawing.Size(122, 27);
            this.radOutOfStock.TabIndex = 2;
            this.radOutOfStock.TabStop = true;
            this.radOutOfStock.Text = "Out of Stock";
            this.radOutOfStock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartName,
            this.colCurrentStock,
            this.colReceivedStock,
            this.colAction});
            this.dgvResult.Location = new System.Drawing.Point(16, 142);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.Size = new System.Drawing.Size(972, 447);
            this.dgvResult.TabIndex = 4;
            // 
            // colPartName
            // 
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.HeaderText = "Current Stock";
            this.colCurrentStock.Name = "colCurrentStock";
            // 
            // colReceivedStock
            // 
            this.colReceivedStock.HeaderText = "Received Stock";
            this.colReceivedStock.Name = "colReceivedStock";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventoryReport";
            this.Text = "Inventory Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbWarehouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOutOfStock;
        private System.Windows.Forms.RadioButton radReceivedStock;
        private System.Windows.Forms.RadioButton radCurrentStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedStock;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}