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

        public List<AllActivitiesDTO> GetAllActivities(int value)
        {
            return _part.GetAllActivities(value);
        }

        public List<PartDTO> GetAllPart()
        {
            return _part.GetAllPart();
        }

        public bool CheckPart(long id)
        {
            return _part.CheckPart(id);
        }

          //Kiem tra hang ton kho
        public decimal CheckAmount(long warehouse, long part)
        {
            return _part.CheckAmount(warehouse, part);
        }

        public List<BatchNumberDTO> SelectAllBatchNumber(long id)
        {
            return _part.SelectAllBatchNumber(id);
        }
    }
}
