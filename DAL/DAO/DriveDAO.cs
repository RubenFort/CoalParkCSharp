using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class DriveDAO : ParkContext
    {
        public static List<driver> GetDrives()
        {
            return db.driver.ToList();
        }
    }
}
