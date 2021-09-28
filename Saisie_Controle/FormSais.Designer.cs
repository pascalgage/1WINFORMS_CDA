
namespace Saisie_Controle
{
    partial class FormSais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 575);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTANT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 729);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "CODE POSTAL";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(659, 245);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(308, 44);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(659, 376);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(308, 44);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.Leave += new System.EventHandler(this.textBoxDate_Leave);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(659, 552);
            this.textBoxMontant.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(308, 44);
            this.textBoxMontant.TabIndex = 6;
            this.textBoxMontant.Leave += new System.EventHandler(this.textBoxMontant_Leave);
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(659, 706);
            this.textBoxCodePostal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(308, 44);
            this.textBoxCodePostal.TabIndex = 7;
            this.textBoxCodePostal.Leave += new System.EventHandler(this.textBoxCodePostal_Leave);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(1507, 868);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(238, 65);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(1507, 993);
            this.buttonEffacer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(238, 65);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "JJ/MM/AAAA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(568, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom en lettres seulement sans espace";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 629);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(698, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Entier ou decimal avec deux chiffres après , ou .";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 783);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(407, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "Code à 5 chiffres maximum";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(1920, 993);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(245, 65);
            this.insert.TabIndex = 14;
            this.insert.Text = "INSERTION BDD";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Les contrôles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderMontant;
        private System.Windows.Forms.ErrorProvider errorProviderCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert;
    }
}

