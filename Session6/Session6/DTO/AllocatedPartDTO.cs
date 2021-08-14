using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AllocatedPartDTO
    {
        public string NAME { get; set; }
        public long ID { get; set; }
        public string BatchNumber { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
