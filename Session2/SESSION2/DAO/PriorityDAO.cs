using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PriorityDAO
    {
        private Session2Entities _ss2 = new Session2Entities();

        public List<PriorityDTO> GetPriorities()
        {
            return _ss2.Priorities.Select(u => new PriorityDTO { ID = u.ID, Name = u.Name }).ToList();
        }
    }
}
