using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class OrderItemDAO
    {
        private Session4Entities _ss4 = new Session4Entities();

        public bool AddOrderItem(long order, long part, string batchnumber, decimal amount)
        {
            int kq= _ss4.AddOrderItem(order, part, batchnumber, amount);
             return kq>0;
        }

        public List<OrderItemDTO> ListItem(long id)
        {
            return _ss4.Items_Order(id).Select(u => new OrderItemDTO { BatchNumber = u.BatchNumber, Amount = u.Amount, Name = u.Name, ID= u.ID}).ToList();
        }

        public bool DeleteItem(long id)
        {
            int kq = _ss4.DeleteOrderItem(id);
            return kq > 0;
        }
    }
}
