
namespace GUI
{
    partial class frmEM_Management_Admin
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
            this.colAssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnManageRequest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfRequestingEM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
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
            this.dgvListOfRequestingEM.Location = new System.Drawing.Point(16, 40);
            this.dgvListOfRequestingEM.Name = "dgvListOfRequestingEM";
            this.dgvListOfRequestingEM.Size = new System.Drawing.Size(821, 319);
            this.dgvListOfRequestingEM.TabIndex = 1;
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
            this.colEmployeeFullName.DataPropertyName = "FullName";
            this.colEmployeeFullName.HeaderText = "Employee Full Name";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Name";
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // btnManageRequest
            // 
            this.btnManageRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnManageRequest.ForeColor = System.Drawing.Color.White;
            this.btnManageRequest.Location = new System.Drawing.Point(25, 377);
            this.btnManageRequest.Name = "btnManageRequest";
            this.btnManageRequest.Size = new System.Drawing.Size(136, 30);
            this.btnManageRequest.TabIndex = 2;
            this.btnManageRequest.Text = "Manage Request";
            this.btnManageRequest.UseVisualStyleBackColor = false;
            this.btnManageRequest.Click += new System.EventHandler(this.btnManageRequest_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(838, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dgvListOfRequestingEM);
            this.panel1.Controls.Add(this.btnManageRequest);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 423);
            this.panel1.TabIndex = 4;
            // 
            // frmEM_Management_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(895, 447);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEM_Management_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.frmEMManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfRequestingEM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}