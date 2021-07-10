using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChangedPartBUS
    {
        private ChangedPartDAO _changedPart = new ChangedPartDAO();

        public List<ChangedPartDTO> GetListChangedPart(long id)
        {
            return _changedPart.GetListChangedPart(id);
        }

        public bool InsertChangedPart(long idEM, long idPart, decimal amount)
        {
            return _changedPart.InsertChangedPart(idEM, idPart, amount);
        }

        public bool DeleteChangedPart(long id)
        {
            return _changedPart.DeleteChangedPart(id);
        }
    }
}
