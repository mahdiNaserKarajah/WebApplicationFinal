using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturantFinal.Models;
using ResturantFinal.Models.Repositories;

namespace ResturantFinal.Controllers
{
    public class suppliersController : Controller
    {
      

        private readonly IRestaurantRepository<supplier> supplierRepository;
        public suppliersController(IRestaurantRepository<supplier> supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        
        // GET: suppliersController
        public ActionResult Index()
        {
            var supplier = supplierRepository.List(); 
            return View(supplier);
        }

        // GET: suppliersController/Details/5
        public ActionResult Details(int id)
        {
            var supplier = supplierRepository.Find(id);
            return View(supplier);
        }

        // GET: suppliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: suppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, supplier supplier)
        {
            try
            {
                supplierRepository.Add(supplier);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: suppliersController/Edit/5
        public ActionResult Edit(int id)
        {
            var suppliers=supplierRepository.Find(id);
            return View();
        }

        public IRestaurantRepository<supplier> GetSupplierRepository()
        {
            return supplierRepository;
        }

        // POST: suppliersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, supplier supplier)
        {
            try
            {
                supplierRepository.Update(id,supplier);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: suppliersController/Delete/5
        public ActionResult Delete(int id)
        { 
            var supplier = supplierRepository.Find(id);
            return View();
        }

        // POST: suppliersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                supplierRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

   
}
