using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public class ChangedPartDAO
    {
       private Session2Entities _ss2 = new Session2Entities();
       public List<ChangedPartDTO> GetListChangedPart(long id)
       {
           return _ss2.GetAllChangedPart(id).Select(u => new ChangedPartDTO { ID = u.ID, Amount = u.Amount, Name = u.Name }).ToList();
       }

       public bool InsertChangedPart(long idEM, long idPart, decimal amount)
       {
           int kq = _ss2.INSERT_CHANGEDPART(idEM, idPart, amount);
           return kq > 0;
       }

       public bool DeleteChangedPart(long id)
       {
           int kq = _ss2.DeletePart(id);
           return kq > 0;
       }
    }
}
