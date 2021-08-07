
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grbEMSpendingByDepartment = new System.Windows.Forms.GroupBox();
            this.dgvEMSpendingByDepartment = new System.Windows.Forms.DataGridView();
            this.grbMonthlyReportForMostUsedParts = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportForMostUsedParts = new System.Windows.Forms.DataGridView();
            this.grbMonthlyReportOfCostlyAssets = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportOfCostlyAssets = new System.Windows.Forms.DataGridView();
            this.chartSpendingRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlySpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbDepartmentSpendingRatio = new System.Windows.Forms.GroupBox();
            this.grbMonthlyDepartmentSpending = new System.Windows.Forms.GroupBox();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbbLaguage = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbYearToReport = new System.Windows.Forms.ComboBox();
            this.lblYearToReport = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeaderInventoryDashbroad = new System.Windows.Forms.Label();
            this.grbEMSpendingByDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMSpendingByDepartment)).BeginInit();
            this.grbMonthlyReportForMostUsedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportForMostUsedParts)).BeginInit();
            this.grbMonthlyReportOfCostlyAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportOfCostlyAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpendingRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySpending)).BeginInit();
            this.grbDepartmentSpendingRatio.SuspendLayout();
            this.grbMonthlyDepartmentSpending.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEMSpendingByDepartment
            // 
            this.grbEMSpendingByDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEMSpendingByDepartment.Controls.Add(this.dgvEMSpendingByDepartment);
            this.grbEMSpendingByDepartment.Location = new System.Drawing.Point(11, 45);
            this.grbEMSpendingByDepartment.Name = "grbEMSpendingByDepartment";
            this.grbEMSpendingByDepartment.Size = new System.Drawing.Size(537, 153);
            this.grbEMSpendingByDepartment.TabIndex = 0;
            this.grbEMSpendingByDepartment.TabStop = false;
            this.grbEMSpendingByDepartment.Text = "groupBox1";
            // 
            // dgvEMSpendingByDepartment
            // 
            this.dgvEMSpendingByDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEMSpendingByDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEMSpendingByDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMSpendingByDepartment.Location = new System.Drawing.Point(19, 19);
            this.dgvEMSpendingByDepartment.Name = "dgvEMSpendingByDepartment";
            this.dgvEMSpendingByDepartment.ReadOnly = true;
            this.dgvEMSpendingByDepartment.Size = new System.Drawing.Size(512, 123);
            this.dgvEMSpendingByDepartment.TabIndex = 0;
            // 
            // grbMonthlyReportForMostUsedParts
            // 
            this.grbMonthlyReportForMostUsedParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMonthlyReportForMostUsedParts.Controls.Add(this.dgvMonthlyReportForMostUsedParts);
            this.grbMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(11, 204);
            this.grbMonthlyReportForMostUsedParts.Name = "grbMonthlyReportForMostUsedParts";
            this.grbMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(537, 155);
            this.grbMonthlyReportForMostUsedParts.TabIndex = 1;
            this.grbMonthlyReportForMostUsedParts.TabStop = false;
            this.grbMonthlyReportForMostUsedParts.Text = "groupBox2";
            // 
            // dgvMonthlyReportForMostUsedParts
            // 
            this.dgvMonthlyReportForMostUsedParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonthlyReportForMostUsedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMonthlyReportForMostUsedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(13, 20);
            this.dgvMonthlyReportForMostUsedParts.Name = "dgvMonthlyReportForMostUsedParts";
            this.dgvMonthlyReportForMostUsedParts.ReadOnly = true;
            this.dgvMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(512, 126);
            this.dgvMonthlyReportForMostUsedParts.TabIndex = 0;
            // 
            // grbMonthlyReportOfCostlyAssets
            // 
            this.grbMonthlyReportOfCostlyAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMonthlyReportOfCostlyAssets.Controls.Add(this.dgvMonthlyReportOfCostlyAssets);
            this.grbMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(11, 362);
            this.grbMonthlyReportOfCostlyAssets.Name = "grbMonthlyReportOfCostlyAssets";
            this.grbMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(537, 152);
            this.grbMonthlyReportOfCostlyAssets.TabIndex = 1;
            this.grbMonthlyReportOfCostlyAssets.TabStop = false;
            this.grbMonthlyReportOfCostlyAssets.Text = "groupBox3";
            // 
            // dgvMonthlyReportOfCostlyAssets
            // 
            this.dgvMonthlyReportOfCostlyAssets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonthlyReportOfCostlyAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMonthlyReportOfCostlyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(13, 20);
            this.dgvMonthlyReportOfCostlyAssets.Name = "dgvMonthlyReportOfCostlyAssets";
            this.dgvMonthlyReportOfCostlyAssets.ReadOnly = true;
            this.dgvMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(512, 126);
            this.dgvMonthlyReportOfCostlyAssets.TabIndex = 0;
            // 
            // chartSpendingRatio
            // 
            this.chartSpendingRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartSpendingRatio.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpendingRatio.Legends.Add(legend1);
            this.chartSpendingRatio.Location = new System.Drawing.Point(6, 17);
            this.chartSpendingRatio.Name = "chartSpendingRatio";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SpendingRatio";
            this.chartSpendingRatio.Series.Add(series1);
            this.chartSpendingRatio.Size = new System.Drawing.Size(321, 219);
            this.chartSpendingRatio.TabIndex = 2;
            this.chartSpendingRatio.Text = "chart1";
            // 
            // chartMonthlySpending
            // 
            this.chartMonthlySpending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartMonthlySpending.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonthlySpending.Legends.Add(legend2);
            this.chartMonthlySpending.Location = new System.Drawing.Point(6, 17);
            this.chartMonthlySpending.Name = "chartMonthlySpending";
            this.chartMonthlySpending.Size = new System.Drawing.Size(321, 219);
            this.chartMonthlySpending.TabIndex = 3;
            this.chartMonthlySpending.Text = "chart2";
            // 
            // grbDepartmentSpendingRatio
            // 
            this.grbDepartmentSpendingRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDepartmentSpendingRatio.Controls.Add(this.chartSpendingRatio);
            this.grbDepartmentSpendingRatio.Location = new System.Drawing.Point(554, 45);
            this.grbDepartmentSpendingRatio.Name = "grbDepartmentSpendingRatio";
            this.grbDepartmentSpendingRatio.Size = new System.Drawing.Size(335, 245);
            this.grbDepartmentSpendingRatio.TabIndex = 4;
            this.grbDepartmentSpendingRatio.TabStop = false;
            this.grbDepartmentSpendingRatio.Text = "groupBox4";
            // 
            // grbMonthlyDepartmentSpending
            // 
            this.grbMonthlyDepartmentSpending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMonthlyDepartmentSpending.Controls.Add(this.chartMonthlySpending);
            this.grbMonthlyDepartmentSpending.Location = new System.Drawing.Point(554, 296);
            this.grbMonthlyDepartmentSpending.Name = "grbMonthlyDepartmentSpending";
            this.grbMonthlyDepartmentSpending.Size = new System.Drawing.Size(335, 245);
            this.grbMonthlyDepartmentSpending.TabIndex = 5;
            this.grbMonthlyDepartmentSpending.TabStop = false;
            this.grbMonthlyDepartmentSpending.Text = "groupBox5";
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInventoryControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.btnInventoryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryControl.Location = new System.Drawing.Point(24, 519);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(215, 31);
            this.btnInventoryControl.TabIndex = 6;
            this.btnInventoryControl.Text = "button1";
            this.btnInventoryControl.UseVisualStyleBackColor = false;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(245, 519);
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
            this.lblLanguage.Location = new System.Drawing.Point(373, 18);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(53, 20);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "label1";
            // 
            // cbbLaguage
            // 
            this.cbbLaguage.FormattingEnabled = true;
            this.cbbLaguage.Location = new System.Drawing.Point(479, 18);
            this.cbbLaguage.Name = "cbbLaguage";
            this.cbbLaguage.Size = new System.Drawing.Size(140, 21);
            this.cbbLaguage.TabIndex = 9;
            this.cbbLaguage.SelectedIndexChanged += new System.EventHandler(this.cboLaguage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbbYearToReport);
            this.panel1.Controls.Add(this.lblYearToReport);
            this.panel1.Controls.Add(this.grbEMSpendingByDepartment);
            this.panel1.Controls.Add(this.cbbLaguage);
            this.panel1.Controls.Add(this.grbMonthlyReportForMostUsedParts);
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.grbMonthlyReportOfCostlyAssets);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.grbDepartmentSpendingRatio);
            this.panel1.Controls.Add(this.btnInventoryControl);
            this.panel1.Controls.Add(this.grbMonthlyDepartmentSpending);
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 562);
            this.panel1.TabIndex = 10;
            // 
            // cbbYearToReport
            // 
            this.cbbYearToReport.FormattingEnabled = true;
            this.cbbYearToReport.Location = new System.Drawing.Point(166, 18);
            this.cbbYearToReport.Name = "cbbYearToReport";
            this.cbbYearToReport.Size = new System.Drawing.Size(140, 21);
            this.cbbYearToReport.TabIndex = 11;
            this.cbbYearToReport.SelectedIndexChanged += new System.EventHandler(this.cbbYearToReport_SelectedIndexChanged);
            // 
            // lblYearToReport
            // 
            this.lblYearToReport.AutoSize = true;
            this.lblYearToReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearToReport.Location = new System.Drawing.Point(20, 16);
            this.lblYearToReport.Name = "lblYearToReport";
            this.lblYearToReport.Size = new System.Drawing.Size(53, 20);
            this.lblYearToReport.TabIndex = 10;
            this.lblYearToReport.Text = "label1";
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
            this.ClientSize = new System.Drawing.Size(921, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
            ((System.ComponentModel.ISupportInitialize)(this.chartSpendingRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySpending)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpendingRatio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlySpending;
        private System.Windows.Forms.GroupBox grbDepartmentSpendingRatio;
        private System.Windows.Forms.GroupBox grbMonthlyDepartmentSpending;
        private System.Windows.Forms.Button btnInventoryControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbbLaguage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeaderInventoryDashbroad;
        private System.Windows.Forms.ComboBox cbbYearToReport;
        private System.Windows.Forms.Label lblYearToReport;
    }
}

