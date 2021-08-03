using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SpendingInTimeDAO
    {
        Session6Entities _ss6 = new Session6Entities();
        public List<SpendingInTimeDTO> GetSpendingInTime(int month,int year)
        {
            return _ss6.GetSpendingByDepartmentInTime(month, year).Select(u=>new SpendingInTimeDTO 
            { ID = u.ID, Name = u.Name, SumSpendingByDepartment = u.SumSpendingByDepartment }).ToList();
        }
        public decimal GetMaxSpendingInTime(int month, int year)
        {
            return _ss6.GetMaxSpendInTime(month, year).FirstOrDefault().GetValueOrDefault();
        }
        public decimal GetMinSpendingInTime(int month, int year)
        {
            return _ss6.GetMinSpendInTime(month, year).FirstOrDefault().GetValueOrDefault();
        }


    }
}
