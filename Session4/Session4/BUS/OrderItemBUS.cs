using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class OrderItemBUS
    {
        private OrderItemDAO _orderItem= new OrderItemDAO();
        public bool AddOrderItem(long order, long part, string batchnumber, decimal amount)
        {
            return _orderItem.AddOrderItem(order, part, batchnumber, amount);
        }

        public List<OrderItemDTO> ListItem(long id)
        {
            return _orderItem.ListItem(id);
        }

        public bool DeleteItem(long id)
        {
            return _orderItem.DeleteItem(id);
        }
    }
}
