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
    public partial class ctrl_Login : UserControl
    {

        public event EventHandler LoginIsOk;
        private List<Employee> _ListOfEmployee = new List<Employee>();
        public Employee LoggedEmploye = new Employee();
        
       

        public ctrl_Login()
        {
            if (!DesignMode)
            { 
                InitializeComponent();
            }
        }

        public void hide()
        {
            this.textBox_password.Text = "";
            this.label_status_password.Text = "";
            this.SendToBack();
            this.Visible = false;
        }
        public void show(List<Employee> ListOfEmployee,bool OnlyAdmin)
        {

            this.textBox_password.Text = "";
            this.label_status_password.Text = "";
            this.label_status_employe.Text = "";
            this.comboBox_employees.SelectedItem = null;
            this.comboBox_employees.Items.Clear();

            if (OnlyAdmin)
            {
                this.label_informations.Text = "Choisir un Administrateur et valider le mot de passe.";
                ListOfEmployee = ListOfEmployee.Where(x => x.status == "admin").ToList();
                this._ListOfEmployee = ListOfEmployee;
            }
            else
            {
                this.label_informations.Text = "Choisir votre nom, puis valider votre mot de passe.";
                ListOfEmployee = ListOfEmployee.Where(x => x.status != "admin").ToList();

                this._ListOfEmployee = ListOfEmployee;
            }
            foreach (Employee emp in ListOfEmployee)
            {
                string UserName = emp.nom + " " + emp.prenom;
                this.comboBox_employees.Items.Add(UserName);
            }

            if(OnlyAdmin) { this.comboBox_employees.SelectedIndex = 0; }

            this.BringToFront();
            this.Visible = true;
            this.Dock = DockStyle.Fill;
        }


        private void Button_Quitter_Click(object sender, EventArgs e)
        {
            this.hide();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            int _id = this.comboBox_employees.SelectedIndex;
            if(_id == -1)
            {
                this.label_status_employe.Text = "Sélectionner un employée";
            }
            else
            {
                this.LoggedEmploye = _ListOfEmployee[_id];

                // On verifie si le password est le bon            
                if (this.textBox_password.Text == this.LoggedEmploye.password)
                {
                    this.label_status_password.Text = "";
                    this.label_status_employe.Text = "";                     
                    this.hide();
                    //Envoie l'évenement au parent                                  
                    if (this.LoginIsOk != null) { this.LoginIsOk(sender, e); };
                }
                else
                {
                    this.label_status_password.Text = "Mot de passe invalide.";
                }
                
            }


        }

   
    }
}
