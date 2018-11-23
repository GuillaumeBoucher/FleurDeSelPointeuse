using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointeuse.Views
{
    public partial class ctrl_Home : UserControl
    {

        private dbContext _DbContext_citation { get; set; }
        private dbContext _DbContext_employee { get; set; }
        private dbContext _DbContext_timedate { get; set; }
        public ctrl_Home()
        {
            InitializeComponent();
            DateTime n = DateTime.Now;
            this.label_date.Text = n.ToLongDateString() + " " + n.ToLongTimeString();
        }

        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show(Citation citationForToday,List<Employee> employees, List<TimeData> timeDatas, dbContext _dbContext_citation, dbContext _dbContext_employee,dbContext _dbContext_timedate)
        {
            this._DbContext_citation = _dbContext_citation;
            this._DbContext_employee = _dbContext_employee;
            this._DbContext_timedate = _dbContext_timedate;
            
            //Citation
            this.label_citation.Text = citationForToday.Texte;
            this.label_auteur.Text = " Auteur: " + citationForToday.Auteur;
            if (citationForToday.Source == null)
            {
                this.label_source.Text = " Source: Inconnue";
            }
            else
            { 
                this.label_source.Text = " Source: " + citationForToday.Source;
            }
            //Employes
            this.label_emp_repos.Text = employees.Where(x => x.status == "new").Count().ToString();
            this.label_emp_pause.Text = employees.Where(x => x.status == "start_pause").Count().ToString();
            this.label_emp_work.Text = employees.Where(x => x.status == "start_work").Count().ToString();
            this.label_emp_total.Text = employees.Count.ToString();
            
            //TimeData
            DateTime EndDateFilter = DateTime.Now;
            DateTime StartDateFilter = EndDateFilter.AddHours(-6);
            timeDatas = timeDatas.Where(x =>x.status !="admin" && x.StartWork >= StartDateFilter && x.StartWork <= EndDateFilter).ToList();
            if (timeDatas.Count > 0)
            {
                //Repas
                this.label_repas.Text = timeDatas.Where(x => x.repas == true).Count().ToString();

                TimeSpan TimeWork = new TimeSpan();
                TimeSpan TimePause = new TimeSpan();
                foreach (TimeData t in timeDatas)
                {

                    /* Calcul du temp de pause */
                    int NbPauses = t.ListOfEndPause.Count;
                    
                    TimeSpan ToTalPauseTime = new TimeSpan();
                    for (int i = 0; i < NbPauses; i++)
                    {
                        DateTime pStart = t.ListOfStartPause[i];
                        DateTime pEnd = t.ListOfEndPause[i];

                        TimeSpan ts = new TimeSpan();
                        ts = pEnd.Subtract(pStart);
                        ts = TimeSpan.FromMinutes(1 * Math.Ceiling(ts.TotalMinutes / 1));

                        ToTalPauseTime = ToTalPauseTime.Add(ts);
                        TimePause = TimePause + ToTalPauseTime;
                    }

                    this.label_time_pause.Text = TimePause.ToString();



                    //calcul du temp de travail
                    TimeSpan T_TimeWork = new TimeSpan();
                    if (t.EndWork.Year == 1)
                    {
                        T_TimeWork = (DateTime.Now).Subtract(t.StartWork);
                    }
                    else
                    {
                        T_TimeWork = (t.EndWork).Subtract(t.StartWork);
                    }
                    T_TimeWork = (TimeSpan.FromMinutes(1 * Math.Ceiling(T_TimeWork.TotalMinutes / 1)));
                    TimeWork = TimeWork + T_TimeWork;
                }
                this.label_time_work.Text = TimeWork.ToString();
            }
            else
            {
                this.label_repas.Text = "?";
                this.label_time_pause.Text = "?";
                this.label_time_work.Text = "?";
            }
           


            this.BringToFront();
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            this.label_date.Text = n.ToLongDateString() + " " + n.ToLongTimeString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.hide();
            /* Control Home */
            //Init Citation
            List<Citation> ListOfCitations = this._DbContext_citation.GetData<Citation>();
            int NBCitations = ListOfCitations.Count;
            Random aleatoire = new Random();
            int RandomCitationID = aleatoire.Next(NBCitations); //Génère un entier compris entre 0 et NBCitations
            Citation _citationForToday = ListOfCitations[RandomCitationID];
            //Employes
            List<Employee> employees = this._DbContext_employee.GetData<Employee>();
            List<TimeData> timeDatas = this._DbContext_timedate.GetData<TimeData>();

            this.show(_citationForToday, employees, timeDatas,this._DbContext_citation,this._DbContext_employee,this._DbContext_timedate);
        }
    }
}
