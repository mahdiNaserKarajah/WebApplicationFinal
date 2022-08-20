using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantFinal.Models.Repositories
{
    public class ItemRepository : IRestaurantRepository<Item>
    {
        IList<Item> Items;
        public ItemRepository()
        {
            Items = new List<Item>()
            {
                new Item{Id=1,Name="Coffe",Quantity=10,Price=20,Barcode="/imageCoffe.png",Country_Of_Origin="turkey" ,Type="hotDrink"},
                new Item{Id=3,Name="Tea",Quantity=16,Price=100,Barcode="/imageTea.png",Country_Of_Origin="china" ,Type="hotDrink"}
            };
        }


        public void Add(Item entity)
        {
            Items.Add(entity);
        

        }
        public void Delete(int id)
        {
            var author = Find(id);

            Items.Remove(author);
           
        }
        public Item Find(int id)
        {
            var item = Items.SingleOrDefault(x => x.Id == id);

            return item;
        }
        public IList<Item> List()
        {
            return Items.ToList();
        }
        public List<Item> Search(string term)
        {
            return Items.Where(x => x.Name.Contains(term)).ToList();
        }

        public void Update(int ID, Item newItem)
        {
            var item = Find(ID);
            item.Name = newItem.Name;
           
        }



    }
}


