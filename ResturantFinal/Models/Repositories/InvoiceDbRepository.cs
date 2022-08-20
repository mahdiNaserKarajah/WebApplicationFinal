using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ResturantFinal.Models.Repositories
{
    public class InvoiceDbRepository : IRestaurantRepository<Invoice>
    {

        RestaurantDbContext db;

        public InvoiceDbRepository(RestaurantDbContext db)
        {
            this.db = db;
        }

        public void Add(Invoice entity)
        {
            db.Invoices.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var invoice = Find(id);

            db.Invoices.Remove(invoice);
            db.SaveChanges();
        }

        public Invoice Find(int id)
        {
            var invoice =db.Invoices.SingleOrDefault(x => x.Id == id);

            return invoice;
        }

        public IList<Invoice> List()
        {
            return db.Invoices.ToList();
        }

        public List<Invoice> Search(string term)
        {
            return db.Invoices.Where(x => x.Supplier_Name.Contains(term)).ToList();
        }

        public void Update(int id, Invoice newInvoice)
        {
            db.Update(newInvoice);
            db.SaveChanges();
        }
    }
}
