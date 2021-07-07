using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PartDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> EffectiveLife { get; set; }
    }
}
