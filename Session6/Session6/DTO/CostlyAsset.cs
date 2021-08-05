using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CostlyAsset
    {
        public string Department { get; set; }
        public string AssetName { get; set; }
        public Nullable<decimal> Money { get; set; }
    }
}
