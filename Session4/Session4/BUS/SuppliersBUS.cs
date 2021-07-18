using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SuppliersBUS
    {
        private SuppliersDAO _supp = new SuppliersDAO();

        public List<SuppliersDTO> GetAllSuppliers()
        {
            return _supp.GetAllSuppliers();
        }
    }
}
