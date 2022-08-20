using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantFinal.Models.Repositories
{
    public class supplierDbRepository : IRestaurantRepository<Item>
    {
        private RestaurantDbContext db;


        public supplierDbRepository(RestaurantDbContext _db)
        {
            Db = _db;
        }

        RestaurantDbContext Db { get; set; }
        public void Add(supplier entity)
        {
          db.Suppliers.Add(entity);
            db.SaveChanges();
           
        }

        public void Add(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var supplier = Find(id);

        db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }

        public supplier Find(int id)
        {
            var supplier =db.Suppliers.SingleOrDefault(x => x.Id == id);
            return supplier;
        }

        public IList<supplier> List()
        {
            return db.Suppliers.ToList();
        }

        public List<supplier> Search(string term)
        {
            return db.Suppliers.Where(x => x.Name.Contains(term)).ToList();
        }

        public void Update(int id, supplier entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }

        public void Update(int id, Item entity)
        {
            throw new NotImplementedException();
        }

        Item IRestaurantRepository<Item>.Find(int id)
        {
            throw new NotImplementedException();
        }

        IList<Item> IRestaurantRepository<Item>.List()
        {
            throw new NotImplementedException();
        }

        List<Item> IRestaurantRepository<Item>.Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
