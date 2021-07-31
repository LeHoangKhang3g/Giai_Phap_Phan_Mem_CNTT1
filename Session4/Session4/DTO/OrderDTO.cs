using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class OrderDTO
    {
        public long ID { get; set; }
        public long TransactionTypeID { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> SourceWarehouseID { get; set; }
        public Nullable<long> DestinationWarehouseID { get; set; }
        public System.DateTime Date { get; set; }
    }
}
