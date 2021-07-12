using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAL.DAO
{
    public class TruckDAO : ParkContext
    {
        public static DataClassDataContext db = null;

        public static List<truck> GetTrucks()
            {
            db = ParkContext.getInstance();

            return db.truck.ToList();
            }

        public static void AddTruck(truck truck)
        {
            try
            {
                db = ParkContext.getInstance();

                db.truck.InsertOnSubmit(truck);
                db.SubmitChanges();
            }
            catch (Exception )
            {
                MessageBox.Show("Error in add truck");
            }
        }

        public static bool IsAllowed(int truckID)
        {
            db = ParkContext.getInstance();

            List<truck> trucks = new List<truck>();
            truck dto = new truck();

            var list = (from p in db.truck
                        where p.id == truckID
                        select new
                        {
                            isAllowed = p.allowed,
                        });
            foreach (var item in list)
            {
                
                dto.allowed = item.isAllowed;

                trucks.Add(dto);
            }

            return dto.allowed.Value;
        }
    }
}
