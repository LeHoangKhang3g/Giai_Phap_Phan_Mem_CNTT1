using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmInventoryDashbroad : Form
    {
        private AssetBUS asset = new AssetBUS();
        private ReportBUS reportBUS = new ReportBUS();
        private SpendingInTimeBUS spendingInTimeBUS = new SpendingInTimeBUS();
        private CultureInfo culture;
        private List<DepartmentDTO> departmentDTOs;
        private List<int?> months;
        private SpendingRatioBUS spendingRatio = new SpendingRatioBUS();

        public static String languageSelect;
        public static int yearSelect;
        public frmInventoryDashbroad()
        {
            InitializeComponent();
        }
        private void frmInventoryDashbroad_Load(object sender, EventArgs e)
        {
            cbbYearToReport.DataSource = reportBUS.GetYearWithCompleteEMDAO();
            cbbYearToReport.SelectedIndex = 0;
            cbbLaguage.Items.Add("vi-VN");
            cbbLaguage.Items.Add("en-US");
            cbbLaguage.SelectedIndex = 0;
            languageSelect = cbbLaguage.SelectedItem.ToString();
            SetLanguage(languageSelect);
        }
        private void SetLanguage(String cultureName)
        {
            culture = CultureInfo.GetCultureInfo(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Properties.Resources", typeof(frmInventoryControl).Assembly);

            lblYearToReport.Text = rm.GetString("Year to Report:", culture);
            lblHeaderInventoryDashbroad.Text = rm.GetString("Inventory Dashbroad", culture);
            lblLanguage.Text = rm.GetString("Language:", culture);
            btnInventoryControl.Text = rm.GetString("Inventory Control", culture);
            btnClose.Text = rm.GetString("Close", culture);
            grbEMSpendingByDepartment.Text = rm.GetString("EM Spending by Department", culture);
            grbDepartmentSpendingRatio.Text = rm.GetString("Department Spending Ratio", culture);
            grbMonthlyDepartmentSpending.Text = rm.GetString("Monthly Department Spending", culture);
            grbMonthlyReportForMostUsedParts.Text = rm.GetString("Monthly Report for Most-Used Parts", culture);
            grbMonthlyReportOfCostlyAssets.Text = rm.GetString("Monthly Report of Costly Assets", culture);

        }
        private void btnInventoryControl_Click(object sender, EventArgs e)
        {
            frmInventoryControl fInventoryControl = new frmInventoryControl();
            this.Hide();
            fInventoryControl.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLaguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                languageSelect = cbbLaguage.SelectedItem.ToString();
                SetLanguage(languageSelect);
            }
            catch
            {
                return;
            }
        }

        private void cbbYearToReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                yearSelect = (int)cbbYearToReport.SelectedItem;
                departmentDTOs = reportBUS.GetDepartmentBUS();
                months = reportBUS.GetMonthWithCompleteEMInYearBUS(yearSelect);

                //dgvEMSpendingByDepartment 
                dgvEMSpendingByDepartment.Columns.Clear();
                dgvEMSpendingByDepartment.Rows.Clear();

                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = "Department";
                column.HeaderText = "Department / Month";
                dgvEMSpendingByDepartment.Columns.Add(column);

                dgvEMSpendingByDepartment.DataSource = null;

                //dgvMonthlyReportForMostUsedParts
                dgvMonthlyReportForMostUsedParts.Columns.Clear();
                dgvMonthlyReportForMostUsedParts.Rows.Clear();

                DataGridViewColumn col_ = new DataGridViewTextBoxColumn();
                col_.Name = "Notes";
                col_.HeaderText = "Notes / Month";
                dgvMonthlyReportForMostUsedParts.Columns.Add(col_);

                dgvMonthlyReportForMostUsedParts.DataSource = null;

                //dgvMonthlyReportOfCostlyAssets
                dgvMonthlyReportOfCostlyAssets.Columns.Clear();
                dgvMonthlyReportOfCostlyAssets  .Rows.Clear();

                DataGridViewColumn col_2 = new DataGridViewTextBoxColumn();
                col_2.Name = "AssetName";
                col_2.HeaderText = "Asset Name / Month";
                dgvMonthlyReportOfCostlyAssets.Columns.Add(col_2);

                dgvMonthlyReportOfCostlyAssets.DataSource = null;

                //Add columns
                foreach(var month in months)
                {
                    //dgvEMSpendingByDepartment
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.Name = "col"+yearSelect.ToString() + "-" + month.ToString();
                    col.HeaderText= yearSelect.ToString() + "-" + month.ToString();
                    dgvEMSpendingByDepartment.Columns.Add(col);

                    //dgvMonthlyReportForMostUsedParts
                    DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                    col2.Name = "col" + yearSelect.ToString() + "-" + month.ToString();
                    col2.HeaderText = yearSelect.ToString() + "-" + month.ToString();
                    dgvMonthlyReportForMostUsedParts.Columns.Add(col2);

                    //dgvMonthlyReportOfCostlyAssets
                    DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                    col3.Name = "col" + yearSelect.ToString() + "-" + month.ToString();
                    col3.HeaderText = yearSelect.ToString() + "-" + month.ToString();
                    dgvMonthlyReportOfCostlyAssets.Columns.Add(col3);
                }

                //Add rows and cells dgvEMSpendingByDepartment
                foreach(DepartmentDTO department in departmentDTOs)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCell c = new DataGridViewTextBoxCell();
                    c.Value = department.Name;
                    row.Cells.Insert(0, c);
                    dgvEMSpendingByDepartment.Rows.Add(row);
                }
                foreach (int i in months)
                {
                    List<SpendingInTimeDTO> spendingInTimeDTOs = spendingInTimeBUS.GetSpendingInTime(i, yearSelect);
                    decimal maxSpending = spendingInTimeBUS.GetMaxSpendingInTime(i,yearSelect);
                    decimal minSpending = spendingInTimeBUS.GetMinSpendingInTime(i, yearSelect);
                    foreach (DepartmentDTO j in departmentDTOs)
                    {
                        DataGridViewCell c = new DataGridViewTextBoxCell();
                        decimal spending = spendingInTimeDTOs[departmentDTOs.IndexOf(j)].SumSpendingByDepartment.GetValueOrDefault();
                        if(spending==minSpending)
                        {
                            c.Style.ForeColor = Color.Red;
                        }
                        if (spending == maxSpending)
                        {
                            c.Style.ForeColor = Color.Green;
                        }
                        c.Value = spending;
                        dgvEMSpendingByDepartment.Rows[departmentDTOs.IndexOf(j)].Cells[months.IndexOf(i) + 1] = c;
                    }
                }
                //Add rows and cells dgvMonthlyReportForMostUsedParts
                DataGridViewRow row1 = new DataGridViewRow();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();

                cell1.Value = "Highest Cost";
                row1.Cells.Insert(0, cell1);
                dgvMonthlyReportForMostUsedParts.Rows.Add(row1);

                DataGridViewRow row2 = new DataGridViewRow();
                DataGridViewCell cell2 = new DataGridViewTextBoxCell();

                cell2.Value = "Most Number";
                row2.Cells.Insert(0, cell2);
                dgvMonthlyReportForMostUsedParts.Rows.Add(row2);

                foreach (int i in months)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();

                        cell.Value = "";
                        if (j == 0)
                        {
                            List<HighestCost> highestCost = new List<HighestCost>();

                            highestCost = reportBUS.GetHighestCost(i, yearSelect);

                            foreach (HighestCost highest in highestCost)
                            {
                                cell.Value += highest.Name + ", ";
                            }
                        }
                        else
                        {
                            List<MostNumber> mostNumber = new List<MostNumber>();

                            mostNumber = reportBUS.GetMostNumber(i, yearSelect);

                            foreach (MostNumber most in mostNumber)
                            {
                                cell.Value += most.Name + ", ";
                            }
                        }
                        cell.Value = cell.Value.ToString().Remove(cell.Value.ToString().Length - 2);//Bỏ dấu phẩy thừa
                        dgvMonthlyReportForMostUsedParts.Rows[j].Cells[months.IndexOf(i) + 1] = cell;
                    }

                }

                //Add rows and cells dgvMonthlyReportOfCostlyAssets
                DataGridViewRow row1_ = new DataGridViewRow();
                DataGridViewCell cell1_ = new DataGridViewTextBoxCell();

                cell1_.Value = "Asset";
                row1_.Cells.Insert(0, cell1_);
                dgvMonthlyReportOfCostlyAssets.Rows.Add(row1_);

                DataGridViewRow row2_ = new DataGridViewRow();
                DataGridViewCell cell2_ = new DataGridViewTextBoxCell();

                cell2_.Value = "Department";
                row2_.Cells.Insert(0, cell2_);
                dgvMonthlyReportOfCostlyAssets.Rows.Add(row2_);

                foreach (int i in months)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();

                        cell.Value = "";
                        if (j == 0)
                        {
                            List<CostlyAsset> costlyAsset = new List<CostlyAsset>();

                            costlyAsset = reportBUS.GetCostlyAsset(i, yearSelect);

                            foreach (CostlyAsset cost in costlyAsset)
                            {
                                cell.Value += cost.AssetName + ", ";
                            }
                        }
                        else
                        {
                            List<CostlyAsset> costlyAsset = new List<CostlyAsset>();

                            costlyAsset = reportBUS.GetCostlyAsset(i, yearSelect);

                            foreach (CostlyAsset cost in costlyAsset)
                            {
                                cell.Value += cost.Department + ", ";
                            }
                        }
                        cell.Value = cell.Value.ToString().Remove(cell.Value.ToString().Length - 2);//Bỏ dấu phẩy thừa
                       dgvMonthlyReportOfCostlyAssets.Rows[j].Cells[months.IndexOf(i) + 1] = cell;
                    }

                }
                //Bieu do
                chartSpendingRatio.DataSource = spendingRatio.GetSpendingRatio(yearSelect);

                chartSpendingRatio.Series["SpendingRatio"].XValueMember = "Name";
                chartSpendingRatio.Series["SpendingRatio"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartSpendingRatio.Series["SpendingRatio"].YValueMembers = "Money";
                chartSpendingRatio.Series["SpendingRatio"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                List<MonthlySpendingDTO> monthlySpending = new List<MonthlySpendingDTO>();

                monthlySpending = spendingRatio.GetMonthlySpending(yearSelect);

                DataTable table = new DataTable();
                DataColumn columns;
                DataRow rows;

                columns = new DataColumn();
                columns.ColumnName = "Name";
                table.Columns.Add(columns);
                columns = new DataColumn();
                columns.ColumnName = "Month";
                table.Columns.Add(columns);

                columns = new DataColumn();
                columns.ColumnName = "Money";
                table.Columns.Add(columns);

                foreach (MonthlySpendingDTO monthly in monthlySpending)
                {
                    rows = table.NewRow();
                    rows["Name"] = monthly.Name;
                    rows["Month"] = monthly.Month;
                    rows["Money"] = monthly.Money;
                    table.Rows.Add(rows);
                }

                chartMonthlySpending.DataBindCrossTable(table.DefaultView, "Name", "Month", "Money", "");
                
            }
            catch
            {
                return;
            }
        }
    }
}
