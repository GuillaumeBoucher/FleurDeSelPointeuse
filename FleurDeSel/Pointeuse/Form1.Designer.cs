namespace Pointeuse
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_top = new System.Windows.Forms.Panel();
            this.Label_LoggedUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Button_Logout = new System.Windows.Forms.LinkLabel();
            this.Button_Rapport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Pointeuse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Admin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ctrl_Home1 = new Pointeuse.Views.ctrl_Home();
            this.ctrl_Pointeuse1 = new Pointeuse.Views.ctrl_Pointeuse();
            this.ctrl_Login1 = new Pointeuse.Views.ctrl_Login();
            this.ctrl_Rapports1 = new Pointeuse.Views.ctrl_Rapports();
            this.ctrl_AdminEmployee1 = new Pointeuse.Views.ctrl_AdminEmployee();
            this.ctrl_AddFisrtAdmin1 = new Pointeuse.Views.ctrl_AddFisrtAdmin();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel_top.Controls.Add(this.Label_LoggedUser);
            this.panel_top.Controls.Add(this.Button_Logout);
            this.panel_top.Controls.Add(this.Button_Rapport);
            this.panel_top.Controls.Add(this.Button_Pointeuse);
            this.panel_top.Controls.Add(this.Button_Admin);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1051, 71);
            this.panel_top.TabIndex = 0;
            // 
            // Label_LoggedUser
            // 
            this.Label_LoggedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_LoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoggedUser.ForeColor = System.Drawing.Color.DarkCyan;
            this.Label_LoggedUser.Location = new System.Drawing.Point(724, 13);
            this.Label_LoggedUser.Name = "Label_LoggedUser";
            this.Label_LoggedUser.Size = new System.Drawing.Size(324, 22);
            this.Label_LoggedUser.TabIndex = 4;
            this.Label_LoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button_Logout
            // 
            this.Button_Logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_Logout.AutoSize = true;
            this.Button_Logout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Logout.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.Button_Logout.Location = new System.Drawing.Point(923, 35);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(116, 23);
            this.Button_Logout.TabIndex = 3;
            this.Button_Logout.TabStop = true;
            this.Button_Logout.Text = "Déconnection";
            this.Button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Button_LogoutClick);
            // 
            // Button_Rapport
            // 
            this.Button_Rapport.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_Rapport.BackColor = System.Drawing.Color.Teal;
            this.Button_Rapport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Rapport.BorderRadius = 0;
            this.Button_Rapport.ButtonText = "Rapports";
            this.Button_Rapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Rapport.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Rapport.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Rapport.Iconimage = null;
            this.Button_Rapport.Iconimage_right = null;
            this.Button_Rapport.Iconimage_right_Selected = null;
            this.Button_Rapport.Iconimage_Selected = null;
            this.Button_Rapport.IconMarginLeft = 0;
            this.Button_Rapport.IconMarginRight = 0;
            this.Button_Rapport.IconRightVisible = true;
            this.Button_Rapport.IconRightZoom = 0D;
            this.Button_Rapport.IconVisible = true;
            this.Button_Rapport.IconZoom = 90D;
            this.Button_Rapport.IsTab = false;
            this.Button_Rapport.Location = new System.Drawing.Point(369, 13);
            this.Button_Rapport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Rapport.Name = "Button_Rapport";
            this.Button_Rapport.Normalcolor = System.Drawing.Color.Teal;
            this.Button_Rapport.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_Rapport.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Rapport.selected = false;
            this.Button_Rapport.Size = new System.Drawing.Size(170, 45);
            this.Button_Rapport.TabIndex = 2;
            this.Button_Rapport.Text = "Rapports";
            this.Button_Rapport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Rapport.Textcolor = System.Drawing.Color.White;
            this.Button_Rapport.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Rapport.Click += new System.EventHandler(this.Button_Rapport_Click);
            // 
            // Button_Pointeuse
            // 
            this.Button_Pointeuse.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_Pointeuse.BackColor = System.Drawing.Color.Teal;
            this.Button_Pointeuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Pointeuse.BorderRadius = 0;
            this.Button_Pointeuse.ButtonText = "Pointeuse";
            this.Button_Pointeuse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Pointeuse.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Pointeuse.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Pointeuse.Iconimage = null;
            this.Button_Pointeuse.Iconimage_right = null;
            this.Button_Pointeuse.Iconimage_right_Selected = null;
            this.Button_Pointeuse.Iconimage_Selected = null;
            this.Button_Pointeuse.IconMarginLeft = 0;
            this.Button_Pointeuse.IconMarginRight = 0;
            this.Button_Pointeuse.IconRightVisible = true;
            this.Button_Pointeuse.IconRightZoom = 0D;
            this.Button_Pointeuse.IconVisible = true;
            this.Button_Pointeuse.IconZoom = 90D;
            this.Button_Pointeuse.IsTab = false;
            this.Button_Pointeuse.Location = new System.Drawing.Point(13, 13);
            this.Button_Pointeuse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Pointeuse.Name = "Button_Pointeuse";
            this.Button_Pointeuse.Normalcolor = System.Drawing.Color.Teal;
            this.Button_Pointeuse.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_Pointeuse.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Pointeuse.selected = false;
            this.Button_Pointeuse.Size = new System.Drawing.Size(170, 45);
            this.Button_Pointeuse.TabIndex = 0;
            this.Button_Pointeuse.Text = "Pointeuse";
            this.Button_Pointeuse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Pointeuse.Textcolor = System.Drawing.Color.White;
            this.Button_Pointeuse.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Pointeuse.Click += new System.EventHandler(this.Button_Pointeuse_Click);
            // 
            // Button_Admin
            // 
            this.Button_Admin.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_Admin.BackColor = System.Drawing.Color.Teal;
            this.Button_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Admin.BorderRadius = 0;
            this.Button_Admin.ButtonText = "Administration";
            this.Button_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Admin.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Admin.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Admin.Iconimage = null;
            this.Button_Admin.Iconimage_right = null;
            this.Button_Admin.Iconimage_right_Selected = null;
            this.Button_Admin.Iconimage_Selected = null;
            this.Button_Admin.IconMarginLeft = 0;
            this.Button_Admin.IconMarginRight = 0;
            this.Button_Admin.IconRightVisible = true;
            this.Button_Admin.IconRightZoom = 0D;
            this.Button_Admin.IconVisible = true;
            this.Button_Admin.IconZoom = 90D;
            this.Button_Admin.IsTab = false;
            this.Button_Admin.Location = new System.Drawing.Point(191, 13);
            this.Button_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Admin.Name = "Button_Admin";
            this.Button_Admin.Normalcolor = System.Drawing.Color.Teal;
            this.Button_Admin.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_Admin.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Admin.selected = false;
            this.Button_Admin.Size = new System.Drawing.Size(170, 45);
            this.Button_Admin.TabIndex = 1;
            this.Button_Admin.Text = "Administration";
            this.Button_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Admin.Textcolor = System.Drawing.Color.White;
            this.Button_Admin.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Admin.Click += new System.EventHandler(this.Button_Admin_Click);
            // 
            // ctrl_Home1
            // 
            this.ctrl_Home1.Location = new System.Drawing.Point(444, 89);
            this.ctrl_Home1.Name = "ctrl_Home1";
            this.ctrl_Home1.Size = new System.Drawing.Size(143, 128);
            this.ctrl_Home1.TabIndex = 5;
            this.ctrl_Home1.Visible = false;
            // 
            // ctrl_Pointeuse1
            // 
            this.ctrl_Pointeuse1.Location = new System.Drawing.Point(623, 196);
            this.ctrl_Pointeuse1.Name = "ctrl_Pointeuse1";
            this.ctrl_Pointeuse1.Size = new System.Drawing.Size(93, 82);
            this.ctrl_Pointeuse1.TabIndex = 4;
            this.ctrl_Pointeuse1.Visible = false;
            // 
            // ctrl_Login1
            // 
            this.ctrl_Login1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrl_Login1.Location = new System.Drawing.Point(905, 89);
            this.ctrl_Login1.Name = "ctrl_Login1";
            this.ctrl_Login1.Size = new System.Drawing.Size(84, 82);
            this.ctrl_Login1.TabIndex = 2;
            this.ctrl_Login1.Visible = false;
            // 
            // ctrl_Rapports1
            // 
            this.ctrl_Rapports1.Location = new System.Drawing.Point(771, 196);
            this.ctrl_Rapports1.Name = "ctrl_Rapports1";
            this.ctrl_Rapports1.Size = new System.Drawing.Size(92, 82);
            this.ctrl_Rapports1.TabIndex = 5;
            this.ctrl_Rapports1.Visible = false;
            // 
            // ctrl_AdminEmployee1
            // 
            this.ctrl_AdminEmployee1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrl_AdminEmployee1.Location = new System.Drawing.Point(623, 89);
            this.ctrl_AdminEmployee1.Name = "ctrl_AdminEmployee1";
            this.ctrl_AdminEmployee1.Size = new System.Drawing.Size(94, 82);
            this.ctrl_AdminEmployee1.TabIndex = 3;
            this.ctrl_AdminEmployee1.Visible = false;
            // 
            // ctrl_AddFisrtAdmin1
            // 
            this.ctrl_AddFisrtAdmin1.AdminMode = false;
            this.ctrl_AddFisrtAdmin1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrl_AddFisrtAdmin1.Location = new System.Drawing.Point(903, 196);
            this.ctrl_AddFisrtAdmin1.Name = "ctrl_AddFisrtAdmin1";
            this.ctrl_AddFisrtAdmin1.nom = null;
            this.ctrl_AddFisrtAdmin1.password = null;
            this.ctrl_AddFisrtAdmin1.prenom = null;
            this.ctrl_AddFisrtAdmin1.Size = new System.Drawing.Size(86, 82);
            this.ctrl_AddFisrtAdmin1.TabIndex = 1;
            this.ctrl_AddFisrtAdmin1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 636);
            this.Controls.Add(this.ctrl_AdminEmployee1);
            this.Controls.Add(this.ctrl_Rapports1);
            this.Controls.Add(this.ctrl_AddFisrtAdmin1);
            this.Controls.Add(this.ctrl_Home1);
            this.Controls.Add(this.ctrl_Pointeuse1);
            this.Controls.Add(this.ctrl_Login1);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FleurDeSel - Pointeuse v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private Views.ctrl_AddFisrtAdmin ctrl_AddFisrtAdmin1;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Pointeuse;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Rapport;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Admin;
        private Views.ctrl_Login ctrl_Login1;
        private System.Windows.Forms.LinkLabel Button_Logout;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_LoggedUser;
        private Views.ctrl_AdminEmployee ctrl_AdminEmployee1;
        private Views.ctrl_Pointeuse ctrl_Pointeuse1;
        private Views.ctrl_Rapports ctrl_Rapports1;
        private Views.ctrl_Home ctrl_Home1;
    }
}

