using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ReportDAO
    {
        Session4Entities _ss4 = new Session4Entities();
        public List<ReportDTO> GetReportDTOs(long wareHouse)
        {
            List<ReportDTO> lstReportDTOs = new List<ReportDTO>();
            List<PartDTO> partDTOs = _ss4.Parts.Select(u => new PartDTO { ID = u.ID, Name = u.Name }).ToList();
            foreach(PartDTO p in partDTOs)
            {
                ReportDTO reportDTO = new ReportDTO();
                reportDTO.id = p.ID;
                reportDTO.PartName = p.Name;
                reportDTO.ReceivedStock = (decimal)_ss4.RECEIVED_STOCK_2(wareHouse, p.ID).FirstOrDefault().GetValueOrDefault();
                reportDTO.OutOfStock = (decimal)_ss4.OUT_OF_STOCK_2(wareHouse, p.ID).FirstOrDefault().GetValueOrDefault();
                reportDTO.CurrentStock = reportDTO.ReceivedStock - reportDTO.OutOfStock;
                lstReportDTOs.Add(reportDTO);
            }
            return lstReportDTOs;
        }
    }
}
