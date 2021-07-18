
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOutOfStock = new System.Windows.Forms.RadioButton();
            this.radReceivedStock = new System.Windows.Forms.RadioButton();
            this.radCurrentStock = new System.Windows.Forms.RadioButton();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboWarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 500);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartName,
            this.colCurrentStock,
            this.colReceivedStock,
            this.colAction});
            this.dataGridView1.Location = new System.Drawing.Point(18, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(878, 380);
            this.dataGridView1.TabIndex = 10;
            // 
            // colPartName
            // 
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            this.colPartName.ReadOnly = true;
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.HeaderText = "Current Stock";
            this.colCurrentStock.Name = "colCurrentStock";
            this.colCurrentStock.ReadOnly = true;
            // 
            // colReceivedStock
            // 
            this.colReceivedStock.HeaderText = "Received Stock";
            this.colReceivedStock.Name = "colReceivedStock";
            this.colReceivedStock.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
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
            this.groupBox1.Controls.Add(this.radOutOfStock);
            this.groupBox1.Controls.Add(this.radReceivedStock);
            this.groupBox1.Controls.Add(this.radCurrentStock);
            this.groupBox1.Location = new System.Drawing.Point(373, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(517, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type";
            // 
            // radOutOfStock
            // 
            this.radOutOfStock.AutoSize = true;
            this.radOutOfStock.Location = new System.Drawing.Point(408, 21);
            this.radOutOfStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOutOfStock.Name = "radOutOfStock";
            this.radOutOfStock.Size = new System.Drawing.Size(97, 20);
            this.radOutOfStock.TabIndex = 2;
            this.radOutOfStock.TabStop = true;
            this.radOutOfStock.Text = "Out of Stock";
            this.radOutOfStock.UseVisualStyleBackColor = true;
            // 
            // radReceivedStock
            // 
            this.radReceivedStock.AutoSize = true;
            this.radReceivedStock.Location = new System.Drawing.Point(211, 21);
            this.radReceivedStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radReceivedStock.Name = "radReceivedStock";
            this.radReceivedStock.Size = new System.Drawing.Size(122, 20);
            this.radReceivedStock.TabIndex = 1;
            this.radReceivedStock.TabStop = true;
            this.radReceivedStock.Text = "Received Stock";
            this.radReceivedStock.UseVisualStyleBackColor = true;
            // 
            // radCurrentStock
            // 
            this.radCurrentStock.AutoSize = true;
            this.radCurrentStock.Checked = true;
            this.radCurrentStock.Location = new System.Drawing.Point(14, 25);
            this.radCurrentStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCurrentStock.Name = "radCurrentStock";
            this.radCurrentStock.Size = new System.Drawing.Size(105, 20);
            this.radCurrentStock.TabIndex = 0;
            this.radCurrentStock.TabStop = true;
            this.radCurrentStock.Text = "Current Stock";
            this.radCurrentStock.UseVisualStyleBackColor = true;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(18, 43);
            this.cboWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(307, 23);
            this.cboWarehouse.TabIndex = 7;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedStock;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}