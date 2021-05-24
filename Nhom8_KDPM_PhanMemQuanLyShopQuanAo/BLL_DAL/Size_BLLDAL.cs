using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
     public   class Size_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        public SIZE laySize(string tenSize)
        {
            return db.SIZEs.Where(t => t.TENSIZE == tenSize).FirstOrDefault();
        }
    }
}
