using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class DriveDAO : ParkContext
    {
        public static DataClassDataContext db = null;

        public static List<driver> GetDrives()
        {
            db = ParkContext.getInstance();

            return db.driver.ToList();
        }
    }
}
