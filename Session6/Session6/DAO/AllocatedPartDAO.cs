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
            return _ss6.GetPartNames(warehouse).Select(u => new PartDTO { ID = u.ID, NAME = u.NAME }).ToList();
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
                allocatedParts = _ss6.FIFO(warehouse).Where(v => v.ID == part).
                    Select(u => new AllocatedPartDTO {ID= u.ID, Amount= u.Amount, BatchNumber= u.BatchNumber, NAME=u.NAME, UnitPrice= u.UnitPrice}).ToList();
            }
            else
                if (method == 1)
            {
                allocatedParts = _ss6.LIFO(warehouse).Where(v => v.ID == part).
                    Select(u => new AllocatedPartDTO { ID = u.ID, Amount = u.Amount, BatchNumber = u.BatchNumber, NAME = u.NAME, UnitPrice = u.UnitPrice }).ToList();
            }
            else
            {
                allocatedParts = _ss6.MinimumFirst(warehouse).Where(v => v.ID == part).
                    Select(u => new AllocatedPartDTO { ID = u.ID, Amount = u.Amount, BatchNumber = u.BatchNumber, NAME = u.NAME, UnitPrice = u.UnitPrice }).ToList();
            }

            return allocatedParts;
        }
    }
}
