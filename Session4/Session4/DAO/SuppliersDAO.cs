using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SuppliersDAO
    {
        private Session4Entities _ss4 = new Session4Entities();

        public List<SuppliersDTO> GetAllSuppliers()
        {
            return _ss4.Suppliers.Select(u => new SuppliersDTO {ID= u.ID, Name= u.Name}).ToList();
        }
    }
}
