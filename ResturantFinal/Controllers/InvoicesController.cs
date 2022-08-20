using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResturantFinal.Data;
using ResturantFinal.Models;
using ResturantFinal.Models.Repositories;

namespace ResturantFinal.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IRestaurantRepository<Invoice> InvoiceRepository;

        public InvoicesController(IRestaurantRepository<Invoice> InvoiceRepository)
        {
            this.InvoiceRepository = InvoiceRepository;
        }
        // GET: Invoice
        public ActionResult Index()
        {
            var authors = InvoiceRepository.List();

            return View(authors);
        }

        // GET: Invoice/Details/5
        public ActionResult Details(int id)
        {
            var author = InvoiceRepository.Find(id);

            return View(author);
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Invoice invoice)
        {
            try
            {
                InvoiceRepository.Add(invoice);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Edit/5
        public ActionResult Edit(int id)
        {
            var invoice = InvoiceRepository.Find(id);

            return View(invoice);
        }

        // POST: Invoice/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Invoice invoice)
        {
            try
            {
                InvoiceRepository.Update(id, invoice);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Delete/5
        public ActionResult Delete(int id)
        {
            var invoice = InvoiceRepository.Find(id);

            return View(invoice);
        }

        // POST: Invoice/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Invoice invoice)
        {
            try
            {
                InvoiceRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    

}
}
