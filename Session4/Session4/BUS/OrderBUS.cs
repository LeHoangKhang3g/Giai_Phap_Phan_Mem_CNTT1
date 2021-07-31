using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class OrderBUS
    {
        OrderDAO _order = new OrderDAO();

        public bool AddOrder(long transaction, long source, long destination, DateTime date)
        {
            return _order.AddOrder(transaction, source, destination, date);
        }

        public bool AddOrder2(long transaction, long supplier, long destination, DateTime date)
        {
            return _order.AddOrder2(transaction, supplier, destination, date);
        }
        public long Max()
        {
            return _order.Max();
        }

        public void DeleteOrder(long id)
        {
            _order.DeleteOrder(id);
        }

        public OrderDTO SelectOrder(long id)
        {
            return _order.SelectOrder(id);
        }
    }
}
