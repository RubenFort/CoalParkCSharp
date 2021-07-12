using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class ParkContext
    {
        private static DataClassDataContext instanceDb;
        private static Object locker = new Object();//Objeto de bloqueo

        public static DataClassDataContext getInstance()
        {
            if (instanceDb == null)
            {
                //lock evita que en un entorno multihilo se acceda a un trozo de código si otro hilo ya ha entrado en dicho fragmento.
                lock (locker)
                {
                    if (instanceDb == null)
                    {
                        instanceDb = new DataClassDataContext();
                    }
                }
            }
            return instanceDb;
        }

        //public static DataClassDataContext db = new DataClassDataContext();
    }
}