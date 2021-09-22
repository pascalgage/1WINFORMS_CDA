
namespace Emprunts
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.hScrollBarDuree = new System.Windows.Forms.HScrollBar();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapitalEmpr = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCapEmpr = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.labelNBrVersement = new System.Windows.Forms.Label();
            this.labelRemb = new System.Windows.Forms.Label();
            this.radioButt7perc = new System.Windows.Forms.RadioButton();
            this.radioButt8perc = new System.Windows.Forms.RadioButton();
            this.radioButt9perc = new System.Windows.Forms.RadioButton();
            this.groupBoxTx = new System.Windows.Forms.GroupBox();
            this.labelRembousement = new System.Windows.Forms.Label();
            this.labelDure = new System.Windows.Forms.Label();
            this.groupBoxTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(929, 41);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(929, 78);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 28);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.LargeChange = 1;
            this.hScrollBarDuree.Location = new System.Drawing.Point(388, 199);
            this.hScrollBarDuree.Maximum = 160;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(205, 23);
            this.hScrollBarDuree.TabIndex = 2;
            this.hScrollBarDuree.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarDuree_Scroll);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(165, 43);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(233, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxCapitalEmpr
            // 
            this.textBoxCapitalEmpr.Location = new System.Drawing.Point(165, 98);
            this.textBoxCapitalEmpr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCapitalEmpr.Name = "textBoxCapitalEmpr";
            this.textBoxCapitalEmpr.Size = new System.Drawing.Size(233, 22);
            this.textBoxCapitalEmpr.TabIndex = 4;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(37, 47);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            // 
            // labelCapEmpr
            // 
            this.labelCapEmpr.AutoSize = true;
            this.labelCapEmpr.Location = new System.Drawing.Point(41, 102);
            this.labelCapEmpr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapEmpr.Name = "labelCapEmpr";
            this.labelCapEmpr.Size = new System.Drawing.Size(116, 17);
            this.labelCapEmpr.TabIndex = 6;
            this.labelCapEmpr.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(41, 199);
            this.labelDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(231, 17);
            this.labelDuree.TabIndex = 7;
            this.labelDuree.Text = "Durée en mois du rempboursement";
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.ItemHeight = 16;
            this.listBoxPeriodicite.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxPeriodicite.Location = new System.Drawing.Point(45, 359);
            this.listBoxPeriodicite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(223, 164);
            this.listBoxPeriodicite.TabIndex = 8;
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(45, 336);
            this.labelPeriodicite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(197, 17);
            this.labelPeriodicite.TabIndex = 9;
            this.labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // labelNBrVersement
            // 
            this.labelNBrVersement.AutoSize = true;
            this.labelNBrVersement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNBrVersement.Location = new System.Drawing.Point(629, 359);
            this.labelNBrVersement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNBrVersement.Name = "labelNBrVersement";
            this.labelNBrVersement.Size = new System.Drawing.Size(2, 19);
            this.labelNBrVersement.TabIndex = 11;
            // 
            // labelRemb
            // 
            this.labelRemb.AutoSize = true;
            this.labelRemb.Location = new System.Drawing.Point(727, 358);
            this.labelRemb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemb.Name = "labelRemb";
            this.labelRemb.Size = new System.Drawing.Size(119, 17);
            this.labelRemb.TabIndex = 12;
            this.labelRemb.Text = "Remboursements";
            // 
            // radioButt7perc
            // 
            this.radioButt7perc.AutoSize = true;
            this.radioButt7perc.Location = new System.Drawing.Point(36, 39);
            this.radioButt7perc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButt7perc.Name = "radioButt7perc";
            this.radioButt7perc.Size = new System.Drawing.Size(49, 21);
            this.radioButt7perc.TabIndex = 13;
            this.radioButt7perc.TabStop = true;
            this.radioButt7perc.Text = "7%";
            this.radioButt7perc.UseVisualStyleBackColor = true;
            // 
            // radioButt8perc
            // 
            this.radioButt8perc.AutoSize = true;
            this.radioButt8perc.Location = new System.Drawing.Point(36, 76);
            this.radioButt8perc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButt8perc.Name = "radioButt8perc";
            this.radioButt8perc.Size = new System.Drawing.Size(49, 21);
            this.radioButt8perc.TabIndex = 14;
            this.radioButt8perc.TabStop = true;
            this.radioButt8perc.Text = "8%";
            this.radioButt8perc.UseVisualStyleBackColor = true;
            // 
            // radioButt9perc
            // 
            this.radioButt9perc.AutoSize = true;
            this.radioButt9perc.Location = new System.Drawing.Point(36, 116);
            this.radioButt9perc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButt9perc.Name = "radioButt9perc";
            this.radioButt9perc.Size = new System.Drawing.Size(49, 21);
            this.radioButt9perc.TabIndex = 15;
            this.radioButt9perc.TabStop = true;
            this.radioButt9perc.Text = "9%";
            this.radioButt9perc.UseVisualStyleBackColor = true;
            // 
            // groupBoxTx
            // 
            this.groupBoxTx.Controls.Add(this.radioButt7perc);
            this.groupBoxTx.Controls.Add(this.radioButt9perc);
            this.groupBoxTx.Controls.Add(this.radioButt8perc);
            this.groupBoxTx.Location = new System.Drawing.Point(696, 26);
            this.groupBoxTx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTx.Name = "groupBoxTx";
            this.groupBoxTx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTx.Size = new System.Drawing.Size(180, 166);
            this.groupBoxTx.TabIndex = 16;
            this.groupBoxTx.TabStop = false;
            this.groupBoxTx.Text = "Taux d\'intérêt";
            // 
            // labelRembousement
            // 
            this.labelRembousement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRembousement.Location = new System.Drawing.Point(732, 436);
            this.labelRembousement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRembousement.Name = "labelRembousement";
            this.labelRembousement.Size = new System.Drawing.Size(205, 42);
            this.labelRembousement.TabIndex = 17;
            // 
            // labelDure
            // 
            this.labelDure.AutoSize = true;
            this.labelDure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDure.Location = new System.Drawing.Point(325, 199);
            this.labelDure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDure.Name = "labelDure";
            this.labelDure.Size = new System.Drawing.Size(2, 19);
            this.labelDure.TabIndex = 18;
            this.labelDure.Tag = "";
            this.labelDure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelDure);
            this.Controls.Add(this.labelRembousement);
            this.Controls.Add(this.groupBoxTx);
            this.Controls.Add(this.labelRemb);
            this.Controls.Add(this.labelNBrVersement);
            this.Controls.Add(this.labelPeriodicite);
            this.Controls.Add(this.listBoxPeriodicite);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelCapEmpr);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxCapitalEmpr);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.hScrollBarDuree);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Emprunts";
            this.groupBoxTx.ResumeLayout(false);
            this.groupBoxTx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.HScrollBar hScrollBarDuree;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCapitalEmpr;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCapEmpr;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.ListBox listBoxPeriodicite;
        private System.Windows.Forms.Label labelPeriodicite;
        private System.Windows.Forms.Label labelNBrVersement;
        private System.Windows.Forms.Label labelRemb;
        private System.Windows.Forms.RadioButton radioButt7perc;
        private System.Windows.Forms.RadioButton radioButt8perc;
        private System.Windows.Forms.RadioButton radioButt9perc;
        private System.Windows.Forms.GroupBox groupBoxTx;
        private System.Windows.Forms.Label labelRembousement;
        private System.Windows.Forms.Label labelDure;
    }
}

