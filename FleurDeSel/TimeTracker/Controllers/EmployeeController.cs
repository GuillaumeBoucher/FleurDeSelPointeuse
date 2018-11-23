using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pointeuse.Controllers
{
    public class EmployeeController : Controller
    {

        private static dbContext Employee_Context;
        private static List<Employee> Employee_List;

        // Constructeur
        public EmployeeController()
        {
            Employee_Context = new dbContext("C:/_dev/fleurdesel/FleurDeSel/db/employee.db");
            Employee_List = Employee_Context.GetData<Employee>();
        }

        private bool FindEmployee(string prenom,string nom)
        {
            bool _ret = false;

            Employee FindOne = Employee_List.Find(x => x.prenom == prenom && x.nom == nom);
            if(FindOne != null)
            {
                _ret = true;
            }

            return _ret;
        }


        // GET: Employee
        public ActionResult Index()
        {
            return View(Employee_List);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (collection["nom"] == "")
            {
                ModelState.AddModelError("nom", "Merci de saisir un nom");
            }
            if (collection["prenom"] == "")
            {
                ModelState.AddModelError("prenom", "Merci de saisir un prenom");
            }
            if (collection["password"] == "")
            {
                ModelState.AddModelError("paswword", "Merci de saisir un mot de passe");
            }
            if (ModelState.IsValid)
            {

                Employee New_Employee = new Employee();
                //Nom en Majuscule
                New_Employee.nom = collection["nom"].ToUpper();
                //Prénom en Miniscule sauf la 1ere lettre
                New_Employee.prenom = collection["prenom"].First().ToString().ToUpper() + collection["prenom"].ToLower().Substring(1);
                New_Employee.password = collection["password"];                
                New_Employee.status = "absent";
               
                try
                {            
                    bool isExist = this.FindEmployee(New_Employee.prenom,New_Employee.nom);
                    if (!isExist)
                    {
                        bool isInserted = Employee_Context.Upsert<Employee>(New_Employee);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Cet employee existe déjà");
                        return View(New_Employee);
                    }
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }

        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            bool ret = Employee_Context.Delete<Employee>(id);
            Employee_List = Employee_Context.GetData<Employee>();

            return View("Index",Employee_List);
        }

        // POST: Employee/Delete/5
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
