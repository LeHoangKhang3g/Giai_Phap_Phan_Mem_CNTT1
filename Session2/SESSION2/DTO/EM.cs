using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EM
    {
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
    }
}
