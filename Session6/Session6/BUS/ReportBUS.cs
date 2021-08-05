using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ReportBUS
    {
        private ReportDAO _reportDAO = new ReportDAO();

        public List<int?> GetYearWithCompleteEMDAO()
        {
            return _reportDAO.GetYearWithCompleteEMDAO();
        }
        public List<DepartmentDTO> GetDepartmentBUS()
        {
            return _reportDAO.GetDepartmentDAO();
        }

        public List<int?> GetMonthWithCompleteEMInYearBUS(int year)
        {
            return _reportDAO.GetMonthWithCompleteEMInYearDAO(year);
        }

        public List<SpendingByDepartmentDTO> GetSpendingByDepartmentInTimeBUS(int month, int year)
        {
            return _reportDAO.GetSpendingByDepartmentInTimeDAO(month, year);
        }

        public List<HighestCost> GetHighestCost(int month, int year)
        {
            return _reportDAO.GetHighestCost(month, year);
        }

        public List<MostNumber> GetMostNumber(int month, int year)
        {
            return _reportDAO.GetMostNumber(month, year);
        }

        public List<CostlyAsset> GetCostlyAsset(int month, int year)
        {
            return _reportDAO.GetCostlyAsset(month, year);
        }
    }
}
