using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class EntriesDetailDTO
    {
        public int id { get; set; }
        public DateTime createDat { get; set; }
        public int driverID { get; set; }
        public int truckID { get; set; }
        public int companyID { get; set; }
        public DateTime? entryDate { get; set; }
        public float entryWeight { get; set; }
        public bool isExit { get; set; }
    }
}
