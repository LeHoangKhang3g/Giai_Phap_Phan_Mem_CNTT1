using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class AllocatedPartBUS
    {
        private AllocatedPartDAO _allocated = new AllocatedPartDAO();

        public List<PartDTO> GetParts(long warehouse)
        {
            return _allocated.GetParts(warehouse);
        }

        public List<WarehouseDTO> GetWarehouse()
        {
            return _allocated.GetWarehouse();
        }

        public List<AssetDTO> GetAsset()
        {
            return _allocated.GetAsset();
        }

        public List<AllocatedPartDTO> ListAllocatedPart(int method, long warehouse, long part)
        {
            return _allocated.ListAllocatedPart(method, warehouse, part);
        }
    }
}
