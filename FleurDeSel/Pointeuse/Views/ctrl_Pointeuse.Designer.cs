namespace Pointeuse.Views
{
    partial class ctrl_Pointeuse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_Pointeuse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.Button_Quitter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_HeuresNBr = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_DayEnd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_DayStart = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_PauseTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_PauseNbr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_actuellement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label_repas = new System.Windows.Forms.Label();
            this.Checkbox_Repas = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label_pause = new System.Windows.Forms.Label();
            this.Button_StopPause = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_StartPause = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label_work = new System.Windows.Forms.Label();
            this.Button_StopWork = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_StartWork = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 71);
            this.panel1.TabIndex = 0;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_date.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_date.Location = new System.Drawing.Point(0, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(489, 44);
            this.label_date.TabIndex = 6;
            this.label_date.Text = "Vendredi 12/02/1933 12:00:45";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MediumAquamarine;
            this.bunifuCards1.Controls.Add(this.Button_Quitter);
            this.bunifuCards1.Controls.Add(this.label_HeuresNBr);
            this.bunifuCards1.Controls.Add(this.label12);
            this.bunifuCards1.Controls.Add(this.label_DayEnd);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label_DayStart);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label_PauseTime);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label_PauseNbr);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label_actuellement);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.label_repas);
            this.bunifuCards1.Controls.Add(this.Checkbox_Repas);
            this.bunifuCards1.Controls.Add(this.label_pause);
            this.bunifuCards1.Controls.Add(this.Button_StopPause);
            this.bunifuCards1.Controls.Add(this.Button_StartPause);
            this.bunifuCards1.Controls.Add(this.label_work);
            this.bunifuCards1.Controls.Add(this.Button_StopWork);
            this.bunifuCards1.Controls.Add(this.Button_StartWork);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 71);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(797, 495);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // Button_Quitter
            // 
            this.Button_Quitter.ActiveBorderThickness = 1;
            this.Button_Quitter.ActiveCornerRadius = 20;
            this.Button_Quitter.ActiveFillColor = System.Drawing.Color.Teal;
            this.Button_Quitter.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Quitter.ActiveLineColor = System.Drawing.Color.Teal;
            this.Button_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Quitter.BackColor = System.Drawing.Color.White;
            this.Button_Quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Quitter.BackgroundImage")));
            this.Button_Quitter.ButtonText = "Quitter";
            this.Button_Quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Quitter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Quitter.ForeColor = System.Drawing.Color.Teal;
            this.Button_Quitter.IdleBorderThickness = 1;
            this.Button_Quitter.IdleCornerRadius = 20;
            this.Button_Quitter.IdleFillColor = System.Drawing.Color.White;
            this.Button_Quitter.IdleForecolor = System.Drawing.Color.Teal;
            this.Button_Quitter.IdleLineColor = System.Drawing.Color.Teal;
            this.Button_Quitter.Location = new System.Drawing.Point(665, 439);
            this.Button_Quitter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_Quitter.Name = "Button_Quitter";
            this.Button_Quitter.Size = new System.Drawing.Size(125, 50);
            this.Button_Quitter.TabIndex = 36;
            this.Button_Quitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Quitter.Click += new System.EventHandler(this.Button_Quitter_Click);
            // 
            // label_HeuresNBr
            // 
            this.label_HeuresNBr.AutoSize = true;
            this.label_HeuresNBr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HeuresNBr.ForeColor = System.Drawing.Color.Teal;
            this.label_HeuresNBr.Location = new System.Drawing.Point(661, 386);
            this.label_HeuresNBr.Name = "label_HeuresNBr";
            this.label_HeuresNBr.Size = new System.Drawing.Size(19, 23);
            this.label_HeuresNBr.TabIndex = 35;
            this.label_HeuresNBr.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(452, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 28);
            this.label12.TabIndex = 34;
            this.label12.Text = "Nombres d\'heures :";
            // 
            // label_DayEnd
            // 
            this.label_DayEnd.AutoSize = true;
            this.label_DayEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DayEnd.ForeColor = System.Drawing.Color.Teal;
            this.label_DayEnd.Location = new System.Drawing.Point(661, 330);
            this.label_DayEnd.Name = "label_DayEnd";
            this.label_DayEnd.Size = new System.Drawing.Size(19, 23);
            this.label_DayEnd.TabIndex = 33;
            this.label_DayEnd.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(546, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "- Fin :";
            // 
            // label_DayStart
            // 
            this.label_DayStart.AutoSize = true;
            this.label_DayStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DayStart.ForeColor = System.Drawing.Color.Teal;
            this.label_DayStart.Location = new System.Drawing.Point(661, 293);
            this.label_DayStart.Name = "label_DayStart";
            this.label_DayStart.Size = new System.Drawing.Size(19, 23);
            this.label_DayStart.TabIndex = 31;
            this.label_DayStart.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(546, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "- Début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(452, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ma journée";
            // 
            // label_PauseTime
            // 
            this.label_PauseTime.AutoSize = true;
            this.label_PauseTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PauseTime.ForeColor = System.Drawing.Color.Teal;
            this.label_PauseTime.Location = new System.Drawing.Point(661, 213);
            this.label_PauseTime.Name = "label_PauseTime";
            this.label_PauseTime.Size = new System.Drawing.Size(19, 23);
            this.label_PauseTime.TabIndex = 28;
            this.label_PauseTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(546, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "- Durée :";
            // 
            // label_PauseNbr
            // 
            this.label_PauseNbr.AutoSize = true;
            this.label_PauseNbr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PauseNbr.ForeColor = System.Drawing.Color.Teal;
            this.label_PauseNbr.Location = new System.Drawing.Point(661, 176);
            this.label_PauseNbr.Name = "label_PauseNbr";
            this.label_PauseNbr.Size = new System.Drawing.Size(19, 23);
            this.label_PauseNbr.TabIndex = 26;
            this.label_PauseNbr.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(546, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "- Nombre(s) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(452, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mes Pauses";
            // 
            // label_actuellement
            // 
            this.label_actuellement.AutoSize = true;
            this.label_actuellement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_actuellement.ForeColor = System.Drawing.Color.Teal;
            this.label_actuellement.Location = new System.Drawing.Point(602, 65);
            this.label_actuellement.Name = "label_actuellement";
            this.label_actuellement.Size = new System.Drawing.Size(78, 23);
            this.label_actuellement.TabIndex = 23;
            this.label_actuellement.Text = "En Pause";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(446, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Actuellement :";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(390, 22);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(38, 425);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label_repas
            // 
            this.label_repas.AutoSize = true;
            this.label_repas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repas.ForeColor = System.Drawing.Color.Teal;
            this.label_repas.Location = new System.Drawing.Point(273, 191);
            this.label_repas.Name = "label_repas";
            this.label_repas.Size = new System.Drawing.Size(103, 23);
            this.label_repas.TabIndex = 20;
            this.label_repas.Text = "Repas inclus";
            // 
            // Checkbox_Repas
            // 
            this.Checkbox_Repas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_Repas.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_Repas.Checked = false;
            this.Checkbox_Repas.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox_Repas.ForeColor = System.Drawing.Color.White;
            this.Checkbox_Repas.Location = new System.Drawing.Point(236, 189);
            this.Checkbox_Repas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Checkbox_Repas.Name = "Checkbox_Repas";
            this.Checkbox_Repas.Size = new System.Drawing.Size(20, 20);
            this.Checkbox_Repas.TabIndex = 19;
            this.Checkbox_Repas.OnChange += new System.EventHandler(this.Checkbox_Repas_OnChange);
            // 
            // label_pause
            // 
            this.label_pause.AutoSize = true;
            this.label_pause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pause.ForeColor = System.Drawing.Color.Teal;
            this.label_pause.Location = new System.Drawing.Point(245, 65);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(67, 28);
            this.label_pause.TabIndex = 18;
            this.label_pause.Text = "Pause";
            // 
            // Button_StopPause
            // 
            this.Button_StopPause.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_StopPause.BackColor = System.Drawing.Color.Teal;
            this.Button_StopPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_StopPause.BorderRadius = 0;
            this.Button_StopPause.ButtonText = "Fin de pause";
            this.Button_StopPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StopPause.DisabledColor = System.Drawing.Color.Gray;
            this.Button_StopPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopPause.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_StopPause.Iconimage = null;
            this.Button_StopPause.Iconimage_right = null;
            this.Button_StopPause.Iconimage_right_Selected = null;
            this.Button_StopPause.Iconimage_Selected = null;
            this.Button_StopPause.IconMarginLeft = 0;
            this.Button_StopPause.IconMarginRight = 0;
            this.Button_StopPause.IconRightVisible = true;
            this.Button_StopPause.IconRightZoom = 0D;
            this.Button_StopPause.IconVisible = true;
            this.Button_StopPause.IconZoom = 90D;
            this.Button_StopPause.IsTab = false;
            this.Button_StopPause.Location = new System.Drawing.Point(220, 218);
            this.Button_StopPause.Margin = new System.Windows.Forms.Padding(4);
            this.Button_StopPause.Name = "Button_StopPause";
            this.Button_StopPause.Normalcolor = System.Drawing.Color.Teal;
            this.Button_StopPause.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_StopPause.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_StopPause.selected = false;
            this.Button_StopPause.Size = new System.Drawing.Size(160, 59);
            this.Button_StopPause.TabIndex = 15;
            this.Button_StopPause.Text = "Fin de pause";
            this.Button_StopPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_StopPause.Textcolor = System.Drawing.Color.White;
            this.Button_StopPause.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopPause.Click += new System.EventHandler(this.Button_StopPause_Click);
            // 
            // Button_StartPause
            // 
            this.Button_StartPause.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_StartPause.BackColor = System.Drawing.Color.Teal;
            this.Button_StartPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_StartPause.BorderRadius = 0;
            this.Button_StartPause.ButtonText = "Début de pause";
            this.Button_StartPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StartPause.DisabledColor = System.Drawing.Color.Gray;
            this.Button_StartPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartPause.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_StartPause.Iconimage = null;
            this.Button_StartPause.Iconimage_right = null;
            this.Button_StartPause.Iconimage_right_Selected = null;
            this.Button_StartPause.Iconimage_Selected = null;
            this.Button_StartPause.IconMarginLeft = 0;
            this.Button_StartPause.IconMarginRight = 0;
            this.Button_StartPause.IconRightVisible = true;
            this.Button_StartPause.IconRightZoom = 0D;
            this.Button_StartPause.IconVisible = true;
            this.Button_StartPause.IconZoom = 90D;
            this.Button_StartPause.IsTab = false;
            this.Button_StartPause.Location = new System.Drawing.Point(220, 122);
            this.Button_StartPause.Margin = new System.Windows.Forms.Padding(4);
            this.Button_StartPause.Name = "Button_StartPause";
            this.Button_StartPause.Normalcolor = System.Drawing.Color.Teal;
            this.Button_StartPause.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_StartPause.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_StartPause.selected = false;
            this.Button_StartPause.Size = new System.Drawing.Size(160, 59);
            this.Button_StartPause.TabIndex = 14;
            this.Button_StartPause.Text = "Début de pause";
            this.Button_StartPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_StartPause.Textcolor = System.Drawing.Color.White;
            this.Button_StartPause.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartPause.Click += new System.EventHandler(this.Button_StartPause_Click);
            // 
            // label_work
            // 
            this.label_work.AutoSize = true;
            this.label_work.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_work.ForeColor = System.Drawing.Color.Teal;
            this.label_work.Location = new System.Drawing.Point(43, 65);
            this.label_work.Name = "label_work";
            this.label_work.Size = new System.Drawing.Size(75, 28);
            this.label_work.TabIndex = 13;
            this.label_work.Text = "Travail";
            // 
            // Button_StopWork
            // 
            this.Button_StopWork.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_StopWork.BackColor = System.Drawing.Color.Teal;
            this.Button_StopWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_StopWork.BorderRadius = 0;
            this.Button_StopWork.ButtonText = "Fin de journéé";
            this.Button_StopWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StopWork.DisabledColor = System.Drawing.Color.Gray;
            this.Button_StopWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopWork.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_StopWork.Iconimage = null;
            this.Button_StopWork.Iconimage_right = null;
            this.Button_StopWork.Iconimage_right_Selected = null;
            this.Button_StopWork.Iconimage_Selected = null;
            this.Button_StopWork.IconMarginLeft = 0;
            this.Button_StopWork.IconMarginRight = 0;
            this.Button_StopWork.IconRightVisible = true;
            this.Button_StopWork.IconRightZoom = 0D;
            this.Button_StopWork.IconVisible = true;
            this.Button_StopWork.IconZoom = 90D;
            this.Button_StopWork.IsTab = false;
            this.Button_StopWork.Location = new System.Drawing.Point(29, 218);
            this.Button_StopWork.Margin = new System.Windows.Forms.Padding(4);
            this.Button_StopWork.Name = "Button_StopWork";
            this.Button_StopWork.Normalcolor = System.Drawing.Color.Teal;
            this.Button_StopWork.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_StopWork.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_StopWork.selected = false;
            this.Button_StopWork.Size = new System.Drawing.Size(160, 59);
            this.Button_StopWork.TabIndex = 12;
            this.Button_StopWork.Text = "Fin de journéé";
            this.Button_StopWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_StopWork.Textcolor = System.Drawing.Color.White;
            this.Button_StopWork.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopWork.Click += new System.EventHandler(this.Button_StopWork_Click);
            // 
            // Button_StartWork
            // 
            this.Button_StartWork.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Button_StartWork.BackColor = System.Drawing.Color.Teal;
            this.Button_StartWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_StartWork.BorderRadius = 0;
            this.Button_StartWork.ButtonText = "Début de journée";
            this.Button_StartWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StartWork.DisabledColor = System.Drawing.Color.Gray;
            this.Button_StartWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartWork.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_StartWork.Iconimage = null;
            this.Button_StartWork.Iconimage_right = null;
            this.Button_StartWork.Iconimage_right_Selected = null;
            this.Button_StartWork.Iconimage_Selected = null;
            this.Button_StartWork.IconMarginLeft = 0;
            this.Button_StartWork.IconMarginRight = 0;
            this.Button_StartWork.IconRightVisible = true;
            this.Button_StartWork.IconRightZoom = 0D;
            this.Button_StartWork.IconVisible = true;
            this.Button_StartWork.IconZoom = 90D;
            this.Button_StartWork.IsTab = false;
            this.Button_StartWork.Location = new System.Drawing.Point(29, 122);
            this.Button_StartWork.Margin = new System.Windows.Forms.Padding(4);
            this.Button_StartWork.Name = "Button_StartWork";
            this.Button_StartWork.Normalcolor = System.Drawing.Color.Teal;
            this.Button_StartWork.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Button_StartWork.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_StartWork.selected = false;
            this.Button_StartWork.Size = new System.Drawing.Size(160, 59);
            this.Button_StartWork.TabIndex = 11;
            this.Button_StartWork.Text = "Début de journée";
            this.Button_StartWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_StartWork.Textcolor = System.Drawing.Color.White;
            this.Button_StartWork.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartWork.Click += new System.EventHandler(this.Button_StartWork_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrl_Pointeuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Name = "ctrl_Pointeuse";
            this.Size = new System.Drawing.Size(797, 566);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton Button_StopPause;
        private Bunifu.Framework.UI.BunifuFlatButton Button_StartPause;
        private System.Windows.Forms.Label label_work;
        private Bunifu.Framework.UI.BunifuFlatButton Button_StopWork;
        private Bunifu.Framework.UI.BunifuFlatButton Button_StartWork;
        private System.Windows.Forms.Label label_pause;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox_Repas;
        private System.Windows.Forms.Label label_repas;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label_actuellement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PauseNbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_PauseTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_HeuresNBr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_DayEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_DayStart;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Quitter;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Timer timer1;
    }
}
