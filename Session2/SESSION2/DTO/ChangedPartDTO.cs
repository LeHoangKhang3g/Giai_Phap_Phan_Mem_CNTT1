using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChangedPartDTO
    {
        public long ID { get; set; }
        public long EmergencyMaintenanceID { get; set; }
        public long PartID { get; set; }
        public decimal Amount { get; set; }
    }
}
