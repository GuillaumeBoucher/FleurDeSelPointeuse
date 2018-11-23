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
    public partial class ctrl_AddFisrtAdmin : UserControl
    {

        public event EventHandler AdminIsSavedEvent;
        public bool AdminMode  { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string password { get; set; }

        public ctrl_AddFisrtAdmin()
        {
            InitializeComponent();
        }


        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show(bool FromParentAdminMode,string InfoMessage)
        {
            this.textBox_nom.Text = "";
            this.textBox_prenom.Text = "";
            this.textBox_password1.Text = "";
            this.textBox_password2.Text = "";
            this.AdminMode = FromParentAdminMode;
            this.label_informations.Text = InfoMessage;

            this.BringToFront();
            this.Visible = true;
            this.Dock = DockStyle.Fill;
        }


        private void Button_Enregister_Click(object sender, EventArgs e)
        {
            string nom = this.textBox_nom.Text;
            string prenom = this.textBox_prenom.Text;
            string pass1 = this.textBox_password1.Text;
            string pass2 = this.textBox_password2.Text;

            //verification si les deux mots de passes sont identique
            if(pass1 == pass2)
            {
                bool etat = true;
                
                if (nom == "") { etat = false; this.label_nom_status.Text = " - <Nom> ne dois pas etre vide"; } else { this.label_nom_status.Text = ""; }
                if (prenom == "") { etat = false; this.label_prenom_status.Text = " - <Prenom> ne dois pas etre vide"; } else { this.label_prenom_status.Text = ""; }
                if (pass1 == "") { etat = false; this.label_pass1_status.Text = " - <Mot de passe> ne dois pas etre vide";  } else { this.label_pass1_status.Text = ""; }
                if (pass2 == "") { etat = false; this.label_pass2_status.Text = " - <Mot de passe> ne dois pas etre vide";  } else { this.label_pass2_status.Text = ""; }

                if (etat)
                {
                    //les infos sont ok 
                    this.nom = this.textBox_nom.Text;
                    this.prenom = this.textBox_prenom.Text;
                    this.password = this.textBox_password2.Text;
                    this.hide();

                    //Envoie l'évenement au parent                                  
                    if (this.AdminIsSavedEvent != null) { this.AdminIsSavedEvent(sender, e); };
                }
               
            }
            else
            {
                this.label_pass2_status.Text = "Les mots de passes doivent être identiques";
            }
        }
             
    }
}
