using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrderDAO
    {
        Session6Entities _ss6 = new Session6Entities();
        public bool InsertOrder(long transactionTypeID, long emergencyMantenancesID, long sourceWarehouseID, DateTime date, TimeSpan time)
        {
            try
            {
                _ss6.InsertOrder(transactionTypeID, emergencyMantenancesID, sourceWarehouseID, date, time);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool InsertOrderItem(long orderID, long partID, string batchNumber, decimal amount, decimal stock, decimal unitPrice)
        {
            try
            {
                _ss6.InsertOrderItem(orderID, partID, batchNumber, amount, stock, unitPrice);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public long GetMaxOrderID()
        {
            return _ss6.GetMaxOrderID().FirstOrDefault().GetValueOrDefault();
        }
    }
}
