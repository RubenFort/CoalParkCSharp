using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TruckerBLL
    {
        public static void AddEntry(truck truck)
        {
            TruckDAO.AddTruck(truck);
        }

        public static TruckDTO GetEntries()
        {
            TruckDTO dto = new TruckDTO();
            dto.entriesList = EntriesDAO.GetEntries();
            dto.trucksList = TruckDAO.GetTrucks();
            dto.companyList = CompanyDAO.GetCompanies();
            dto.driveList = DriveDAO.GetDrives();

            return dto;
        }

        public static bool IsAllowed(int truckID)
        {
            TruckDTO dto = new TruckDTO();
            //dto.trucksList = 
            bool t = TruckDAO.IsAllowed(truckID);

            return t;
        }
    }
}
