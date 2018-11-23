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
    public partial class ctrl_Pointeuse : UserControl
    {
        private Employee _CurrentEmployee { get; set; }
        private dbContext _context { get; set; }
        private TimeData _CurentTimeData { get; set; }
        public ctrl_Pointeuse()
        {
            InitializeComponent();
        }

        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show(Employee CurentEmploye,dbContext Context)
        {
            this._CurrentEmployee = CurentEmploye;
            this._context = Context;
            this.LoadTimeData();


            this.BringToFront();
            this.Dock = DockStyle.Fill;            
            this.Visible = true;

        }

        private void LoadTimeData()
        {
            List<TimeData> ListOfTimeData = this._context.GetData<TimeData>();

            DateTime EndDateFilter = DateTime.Now;
            DateTime StartDateFilter = EndDateFilter.AddHours(-6);
            //DateTime StartDateFilter = EndDateFilter.AddDays(-1);
            //Filtre par Employé et date
            ListOfTimeData = ListOfTimeData.Where(x => x.EmployeId == this._CurrentEmployee.id && x.StartWork >= StartDateFilter && x.StartWork <= EndDateFilter).ToList();
            if(ListOfTimeData.Count > 0)
            {
                if(ListOfTimeData.Count == 1)
                {
                    // On est dans le cas ou une journée de travail est commencé 
                    this._CurentTimeData = new TimeData();
                    this._CurentTimeData = ListOfTimeData[0];
                    this.MiseAjourAffichage();

                }
                else
                {
                    // plusieurs journée de travail il y a un problème
                    // a vérifier si ce cas exist

                }

            }
            else
            {
                //Creation d'un timedata vide
                this._CurentTimeData = new TimeData();
                this._CurentTimeData.EmployeId = this._CurrentEmployee.id;
                this._CurentTimeData.status = "new";
                this._CurentTimeData.ListOfEndPause = new List<DateTime>();
                this._CurentTimeData.ListOfStartPause = new List<DateTime>();
                this._CurentTimeData.repas = this.Checkbox_Repas.Checked;

                //Sauvegarde des donnees
                this.SaveTime();
                this.MiseAjourAffichage();
            }
        }

        private void MiseAjourAffichage()
        {
            //update repas status
            this.Checkbox_Repas.Checked = this._CurentTimeData.repas; 

            /* Calcul du temp de pause */
            int NbPauses = this._CurentTimeData.ListOfEndPause.Count;
            this.label_PauseTime.Text = "--";
            this.label_PauseNbr.Text = NbPauses.ToString();

            TimeSpan ToTalPauseTime = new TimeSpan();
            for (int i=0;i<NbPauses;i++)
            {
                DateTime pStart = this._CurentTimeData.ListOfStartPause[i];
                DateTime pEnd = this._CurentTimeData.ListOfEndPause[i];

                TimeSpan ts = new TimeSpan();
                ts = pEnd.Subtract(pStart);
                ts = TimeSpan.FromMinutes(1 * Math.Ceiling(ts.TotalMinutes / 1));

                ToTalPauseTime = ToTalPauseTime.Add(ts);
                this.label_PauseTime.Text = ToTalPauseTime.ToString();
            }

            /* Calcul du temp de travail */
            TimeSpan TimeWork = new TimeSpan();
            if (this._CurentTimeData.EndWork.Year == 1)
            {
                TimeWork = (DateTime.Now).Subtract(this._CurentTimeData.StartWork);
            }
            else
            {                
                TimeWork = (this._CurentTimeData.EndWork).Subtract(this._CurentTimeData.StartWork);
            }
            TimeWork = TimeSpan.FromMinutes(1 * Math.Ceiling(TimeWork.TotalMinutes / 1));
            this.label_HeuresNBr.Text = TimeWork.ToString();
            switch (this._CurentTimeData.status)
            {
                case "new":
                    {
                        this.label_HeuresNBr.Text = "--";
                        this.label_DayStart.Text = "--";
                        this.label_DayEnd.Text = "--";
                        this.label_actuellement.Text = "En repos";
                        this.Button_StartWork.Enabled = true;
                        this.Button_StopWork.Enabled = false;
                        this.Button_StartPause.Enabled = false;
                        this.Button_StopPause.Enabled = false;
                        this.Checkbox_Repas.Enabled = false;
                        break;
                    }
                case "start_work":
                    {                        
                        this.label_DayStart.Text = this._CurentTimeData.StartWork.ToLongDateString() + " " + this._CurentTimeData.StartWork.ToLongTimeString();
                        this.label_DayEnd.Text = "--";
                        this.label_actuellement.Text = "Au travail";
                        this.Button_StartWork.Enabled = false;
                        this.Button_StopWork.Enabled = true;
                        this.Button_StartPause.Enabled = true;
                        this.Button_StopPause.Enabled = false;
                        this.Checkbox_Repas.Enabled = true;
                        break;
                    }
                case "end_work":
                    {
                        
                        this.label_actuellement.Text = "Journée terminée";
                        this.label_DayStart.Text = this._CurentTimeData.StartWork.ToLongDateString() + " " + this._CurentTimeData.StartWork.ToLongTimeString();
                        this.label_DayEnd.Text = this._CurentTimeData.EndWork.ToLongDateString() + " " + this._CurentTimeData.EndWork.ToLongTimeString();
                        this.Button_StartWork.Enabled = false;
                        this.Button_StopWork.Enabled = false;
                        this.Button_StartPause.Enabled = false;
                        this.Button_StopPause.Enabled = false;
                        this.Checkbox_Repas.Enabled = false;
                        break;
                    }
                case "start_pause":
                    {
                        this.label_actuellement.Text = "En pause";
                        this.label_DayStart.Text = this._CurentTimeData.StartWork.ToLongDateString() + " " + this._CurentTimeData.StartWork.ToLongTimeString();
                        this.label_DayEnd.Text = "--";
                                            
                        this.Button_StartWork.Enabled = false;
                        this.Button_StopWork.Enabled = false;
                        this.Button_StartPause.Enabled = false;
                        this.Button_StopPause.Enabled = true;
                        this.Checkbox_Repas.Enabled = true;
                        break;
                    }
            }
        }

        private void Button_StartWork_Click(object sender, EventArgs e)
        {
            this._CurentTimeData.StartWork = DateTime.Now;
            this._CurentTimeData.status = "start_work";
            this.SaveTime();
            MiseAjourAffichage();
        }
        private void Button_StopWork_Click(object sender, EventArgs e)
        {
            this._CurentTimeData.EndWork = DateTime.Now;
            this._CurentTimeData.status = "end_work";
            this.SaveTime();
            MiseAjourAffichage();
        }

        private void SaveTime()
        {
            this._context.Upsert<TimeData>(this._CurentTimeData);
        }

        private void Button_StartPause_Click(object sender, EventArgs e)
        {            
            this._CurentTimeData.ListOfStartPause.Add(DateTime.Now);
            this._CurentTimeData.status = "start_pause";
            this.SaveTime();
            MiseAjourAffichage();
        }

        private void Button_StopPause_Click(object sender, EventArgs e)
        {
            this._CurentTimeData.ListOfEndPause.Add(DateTime.Now);
            this._CurentTimeData.status = "start_work";
            this.SaveTime();
            MiseAjourAffichage();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Quitter_Click(object sender, EventArgs e)
        {
            this.hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            this.label_date.Text = n.ToLongDateString() + " " + n.ToLongTimeString();
        }

        private void Checkbox_Repas_OnChange(object sender, EventArgs e)
        {

            this._CurentTimeData.repas = this.Checkbox_Repas.Checked;

            //Sauvegarde des donnees
            this.SaveTime();
            this.MiseAjourAffichage();
        }
    }
    

}
