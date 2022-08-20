using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ResturantFinal.Models.Repositories
{
    public class consumption_reportRepository : IRestaurantRepository<consumption_report>
    {
        IList<consumption_report> consumption_Reports;

        public consumption_reportRepository()
        {
            consumption_Reports = new List<consumption_report>
             {
            new consumption_report{Id=1,Item_Name="coffee",Quantity=20,Date="2022/2/2",Section="paresta"}
            };


        }


        public void Add(consumption_report entity)
        {
            consumption_Reports.Add(entity);
        }

        public void Delete(int id)
        {
            var consumption_Report = Find(id);
            consumption_Reports.Remove(consumption_Report);
        }

        public consumption_report Find(int id)
        {
            var consumption_Report = consumption_Reports.SingleOrDefault(x => x.Id == id);
            return consumption_Report;
        }

        public IList<consumption_report> List()
        {
            return consumption_Reports;
        }

        public List<consumption_report> Search(string term)
        {
            return consumption_Reports.Where(x => x.Item_Name.Contains(term)).ToList();
        }

        public void Update(int id, consumption_report entity)
        {
            var consumption_Report = Find(id);
            consumption_Report.Item_Name = entity.Item_Name;

        }


    }
}
