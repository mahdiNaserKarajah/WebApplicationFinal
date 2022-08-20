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
    public class consumption_reportController : Controller
    {
        private readonly IRestaurantRepository<consumption_report> consumption_reportRepository;

        public consumption_reportController(IRestaurantRepository<consumption_report> consumption_reportRepository)
        {
            this.consumption_reportRepository = consumption_reportRepository;   
        }

        // GET: consumption_report
        public ActionResult Index()
        {
            var consumption_report = consumption_reportRepository.List();

            return View(consumption_report);
        }

        // GET: consumption_report/Details/5
        public ActionResult Details(int id)
        {
            var consumption_report = consumption_reportRepository.Find(id);

            return View(consumption_report);
        }

        // GET: consumption_report/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: consumption_report/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(consumption_report consumption_report)
        {
            try
            {
                consumption_reportRepository.Add(consumption_report);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: consumption_report/Edit/5
        public ActionResult Edit(int id)
        {
            var consumption_report = consumption_reportRepository.Find(id);

            return View(consumption_report);
        }

        // POST: consumption_report/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, consumption_report consumption_report)
        {
            try
            {
                consumption_reportRepository.Update(id, consumption_report);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: consumption_report/Delete/5
        public ActionResult Delete(int id)
        {
            var consumption_report = consumption_reportRepository.Find(id);

            return View(consumption_report);
        }

        // POST: consumption_report/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, consumption_report consumption_report)
        {
            try
            {
                consumption_reportRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
