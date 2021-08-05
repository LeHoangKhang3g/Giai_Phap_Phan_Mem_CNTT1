using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonthlySpendingDTO
    {
        public Nullable<int> Month { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Money { get; set; }
    }
}
