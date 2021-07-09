using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PriorityBUS
    {
        private PriorityDAO _priorityDAO = new PriorityDAO();

        public List<PriorityDTO> GetPriorities()
        {
            return _priorityDAO.GetPriorities();
        }
    }
}
