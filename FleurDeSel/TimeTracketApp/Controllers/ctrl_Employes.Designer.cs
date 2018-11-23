namespace Pointeuse
{
    partial class Ctrl_Employes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_Employes));
            this.panel_actions = new System.Windows.Forms.Panel();
            this.bunifuThinButton_Create = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid_employes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid_employes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_actions
            // 
            this.panel_actions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_actions.Controls.Add(this.label_status);
            this.panel_actions.Controls.Add(this.bunifuThinButton_Delete);
            this.panel_actions.Controls.Add(this.bunifuThinButton_Create);
            this.panel_actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_actions.Location = new System.Drawing.Point(0, 0);
            this.panel_actions.Name = "panel_actions";
            this.panel_actions.Size = new System.Drawing.Size(913, 58);
            this.panel_actions.TabIndex = 0;
            // 
            // bunifuThinButton_Create
            // 
            this.bunifuThinButton_Create.ActiveBorderThickness = 1;
            this.bunifuThinButton_Create.ActiveCornerRadius = 20;
            this.bunifuThinButton_Create.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuThinButton_Create.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton_Create.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuThinButton_Create.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton_Create.BackgroundImage")));
            this.bunifuThinButton_Create.ButtonText = "Créer";
            this.bunifuThinButton_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton_Create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Create.IdleBorderThickness = 1;
            this.bunifuThinButton_Create.IdleCornerRadius = 20;
            this.bunifuThinButton_Create.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton_Create.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Create.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Create.Location = new System.Drawing.Point(5, 5);
            this.bunifuThinButton_Create.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton_Create.Name = "bunifuThinButton_Create";
            this.bunifuThinButton_Create.Size = new System.Drawing.Size(164, 41);
            this.bunifuThinButton_Create.TabIndex = 0;
            this.bunifuThinButton_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton_Create.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomDataGrid_employes
            // 
            this.bunifuCustomDataGrid_employes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid_employes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid_employes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid_employes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bunifuCustomDataGrid_employes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid_employes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid_employes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid_employes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid_employes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid_employes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nom,
            this.prenom,
            this.password});
            this.bunifuCustomDataGrid_employes.DoubleBuffered = true;
            this.bunifuCustomDataGrid_employes.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid_employes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid_employes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuCustomDataGrid_employes.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid_employes.Location = new System.Drawing.Point(5, 64);
            this.bunifuCustomDataGrid_employes.Name = "bunifuCustomDataGrid_employes";
            this.bunifuCustomDataGrid_employes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid_employes.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid_employes.Size = new System.Drawing.Size(614, 413);
            this.bunifuCustomDataGrid_employes.TabIndex = 1;
            // 
            // no
            // 
            this.no.HeaderText = "#";
            this.no.Name = "no";
            this.no.Width = 47;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 70;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 92;
            // 
            // password
            // 
            this.password.HeaderText = "Mot de passe";
            this.password.Name = "password";
            this.password.Width = 136;
            // 
            // bunifuThinButton_Delete
            // 
            this.bunifuThinButton_Delete.ActiveBorderThickness = 1;
            this.bunifuThinButton_Delete.ActiveCornerRadius = 20;
            this.bunifuThinButton_Delete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuThinButton_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton_Delete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuThinButton_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton_Delete.BackgroundImage")));
            this.bunifuThinButton_Delete.ButtonText = "Supprimer";
            this.bunifuThinButton_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Delete.IdleBorderThickness = 1;
            this.bunifuThinButton_Delete.IdleCornerRadius = 20;
            this.bunifuThinButton_Delete.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton_Delete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Delete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.bunifuThinButton_Delete.Location = new System.Drawing.Point(194, 5);
            this.bunifuThinButton_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton_Delete.Name = "bunifuThinButton_Delete";
            this.bunifuThinButton_Delete.Size = new System.Drawing.Size(148, 41);
            this.bunifuThinButton_Delete.TabIndex = 1;
            this.bunifuThinButton_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton_Delete.Click += new System.EventHandler(this.bunifuThinButton_Delete_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.DarkRed;
            this.label_status.Location = new System.Drawing.Point(415, 16);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 28);
            this.label_status.TabIndex = 2;
            // 
            // ctrl_Employes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCustomDataGrid_employes);
            this.Controls.Add(this.panel_actions);
            this.Name = "ctrl_Employes";
            this.Size = new System.Drawing.Size(913, 698);
            this.panel_actions.ResumeLayout(false);
            this.panel_actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid_employes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_actions;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton_Create;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid_employes;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton_Delete;
        private System.Windows.Forms.Label label_status;
    }
}
