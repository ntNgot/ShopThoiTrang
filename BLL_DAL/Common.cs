using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Common
    {
        private static dbQLShopDataContext _Entities = new dbQLShopDataContext();

        public static dbQLShopDataContext Entities
        {
            get { return Common._Entities; }
            set { Common._Entities = value; }
        }
    }
}
