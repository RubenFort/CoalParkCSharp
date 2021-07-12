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
        public static DataClassDataContext db = null;

        public static void AddEntry(entries entry)
        {
            try
            {
                db = ParkContext.getInstance();

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
            db = ParkContext.getInstance();

            return db.entries.ToList();
        }

        public static List<entries> GetTruckEntries(int truckID)
        {
            db = ParkContext.getInstance();

            List<entries> entries = new List<entries>();

            List<entries> list = db.entries.Where(x => x.truck_id == truckID).ToList();

            foreach (entries item in list)
            {
                entries dto = new entries();

                dto.createdat = item.createdat.Value;
                dto.driver_id = item.driver_id;
                dto.truck_id = item.truck_id;
                dto.company_id = item.company_id;
                dto.entry_date = item.entry_date;
                dto.entry_weight = Convert.ToSingle(item.entry_weight);
                dto.is_exit = item.is_exit.Value;

                entries.Add(dto);
            }
            return entries;
        }

        public static void UpdateEntry(entries entry)
        {
            try
            {
                db = ParkContext.getInstance();

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
