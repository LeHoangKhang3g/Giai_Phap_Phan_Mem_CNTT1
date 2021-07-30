
namespace GUI
{
    partial class frmInventoryControl
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
            this.lblAssetName = new System.Windows.Forms.Label();
            this.cboAssetName = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grbSearchForParts = new System.Windows.Forms.GroupBox();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.cboAllocationMethod = new System.Windows.Forms.ComboBox();
            this.lblAllocationMethod = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cboPartName = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.grbAllocatedParts = new System.Windows.Forms.GroupBox();
            this.btnAssignToEM = new System.Windows.Forms.Button();
            this.dgvAllocatedParts = new System.Windows.Forms.DataGridView();
            this.grbAssignedParts = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHeaderInventoryControl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbSearchForParts.SuspendLayout();
            this.grbAllocatedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).BeginInit();
            this.grbAssignedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(14, 10);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(35, 13);
            this.lblAssetName.TabIndex = 0;
            this.lblAssetName.Text = "label1";
            // 
            // cboAssetName
            // 
            this.cboAssetName.FormattingEnabled = true;
            this.cboAssetName.Location = new System.Drawing.Point(164, 7);
            this.cboAssetName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAssetName.Name = "cboAssetName";
            this.cboAssetName.Size = new System.Drawing.Size(284, 21);
            this.cboAssetName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(505, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(564, 7);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // grbSearchForParts
            // 
            this.grbSearchForParts.Controls.Add(this.btnAllocate);
            this.grbSearchForParts.Controls.Add(this.cboAllocationMethod);
            this.grbSearchForParts.Controls.Add(this.lblAllocationMethod);
            this.grbSearchForParts.Controls.Add(this.txtAmount);
            this.grbSearchForParts.Controls.Add(this.lblAmount);
            this.grbSearchForParts.Controls.Add(this.cboPartName);
            this.grbSearchForParts.Controls.Add(this.comboBox2);
            this.grbSearchForParts.Controls.Add(this.lblPartName);
            this.grbSearchForParts.Controls.Add(this.lblWarehouse);
            this.grbSearchForParts.Location = new System.Drawing.Point(16, 48);
            this.grbSearchForParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearchForParts.Name = "grbSearchForParts";
            this.grbSearchForParts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearchForParts.Size = new System.Drawing.Size(754, 96);
            this.grbSearchForParts.TabIndex = 4;
            this.grbSearchForParts.TabStop = false;
            this.grbSearchForParts.Text = "groupBox1";
            // 
            // btnAllocate
            // 
            this.btnAllocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnAllocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocate.ForeColor = System.Drawing.Color.White;
            this.btnAllocate.Location = new System.Drawing.Point(611, 17);
            this.btnAllocate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(99, 24);
            this.btnAllocate.TabIndex = 12;
            this.btnAllocate.Text = "button1";
            this.btnAllocate.UseVisualStyleBackColor = false;
            // 
            // cboAllocationMethod
            // 
            this.cboAllocationMethod.FormattingEnabled = true;
            this.cboAllocationMethod.Location = new System.Drawing.Point(555, 56);
            this.cboAllocationMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAllocationMethod.Name = "cboAllocationMethod";
            this.cboAllocationMethod.Size = new System.Drawing.Size(155, 21);
            this.cboAllocationMethod.TabIndex = 11;
            // 
            // lblAllocationMethod
            // 
            this.lblAllocationMethod.AutoSize = true;
            this.lblAllocationMethod.Location = new System.Drawing.Point(438, 59);
            this.lblAllocationMethod.Name = "lblAllocationMethod";
            this.lblAllocationMethod.Size = new System.Drawing.Size(35, 13);
            this.lblAllocationMethod.TabIndex = 10;
            this.lblAllocationMethod.Text = "label1";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(353, 56);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(63, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(296, 59);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "label1";
            // 
            // cboPartName
            // 
            this.cboPartName.FormattingEnabled = true;
            this.cboPartName.Location = new System.Drawing.Point(132, 56);
            this.cboPartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPartName.Name = "cboPartName";
            this.cboPartName.Size = new System.Drawing.Size(147, 21);
            this.cboPartName.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(16, 59);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(35, 13);
            this.lblPartName.TabIndex = 6;
            this.lblPartName.Text = "label1";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(16, 25);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(35, 13);
            this.lblWarehouse.TabIndex = 5;
            this.lblWarehouse.Text = "label1";
            // 
            // grbAllocatedParts
            // 
            this.grbAllocatedParts.Controls.Add(this.btnAssignToEM);
            this.grbAllocatedParts.Controls.Add(this.dgvAllocatedParts);
            this.grbAllocatedParts.Location = new System.Drawing.Point(16, 158);
            this.grbAllocatedParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAllocatedParts.Name = "grbAllocatedParts";
            this.grbAllocatedParts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAllocatedParts.Size = new System.Drawing.Size(754, 153);
            this.grbAllocatedParts.TabIndex = 5;
            this.grbAllocatedParts.TabStop = false;
            this.grbAllocatedParts.Text = "groupBox1";
            // 
            // btnAssignToEM
            // 
            this.btnAssignToEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnAssignToEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignToEM.ForeColor = System.Drawing.Color.White;
            this.btnAssignToEM.Location = new System.Drawing.Point(622, 115);
            this.btnAssignToEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignToEM.Name = "btnAssignToEM";
            this.btnAssignToEM.Size = new System.Drawing.Size(115, 27);
            this.btnAssignToEM.TabIndex = 1;
            this.btnAssignToEM.Text = "button1";
            this.btnAssignToEM.UseVisualStyleBackColor = false;
            // 
            // dgvAllocatedParts
            // 
            this.dgvAllocatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocatedParts.Location = new System.Drawing.Point(11, 17);
            this.dgvAllocatedParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllocatedParts.Name = "dgvAllocatedParts";
            this.dgvAllocatedParts.Size = new System.Drawing.Size(595, 125);
            this.dgvAllocatedParts.TabIndex = 0;
            // 
            // grbAssignedParts
            // 
            this.grbAssignedParts.Controls.Add(this.dataGridView1);
            this.grbAssignedParts.Location = new System.Drawing.Point(16, 316);
            this.grbAssignedParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAssignedParts.Name = "grbAssignedParts";
            this.grbAssignedParts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAssignedParts.Size = new System.Drawing.Size(754, 197);
            this.grbAssignedParts.TabIndex = 6;
            this.grbAssignedParts.TabStop = false;
            this.grbAssignedParts.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(258, 518);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 33);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "button1";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(393, 518);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblAssetName);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.cboAssetName);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.grbAssignedParts);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.grbAllocatedParts);
            this.panel1.Controls.Add(this.grbSearchForParts);
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 557);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblHeaderInventoryControl);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 28);
            this.panel2.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(775, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 24);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeaderInventoryControl
            // 
            this.lblHeaderInventoryControl.AutoSize = true;
            this.lblHeaderInventoryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderInventoryControl.ForeColor = System.Drawing.Color.White;
            this.lblHeaderInventoryControl.Location = new System.Drawing.Point(10, 8);
            this.lblHeaderInventoryControl.Name = "lblHeaderInventoryControl";
            this.lblHeaderInventoryControl.Size = new System.Drawing.Size(51, 16);
            this.lblHeaderInventoryControl.TabIndex = 12;
            this.lblHeaderInventoryControl.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(885, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmInventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(812, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInventoryControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control";
            this.Load += new System.EventHandler(this.frmInventoryControl_Load);
            this.grbSearchForParts.ResumeLayout(false);
            this.grbSearchForParts.PerformLayout();
            this.grbAllocatedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).EndInit();
            this.grbAssignedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.ComboBox cboAssetName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grbSearchForParts;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cboPartName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAllocationMethod;
        private System.Windows.Forms.ComboBox cboAllocationMethod;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.GroupBox grbAllocatedParts;
        private System.Windows.Forms.DataGridView dgvAllocatedParts;
        private System.Windows.Forms.Button btnAssignToEM;
        private System.Windows.Forms.GroupBox grbAssignedParts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeaderInventoryControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}