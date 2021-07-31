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
            return _ss4.All_Activities2().Select(u => new AllActivitiesDTO { OrderID= u.OrderID ,ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
        }

        public List<AllActivitiesDTO> GetAllActivities(int value)
        {
            if(value == 1)
            {
                return _ss4.All_Activities_OrderByPartName().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
            }

            if(value == 2)
            {
                return _ss4.All_Activities_OrderByTransactionType().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
            }

            if (value == 3)
            {
                return _ss4.All_Activities_OrderByDate().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
            
            }

            if (value == 4)
            {
                return _ss4.All_Activities_OrderByAmount().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
            
            }

            if (value == 5)
            {
                return _ss4.All_Activities_OrderByDestination().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();            
            }

            return _ss4.All_Activities_OrderBySource().Select(u => new AllActivitiesDTO { OrderID = u.OrderID, ID = u.ID, Amount = u.Amount, Transaction_Type = u.Transaction_Type, Transaction_Date = u.Transaction_Date, Destination_Warehouse = u.Destination_Warehouse, Source_Warehouse = u.Source_Warehouse, Part_Name = u.Part_Name }).ToList();
        }
        public List<PartDTO> GetAllPart()
        {
            return _ss4.Parts.Select(u => new PartDTO {ID= u.ID, BatchNumberHasRequired= u.BatchNumberHasRequired, EffectiveLife= u.EffectiveLife, Name= u.Name}).ToList();
        }

        public bool CheckPart(long id)
        {
            Part part = _ss4.Parts.SingleOrDefault(u=> u.ID == id);

            return part.BatchNumberHasRequired.Value;
        }

        //Kiem tra hang ton kho
        public decimal CheckAmount(long warehouse, long part)
        {
            return (decimal)_ss4.RECEIVED_STOCK_2(warehouse, part).FirstOrDefault().GetValueOrDefault() - (decimal)_ss4.OUT_OF_STOCK_2(warehouse, part).FirstOrDefault().GetValueOrDefault();
        }

        public List<BatchNumberDTO> SelectAllBatchNumber(long id)
        {
            return _ss4.SelectBatchNumber(id).Select(u => new BatchNumberDTO { PartID = u.PartID, BatchNumber = u.BatchNumber, NAME = u.NAME }).ToList();
        }
    }
}
