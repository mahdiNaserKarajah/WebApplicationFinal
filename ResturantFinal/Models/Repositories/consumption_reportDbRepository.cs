using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ResturantFinal.Models.Repositories
{
    public class consumption_reportDbRepository : IRestaurantRepository<consumption_report>
    {
        RestaurantDbContext db;
        public consumption_reportDbRepository(RestaurantDbContext db)
        {
            this.db = db;
        }
        RestaurantDbContext Db { get; set; }
        public void add(consumption_report entity)
        {
            db.consumption_Reports.Add(entity);
            db.SaveChanges();
            
        }

        public void Add(consumption_report entity)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            var consumption_report = Find(id);
            db.consumption_Reports.Remove(consumption_report);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public consumption_report Find(int id) 
        {
        var consumption_Report =db.consumption_Reports.SingleOrDefault(x => x.Id == id);

            return consumption_Report;
        }
        public IList<consumption_report> List()
        {
            return db.consumption_Reports.ToList();
        }
        public List<consumption_report> Search(string term)
        {
            return db.consumption_Reports.Where(x => x.Item_Name.Contains(term)).ToList();
        }
        public void Update(int ID, consumption_report newItem)
        {
            db.Update(newItem);
            db.SaveChanges();
        }

        
    }
   
}
