using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class WeightBLL
    {
        public static WeightDTO GetEntries()
        {
            WeightDTO dto = new WeightDTO();
            dto.weightList = WeightDAO.GetEntries();

            return dto;
        }
    }
}
