using System;
using System.Collections.Generic;
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
    public class ItemsController : Controller
    {
        private readonly IRestaurantRepository<Item> ItemRepository; 

        public ItemsController(IRestaurantRepository<Item> ItemRepository)
        {
            this.ItemRepository = ItemRepository;   
        }
        // GET: Item
        public ActionResult Index()
        {
            var item = ItemRepository.List();

            return View(item);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            var item = ItemRepository.Find(id);

            return View(item);
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item item)
        {
            try
            {
                ItemRepository.Add(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            var item = ItemRepository.Find(id);

            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Item item)
        {
            try
            {
                ItemRepository.Update(id, item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            var item = ItemRepository.Find(id);

            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Item item)
        {
            try
            {
                ItemRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
