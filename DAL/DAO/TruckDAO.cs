using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAL.DAO
{
    public class TruckDAO : ParkContext
    {
        
    public static List<truck> GetTrucks()
        {
            return db.truck.ToList();
        }

        public static void AddTruck(truck truck)
        {
            try
            {
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
