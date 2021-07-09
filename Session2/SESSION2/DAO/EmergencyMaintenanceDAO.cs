using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class EmergencyMaintenanceDAO
    {
        Session2Entities _ss2 = new Session2Entities();

        public bool AddEM_Request(long assetID,long priorityID,string decriptionEmergency, string otherConsiderations)
        {
            try
            {
                int count = _ss2.SEND_REPORT(assetID, priorityID, decriptionEmergency, otherConsiderations, DateTime.Now, DateTime.Now,null);
                if (count != 0) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
