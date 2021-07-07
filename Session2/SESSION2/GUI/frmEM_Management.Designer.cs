
namespace GUI
{
    partial class frmEMManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListOfRequestingEM = new System.Windows.Forms.DataGridView();
            this.btnManageRequest = new System.Windows.Forms.Button();
            this.colAssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfRequestingEM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // dgvListOfRequestingEM
            // 
            this.dgvListOfRequestingEM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOfRequestingEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfRequestingEM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetSN,
            this.colAssetName,
            this.colRequestDate,
            this.colEmployeeFullName,
            this.colDepartment});
            this.dgvListOfRequestingEM.Location = new System.Drawing.Point(33, 49);
            this.dgvListOfRequestingEM.Name = "dgvListOfRequestingEM";
            this.dgvListOfRequestingEM.Size = new System.Drawing.Size(821, 319);
            this.dgvListOfRequestingEM.TabIndex = 1;
            // 
            // btnManageRequest
            // 
            this.btnManageRequest.Location = new System.Drawing.Point(42, 397);
            this.btnManageRequest.Name = "btnManageRequest";
            this.btnManageRequest.Size = new System.Drawing.Size(136, 23);
            this.btnManageRequest.TabIndex = 2;
            this.btnManageRequest.Text = "Manage Request";
            this.btnManageRequest.UseVisualStyleBackColor = true;
            this.btnManageRequest.Click += new System.EventHandler(this.btnManageRequest_Click);
            // 
            // colAssetSN
            // 
            this.colAssetSN.DataPropertyName = "AssetSN";
            this.colAssetSN.HeaderText = "Asset SN";
            this.colAssetSN.Name = "colAssetSN";
            // 
            // colAssetName
            // 
            this.colAssetName.DataPropertyName = "AssetName";
            this.colAssetName.HeaderText = "Asset Name";
            this.colAssetName.Name = "colAssetName";
            // 
            // colRequestDate
            // 
            this.colRequestDate.DataPropertyName = "WarrantyDate";
            this.colRequestDate.HeaderText = "Request Date";
            this.colRequestDate.Name = "colRequestDate";
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.DataPropertyName = "FirstName";
            this.colEmployeeFullName.HeaderText = "Employee Full Name";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Name";
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // frmEMManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 443);
            this.Controls.Add(this.btnManageRequest);
            this.Controls.Add(this.dgvListOfRequestingEM);
            this.Controls.Add(this.label1);
            this.Name = "frmEMManagement";
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.frmEMManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfRequestingEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListOfRequestingEM;
        private System.Windows.Forms.Button btnManageRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
    }
}