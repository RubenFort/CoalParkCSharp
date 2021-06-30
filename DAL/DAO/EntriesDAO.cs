using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class EntriesDAO : ParkContext
    {
        public static void AddEntry(entries entry)
        {
            try
            {
                db.entries.InsertOnSubmit(entry);
                    db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
