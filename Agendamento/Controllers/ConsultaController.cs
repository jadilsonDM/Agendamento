using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: ConsultaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConsultaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConsultaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsultaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConsultaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConsultaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConsultaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConsultaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
