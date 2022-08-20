using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantFinal.Models.Repositories
{
    public class supplierRepository : IRestaurantRepository<supplier>
    {

        IList<supplier> suppliers;

        public supplierRepository()
        {
            suppliers = new List<supplier>()
            {
                new supplier{Id=1,Name="ahmad",UserName="ahmad_2020",Password="&&&$",Phone_Number=059585555,Email_Address="ahmad@gmail.com",Item_Type="Hot Drink",Location="Ramallah" }
            };
        }
        public void Add(supplier entity)
        {
            suppliers.Add(entity);
        }

        public void Delete(int id)
        {
            var supplier = Find(id);
            suppliers.Remove(supplier);
        }

        public supplier Find(int id)
        {
            var supplier = suppliers.SingleOrDefault(x => x.Id == id);
            return supplier;
        }

        public IList<supplier> List()
        {
            return suppliers;
        }

        public List<supplier> Search(string term)
        {
            return suppliers.Where(x=>x.Name.Contains(term)).ToList();
        }

        public void Update(int id, supplier entity)
        {
            var supplier = Find(id);
            supplier.Name = entity.Name;
        }
    }
}
