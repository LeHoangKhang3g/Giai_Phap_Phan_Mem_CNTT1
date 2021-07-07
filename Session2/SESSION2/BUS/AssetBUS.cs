using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AssetBUS
    {
        private AssetDAO _assetDAO = new AssetDAO();
        public List<AssetDTO> LayDS_EM()
        {
            return _assetDAO.LayDS_EM();
        }

        public List<EM> GetListEM()
        {
            return _assetDAO.GetListEM();
        }
    }
}
