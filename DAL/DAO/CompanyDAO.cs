using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class CompanyDAO : ParkContext
    {
        public static List<company> GetCompanies()
        {
            return db.company.ToList();
        }
    }
}
