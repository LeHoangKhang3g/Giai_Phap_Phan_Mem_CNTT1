using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class OrderBUS
    {
        private OrderDAO orderDAO = new OrderDAO();
        public bool InsertOrderDAO(long transactionTypeID, long emergencyMantenancesID, long sourceWarehouseID, DateTime date, TimeSpan time)
        {

            return orderDAO.InsertOrder(transactionTypeID, emergencyMantenancesID, sourceWarehouseID, date, time);
        }
        public bool InsertOrderItemDAO(long orderID, long partID, string batchNumber, decimal amount, decimal stock, decimal unitPrice)
        {

            return orderDAO.InsertOrderItem(orderID, partID, batchNumber, amount, stock, unitPrice);
        }
        public long GetMaxOrderID()
        {
            return orderDAO.GetMaxOrderID();
        }
    }
}
