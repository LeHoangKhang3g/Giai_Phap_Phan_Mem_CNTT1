
namespace GUI
{
    partial class frmInventoryDashbroad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbEMSpendingByDepartment = new System.Windows.Forms.GroupBox();
            this.dgvEMSpendingByDepartment = new System.Windows.Forms.DataGridView();
            this.grbMonthlyReportForMostUsedParts = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportForMostUsedParts = new System.Windows.Forms.DataGridView();
            this.grbMonthlyReportOfCostlyAssets = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportOfCostlyAssets = new System.Windows.Forms.DataGridView();
            this.chartDepartmentSpendingRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlyDepartmentSpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbDepartmentSpendingRatio = new System.Windows.Forms.GroupBox();
            this.grbMonthlyDepartmentSpending = new System.Windows.Forms.GroupBox();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboLaguage = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeaderInventoryDashbroad = new System.Windows.Forms.Label();
            this.grbEMSpendingByDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMSpendingByDepartment)).BeginInit();
            this.grbMonthlyReportForMostUsedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportForMostUsedParts)).BeginInit();
            this.grbMonthlyReportOfCostlyAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportOfCostlyAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartmentSpendingRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyDepartmentSpending)).BeginInit();
            this.grbDepartmentSpendingRatio.SuspendLayout();
            this.grbMonthlyDepartmentSpending.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEMSpendingByDepartment
            // 
            this.grbEMSpendingByDepartment.Controls.Add(this.dgvEMSpendingByDepartment);
            this.grbEMSpendingByDepartment.Location = new System.Drawing.Point(11, 11);
            this.grbEMSpendingByDepartment.Name = "grbEMSpendingByDepartment";
            this.grbEMSpendingByDepartment.Size = new System.Drawing.Size(608, 153);
            this.grbEMSpendingByDepartment.TabIndex = 0;
            this.grbEMSpendingByDepartment.TabStop = false;
            this.grbEMSpendingByDepartment.Text = "groupBox1";
            // 
            // dgvEMSpendingByDepartment
            // 
            this.dgvEMSpendingByDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMSpendingByDepartment.Location = new System.Drawing.Point(13, 20);
            this.dgvEMSpendingByDepartment.Name = "dgvEMSpendingByDepartment";
            this.dgvEMSpendingByDepartment.Size = new System.Drawing.Size(583, 123);
            this.dgvEMSpendingByDepartment.TabIndex = 0;
            // 
            // grbMonthlyReportForMostUsedParts
            // 
            this.grbMonthlyReportForMostUsedParts.Controls.Add(this.dgvMonthlyReportForMostUsedParts);
            this.grbMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(11, 170);
            this.grbMonthlyReportForMostUsedParts.Name = "grbMonthlyReportForMostUsedParts";
            this.grbMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(608, 155);
            this.grbMonthlyReportForMostUsedParts.TabIndex = 1;
            this.grbMonthlyReportForMostUsedParts.TabStop = false;
            this.grbMonthlyReportForMostUsedParts.Text = "groupBox2";
            // 
            // dgvMonthlyReportForMostUsedParts
            // 
            this.dgvMonthlyReportForMostUsedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(13, 20);
            this.dgvMonthlyReportForMostUsedParts.Name = "dgvMonthlyReportForMostUsedParts";
            this.dgvMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(583, 126);
            this.dgvMonthlyReportForMostUsedParts.TabIndex = 0;
            // 
            // grbMonthlyReportOfCostlyAssets
            // 
            this.grbMonthlyReportOfCostlyAssets.Controls.Add(this.dgvMonthlyReportOfCostlyAssets);
            this.grbMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(11, 328);
            this.grbMonthlyReportOfCostlyAssets.Name = "grbMonthlyReportOfCostlyAssets";
            this.grbMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(608, 152);
            this.grbMonthlyReportOfCostlyAssets.TabIndex = 1;
            this.grbMonthlyReportOfCostlyAssets.TabStop = false;
            this.grbMonthlyReportOfCostlyAssets.Text = "groupBox3";
            // 
            // dgvMonthlyReportOfCostlyAssets
            // 
            this.dgvMonthlyReportOfCostlyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(13, 20);
            this.dgvMonthlyReportOfCostlyAssets.Name = "dgvMonthlyReportOfCostlyAssets";
            this.dgvMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(583, 126);
            this.dgvMonthlyReportOfCostlyAssets.TabIndex = 0;
            // 
            // chartDepartmentSpendingRatio
            // 
            chartArea5.Name = "ChartArea1";
            this.chartDepartmentSpendingRatio.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDepartmentSpendingRatio.Legends.Add(legend5);
            this.chartDepartmentSpendingRatio.Location = new System.Drawing.Point(9, 17);
            this.chartDepartmentSpendingRatio.Name = "chartDepartmentSpendingRatio";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDepartmentSpendingRatio.Series.Add(series5);
            this.chartDepartmentSpendingRatio.Size = new System.Drawing.Size(233, 219);
            this.chartDepartmentSpendingRatio.TabIndex = 2;
            this.chartDepartmentSpendingRatio.Text = "chart1";
            // 
            // chartMonthlyDepartmentSpending
            // 
            chartArea6.Name = "ChartArea1";
            this.chartMonthlyDepartmentSpending.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartMonthlyDepartmentSpending.Legends.Add(legend6);
            this.chartMonthlyDepartmentSpending.Location = new System.Drawing.Point(9, 17);
            this.chartMonthlyDepartmentSpending.Name = "chartMonthlyDepartmentSpending";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMonthlyDepartmentSpending.Series.Add(series6);
            this.chartMonthlyDepartmentSpending.Size = new System.Drawing.Size(233, 219);
            this.chartMonthlyDepartmentSpending.TabIndex = 3;
            this.chartMonthlyDepartmentSpending.Text = "chart2";
            // 
            // grbDepartmentSpendingRatio
            // 
            this.grbDepartmentSpendingRatio.Controls.Add(this.chartDepartmentSpendingRatio);
            this.grbDepartmentSpendingRatio.Location = new System.Drawing.Point(639, 11);
            this.grbDepartmentSpendingRatio.Name = "grbDepartmentSpendingRatio";
            this.grbDepartmentSpendingRatio.Size = new System.Drawing.Size(250, 245);
            this.grbDepartmentSpendingRatio.TabIndex = 4;
            this.grbDepartmentSpendingRatio.TabStop = false;
            this.grbDepartmentSpendingRatio.Text = "groupBox4";
            // 
            // grbMonthlyDepartmentSpending
            // 
            this.grbMonthlyDepartmentSpending.Controls.Add(this.chartMonthlyDepartmentSpending);
            this.grbMonthlyDepartmentSpending.Location = new System.Drawing.Point(639, 262);
            this.grbMonthlyDepartmentSpending.Name = "grbMonthlyDepartmentSpending";
            this.grbMonthlyDepartmentSpending.Size = new System.Drawing.Size(250, 245);
            this.grbMonthlyDepartmentSpending.TabIndex = 5;
            this.grbMonthlyDepartmentSpending.TabStop = false;
            this.grbMonthlyDepartmentSpending.Text = "groupBox5";
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnInventoryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryControl.Location = new System.Drawing.Point(24, 485);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(215, 31);
            this.btnInventoryControl.TabIndex = 6;
            this.btnInventoryControl.Text = "button1";
            this.btnInventoryControl.UseVisualStyleBackColor = false;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(245, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "button2";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(374, 495);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(53, 20);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "label1";
            // 
            // cboLaguage
            // 
            this.cboLaguage.FormattingEnabled = true;
            this.cboLaguage.Location = new System.Drawing.Point(480, 495);
            this.cboLaguage.Name = "cboLaguage";
            this.cboLaguage.Size = new System.Drawing.Size(140, 21);
            this.cboLaguage.TabIndex = 9;
            this.cboLaguage.SelectedIndexChanged += new System.EventHandler(this.cboLaguage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.grbEMSpendingByDepartment);
            this.panel1.Controls.Add(this.cboLaguage);
            this.panel1.Controls.Add(this.grbMonthlyReportForMostUsedParts);
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.grbMonthlyReportOfCostlyAssets);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.grbDepartmentSpendingRatio);
            this.panel1.Controls.Add(this.btnInventoryControl);
            this.panel1.Controls.Add(this.grbMonthlyDepartmentSpending);
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 530);
            this.panel1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(885, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.lblHeaderInventoryDashbroad);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 29);
            this.panel2.TabIndex = 13;
            // 
            // lblHeaderInventoryDashbroad
            // 
            this.lblHeaderInventoryDashbroad.AutoSize = true;
            this.lblHeaderInventoryDashbroad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderInventoryDashbroad.ForeColor = System.Drawing.Color.White;
            this.lblHeaderInventoryDashbroad.Location = new System.Drawing.Point(10, 8);
            this.lblHeaderInventoryDashbroad.Name = "lblHeaderInventoryDashbroad";
            this.lblHeaderInventoryDashbroad.Size = new System.Drawing.Size(51, 16);
            this.lblHeaderInventoryDashbroad.TabIndex = 12;
            this.lblHeaderInventoryDashbroad.Text = "label1";
            // 
            // frmInventoryDashbroad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(921, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryDashbroad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Dashbroad";
            this.Load += new System.EventHandler(this.frmInventoryDashbroad_Load);
            this.grbEMSpendingByDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMSpendingByDepartment)).EndInit();
            this.grbMonthlyReportForMostUsedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportForMostUsedParts)).EndInit();
            this.grbMonthlyReportOfCostlyAssets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportOfCostlyAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartmentSpendingRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyDepartmentSpending)).EndInit();
            this.grbDepartmentSpendingRatio.ResumeLayout(false);
            this.grbMonthlyDepartmentSpending.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEMSpendingByDepartment;
        private System.Windows.Forms.DataGridView dgvEMSpendingByDepartment;
        private System.Windows.Forms.GroupBox grbMonthlyReportForMostUsedParts;
        private System.Windows.Forms.DataGridView dgvMonthlyReportForMostUsedParts;
        private System.Windows.Forms.GroupBox grbMonthlyReportOfCostlyAssets;
        private System.Windows.Forms.DataGridView dgvMonthlyReportOfCostlyAssets;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartmentSpendingRatio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyDepartmentSpending;
        private System.Windows.Forms.GroupBox grbDepartmentSpendingRatio;
        private System.Windows.Forms.GroupBox grbMonthlyDepartmentSpending;
        private System.Windows.Forms.Button btnInventoryControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cboLaguage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeaderInventoryDashbroad;
    }
}

