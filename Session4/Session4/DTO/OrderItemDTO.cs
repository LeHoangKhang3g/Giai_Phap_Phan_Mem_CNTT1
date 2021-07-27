using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderItemDTO
    {
        public string Name { get; set; }
        public string BatchNumber { get; set; }
        public decimal Amount { get; set; }
        public long ID { get; set; }
    }
}
