using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.DTO;

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
            catch (Exception )
            {
                MessageBox.Show("Add entry failed");
            }
        }

        public static List<entries> GetEntries()
        {
            //return db.entries.ToList();

            List<entries> entries = new List<entries>();

            var list = (from p in db.entries
                        select new
                        {
                            createDat = p.createdat,
                            driverID = p.driver_id,
                            truckID = p.truck_id,
                            companyID = p.company_id,
                            entryDate = p.entry_date,
                            entryWeight = p.entry_weight,
                            isExit = p.is_exit,
                        }).OrderBy(x => x.createDat).ToList();

            foreach (var item in list)
            {
                entries dto = new entries();

                dto.createdat = item.createDat.Value;
                dto.driver_id = item.driverID;
                dto.truck_id = item.truckID;
                dto.company_id = item.companyID;
                dto.entry_date = item.entryDate;

                double weight = Convert.ToSingle(item.entryWeight);
                dto.entry_weight = Math.Round(weight, 3);
                dto.is_exit = item.isExit.Value;

                entries.Add(dto);
            }
            return entries;
        }

        public static List<entries> GetTruckEntries(int truckID)
        {
            List<entries> entries = new List<entries>();

            var list = (from p in db.entries
                        where p.id == truckID
                        select new
                        {
                            createDat = p.createdat,
                            driverID = p.driver_id,
                            truckID = p.truck_id,
                            companyID = p.company_id,
                            entryDate = p.entry_date,
                            entryWeight = p.entry_weight,
                            isExit = p.is_exit,
                        }).OrderBy(x => x.entryDate).ToList();

            foreach (var item in list)
            {
                entries dto = new entries();

                dto.createdat = item.createDat.Value;
                dto.driver_id = item.driverID;
                dto.truck_id = item.truckID;
                dto.company_id = item.companyID;
                dto.entry_date = item.entryDate;
                dto.entry_weight = Convert.ToSingle(item.entryWeight);
                dto.is_exit = item.isExit.Value;

                entries.Add(dto);
            }
            return entries;
        }

        public static void UpdateEntry(entries entry)
        {
            try
            {
                entries ent = db.entries.First(x => x.id == entry.id);
                ent.driver_id = entry.driver_id;
                ent.truck_id = entry.truck_id;
                ent.company_id = entry.company_id;
                ent.entry_date = entry.entry_date;
                ent.entry_weight = entry.entry_weight;
                db.SubmitChanges();
            }
            catch (Exception )
            {
                MessageBox.Show("Error in update");
            }
        }
    }
}
