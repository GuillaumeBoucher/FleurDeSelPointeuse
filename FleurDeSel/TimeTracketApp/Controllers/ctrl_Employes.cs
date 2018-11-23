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
    public partial class Ctrl_Employes : UserControl
    {
        

        public Ctrl_Employes()
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
        public void show ()
        {
            this.BringToFront();
            this.Visible = true;
            this.Dock = DockStyle.Fill;
        }

        public void RefreshGrid()
        {
            Employe _objEmploye = new Employe();
            List<Employe> ListofEmployes = _objEmploye.GetAll();
            this.bunifuCustomDataGrid_employes.Rows.Clear();
            foreach(Employe emp in ListofEmployes)
            {
                this.bunifuCustomDataGrid_employes.Rows.Add();
                this.bunifuCustomDataGrid_employes.Rows[this.bunifuCustomDataGrid_employes.Rows.Count - 1].Cells[0].Value = emp.Id;
                this.bunifuCustomDataGrid_employes.Rows[this.bunifuCustomDataGrid_employes.Rows.Count - 1].Cells[1].Value = emp.Prenom;
                this.bunifuCustomDataGrid_employes.Rows[this.bunifuCustomDataGrid_employes.Rows.Count - 1].Cells[2].Value = emp.Nom;
                this.bunifuCustomDataGrid_employes.Rows[this.bunifuCustomDataGrid_employes.Rows.Count - 1].Cells[3].Value = "********";//emp.Password;
            }
        }

        public event EventHandler ButtonClick;
        protected void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void bunifuThinButton_Delete_Click(object sender, EventArgs e)
        {
            if(bunifuCustomDataGrid_employes.SelectedRows.Count > 0)
            {
                this.label_status.Text = "";
                foreach(DataGridViewRow r in bunifuCustomDataGrid_employes.SelectedRows)
                {
                    int Id = (int) r.Cells[0].Value;
                    Employe _objEmploye = new Employe();
                    _objEmploye.Delete(Id);
                }
                this.RefreshGrid();
            }
            else
            {
                this.label_status.Text = "Merci de selectioner un employé";
            }
        }
    }
}
