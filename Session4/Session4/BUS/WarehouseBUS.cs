using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class WarehouseBUS
    {
        private WarehouseDAO _ware = new WarehouseDAO();
        public List<WarehouseDTO> GetAllWarehouse()
        {
            return _ware.GetAllWarehouse();
        }
    }
}
