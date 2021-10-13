
namespace ToutEmballDyn
{
    partial class CreationProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomProd = new System.Windows.Forms.Label();
            this.labelQuantiteAproduire = new System.Windows.Forms.Label();
            this.labelProdparHeure = new System.Windows.Forms.Label();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.textBoxQuantiteAprod = new System.Windows.Forms.TextBox();
            this.textBoxProductionParHeure = new System.Windows.Forms.TextBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomProd
            // 
            this.labelNomProd.AutoSize = true;
            this.labelNomProd.Location = new System.Drawing.Point(85, 81);
            this.labelNomProd.Name = "labelNomProd";
            this.labelNomProd.Size = new System.Drawing.Size(109, 13);
            this.labelNomProd.TabIndex = 0;
            this.labelNomProd.Text = "Nom de la Production";
            // 
            // labelQuantiteAproduire
            // 
            this.labelQuantiteAproduire.AutoSize = true;
            this.labelQuantiteAproduire.Location = new System.Drawing.Point(88, 165);
            this.labelQuantiteAproduire.Name = "labelQuantiteAproduire";
            this.labelQuantiteAproduire.Size = new System.Drawing.Size(97, 13);
            this.labelQuantiteAproduire.TabIndex = 1;
            this.labelQuantiteAproduire.Text = "Quantité à produire";
            // 
            // labelProdparHeure
            // 
            this.labelProdparHeure.AutoSize = true;
            this.labelProdparHeure.Location = new System.Drawing.Point(91, 254);
            this.labelProdparHeure.Name = "labelProdparHeure";
            this.labelProdparHeure.Size = new System.Drawing.Size(106, 13);
            this.labelProdparHeure.TabIndex = 2;
            this.labelProdparHeure.Text = "Production par heure";
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Location = new System.Drawing.Point(252, 73);
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomProd.TabIndex = 3;
            
            // 
            // textBoxQuantiteAprod
            // 
            this.textBoxQuantiteAprod.Location = new System.Drawing.Point(252, 157);
            this.textBoxQuantiteAprod.Name = "textBoxQuantiteAprod";
            this.textBoxQuantiteAprod.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantiteAprod.TabIndex = 4;
            // 
            // textBoxProductionParHeure
            // 
            this.textBoxProductionParHeure.Location = new System.Drawing.Point(252, 246);
            this.textBoxProductionParHeure.Name = "textBoxProductionParHeure";
            this.textBoxProductionParHeure.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductionParHeure.TabIndex = 5;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(122, 325);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 6;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(277, 325);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 7;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // CreationProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 383);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.textBoxProductionParHeure);
            this.Controls.Add(this.textBoxQuantiteAprod);
            this.Controls.Add(this.textBoxNomProd);
            this.Controls.Add(this.labelProdparHeure);
            this.Controls.Add(this.labelQuantiteAproduire);
            this.Controls.Add(this.labelNomProd);
            this.Name = "CreationProd";
            this.Text = "CreationProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomProd;
        private System.Windows.Forms.Label labelQuantiteAproduire;
        private System.Windows.Forms.Label labelProdparHeure;
        private System.Windows.Forms.TextBox textBoxNomProd;
        private System.Windows.Forms.TextBox textBoxQuantiteAprod;
        private System.Windows.Forms.TextBox textBoxProductionParHeure;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
    }
}