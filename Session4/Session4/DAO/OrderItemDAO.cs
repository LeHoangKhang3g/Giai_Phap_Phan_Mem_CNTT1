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

        public decimal GetCurrentStock(String wareHouse, String partName)
        {
            long wareHouseID = _ss4.Warehouses.SingleOrDefault(u => u.Name.Equals(wareHouse)).ID;
            long partID=_ss4.Parts.SingleOrDefault(u=>u.Name.Equals(partName)).ID;
            decimal receivedStock = (decimal)_ss4.RECEIVED_STOCK_2(wareHouseID, partID).FirstOrDefault().GetValueOrDefault();
            decimal outOfStock = (decimal)_ss4.OUT_OF_STOCK_2(wareHouseID, partID).FirstOrDefault().GetValueOrDefault();
            return receivedStock - outOfStock;
        }
        public bool EditOrderItem(long id, decimal amount)
        {
            try
            {
                _ss4.EditOrderItem(id, amount);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
