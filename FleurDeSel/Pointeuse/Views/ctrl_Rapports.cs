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
    public partial class ctrl_Rapports : UserControl
    {
        public ctrl_Rapports()
        {
            InitializeComponent();
        }

        public void hide()
        {
            this.SendToBack();
            this.Visible = false;
        }
        public void show()
        {            
            this.BringToFront();
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }
    }
}