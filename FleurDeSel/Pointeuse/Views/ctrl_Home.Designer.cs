namespace Pointeuse.Views
{
    partial class ctrl_Home
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
            this.panel_top1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.panel_citation = new System.Windows.Forms.Panel();
            this.label_source = new System.Windows.Forms.Label();
            this.label_auteur = new System.Windows.Forms.Label();
            this.label_citation = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label10 = new System.Windows.Forms.Label();
            this.label_repas = new System.Windows.Forms.Label();
            this.label_time_pause = new System.Windows.Forms.Label();
            this.label_time_work = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label_emp_total = new System.Windows.Forms.Label();
            this.label_emp_pause = new System.Windows.Forms.Label();
            this.label_emp_repos = new System.Windows.Forms.Label();
            this.label_emp_work = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_top1.SuspendLayout();
            this.panel_citation.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top1
            // 
            this.panel_top1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel_top1.Controls.Add(this.label_date);
            this.panel_top1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top1.Location = new System.Drawing.Point(0, 0);
            this.panel_top1.Name = "panel_top1";
            this.panel_top1.Size = new System.Drawing.Size(952, 66);
            this.panel_top1.TabIndex = 0;
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
            this.label_date.TabIndex = 5;
            this.label_date.Text = "Vendredi 12/02/1933 12:00:45";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_citation
            // 
            this.panel_citation.BackColor = System.Drawing.Color.Azure;
            this.panel_citation.Controls.Add(this.label_source);
            this.panel_citation.Controls.Add(this.label_auteur);
            this.panel_citation.Controls.Add(this.label_citation);
            this.panel_citation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_citation.Location = new System.Drawing.Point(0, 66);
            this.panel_citation.Name = "panel_citation";
            this.panel_citation.Size = new System.Drawing.Size(952, 128);
            this.panel_citation.TabIndex = 1;
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_source.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_source.Location = new System.Drawing.Point(16, 86);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(60, 22);
            this.label_source.TabIndex = 49;
            this.label_source.Text = "source";
            // 
            // label_auteur
            // 
            this.label_auteur.AutoSize = true;
            this.label_auteur.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auteur.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_auteur.Location = new System.Drawing.Point(16, 53);
            this.label_auteur.Name = "label_auteur";
            this.label_auteur.Size = new System.Drawing.Size(60, 22);
            this.label_auteur.TabIndex = 48;
            this.label_auteur.Text = "auteur";
            // 
            // label_citation
            // 
            this.label_citation.AutoSize = true;
            this.label_citation.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_citation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_citation.Location = new System.Drawing.Point(16, 15);
            this.label_citation.Name = "label_citation";
            this.label_citation.Size = new System.Drawing.Size(86, 27);
            this.label_citation.TabIndex = 47;
            this.label_citation.Text = "citation";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.label_repas);
            this.bunifuCards1.Controls.Add(this.label_time_pause);
            this.bunifuCards1.Controls.Add(this.label_time_work);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.label_emp_total);
            this.bunifuCards1.Controls.Add(this.label_emp_pause);
            this.bunifuCards1.Controls.Add(this.label_emp_repos);
            this.bunifuCards1.Controls.Add(this.label_emp_work);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 194);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(952, 346);
            this.bunifuCards1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(696, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 27);
            this.label10.TabIndex = 59;
            this.label10.Text = "- Aujourd\'hui";
            // 
            // label_repas
            // 
            this.label_repas.AutoSize = true;
            this.label_repas.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_repas.Location = new System.Drawing.Point(843, 103);
            this.label_repas.Name = "label_repas";
            this.label_repas.Size = new System.Drawing.Size(60, 22);
            this.label_repas.TabIndex = 58;
            this.label_repas.Text = "source";
            // 
            // label_time_pause
            // 
            this.label_time_pause.AutoSize = true;
            this.label_time_pause.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_pause.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_time_pause.Location = new System.Drawing.Point(522, 164);
            this.label_time_pause.Name = "label_time_pause";
            this.label_time_pause.Size = new System.Drawing.Size(60, 22);
            this.label_time_pause.TabIndex = 57;
            this.label_time_pause.Text = "source";
            // 
            // label_time_work
            // 
            this.label_time_work.AutoSize = true;
            this.label_time_work.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_work.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_time_work.Location = new System.Drawing.Point(522, 103);
            this.label_time_work.Name = "label_time_work";
            this.label_time_work.Size = new System.Drawing.Size(60, 22);
            this.label_time_work.TabIndex = 56;
            this.label_time_work.Text = "source";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(654, 26);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(47, 276);
            this.bunifuSeparator2.TabIndex = 55;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(279, 26);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(36, 276);
            this.bunifuSeparator1.TabIndex = 54;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label_emp_total
            // 
            this.label_emp_total.AutoSize = true;
            this.label_emp_total.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_total.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_emp_total.Location = new System.Drawing.Point(187, 280);
            this.label_emp_total.Name = "label_emp_total";
            this.label_emp_total.Size = new System.Drawing.Size(60, 22);
            this.label_emp_total.TabIndex = 53;
            this.label_emp_total.Text = "source";
            // 
            // label_emp_pause
            // 
            this.label_emp_pause.AutoSize = true;
            this.label_emp_pause.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_pause.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_emp_pause.Location = new System.Drawing.Point(187, 220);
            this.label_emp_pause.Name = "label_emp_pause";
            this.label_emp_pause.Size = new System.Drawing.Size(60, 22);
            this.label_emp_pause.TabIndex = 52;
            this.label_emp_pause.Text = "source";
            // 
            // label_emp_repos
            // 
            this.label_emp_repos.AutoSize = true;
            this.label_emp_repos.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_repos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_emp_repos.Location = new System.Drawing.Point(187, 164);
            this.label_emp_repos.Name = "label_emp_repos";
            this.label_emp_repos.Size = new System.Drawing.Size(60, 22);
            this.label_emp_repos.TabIndex = 51;
            this.label_emp_repos.Text = "source";
            // 
            // label_emp_work
            // 
            this.label_emp_work.AutoSize = true;
            this.label_emp_work.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_work.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_emp_work.Location = new System.Drawing.Point(187, 103);
            this.label_emp_work.Name = "label_emp_work";
            this.label_emp_work.Size = new System.Drawing.Size(60, 22);
            this.label_emp_work.TabIndex = 50;
            this.label_emp_work.Text = "source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(708, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 44);
            this.label9.TabIndex = 46;
            this.label9.Text = "Repa(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(371, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "- De pause(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(371, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "- De travail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(357, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 44);
            this.label8.TabIndex = 43;
            this.label8.Text = "Heure(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(52, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "- Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(52, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "- En pause";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(52, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "- En repos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "- Au travail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 44);
            this.label1.TabIndex = 38;
            this.label1.Text = "Employé(s)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3600000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ctrl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel_citation);
            this.Controls.Add(this.panel_top1);
            this.Name = "ctrl_Home";
            this.Size = new System.Drawing.Size(952, 540);
            this.panel_top1.ResumeLayout(false);
            this.panel_top1.PerformLayout();
            this.panel_citation.ResumeLayout(false);
            this.panel_citation.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top1;
        private System.Windows.Forms.Panel panel_citation;
        private System.Windows.Forms.Label label_date;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_citation;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.Label label_auteur;
        private System.Windows.Forms.Label label_emp_work;
        private System.Windows.Forms.Label label_emp_pause;
        private System.Windows.Forms.Label label_emp_repos;
        private System.Windows.Forms.Label label_emp_total;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label_time_pause;
        private System.Windows.Forms.Label label_time_work;
        private System.Windows.Forms.Label label_repas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer2;
    }
}
