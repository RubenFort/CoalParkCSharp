using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EntriesBLL
    {
        public static void AddEntry(entries entry)
        {
            EntriesDAO.AddEntry(entry);
        }
    }
}
