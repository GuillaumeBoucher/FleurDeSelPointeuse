using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pointeuse
{
    public partial class TimeTracker : Form
    {
        public TimeTracker()
        {
            InitializeComponent();
            ctrl_Employes1.ButtonClick += new EventHandler(Employes_event_create);
            ctrl_Employes_new1.ButtonClick_cancel += new EventHandler(Employes_event_new);
            ctrl_Employes_new1.ButtonClick_save += new EventHandler(Employes_event_new);
            ctrl_Employes1.RefreshGrid();

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Event Employes

        //handle the event : boutton créer un employé
        protected void Employes_event_create(object sender, EventArgs e)
        {            
            ctrl_Employes1.hide();
            ctrl_Employes_new1.show();
        }

        //handle the event : boutton Save ou Cancel
        protected void Employes_event_new(object sender, EventArgs e)
        {
            ctrl_Employes_new1.hide();
            ctrl_Employes1.show();
            string name = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Name;
            
            if(name == "bunifuThinButton_save")
            {
                Employe EmployeToSave = ctrl_Employes_new1.NewEmploye;
                //affichage
                ctrl_Employes1.RefreshGrid();

            }

        }
        #endregion
        
        private void bunifuFlatButton_Accueil_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            ctrl_Employes1.hide();
            ctrl_Pointeuse1.hide();
        }

        private void bunifuFlatButton_Employées_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            ctrl_Employes1.show();
            ctrl_Pointeuse1.hide();

        }

        private void bunifuFlatButton_Pointeuse_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            ctrl_Employes1.hide();
            ctrl_Pointeuse1.RefreshCombo();
            ctrl_Pointeuse1.show();
        }

        private void bunifuFlatButton_Paies_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            ctrl_Employes1.hide();
            ctrl_Pointeuse1.Hide();
            
        }

       
    }
}
