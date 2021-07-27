using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class AllActivitiesDTO
    {
       public long OrderID { get; set; }
        public long ID { get; set; }
        public string Part_Name { get; set; }
        public string Transaction_Type { get; set; }
        public System.DateTime Transaction_Date { get; set; }
        public decimal Amount { get; set; }
        public string Source_Warehouse { get; set; }
        public string Destination_Warehouse { get; set; }
    }
}
