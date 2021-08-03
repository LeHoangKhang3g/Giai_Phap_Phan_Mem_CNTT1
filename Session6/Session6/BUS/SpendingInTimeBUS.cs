using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SpendingInTimeBUS
    {
        SpendingInTimeDAO spendingInTimeDAO = new SpendingInTimeDAO();
        public List<SpendingInTimeDTO> GetSpendingInTime(int month, int year)
        {
            return spendingInTimeDAO.GetSpendingInTime(month, year);
        }
        public decimal GetMaxSpendingInTime(int month, int year)
        {
            return spendingInTimeDAO.GetMaxSpendingInTime(month, year);
        }
        public decimal GetMinSpendingInTime(int month, int year)
        {
            return spendingInTimeDAO.GetMinSpendingInTime(month, year);
        }
    }
}
