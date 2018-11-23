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
    public partial class Ctrl_Employes_new : UserControl
    {
        private Employe _NewEmploye = null;

        //constructeur
        public Ctrl_Employes_new()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
                        
        }
        
        public event EventHandler ButtonClick_cancel;
        public event EventHandler ButtonClick_save;
        private void BunifuThinButton_Cancel_Click(object sender, EventArgs e)
        {
            this.label_status.Text = "";

            //bubble the event up to the parent
            if (this.ButtonClick_save != null) 
                this.ButtonClick_cancel(sender, e);
        }                
        private void BunifuThinButton_Save_Click(object sender, EventArgs e)
        {
            // On vérifier si les deux password sont identique
            if (this.bunifuMetroTextbox_Password1.Text == this.bunifuMetroTextbox_Password2.Text)
            {
                
                this._NewEmploye = new Employe(this.bunifuMetroTextbox_prenom.Text, this.bunifuMetroTextbox_Nom.Text, this.bunifuMetroTextbox_Password1.Text);
                
                // on verifie la syntaxte 
                List<string> _isOk = _NewEmploye.isOk();
                if (_isOk.Count == 0)
                {
                    bool isExist = _NewEmploye.isExist();
                    if (isExist)
                    {
                        this.label_status.Text = "Cet Employé existe déjà";
                    }
                    else
                    {

                        //sauvegarde
                        _NewEmploye.UpSert();

                        this.label_status.Text = "";
                        this.bunifuMetroTextbox_prenom.Text = "";
                        this.bunifuMetroTextbox_Nom.Text = "";
                        this.bunifuMetroTextbox_Password1.Text = "";
                        this.bunifuMetroTextbox_Password2.Text = "";




                        //Envoie l'évenement au parent
                        if (this.ButtonClick_save != null)
                            this.ButtonClick_save(sender, e);                        
                    }
                }
                else
                {
                    //il y a des erreurs
                    this.label_status.Text = _isOk[0] + Environment.NewLine;
                    for(int i = 1; i<= _isOk.Count -1 ;i++)
                    {
                        this.label_status.Text = this.label_status.Text + _isOk[i] + Environment.NewLine;

                    }                    
                }
            }
            else
            {
                label_status.Text = "Les deux mots de passe sont diferent";
            }                              

        }

        public Employe NewEmploye
        {   
            get
            {
                return _NewEmploye;                 
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

    }
}
