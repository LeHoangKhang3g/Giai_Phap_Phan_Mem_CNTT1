using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ReportBUS
    {
        ReportDAO _reportDAO = new ReportDAO();
        public List<ReportDTO> GetReportDTOs(long wareHouse)
        {
            return _reportDAO.GetReportDTOs(wareHouse);
        }
        
    }
}
