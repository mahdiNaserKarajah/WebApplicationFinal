using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantFinal.Models.Repositories
{
    public class ItemDbRepository : IRestaurantRepository<Item>
    {
        private RestaurantDbContext db;


        public ItemDbRepository(RestaurantDbContext _db)
        {
            Db = _db;
        }

        RestaurantDbContext Db { get; set; }

        public void Add(Item entity)
        {
            Db.Items.Add(entity);
            Db.SaveChanges();
            
         }
        public void Delete(int id)
        {
            var author = Find(id);

            Db.Items.Remove(author);
            Db.SaveChanges();
        }
        public Item Find(int id)
        {
            var item = Db.Items.SingleOrDefault(x => x.Id == id);

            return item;
        }
        public IList<Item> List()
        {
            return Db.Items.ToList();
        }
        public List<Item> Search(string term) 
        {
        return db.Items.Where(x => x.Name.Contains(term)).ToList();
        }
        
        public void Update(int ID, Item newItem)
        {
            Db.Update(newItem);
            Db.SaveChanges();
        }



    }
}
