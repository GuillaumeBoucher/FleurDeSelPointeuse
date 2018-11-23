using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pointeuse.Controllers
{
    public class PointeuseController : Controller
    {

        private static dbContext Employee_Context = new dbContext("C:/_dev/fleurdesel/FleurDeSel/db/employee.db");
        private static Employee  Employee_Current;


        private static dbContext WorkTime_Context = new dbContext("C:/_dev/fleurdesel/FleurDeSel/db/WorkTime.db");
        private static List<TimeData> WorkTime;

        private static dbContext PauseTime_Context = new dbContext("C:/_dev/fleurdesel/FleurDeSel/db/PauseTime.db");
        private static List<TimeData> PauseTime;


        private List<TimeData> GetTimeData(dbContext context, int id)
        {
            List<TimeData> _ret= null;
                        
            //get only last 3 days data
            DateTime TreeDaysInPast = DateTime.Now.AddDays(-3);
            _ret = context.GetData<TimeData>().Where(x => x.EmployeeID == id && x.Start > TreeDaysInPast).ToList();
            if(_ret.Count == 0)
            {
                _ret = null;
            }          
            return _ret;
        }

        private string GetTotalWorkTime(List<TimeData>  WorkTime2)
        {
            string _ret = "";
            TimeSpan total = new TimeSpan();
            if(WorkTime2 != null)
            { 
                foreach (TimeData td in WorkTime2)
                {
                    if (td.Start != null && td.End != null)
                    {
                        TimeSpan t1 = td.End.Value.Subtract(td.Start.Value);
                        total = total + t1;
                    }                    
                }
            }
            _ret = total.ToString();
            return _ret;
        }

        // GET: Pointeuse
        public ActionResult Index(int id)
        {
            Employee_Current = Employee_Context.GetDataById<Employee>(id);
            WorkTime = GetTimeData(WorkTime_Context, id);
            PauseTime = GetTimeData(PauseTime_Context, id);

            ViewBag.WorkTime = GetTimeData(WorkTime_Context, id);
            ViewBag.PauseTime = GetTimeData(PauseTime_Context, id);
            ViewBag.TotalWorkTime = GetTotalWorkTime(WorkTime);
            ViewBag.TotalPauseTime = GetTotalWorkTime(PauseTime);

            return View("Index",Employee_Current);
        }

        public ActionResult StartService(int id)
        {
            WorkTime = GetTimeData(WorkTime_Context, id);
            
            TimeData NewWork = new TimeData();
            
            NewWork.EmployeeID = Employee_Current.id;
            NewWork.Start = DateTime.Now;
            if(WorkTime == null)
            { 
                WorkTime = new List<TimeData>();
            }
            WorkTime.Add(NewWork);
            int isSaveInt = WorkTime_Context.Upsert<TimeData>(WorkTime);

            Employee_Current.status = "service";
            bool isSave = Employee_Context.Update<Employee>(Employee_Current);

            ViewBag.WorkTime = WorkTime;            
            ViewBag.PauseTime = GetTimeData(PauseTime_Context, id);
            ViewBag.TotalWorkTime = GetTotalWorkTime(WorkTime);
            ViewBag.TotalPauseTime = GetTotalWorkTime(PauseTime);

            return View("Index", Employee_Current);
        }

        

        public ActionResult EndService(int id)
        {
            WorkTime = GetTimeData(WorkTime_Context, id);
            if (WorkTime == null)
            {

            }
            else
            {
                int Indice = WorkTime.Count - 1;  // recupère la dernière entrée ( a vérifier si on change d'utilisateur ? )
                WorkTime[Indice].End = DateTime.Now;
                int isSaveInt = WorkTime_Context.Upsert<TimeData>(WorkTime);

                Employee_Current.status = "absent";
                bool isSave = Employee_Context.Update<Employee>(Employee_Current);

            }

            ViewBag.WorkTime = WorkTime;
            ViewBag.PauseTime = GetTimeData(PauseTime_Context, id);
            ViewBag.TotalWorkTime = GetTotalWorkTime(WorkTime);
            ViewBag.TotalPauseTime = GetTotalWorkTime(PauseTime);

            return View("Index", Employee_Current);

                       

        }

        public ActionResult StartPause(int id)
        {
            PauseTime = GetTimeData(PauseTime_Context, id);
            
            TimeData NewPause = new TimeData();
            
            NewPause.EmployeeID = Employee_Current.id;
            NewPause.Start = DateTime.Now;

            PauseTime = new List<TimeData>();
            PauseTime.Add(NewPause);
            int isSaveInt = PauseTime_Context.Upsert<TimeData>(PauseTime);

            Employee_Current.status = "pause";
            bool isSave = Employee_Context.Update<Employee>(Employee_Current);
                        
            ViewBag.WorkTime = GetTimeData(WorkTime_Context, id);
            ViewBag.PauseTime = PauseTime;
            ViewBag.TotalWorkTime = GetTotalWorkTime(WorkTime);
            ViewBag.TotalPauseTime = GetTotalWorkTime(PauseTime);

            return View("Index",Employee_Current);
        }

        public ActionResult EndPause(int id)
        {
            PauseTime = GetTimeData(PauseTime_Context, id);
            if (PauseTime == null)
            {

            }
            else
            {
                int Indice = PauseTime.Count - 1;  // recupère la dernière entrée ( a vérifier si on change d'utilisateur ? )
                PauseTime[Indice].End = DateTime.Now;
                int isSaveInt = PauseTime_Context.Upsert<TimeData>(PauseTime);

                Employee_Current.status = "service";                    
                bool isSave = Employee_Context.Update<Employee>(Employee_Current);                

            }

            ViewBag.WorkTime = GetTimeData(WorkTime_Context, id);
            ViewBag.PauseTime = PauseTime;
            ViewBag.TotalWorkTime = GetTotalWorkTime(WorkTime);
            ViewBag.TotalPauseTime = GetTotalWorkTime(PauseTime);


            return View("Index", Employee_Current);
        }




        // GET: Pointeuse/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Pointeuse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pointeuse/Create
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

        // GET: Pointeuse/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pointeuse/Edit/5
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

        // GET: Pointeuse/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pointeuse/Delete/5
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
