using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class EmergencyMaintenanceBUS
    {
        EmergencyMaintenanceDAO _emergencyMaintenance = new EmergencyMaintenanceDAO();

        public bool AddEM_Request(long assetID, long priorityID, string decriptionEmergency, string otherConsiderations)
        {
            return _emergencyMaintenance.AddEM_Request(assetID, priorityID, decriptionEmergency, otherConsiderations);
        }
    }
}
