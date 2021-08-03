using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ReportDAO
    {
        Session6Entities _ss6 = new Session6Entities();

        public List<int?> GetYearWithCompleteEMDAO()
        {
            return _ss6.GetYearWithCompleteEM().ToList();
        }
        public List<DepartmentDTO> GetDepartmentDAO(int year)
        {
            return _ss6.GetDepartment().Select(u => new DepartmentDTO { ID = u.ID, Name = u.Name }).ToList();

        }

        public List<int?> GetMonthWithCompleteEMInYearDAO(int year)
        {
            return _ss6.GetMonthWithCompleteEMInYear(year).ToList();
        }

        public List<SpendingByDepartmentDTO> GetSpendingByDepartmentInTimeDAO(int month, int year)
        {
            return _ss6.GetSpendingByDepartmentInTime(month, year).Select(u=>new SpendingByDepartmentDTO 
            {ID=u.ID,Name=u.Name,SumSpendingByDepartment=u.SumSpendingByDepartment }).ToList();
        }
    }
}
