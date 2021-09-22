
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
            this.labelDure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRemb = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxTx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(697, 33);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(697, 63);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.Location = new System.Drawing.Point(292, 152);
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(154, 23);
            this.hScrollBarDuree.TabIndex = 2;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(124, 35);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(176, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxCapitalEmpr
            // 
            this.textBoxCapitalEmpr.Location = new System.Drawing.Point(124, 80);
            this.textBoxCapitalEmpr.Name = "textBoxCapitalEmpr";
            this.textBoxCapitalEmpr.Size = new System.Drawing.Size(176, 20);
            this.textBoxCapitalEmpr.TabIndex = 4;
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
            this.labelDuree.Size = new System.Drawing.Size(171, 13);
            this.labelDuree.TabIndex = 7;
            this.labelDuree.Text = "Durée en mois du rempboursement";
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.Location = new System.Drawing.Point(34, 292);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(168, 134);
            this.listBoxPeriodicite.TabIndex = 8;
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
            // labelDure
            // 
            this.labelDure.AutoSize = true;
            this.labelDure.Location = new System.Drawing.Point(231, 162);
            this.labelDure.Name = "labelDure";
            this.labelDure.Size = new System.Drawing.Size(35, 13);
            this.labelDure.TabIndex = 10;
            this.labelDure.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 94);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxTx
            // 
            this.groupBoxTx.Controls.Add(this.radioButton1);
            this.groupBoxTx.Controls.Add(this.radioButton3);
            this.groupBoxTx.Controls.Add(this.radioButton2);
            this.groupBoxTx.Location = new System.Drawing.Point(522, 21);
            this.groupBoxTx.Name = "groupBoxTx";
            this.groupBoxTx.Size = new System.Drawing.Size(135, 135);
            this.groupBoxTx.TabIndex = 16;
            this.groupBoxTx.TabStop = false;
            this.groupBoxTx.Text = "Taux d\'intérêt";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(549, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxTx);
            this.Controls.Add(this.labelRemb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDure);
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
        private System.Windows.Forms.Label labelDure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRemb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBoxTx;
        private System.Windows.Forms.Label label2;
    }
}

