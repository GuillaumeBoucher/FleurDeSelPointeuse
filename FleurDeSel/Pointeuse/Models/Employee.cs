using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointeuse
{
    public class Employee
    {

        public dbContext _context { get; set; }            


        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        public Employee()
        {

        }
        public Employee(dbContext _ctx)
        {
            this._context = _ctx;
        }

        //public bool isExist()
        //{
        //    bool _ret = false;
        //    List<Employee> Employee_List = _context.GetData<Employee>();
        //    List<Employe> FindList = Employee_List.Where(x => x.Prenom == this.Prenom && x.Nom == this.Nom).ToList();
        //    if (FindList.Count > 0)
        //    {
        //        _ret = true;
        //    }
        //    return _ret;
        //}

        public void UpSert()
        {
            List<Employee> Employee_List = _context.GetData<Employee>();
            Employee_List.Add(this);
            _context.Upsert(Employee_List);

        }

        public List<Employee> GetAll()
        {
            return _context.GetData<Employee>();

        }

        public void Delete(int id)
        {
            _context.Delete<Employee>(id);
        }


    }
}
