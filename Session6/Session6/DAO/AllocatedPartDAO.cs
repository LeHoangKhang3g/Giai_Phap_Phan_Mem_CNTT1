using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class AllocatedPartDAO
    {
        Session6Entities _ss6 = new Session6Entities();

        public List<PartDTO> GetParts(long warehouse)
        {
            return _ss6.Get_PartName(warehouse).Select(u => new PartDTO { ID = u.PARTID, NAME = u.Name }).ToList();
        }
        public List<WarehouseDTO> GetWarehouse()
        {
            return _ss6.Warehouse().Select(u => new WarehouseDTO { ID = u.ID, Name= u.Name }).ToList();
        }

        public List<AssetDTO> GetAsset()
        {
            return _ss6.AssetNames().Select(u => new AssetDTO { ID = u.ID, NAME = u.AssetName }).ToList();
        }

        public List<AllocatedPartDTO> ListAllocatedPart(int method, long warehouse, long part)
        {
            List<AllocatedPartDTO> allocatedParts = new List<AllocatedPartDTO>();

            if(method == 0)
            {
                allocatedParts = _ss6.FI_FO(warehouse).Where(v => v.PARTID == part).
                    Select(u => new AllocatedPartDTO { ID = u.PARTID, Amount = u.Amount, BatchNumber = u.BatchNumber, NAME = u.Name, UnitPrice = u.UnitPrice }).ToList();
            }
            else
                if (method == 1)
            {
                allocatedParts = _ss6.LI_FO(warehouse).Where(v => v.PARTID == part).
                    Select(u => new AllocatedPartDTO { ID = u.PARTID, Amount = u.Amount, BatchNumber = u.BatchNumber, NAME = u.Name, UnitPrice = u.UnitPrice }).ToList();
            }
            else
            {
                allocatedParts = _ss6.Minimum_First(warehouse).Where(v => v.PARTID == part).
                    Select(u => new AllocatedPartDTO { ID = u.PARTID, Amount = u.Amount, BatchNumber = u.BatchNumber, NAME = u.Name, UnitPrice = u.UnitPrice }).ToList();
            }

            return allocatedParts;
        }
    }
}
