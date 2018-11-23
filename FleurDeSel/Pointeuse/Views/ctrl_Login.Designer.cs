namespace Pointeuse.Views
{
    partial class ctrl_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_Login));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label_status_employe = new System.Windows.Forms.Label();
            this.Button_OK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_employees = new System.Windows.Forms.ComboBox();
            this.label_informations = new System.Windows.Forms.Label();
            this.label_status_password = new System.Windows.Forms.Label();
            this.Button_Enregister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_pass1 = new System.Windows.Forms.Label();
            this.label_employees = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.label_status_employe);
            this.bunifuCards1.Controls.Add(this.Button_OK);
            this.bunifuCards1.Controls.Add(this.comboBox_employees);
            this.bunifuCards1.Controls.Add(this.label_informations);
            this.bunifuCards1.Controls.Add(this.label_status_password);
            this.bunifuCards1.Controls.Add(this.Button_Enregister);
            this.bunifuCards1.Controls.Add(this.textBox_password);
            this.bunifuCards1.Controls.Add(this.label_pass1);
            this.bunifuCards1.Controls.Add(this.label_employees);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(877, 577);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label_status_employe
            // 
            this.label_status_employe.AutoSize = true;
            this.label_status_employe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_employe.ForeColor = System.Drawing.Color.DarkRed;
            this.label_status_employe.Location = new System.Drawing.Point(183, 131);
            this.label_status_employe.Name = "label_status_employe";
            this.label_status_employe.Size = new System.Drawing.Size(22, 28);
            this.label_status_employe.TabIndex = 27;
            this.label_status_employe.Text = "x";
            // 
            // Button_OK
            // 
            this.Button_OK.ActiveBorderThickness = 1;
            this.Button_OK.ActiveCornerRadius = 20;
            this.Button_OK.ActiveFillColor = System.Drawing.Color.Teal;
            this.Button_OK.ActiveForecolor = System.Drawing.Color.White;
            this.Button_OK.ActiveLineColor = System.Drawing.Color.Teal;
            this.Button_OK.BackColor = System.Drawing.Color.White;
            this.Button_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_OK.BackgroundImage")));
            this.Button_OK.ButtonText = "Ok";
            this.Button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_OK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OK.ForeColor = System.Drawing.Color.Teal;
            this.Button_OK.IdleBorderThickness = 1;
            this.Button_OK.IdleCornerRadius = 20;
            this.Button_OK.IdleFillColor = System.Drawing.Color.White;
            this.Button_OK.IdleForecolor = System.Drawing.Color.Teal;
            this.Button_OK.IdleLineColor = System.Drawing.Color.Teal;
            this.Button_OK.Location = new System.Drawing.Point(578, 170);
            this.Button_OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(114, 50);
            this.Button_OK.TabIndex = 26;
            this.Button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_OK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // comboBox_employees
            // 
            this.comboBox_employees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_employees.FormattingEnabled = true;
            this.comboBox_employees.Location = new System.Drawing.Point(188, 92);
            this.comboBox_employees.Name = "comboBox_employees";
            this.comboBox_employees.Size = new System.Drawing.Size(359, 36);
            this.comboBox_employees.TabIndex = 25;
            // 
            // label_informations
            // 
            this.label_informations.AutoSize = true;
            this.label_informations.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informations.Location = new System.Drawing.Point(47, 36);
            this.label_informations.Name = "label_informations";
            this.label_informations.Size = new System.Drawing.Size(476, 23);
            this.label_informations.TabIndex = 24;
            this.label_informations.Text = "Selectionner un utilisateur et valider avec son mot de passe.";
            // 
            // label_status_password
            // 
            this.label_status_password.AutoSize = true;
            this.label_status_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_password.ForeColor = System.Drawing.Color.DarkRed;
            this.label_status_password.Location = new System.Drawing.Point(183, 216);
            this.label_status_password.Name = "label_status_password";
            this.label_status_password.Size = new System.Drawing.Size(22, 28);
            this.label_status_password.TabIndex = 23;
            this.label_status_password.Text = "x";
            // 
            // Button_Enregister
            // 
            this.Button_Enregister.ActiveBorderThickness = 1;
            this.Button_Enregister.ActiveCornerRadius = 20;
            this.Button_Enregister.ActiveFillColor = System.Drawing.Color.Teal;
            this.Button_Enregister.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Enregister.ActiveLineColor = System.Drawing.Color.Teal;
            this.Button_Enregister.BackColor = System.Drawing.Color.White;
            this.Button_Enregister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Enregister.BackgroundImage")));
            this.Button_Enregister.ButtonText = "Quitter";
            this.Button_Enregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Enregister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Enregister.ForeColor = System.Drawing.Color.Teal;
            this.Button_Enregister.IdleBorderThickness = 1;
            this.Button_Enregister.IdleCornerRadius = 20;
            this.Button_Enregister.IdleFillColor = System.Drawing.Color.White;
            this.Button_Enregister.IdleForecolor = System.Drawing.Color.Teal;
            this.Button_Enregister.IdleLineColor = System.Drawing.Color.Teal;
            this.Button_Enregister.Location = new System.Drawing.Point(578, 85);
            this.Button_Enregister.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_Enregister.Name = "Button_Enregister";
            this.Button_Enregister.Size = new System.Drawing.Size(114, 53);
            this.Button_Enregister.TabIndex = 21;
            this.Button_Enregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Enregister.Click += new System.EventHandler(this.Button_Quitter_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(187, 179);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(360, 34);
            this.textBox_password.TabIndex = 20;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_pass1
            // 
            this.label_pass1.AutoSize = true;
            this.label_pass1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass1.Location = new System.Drawing.Point(46, 179);
            this.label_pass1.Name = "label_pass1";
            this.label_pass1.Size = new System.Drawing.Size(135, 28);
            this.label_pass1.TabIndex = 19;
            this.label_pass1.Text = "Mot de passe";
            // 
            // label_employees
            // 
            this.label_employees.AutoSize = true;
            this.label_employees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employees.Location = new System.Drawing.Point(72, 95);
            this.label_employees.Name = "label_employees";
            this.label_employees.Size = new System.Drawing.Size(110, 28);
            this.label_employees.TabIndex = 18;
            this.label_employees.Text = "Employées";
            // 
            // ctrl_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ctrl_Login";
            this.Size = new System.Drawing.Size(877, 577);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_OK;
        private System.Windows.Forms.ComboBox comboBox_employees;
        private System.Windows.Forms.Label label_informations;
        private System.Windows.Forms.Label label_status_password;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Enregister;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_pass1;
        private System.Windows.Forms.Label label_employees;
        private System.Windows.Forms.Label label_status_employe;
    }
}
