using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AssetDAO
    {

        private Session2Entities _ss2 = new Session2Entities();

        //Lấy danh sách 
        public List<AssetDTO> LayDS_EM()
        {
            return _ss2.Assets.Select(u => new AssetDTO
            {
                ID = u.ID,
                AssetGroupID = u.AssetGroupID,
                AssetName = u.AssetName,
                AssetSN = u.AssetSN,
                DepartmentLocationID = u.DepartmentLocationID,
                Description = u.Description,
                EmployeeID = u.EmployeeID,
                WarrantyDate = u.WarrantyDate
            }).ToList();
        }

        //Lấy danh sách EM cho frmEm_Management
        public List<EM> GetListEM()
        {
            return _ss2.SELECT_ALL_EM().Select(u => new EM {ID= u.ID, AssetName= u.AssetName, AssetSN= u.AssetSN, Department= u.Department, FullName= u.Employee_Full_Name, ReportDate= u.EMReportDate}).ToList();
        }

        //Lấy danh sách cho nhân viên
        public List<AssetEmloyee> GetlistAssets(long id)
        {
            return _ss2.Asset_Emloyees(id).Select(u => new AssetEmloyee {Department= u.Department, ID= u.ID, AssetName= u.AssetName, AssetSN= u.AssetSN, LastClosedEM= u.Last_Closed_EM, NumberOfEMs=u.Number_of_EMs.Value}).ToList();
        }
    }
}
