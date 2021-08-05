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
        public List<DepartmentDTO> GetDepartmentDAO()
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

        public List<HighestCost> GetHighestCost(int month, int year)
        {
            return _ss6.HighestCosts(month, year).Select(u=> new HighestCost{Name= u.Name, Column1= u.Money.Value}).ToList();
        }

        public List<MostNumber> GetMostNumber(int month, int year)
        {
            return _ss6.MostNumbers(month, year).Select(u => new MostNumber { ID = u.ID, Column1 = u.Count.Value, Name = u.Name }).ToList();
        }

        public List<CostlyAsset> GetCostlyAsset(int month, int year)
        {
            return _ss6.CostlyAssets(month, year).Select(u=> new CostlyAsset{Department= u.Department, AssetName= u.AssetName, Money= u.Money}).ToList();
        }
    }
}
