using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PartBUS
    {
        private PartDAO _partDAO = new PartDAO();
        public List<PartDTO> GetListPart()
        {
            return _partDAO.GetListPart();
        }
    }
}
