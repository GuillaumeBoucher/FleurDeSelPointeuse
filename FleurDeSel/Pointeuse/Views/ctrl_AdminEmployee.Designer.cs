namespace Pointeuse.Views
{
    partial class ctrl_AdminEmployee
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_AdminEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.Button_Del = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_New = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.DataGrid_employe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_employe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.Button_Del);
            this.panel1.Controls.Add(this.Button_New);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 46);
            this.panel1.TabIndex = 0;
            // 
            // label_info
            // 
            this.label_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_info.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DarkRed;
            this.label_info.Location = new System.Drawing.Point(328, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(492, 46);
            this.label_info.TabIndex = 2;
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Del
            // 
            this.Button_Del.ActiveBorderThickness = 1;
            this.Button_Del.ActiveCornerRadius = 20;
            this.Button_Del.ActiveFillColor = System.Drawing.Color.Teal;
            this.Button_Del.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Del.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
            this.Button_Del.BackColor = System.Drawing.Color.Aquamarine;
            this.Button_Del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Del.BackgroundImage")));
            this.Button_Del.ButtonText = "Suprimer";
            this.Button_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Del.ForeColor = System.Drawing.Color.Teal;
            this.Button_Del.IdleBorderThickness = 1;
            this.Button_Del.IdleCornerRadius = 20;
            this.Button_Del.IdleFillColor = System.Drawing.Color.White;
            this.Button_Del.IdleForecolor = System.Drawing.Color.Teal;
            this.Button_Del.IdleLineColor = System.Drawing.Color.Teal;
            this.Button_Del.Location = new System.Drawing.Point(161, 1);
            this.Button_Del.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.Size = new System.Drawing.Size(146, 45);
            this.Button_Del.TabIndex = 1;
            this.Button_Del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Button_New
            // 
            this.Button_New.ActiveBorderThickness = 1;
            this.Button_New.ActiveCornerRadius = 20;
            this.Button_New.ActiveFillColor = System.Drawing.Color.Teal;
            this.Button_New.ActiveForecolor = System.Drawing.Color.White;
            this.Button_New.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
            this.Button_New.BackColor = System.Drawing.Color.Aquamarine;
            this.Button_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_New.BackgroundImage")));
            this.Button_New.ButtonText = "Nouveau";
            this.Button_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_New.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_New.ForeColor = System.Drawing.Color.Teal;
            this.Button_New.IdleBorderThickness = 1;
            this.Button_New.IdleCornerRadius = 20;
            this.Button_New.IdleFillColor = System.Drawing.Color.White;
            this.Button_New.IdleForecolor = System.Drawing.Color.Teal;
            this.Button_New.IdleLineColor = System.Drawing.Color.Teal;
            this.Button_New.Location = new System.Drawing.Point(5, 1);
            this.Button_New.Margin = new System.Windows.Forms.Padding(5);
            this.Button_New.Name = "Button_New";
            this.Button_New.Size = new System.Drawing.Size(146, 45);
            this.Button_New.TabIndex = 0;
            this.Button_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_New.Click += new System.EventHandler(this.Button_New_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MediumAquamarine;
            this.bunifuCards1.Controls.Add(this.DataGrid_employe);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 46);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(820, 474);
            this.bunifuCards1.TabIndex = 1;
            // 
            // DataGrid_employe
            // 
            this.DataGrid_employe.AllowUserToAddRows = false;
            this.DataGrid_employe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_employe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_employe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_employe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_employe.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_employe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_employe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGrid_employe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_employe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_employe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Password,
            this.isAdmin,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_employe.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_employe.DoubleBuffered = true;
            this.DataGrid_employe.EnableHeadersVisualStyles = false;
            this.DataGrid_employe.HeaderBgColor = System.Drawing.Color.Teal;
            this.DataGrid_employe.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGrid_employe.Location = new System.Drawing.Point(0, 5);
            this.DataGrid_employe.Name = "DataGrid_employe";
            this.DataGrid_employe.ReadOnly = true;
            this.DataGrid_employe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGrid_employe.RowHeadersVisible = false;
            this.DataGrid_employe.RowTemplate.Height = 24;
            this.DataGrid_employe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_employe.Size = new System.Drawing.Size(818, 454);
            this.DataGrid_employe.TabIndex = 1;
            this.DataGrid_employe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_employe_CellContentClick);
            this.DataGrid_employe.SelectionChanged += new System.EventHandler(this.DataGrid_employe_SelectionChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Pointeuse.Employee);
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Mot de passe";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // isAdmin
            // 
            this.isAdmin.HeaderText = "Administrateur";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ctrl_AdminEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Name = "ctrl_AdminEmployee";
            this.Size = new System.Drawing.Size(820, 520);
            this.panel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_employe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_New;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_employe;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Del;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
