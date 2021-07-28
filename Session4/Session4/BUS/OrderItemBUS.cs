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

        ////////////////////////////
        public decimal GetCurrentStock(String wareHouse, String partName)
        {
            return _orderItem.GetCurrentStock(wareHouse, partName);
        }
        public bool EditOrderItem(long id, decimal amount)
        {
            return _orderItem.EditOrderItem(id,amount);
        }
        public bool RemoveOrderItem(long id)
        {
            return _orderItem.DeleteItem(id);
        }

        public bool CheckOrder(long part, string batchNumber)
        {
            return _orderItem.CheckOrder(part, batchNumber);
        }

        public bool CheckOrder2(long part, long order)
        {
            return _orderItem.CheckOrder2(part, order);
        }
    }
}
