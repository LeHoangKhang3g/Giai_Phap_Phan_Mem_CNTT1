using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PartsDAO
    {
        Session4Entities _ss4 = new Session4Entities();
        
        public List<AllActivitiesDTO> GetAllActivities()
        {
            return _ss4.All_Activities().Select(u => new AllActivitiesDTO { ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
        }
    }
}
