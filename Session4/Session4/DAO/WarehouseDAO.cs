using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class WarehouseDAO
    {
        private Session4Entities _ss4 = new Session4Entities();

        public List<WarehouseDTO> GetAllWarehouse()
        {
            return _ss4.Warehouses.Select(u => new WarehouseDTO { ID = u.ID, Name = u.Name }).ToList();
        }
        
    }
}
