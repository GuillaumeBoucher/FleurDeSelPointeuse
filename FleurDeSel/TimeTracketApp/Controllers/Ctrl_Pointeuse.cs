using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointeuse
{
    public partial class Ctrl_Pointeuse : UserControl
    {
        private Employe SelectedEmploye {get;set;}

        public Ctrl_Pointeuse()
        {
            if (!this.DesignMode)
            { 
                InitializeComponent();
            }
        }

        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show()
        {
            this.BringToFront();
            this.Visible = true;
            this.Dock = DockStyle.Fill;
        }

        private void Ctrl_Pointeuse_Load(object sender, EventArgs e)
        {
            this.RefreshCombo();
            if(this.bunifuDropdown1.selectedIndex == -1)
            {
                this.bunifuCustomLabel1.Text = "Selectionner un utilisteur";
            }            
        }

        public void RefreshCombo()
        {
            //clear
            this.bunifuDropdown1.Clear();

            //Populate ComboBox
            Employe _objEmploye = new Employe();
            List<Employe> ListOfEmploye = _objEmploye.GetAll();
            foreach (Employe emp in ListOfEmploye)
            {
                string usr = emp.Prenom + " " + emp.Nom;
                this.bunifuDropdown1.AddItem(usr);
            }

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            string usr = ((Bunifu.Framework.UI.BunifuDropdown)sender).selectedValue;
            string[] ListUsr = usr.Split(' ');
            string usr_prenom = ListUsr[0];
            string usr_nom = ListUsr[1];

            Employe _objEmploye = new Employe();

            this.SelectedEmploye = _objEmploye.Find(usr_prenom, usr_nom);
            this.bunifuCustomLabel1.Text = "Saisisier votre mot de passe puis connecter vous";
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string password = this.bunifuMetroTextbox1.Text;

            if(this.SelectedEmploye.Password == password )
            {
                this.bunifuCustomLabel1.Text = "Ok";
            }
            else
            {
                this.bunifuCustomLabel1.Text = "Mot de passe incorecte Saisisier votre mot de passe puis connecter vous";
            }
        }
    }
}
