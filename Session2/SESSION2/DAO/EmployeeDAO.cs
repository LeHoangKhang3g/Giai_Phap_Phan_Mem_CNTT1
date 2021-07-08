using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class EmployeeDAO
    {
        Session2Entities _ss2 = new Session2Entities();

        //Kiểm tra đang nhập
        public EmployeeDTO CheckAccount(string userName, string pass)
        {
            Employee employee = _ss2.Employees.SingleOrDefault(u => u.Username == userName && u.Password == pass);

            if (employee != null)
            {
                EmployeeDTO employeeDTO = new EmployeeDTO()
                {
                    ID = employee.ID,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Phone = employee.Phone,
                    isAdmin = employee.isAdmin,
                    Username = employee.Username,
                    Password = employee.Password
                };

                return employeeDTO;
            }

            return null;
        }
    }
}
