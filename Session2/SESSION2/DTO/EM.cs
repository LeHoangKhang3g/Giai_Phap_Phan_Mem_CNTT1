using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EM
    {
        private string fullName;
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }
        public string FullName
        {
            get { if (String.IsNullOrEmpty(fullName) == true) fullName = FirstName + " " + LastName; return fullName; }
            set { fullName = value; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
    }
}
