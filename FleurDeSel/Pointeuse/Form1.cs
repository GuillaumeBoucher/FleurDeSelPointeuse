using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointeuse
{
    public partial class Form1 : Form
    {

        private static string _GLOBAL_BATABASE_PATH { get; set; }
        private static string _EMPLOYEE_GLOBAL_BATABASE_PATH { get; set; }
        private static string _TIMEDATA_GLOBAL_BATABASE_PATH { get; set; }
        private static string _CITATIONS_GLOBAL_BATABASE_PATH { get; set; }
        private static dbContext _dbContext_employee { get; set; }
        private static dbContext _dbContext_timedate { get; set; }
        private static dbContext _dbContext_citation { get; set; }

        private Employee LoggedEmployee { get; set; }

              

        #region InitAndLoad
        public Form1()
        {
            InitializeComponent();
            //chemin des bases de données litedb 
            _GLOBAL_BATABASE_PATH = System.Configuration.ConfigurationManager.AppSettings["datapath"];
            _EMPLOYEE_GLOBAL_BATABASE_PATH = _GLOBAL_BATABASE_PATH + "/employees.db";
            _TIMEDATA_GLOBAL_BATABASE_PATH = _GLOBAL_BATABASE_PATH + "/timedata.db";
            _CITATIONS_GLOBAL_BATABASE_PATH = _GLOBAL_BATABASE_PATH + "/citations.db";
            //context 
            _dbContext_employee = new dbContext(_EMPLOYEE_GLOBAL_BATABASE_PATH);
            _dbContext_timedate = new dbContext(_TIMEDATA_GLOBAL_BATABASE_PATH);
            _dbContext_citation = new dbContext(_CITATIONS_GLOBAL_BATABASE_PATH);

            //Employer actuellement loggé 
            LoggedEmployee = new Employee();
            this.Button_Logout.Visible = false;
            this.Label_LoggedUser.Visible = false;

            ctrl_AddFisrtAdmin1.AdminIsSavedEvent += new EventHandler(AdminIsSavedEvent);
            ctrl_Login1.LoginIsOk += new EventHandler(LoginIsOk);
            
        }

        private void UpdateHome()
        {

            /* Control Home */
            //Init Citation
            List<Citation> ListOfCitations = _dbContext_citation.GetData<Citation>();
            int NBCitations = ListOfCitations.Count;
            Random aleatoire = new Random();
            int RandomCitationID = aleatoire.Next(NBCitations); //Génère un entier compris entre 0 et NBCitations
            Citation _citationForToday = ListOfCitations[RandomCitationID];
            //Employes
            List<Employee> employees = _dbContext_employee.GetData<Employee>();
            List<TimeData> timeDatas = _dbContext_timedate.GetData<TimeData>();

            ctrl_Home1.show(_citationForToday, employees, timeDatas, _dbContext_citation, _dbContext_employee, _dbContext_timedate);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            if(!File.Exists(_EMPLOYEE_GLOBAL_BATABASE_PATH))
            {
                // CREATION DU COMPTE ADMIN
                //1 - affichage de la form 
                ctrl_AddFisrtAdmin1.show(true, "Avant de commencer il faut creer un compte administrateur.");
            }
            else
            {

            }
        }
        #endregion

        #region ViewEvents
        protected void AdminIsSavedEvent(object sender,EventArgs e)
        {
            // CREATION DU COMPTE ADMIN
            //2 - recupération des valeurs
            Employee _AdminToSave = new Employee();

            _AdminToSave.nom = ctrl_AddFisrtAdmin1.nom;
            _AdminToSave.prenom = ctrl_AddFisrtAdmin1.prenom;
            _AdminToSave.password = ctrl_AddFisrtAdmin1.password;
            if(ctrl_AddFisrtAdmin1.AdminMode)
            { 
                _AdminToSave.status = "admin";
                
            }
            else
            {
                _AdminToSave.status = "new";
            }
            //3 - sauvegarde du compte admin                
            _dbContext_employee.Upsert<Employee>(_AdminToSave);

            if (_AdminToSave.status == "new")
            {
                //On affiche la liste des employees + ajout / supression
                ctrl_AdminEmployee1.show(_dbContext_employee.GetData<Employee>(), _dbContext_employee, ctrl_AddFisrtAdmin1);
            }
            else
            {
                UpdateHome();
                Test_InitAddEmployee();
            }
            

        }

        protected void LoginIsOk(object sender,EventArgs e)
        {
            this.LoggedEmployee = ctrl_Login1.LoggedEmploye;

            //On affiche l'utilisateur loggé
            this.Label_LoggedUser.Text = this.LoggedEmployee.nom + " " + this.LoggedEmployee.prenom;
            this.Label_LoggedUser.Visible = true;
            this.Button_Logout.Visible = true;

            if (this.LoggedEmployee.status == "admin")
            {
                //On affiche la liste des employees + ajout / supression
                ctrl_AdminEmployee1.show(_dbContext_employee.GetData<Employee>(),_dbContext_employee,ctrl_AddFisrtAdmin1);
            
            }
            else
            {
                // On affiche l'interface de pointeuse
                ctrl_Pointeuse1.show(this.LoggedEmployee,_dbContext_timedate);
            }
            

        }
        #endregion

        #region Menu button
        //Button du menu
        private void Button_Admin_Click(object sender, EventArgs e)
        {
            //Se logger
            Logout();
            List<Employee> ListOfEmployee = _dbContext_employee.GetData<Employee>();
            ctrl_Login1.show(ListOfEmployee,true);
        }

        private void Logout()
        {
            /*
            ctrl_AdminEmployee1.Visible = false;
            ctrl_Login1.Visible = false;
            ctrl_Pointeuse1.Visible = false;
            */
            ctrl_AdminEmployee1.hide();
            ctrl_Login1.hide();
            ctrl_Pointeuse1.hide();
            ctrl_Rapports1.hide();


            this.Button_Logout.Visible = false;
            this.Label_LoggedUser.Text = "";
            this.Label_LoggedUser.Visible = false;
            this.LoggedEmployee = new Employee();
        }

        private void Button_Pointeuse_Click(object sender, EventArgs e)
        {
            //Se logger
            Logout();
            List<Employee> ListOfEmployee = _dbContext_employee.GetData<Employee>();
            ctrl_Login1.show(ListOfEmployee, false);

        }

        #endregion
        private void Test_InitAddEmployee()
        {
            //Se logger
            List<Employee> ListOfEmployee = _dbContext_employee.GetData<Employee>();
            if(ListOfEmployee.Count == 1)
            {

                Employee g = new Employee();
                g.nom = "BOUCHER";
                g.prenom = "Guillaume";
                g.password = "1234";
                g.status = "new";


                Employee r = new Employee();
                r.nom = "ARNOU";
                r.prenom = "Rebecca";
                r.password = "1234";
                r.status = "new";
                ListOfEmployee.Add(g);
                ListOfEmployee.Add(r);
               
                _dbContext_employee.Upsert<Employee>(ListOfEmployee);

            }
        }

        private void Button_LogoutClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Logout();
        }

        private void Button_Rapport_Click(object sender, EventArgs e)
        {
            this.Logout();
            ctrl_Rapports1.show();
        }

       
    }
}
