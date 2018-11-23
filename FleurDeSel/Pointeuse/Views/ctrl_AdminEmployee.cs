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
    public partial class ctrl_AdminEmployee : UserControl
    {

        private List<Employee> _ListOfEmployee = new List<Employee>();
        private dbContext _context { get; set; }
        private ctrl_AddFisrtAdmin _AddUserControl { get; set; }
        public ctrl_AdminEmployee()
        {
            InitializeComponent();
           
            
           
        }

        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show(List<Employee> ListOfEmployee, dbContext Context, ctrl_AddFisrtAdmin AddUserControl)
        {
            
            this.BringToFront();
            this.Dock = DockStyle.Fill;
            this._ListOfEmployee = ListOfEmployee;
            this._context = Context;
            this._AddUserControl = AddUserControl;
            this.RefreshGrid();
            this.Visible = true;
            
        }

        public void RefreshGrid()
        {
            this.DataGrid_employe.AllowUserToAddRows = true;
            this.DataGrid_employe.Rows.Clear();
            foreach (Employee emp in this._ListOfEmployee)
            {
                int NbRows = this.DataGrid_employe.Rows.Count - 1;
                this.DataGrid_employe.Rows.Add();
                this.DataGrid_employe.Rows[NbRows].Cells[0].Value = emp.id;
                this.DataGrid_employe.Rows[NbRows].Cells[1].Value = emp.nom;
                this.DataGrid_employe.Rows[NbRows].Cells[2].Value = emp.prenom;
                this.DataGrid_employe.Rows[NbRows].Cells[3].Value = "********";//emp.Password;
                if(emp.status == "admin")
                {
                    this.DataGrid_employe.Rows[NbRows].Cells[4].Value = "Oui";//is admin
                    this.DataGrid_employe.Rows[NbRows].Cells[5].Value = "-";
                }
                else
                {
                    this.DataGrid_employe.Rows[NbRows].Cells[4].Value = "Non";// is admin
                    this.DataGrid_employe.Rows[NbRows].Cells[5].Value = emp.status;
                }               

            }
            this.DataGrid_employe.AllowUserToAddRows = false;
        }

        private void DataGrid_employe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            this.label_info.Text = "";

            int SelectedRowCount = this.DataGrid_employe.SelectedRows.Count;
            if(SelectedRowCount > 0)
            {
                string IsAdmin = (string)this.DataGrid_employe.SelectedRows[0].Cells[4].Value;
                if(IsAdmin == "Oui")
                {
                    this.label_info.Text = "Le compte Admin ne peut pas être suprimé.";
                }
                else
                {
                    int EmployeID = (int)this.DataGrid_employe.SelectedRows[0].Cells[0].Value;
                    //delete Employee
                    _context.Delete<Employee>(EmployeID);
                    //Efface la ligne de la datagrid
                    int RowIndex = this.DataGrid_employe.SelectedRows[0].Index;
                    this.DataGrid_employe.Rows.RemoveAt(RowIndex);

                }
            }
            else
            {
                this.label_info.Text = "Merci de selectioner un employé";
            }

        }

        private void DataGrid_employe_SelectionChanged(object sender, EventArgs e)
        {
            this.label_info.Text = "";
        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            this._AddUserControl.show(false, "Pour créer un nouveau compte merci de saisir les informations ci-dessous.");
            this.hide();
        }
    }
}
