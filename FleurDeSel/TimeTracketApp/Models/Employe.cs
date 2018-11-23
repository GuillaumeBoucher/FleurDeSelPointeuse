using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pointeuse.Dal;

namespace Pointeuse
{
    public class Employe
    {

        private dbContext _context = new dbContext("C:/_dev/fleurdesel/FleurDeSel/db/employe.db");

        //constructeur
        public int Id { get; set; }
        public Employe()
        {
        }

        public Employe Find(string prenom,string nom)
        {
            Employe _ret = null;

          List <Employe> ListOfEmployes = this.GetAll();
            List<Employe> FindEmployes = ListOfEmployes.Where(x => x.Nom == nom && x.Prenom == prenom).ToList();
            if(FindEmployes.Count > 0)
            {
               _ret = FindEmployes[0];
                
            }            
            return _ret;
        }

        public Employe(string Prenom,string Nom, string Password)
        {
            this.Prenom = Prenom;
            this.Nom = Nom;
            this.Password = Password;
        }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }
        public List<TimeData> ListOfTime { get; set; }

        public List<string> isOk()
        {
            List<string> _ret = new List<string>();

            if(this.Prenom == "")
            {
                _ret.Add(" < PRENOM > - Ne dois pas etre vide");
            }
            if (this.Nom == "")
            {
                _ret.Add(" < NOM > - Ne dois pas etre vide");
            }
            if (this.Password == "")
            {
                _ret.Add(" < PASSWORD > - Ne dois pas etre vide");
            }

            return _ret;
        }

        public bool isExist()
        {
            bool _ret = false;
            List<Employe> Employee_List = _context.GetData<Employe>();
            List<Employe> FindList = Employee_List.Where(x => x.Prenom == this.Prenom && x.Nom == this.Nom).ToList();
            if(FindList.Count > 0)
            {
                _ret = true;
            }
            return _ret;
        }

        public void UpSert()
        {
            List<Employe> Employee_List = _context.GetData<Employe>();
            Employee_List.Add(this);
            _context.Upsert(Employee_List);

        }

        public List<Employe> GetAll()
        {
            return _context.GetData<Employe>();
          
        }

        public void Delete(int id)
        {
            _context.Delete<Employe>(id);
        }

    }
}
