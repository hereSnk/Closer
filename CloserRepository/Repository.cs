using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CloserRepository
{
    public class Repository
    {
        bool statusDataSaved = false;
        public bool RegisterBuyer(TBL_BUYER_INFO tblObj)
        {
            
            Closer_DBEntities dB = new Closer_DBEntities();
            dB.TBL_BUYER_INFO.Add(tblObj);
            dB.SaveChanges();
            return statusDataSaved = true;
        }
    }
}
