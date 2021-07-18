using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PartsBUS
    {
        PartsDAO _part = new PartsDAO();

        public List<AllActivitiesDTO> GetAllActivities()
        {
            return _part.GetAllActivities();
        }

        public List<PartDTO> GetAllPart()
        {
            return _part.GetAllPart();
        }
    }
}
