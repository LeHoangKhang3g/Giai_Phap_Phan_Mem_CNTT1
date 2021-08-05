using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SpendingRatioBUS
    {
        SpendingRatioDAO spending = new SpendingRatioDAO();

        public List<SpendingRatioDTO> GetSpendingRatio(int year)
        {
            return spending.GetSpendingRatio(year);
        }

        public List<MonthlySpendingDTO> GetMonthlySpending(int year)
        {
            return spending.GetMonthlySpending(year);
        }
    }
}
