using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DAO;
using DAL;
using DAL.DTO;

namespace BLL
{
    public class EntriesBLL
    {
        public static void AddEntry(entries entry)
        {
            EntriesDAO.AddEntry(entry);
        }

        public static EntriesDTO GetEntries()
        {
            EntriesDTO dto = new EntriesDTO();
            dto.entriesList = EntriesDAO.GetEntries();
            dto.trucksList = TruckDAO.GetTrucks();
            dto.companyList = CompanyDAO.GetCompanies();
            dto.driveList = DriveDAO.GetDrives();

            return dto;
        }

        public static void UpdateEntry(entries entry)
        {
            EntriesDAO.UpdateEntry(entry);
        }

        public static EntriesDTO GetTruckEntries(int truckID)
        {
            EntriesDTO dto = new EntriesDTO();
            dto.entriesList = EntriesDAO.GetTruckEntries(truckID);
            return dto;
        }
    }
}
