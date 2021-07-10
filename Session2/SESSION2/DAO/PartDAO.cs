using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PartDAO
    {
        Session2Entities _ss2 = new Session2Entities();
        public List<PartDTO> GetListPart()
        {
            return _ss2.Parts.Select(u => new PartDTO { ID = u.ID, EffectiveLife = u.EffectiveLife.Value, Name= u.Name }).ToList();
        }
    }
}
