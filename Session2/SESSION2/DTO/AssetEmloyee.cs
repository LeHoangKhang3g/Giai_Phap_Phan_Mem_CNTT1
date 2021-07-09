using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssetEmloyee
    {
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public Nullable<System.DateTime> LastClosedEM { get; set; }
        public int NumberOfEMs { get; set; }
        public string NameDepartment { get; set; }
    }
}
