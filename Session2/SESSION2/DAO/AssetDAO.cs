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
    }
}
