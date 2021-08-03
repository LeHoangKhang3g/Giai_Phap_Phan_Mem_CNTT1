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
                departmentDTOs = reportBUS.GetDepartmentBUS(yearSelect);
                months = reportBUS.GetMonthWithCompleteEMInYearBUS(yearSelect);

                dgvEMSpendingByDepartment.Columns.Clear();
                dgvEMSpendingByDepartment.Rows.Clear();

                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = "Department";
                column.HeaderText = "Department / Month";
                dgvEMSpendingByDepartment.Columns.Add(column);

                dgvEMSpendingByDepartment.DataSource = null;
                foreach(var month in months)
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.Name = "col"+yearSelect.ToString() + "-" + month.ToString();
                    col.HeaderText= yearSelect.ToString() + "-" + month.ToString();
                    dgvEMSpendingByDepartment.Columns.Add(col);
                }
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
                            //Đổi màu đỏ
                        }
                        if (spending == maxSpending)
                        {
                            //Đổi màu xanh
                        }
                        c.Value = spending;
                        dgvEMSpendingByDepartment.Rows[departmentDTOs.IndexOf(j)].Cells[months.IndexOf(i) + 1] = c;
                        
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
