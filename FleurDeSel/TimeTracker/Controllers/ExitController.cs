using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pointeuse.Controllers
{
    public class ExitController : Controller
    {
        // GET: Exit
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Exit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exit/Create
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

        // GET: Exit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exit/Edit/5
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

        // GET: Exit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exit/Delete/5
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
