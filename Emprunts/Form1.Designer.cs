
namespace Emprunts
{
    partial class FormEmp
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
            this.components = new System.ComponentModel.Container();
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
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.labelDure = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProK = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(697, 33);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(697, 63);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBarDuree.LargeChange = 1;
            this.hScrollBarDuree.Location = new System.Drawing.Point(291, 162);
            this.hScrollBarDuree.Maximum = 240;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(154, 23);
            this.hScrollBarDuree.TabIndex = 2;
            this.hScrollBarDuree.Value = 1;
            this.hScrollBarDuree.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarDuree_Scroll);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(124, 35);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(176, 20);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxCapitalEmpr
            // 
            this.textBoxCapitalEmpr.Location = new System.Drawing.Point(124, 80);
            this.textBoxCapitalEmpr.Name = "textBoxCapitalEmpr";
            this.textBoxCapitalEmpr.Size = new System.Drawing.Size(176, 20);
            this.textBoxCapitalEmpr.TabIndex = 1;
            this.textBoxCapitalEmpr.TextChanged += new System.EventHandler(this.textBoxCapitalEmpr_TextChanged);
            this.textBoxCapitalEmpr.Leave += new System.EventHandler(this.textBoxCapitalEmpr_Leave);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(28, 38);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            // 
            // labelCapEmpr
            // 
            this.labelCapEmpr.AutoSize = true;
            this.labelCapEmpr.Location = new System.Drawing.Point(31, 83);
            this.labelCapEmpr.Name = "labelCapEmpr";
            this.labelCapEmpr.Size = new System.Drawing.Size(87, 13);
            this.labelCapEmpr.TabIndex = 6;
            this.labelCapEmpr.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(31, 162);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(165, 13);
            this.labelDuree.TabIndex = 7;
            this.labelDuree.Text = "Durée en mois du remboursement";
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.Location = new System.Drawing.Point(34, 292);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(168, 134);
            this.listBoxPeriodicite.TabIndex = 8;
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(34, 273);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(146, 13);
            this.labelPeriodicite.TabIndex = 9;
            this.labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // labelNBrVersement
            // 
            this.labelNBrVersement.AutoSize = true;
            this.labelNBrVersement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNBrVersement.Location = new System.Drawing.Point(472, 292);
            this.labelNBrVersement.Name = "labelNBrVersement";
            this.labelNBrVersement.Size = new System.Drawing.Size(2, 15);
            this.labelNBrVersement.TabIndex = 11;
            // 
            // labelRemb
            // 
            this.labelRemb.AutoSize = true;
            this.labelRemb.Location = new System.Drawing.Point(545, 291);
            this.labelRemb.Name = "labelRemb";
            this.labelRemb.Size = new System.Drawing.Size(89, 13);
            this.labelRemb.TabIndex = 12;
            this.labelRemb.Text = "Remboursements";
            // 
            // radioButt7perc
            // 
            this.radioButt7perc.AutoSize = true;
            this.radioButt7perc.Location = new System.Drawing.Point(27, 32);
            this.radioButt7perc.Name = "radioButt7perc";
            this.radioButt7perc.Size = new System.Drawing.Size(39, 17);
            this.radioButt7perc.TabIndex = 2;
            this.radioButt7perc.TabStop = true;
            this.radioButt7perc.Text = "7%";
            this.radioButt7perc.UseVisualStyleBackColor = true;
            // 
            // radioButt8perc
            // 
            this.radioButt8perc.AutoSize = true;
            this.radioButt8perc.Location = new System.Drawing.Point(27, 62);
            this.radioButt8perc.Name = "radioButt8perc";
            this.radioButt8perc.Size = new System.Drawing.Size(39, 17);
            this.radioButt8perc.TabIndex = 3;
            this.radioButt8perc.TabStop = true;
            this.radioButt8perc.Text = "8%";
            this.radioButt8perc.UseVisualStyleBackColor = true;
            // 
            // radioButt9perc
            // 
            this.radioButt9perc.AutoSize = true;
            this.radioButt9perc.Location = new System.Drawing.Point(27, 94);
            this.radioButt9perc.Name = "radioButt9perc";
            this.radioButt9perc.Size = new System.Drawing.Size(39, 17);
            this.radioButt9perc.TabIndex = 4;
            this.radioButt9perc.TabStop = true;
            this.radioButt9perc.Text = "9%";
            this.radioButt9perc.UseVisualStyleBackColor = true;
            // 
            // groupBoxTx
            // 
            this.groupBoxTx.Controls.Add(this.radioButt7perc);
            this.groupBoxTx.Controls.Add(this.radioButt9perc);
            this.groupBoxTx.Controls.Add(this.radioButt8perc);
            this.groupBoxTx.Location = new System.Drawing.Point(522, 21);
            this.groupBoxTx.Name = "groupBoxTx";
            this.groupBoxTx.Size = new System.Drawing.Size(135, 135);
            this.groupBoxTx.TabIndex = 16;
            this.groupBoxTx.TabStop = false;
            this.groupBoxTx.Text = "Taux d\'intérêt";
            // 
            // labelRemboursement
            // 
            this.labelRemboursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemboursement.Location = new System.Drawing.Point(549, 354);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(154, 34);
            this.labelRemboursement.TabIndex = 17;
            this.labelRemboursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDure
            // 
            this.labelDure.AutoSize = true;
            this.labelDure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDure.Location = new System.Drawing.Point(244, 162);
            this.labelDure.Name = "labelDure";
            this.labelDure.Size = new System.Drawing.Size(2, 15);
            this.labelDure.TabIndex = 18;
            this.labelDure.Tag = "";
            this.labelDure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProK
            // 
            this.errorProK.ContainerControl = this;
            // 
            // FormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.labelDure);
            this.Controls.Add(this.labelRemboursement);
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
            this.Name = "FormEmp";
            this.Text = "Emprunts";
            this.groupBoxTx.ResumeLayout(false);
            this.groupBoxTx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProK)).EndInit();
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
        private System.Windows.Forms.Label labelRemboursement;
        private System.Windows.Forms.Label labelDure;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProK;
    }
}

