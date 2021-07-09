using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAO _employeeDAO = new EmployeeDAO();

        public EmployeeDTO CheckAccount(string userName, string pass)
        {
            return _employeeDAO.CheckAccount(userName, pass);
        }
    }
}
