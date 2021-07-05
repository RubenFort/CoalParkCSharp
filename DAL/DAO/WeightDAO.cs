using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DTO;

namespace DAL.DAO
{
    public class WeightDAO : ParkContext
    {
        public static List<WeightDetailDTO> GetEntries()
        {
            WeightDTO dto = new WeightDTO();
            List<WeightDetailDTO> weight = new List<WeightDetailDTO>();

            var List = db.entries.ToList();

            var list = (from p in db.entries
                        select new
                        {
                            createDat = p.createdat,
                            entryDate = p.entry_date,
                            weightEntry = p.entry_weight
                        }).OrderBy(x => x.createDat).ToList();

            foreach (var item in list)
            {
                WeightDetailDTO detail = new WeightDetailDTO();
                detail.createDat = item.createDat.Value.Date;
                int index = 0;
                bool condition = false;

                String strCreateDateHour = item.createDat.ToString();
                strCreateDateHour = strCreateDateHour.Substring(10);
                string[] subs = strCreateDateHour.Split(':');

                foreach (var itemWeight in weight)
                {
                    WeightDetailDTO dtoWeight = weight[index];
                    if (item.createDat.Value.Date == dtoWeight.createDat)
                    {
                        condition = true;
                        break;
                    }
                    index++;
                }

                int hour = Convert.ToInt32(subs[0]);

                switch (hour)
                {
                    case 0:
                        detail.Hour00 += item.weightEntry;
                        break;
                    case 1:
                        detail.Hour01 += item.weightEntry;
                        break;
                    case 2:
                        detail.Hour02 += item.weightEntry;
                        break;
                    case 3:
                        detail.Hour03 += item.weightEntry;
                        break;
                    case 4:
                        detail.Hour04 += item.weightEntry;
                        break;
                    case 5:
                        detail.Hour05 += item.weightEntry;
                        break;
                    case 6:
                        detail.Hour06 += item.weightEntry;
                        break;
                    case 7:
                        detail.Hour07 += item.weightEntry;
                        break;
                    case 8:
                        detail.Hour08 += item.weightEntry;
                        break;
                    case 9:
                        detail.Hour09 += item.weightEntry;
                        break;
                    case 10:
                        detail.Hour10 += item.weightEntry;
                        break;
                    case 11:
                        detail.Hour11 += item.weightEntry;
                        break;
                    case 12:
                        detail.Hour12 += item.weightEntry;
                        break;
                    case 13:
                        detail.Hour13 += item.weightEntry;
                        break;
                    case 14:
                        detail.Hour14 += item.weightEntry;
                        break;
                    case 15:
                        detail.Hour15 += item.weightEntry;
                        break;
                    case 16:
                        detail.Hour16 += item.weightEntry;
                        break;
                    case 17:
                        detail.Hour17 += item.weightEntry;
                        break;
                    case 18:
                        detail.Hour18 += item.weightEntry;
                        break;
                    case 19:
                        detail.Hour19 += item.weightEntry;
                        break;
                    case 20:
                        detail.Hour20 += item.weightEntry;
                        break;
                    case 21:
                        detail.Hour21 += item.weightEntry;
                        break;
                    case 22:
                        detail.Hour22 += item.weightEntry;
                        break;
                    case 23:
                        detail.Hour23 += item.weightEntry;
                        break;
                    default:
                        break;
                }

                setWeightInDTO(index, condition, detail, weight);
            }
            return weight;
        }

        private static void setWeightInDTO(int index, bool condition, WeightDetailDTO detail, List<WeightDetailDTO> weight)
        {
            if (condition)
            {
                WeightDetailDTO detailDtoRecovery = weight[index];

                detailDtoRecovery.Hour00 = Math.Round(detailDtoRecovery.Hour00 + detail.Hour00, 3);
                detailDtoRecovery.Hour01 = Math.Round(detailDtoRecovery.Hour01 + detail.Hour01, 3);
                detailDtoRecovery.Hour02 = Math.Round(detailDtoRecovery.Hour02 + detail.Hour02, 3);
                detailDtoRecovery.Hour03 = Math.Round(detailDtoRecovery.Hour03 + detail.Hour03, 3);
                detailDtoRecovery.Hour04 = Math.Round(detailDtoRecovery.Hour04 + detail.Hour04, 3);
                detailDtoRecovery.Hour05 = Math.Round(detailDtoRecovery.Hour05 + detail.Hour05, 3);
                detailDtoRecovery.Hour06 = Math.Round(detailDtoRecovery.Hour06 + detail.Hour06, 3);
                detailDtoRecovery.Hour07 = Math.Round(detailDtoRecovery.Hour07 + detail.Hour07, 3);
                detailDtoRecovery.Hour08 = Math.Round(detailDtoRecovery.Hour08 + detail.Hour08, 3);
                detailDtoRecovery.Hour09 = Math.Round(detailDtoRecovery.Hour09 + detail.Hour09, 3);
                detailDtoRecovery.Hour10 = Math.Round(detailDtoRecovery.Hour10 + detail.Hour10, 3);
                detailDtoRecovery.Hour11 = Math.Round(detailDtoRecovery.Hour11 + detail.Hour11, 3);
                detailDtoRecovery.Hour12 = Math.Round(detailDtoRecovery.Hour12 + detail.Hour12, 3);
                detailDtoRecovery.Hour13 = Math.Round(detailDtoRecovery.Hour13 + detail.Hour13, 3);
                detailDtoRecovery.Hour14 = Math.Round(detailDtoRecovery.Hour14 + detail.Hour14, 3);
                detailDtoRecovery.Hour15 = Math.Round(detailDtoRecovery.Hour15 + detail.Hour15, 3);
                detailDtoRecovery.Hour16 = Math.Round(detailDtoRecovery.Hour16 + detail.Hour16, 3);
                detailDtoRecovery.Hour17 = Math.Round(detailDtoRecovery.Hour17 + detail.Hour17, 3);
                detailDtoRecovery.Hour18 = Math.Round(detailDtoRecovery.Hour18 + detail.Hour18, 3);
                detailDtoRecovery.Hour19 = Math.Round(detailDtoRecovery.Hour19 + detail.Hour19, 3);
                detailDtoRecovery.Hour20 = Math.Round(detailDtoRecovery.Hour20 + detail.Hour20, 3);
                detailDtoRecovery.Hour21 = Math.Round(detailDtoRecovery.Hour21 + detail.Hour21, 3);
                detailDtoRecovery.Hour22 = Math.Round(detailDtoRecovery.Hour22 + detail.Hour22, 3);
                detailDtoRecovery.Hour23 = Math.Round(detailDtoRecovery.Hour23 + detail.Hour23, 3);

                weight.RemoveAt(index);
                weight.Insert(index, detailDtoRecovery);
            }
            else
                weight.Add(detail);
        }
    }
}
