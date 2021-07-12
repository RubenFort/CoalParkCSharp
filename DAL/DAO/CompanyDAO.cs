using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class CompanyDAO : ParkContext
    {
        public static DataClassDataContext db = null;

        public static List<company> GetCompanies()
        {
            db = ParkContext.getInstance();

            return db.company.ToList();
        }
    }
}
