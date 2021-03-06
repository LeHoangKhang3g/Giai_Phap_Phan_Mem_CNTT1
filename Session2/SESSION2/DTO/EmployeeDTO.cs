using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
