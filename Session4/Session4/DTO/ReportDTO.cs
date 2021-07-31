using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportDTO
    {
        private String _partName;
        private Nullable<decimal> _currentStock;
        private Nullable<decimal> _receivedStock;
        private Nullable<decimal> _outOfStock;

        public long id { get; set; }
        public String PartName { get { return _partName; } set { _partName = value; } }
        public Nullable<decimal> CurrentStock { get { return _currentStock; } set { _currentStock = value; } }
        public Nullable<decimal> ReceivedStock { get { return _receivedStock; } set { _receivedStock = value; } }
        public Nullable<decimal> OutOfStock { get { return _outOfStock; } set { _outOfStock = value; } }
    }
}
