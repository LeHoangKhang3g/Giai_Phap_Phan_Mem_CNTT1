
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
            this.btnSendEmergencyMaintenanceRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
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
            this.colNumberOfEM});
            this.dgvAvailableAsset.Location = new System.Drawing.Point(16, 43);
            this.dgvAvailableAsset.Name = "dgvAvailableAsset";
            this.dgvAvailableAsset.Size = new System.Drawing.Size(900, 326);
            this.dgvAvailableAsset.TabIndex = 1;
            // 
            // colAssetSN
            // 
            this.colAssetSN.HeaderText = "Asset SN";
            this.colAssetSN.Name = "colAssetSN";
            // 
            // colAssetName
            // 
            this.colAssetName.HeaderText = "Asset Name";
            this.colAssetName.Name = "colAssetName";
            // 
            // colLastClosedEM
            // 
            this.colLastClosedEM.HeaderText = "LastClosedEM";
            this.colLastClosedEM.Name = "colLastClosedEM";
            // 
            // colNumberOfEM
            // 
            this.colNumberOfEM.HeaderText = "NumberOfEM";
            this.colNumberOfEM.Name = "colNumberOfEM";
            // 
            // btnSendEmergencyMaintenanceRequest
            // 
            this.btnSendEmergencyMaintenanceRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmergencyMaintenanceRequest.Location = new System.Drawing.Point(16, 393);
            this.btnSendEmergencyMaintenanceRequest.Name = "btnSendEmergencyMaintenanceRequest";
            this.btnSendEmergencyMaintenanceRequest.Size = new System.Drawing.Size(343, 32);
            this.btnSendEmergencyMaintenanceRequest.TabIndex = 2;
            this.btnSendEmergencyMaintenanceRequest.Text = "Send Emegency Maintenance Request";
            this.btnSendEmergencyMaintenanceRequest.UseVisualStyleBackColor = true;
            // 
            // frmEM_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnSendEmergencyMaintenanceRequest);
            this.Controls.Add(this.dgvAvailableAsset);
            this.Controls.Add(this.label1);
            this.Name = "frmEM_Management";
            this.Text = "Emergency Maintenance Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailableAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastClosedEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfEM;
        private System.Windows.Forms.Button btnSendEmergencyMaintenanceRequest;
    }
}