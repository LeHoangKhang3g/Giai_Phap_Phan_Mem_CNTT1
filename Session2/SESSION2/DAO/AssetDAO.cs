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
            return _ss2.SELECT_EM().Select(u => new EM { AssetSN = u.ASSETSN, AssetName = u.ASSETNAME, WarrantyDate = u.WarrantyDate, FirstName = u.FirstName, LastName = u.LastName, Name = u.Name }).ToList();
        }

        //Lấy danh sách cho nhân viên
        public List<AssetEmloyee> GetlistAssets(long id)
        {
            return _ss2.AssetOfEmloyee(id).Select(u => new AssetEmloyee {Department= u.Department, ID= u.ID, AssetName= u.AssetName, AssetSN= u.AssetSN, LastClosedEM= u.Last_Closed_EM, NumberOfEMs=u.Number_of_EMs.Value}).ToList();
        }
    }
}
