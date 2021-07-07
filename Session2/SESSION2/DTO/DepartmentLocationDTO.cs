using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DepartmentLocationDTO
    {
        public long ID { get; set; }
        public long DepartmentID { get; set; }
        public long LocationID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
