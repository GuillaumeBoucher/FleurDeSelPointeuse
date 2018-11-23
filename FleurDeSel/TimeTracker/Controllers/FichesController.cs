using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pointeuse.Controllers
{
    public class FichesController : Controller
    {
        // GET: Fiches
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fiches/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fiches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fiches/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fiches/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fiches/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fiches/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fiches/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
