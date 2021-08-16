using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SpendingRatioDAO
    {
        Session6Entities _ss6 = new Session6Entities();

        public List<SpendingRatioDTO> GetSpendingRatio(int year)
        {
            return _ss6.SpendingRatio(year).Select(u => new SpendingRatioDTO { Name = u.Name, Money = u.Money }).ToList();
        }

        public List<MonthlySpendingDTO> GetMonthlySpending(int year)
        {
            return _ss6.MonthlySpending(year).Select(u => new MonthlySpendingDTO { Money = u.Money, Month = u.Moth, Name = u.Name }).ToList();
        }
    }
}
