
namespace GUI
{
    partial class frmEM_Management
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
            this.dgvAvailableAsset = new System.Windows.Forms.DataGridView();
            this.colAssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastClosedEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendEmergencyMaintenanceRequest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableAsset)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Asset:";
            // 
            // dgvAvailableAsset
            // 
            this.dgvAvailableAsset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetSN,
            this.colAssetName,
            this.colLastClosedEM,
            this.colNumberOfEM,
            this.departmen,
            this.colAssetID});
            this.dgvAvailableAsset.Location = new System.Drawing.Point(21, 39);
            this.dgvAvailableAsset.Name = "dgvAvailableAsset";
            this.dgvAvailableAsset.ReadOnly = true;
            this.dgvAvailableAsset.Size = new System.Drawing.Size(900, 326);
            this.dgvAvailableAsset.TabIndex = 1;
            // 
            // colAssetSN
            // 
            this.colAssetSN.DataPropertyName = "AssetSN";
            this.colAssetSN.HeaderText = "Asset SN";
            this.colAssetSN.Name = "colAssetSN";
            this.colAssetSN.ReadOnly = true;
            // 
            // colAssetName
            // 
            this.colAssetName.DataPropertyName = "AssetName";
            this.colAssetName.HeaderText = "Asset Name";
            this.colAssetName.Name = "colAssetName";
            this.colAssetName.ReadOnly = true;
            // 
            // colLastClosedEM
            // 
            this.colLastClosedEM.DataPropertyName = "LastClosedEM";
            this.colLastClosedEM.HeaderText = "LastClosedEM";
            this.colLastClosedEM.Name = "colLastClosedEM";
            this.colLastClosedEM.ReadOnly = true;
            // 
            // colNumberOfEM
            // 
            this.colNumberOfEM.DataPropertyName = "NumberOfEMs";
            this.colNumberOfEM.HeaderText = "NumberOfEM";
            this.colNumberOfEM.Name = "colNumberOfEM";
            this.colNumberOfEM.ReadOnly = true;
            // 
            // departmen
            // 
            this.departmen.DataPropertyName = "Department";
            this.departmen.HeaderText = "Departmen";
            this.departmen.Name = "departmen";
            this.departmen.ReadOnly = true;
            this.departmen.Visible = false;
            // 
            // colAssetID
            // 
            this.colAssetID.DataPropertyName = "ID";
            this.colAssetID.HeaderText = "AssetID";
            this.colAssetID.Name = "colAssetID";
            this.colAssetID.ReadOnly = true;
            this.colAssetID.Visible = false;
            // 
            // btnSendEmergencyMaintenanceRequest
            // 
            this.btnSendEmergencyMaintenanceRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnSendEmergencyMaintenanceRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmergencyMaintenanceRequest.ForeColor = System.Drawing.Color.White;
            this.btnSendEmergencyMaintenanceRequest.Location = new System.Drawing.Point(21, 389);
            this.btnSendEmergencyMaintenanceRequest.Name = "btnSendEmergencyMaintenanceRequest";
            this.btnSendEmergencyMaintenanceRequest.Size = new System.Drawing.Size(343, 32);
            this.btnSendEmergencyMaintenanceRequest.TabIndex = 2;
            this.btnSendEmergencyMaintenanceRequest.Text = "Send Emegency Maintenance Request";
            this.btnSendEmergencyMaintenanceRequest.UseVisualStyleBackColor = false;
            this.btnSendEmergencyMaintenanceRequest.Click += new System.EventHandler(this.btnSendEmergencyMaintenanceRequest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSendEmergencyMaintenanceRequest);
            this.panel1.Controls.Add(this.dgvAvailableAsset);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 439);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(935, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEM_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(996, 462);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEM_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.frmEM_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableAsset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailableAsset;
        private System.Windows.Forms.Button btnSendEmergencyMaintenanceRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastClosedEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetID;
    }
}