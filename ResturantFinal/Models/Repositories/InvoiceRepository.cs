using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ResturantFinal.Models.Repositories
{
    public class InvoiceRepository : IRestaurantRepository<Invoice>
    {
        IList<Invoice> invoices;
        public InvoiceRepository() {
            invoices = new List<Invoice>()
            {

                new Invoice { Id = 1, Admin_Name = "mahdi", Admin_Location = "saffa", Item_Name = "coffee", Item_Type = "hot drink", Supplier_Name = "ahmad", Date = "2022/3/3", Total_Price = "1000" }
            ,
                new Invoice { Id = 2, Admin_Name = "mahdi", Admin_Location = "saffa", Item_Name = "coffee", Item_Type = "hot drink", Supplier_Name = "ahmad", Date = "2022/3/3", Total_Price = "1000" }
            ,
                new Invoice { Id = 3, Admin_Name = "mahdi", Admin_Location = "saffa", Item_Name = "coffee", Item_Type = "hot drink", Supplier_Name = "ahmad", Date = "2022/3/3", Total_Price = "1000" }
            };
            }
        public void Add(Invoice entity)
        {
            invoices.Add(entity);
            
        }

        public void Delete(int id)
        {
            var invoice = Find(id);
            invoices.Remove(invoice);
        }
        public Invoice Find(int id)
        {
            var invoice = invoices.SingleOrDefault(x => x.Id == id);
            return invoice;
        }

        public IList<Invoice> List()
        {
            return invoices;
        }

        public List<Invoice> Search(string term)
        {
            return invoices.Where(x=>x.Supplier_Name.Contains(term)).ToList();
        }

        public void Update(int id, Invoice entity)
        {
            var invoice = Find(id);
            invoice.Supplier_Name= entity.Supplier_Name;
        }
    }
}
