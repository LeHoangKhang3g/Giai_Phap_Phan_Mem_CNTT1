using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmergencyMaintenanceDTO
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public long PriorityID { get; set; }
        public string DescriptionEmergency { get; set; }
        public string OtherConsiderations { get; set; }
        public System.DateTime EMReportDate { get; set; }
        public Nullable<System.DateTime> EMStartDate { get; set; }
        public Nullable<System.DateTime> EMEndDate { get; set; }
        public string EMTechnicianNote { get; set; }
    }
}
