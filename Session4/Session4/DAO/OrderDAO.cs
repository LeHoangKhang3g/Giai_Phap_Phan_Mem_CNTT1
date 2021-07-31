using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class OrderDAO
    {
        Session4Entities _ss4 = new Session4Entities();

        public bool AddOrder(long transaction, long source, long destination, DateTime date)
        {
            int kq= _ss4.AddOrder2(transaction, source, destination, date);

            return kq > 0 ;
        }

        public bool AddOrder2(long transaction, long supplier, long destination, DateTime date)
        {
            int kq = _ss4.AddOrder(transaction, supplier, destination, date);

            return kq > 0;
        }
        public long Max ()
        {
            return Int64.Parse(_ss4.Orders.Max(u=> u.ID).ToString());
        }

        public void DeleteOrder(long id)
        {
            _ss4.DeleteOrder(id);
        }

        public OrderDTO SelectOrder(long id)
        {
            Order order = _ss4.Orders.SingleOrDefault(u => u.ID == id);

            OrderDTO orderDTO = new OrderDTO()
            {
                ID= order.ID,
                TransactionTypeID= order.TransactionTypeID,
                SupplierID= order.SupplierID,
                SourceWarehouseID= order.SourceWarehouseID,
                DestinationWarehouseID= order.DestinationWarehouseID,
                Date= order.Date
            };

            return orderDTO;
        }
    }
}
