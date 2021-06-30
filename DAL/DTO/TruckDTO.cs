using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class TruckDTO
    {
        public List<entries> entriesList { get; set; }
        public List<truck> trucksList { get; set; }
        public List<driver> driveList { get; set; }
        public List<company> companyList { get; set; }
    }
}
