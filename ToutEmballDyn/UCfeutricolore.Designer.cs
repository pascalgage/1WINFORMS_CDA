
namespace ToutEmballDyn
{
    partial class UCfeutricolore
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
            this.labelNomProd = new System.Windows.Forms.Label();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomProd
            // 
            this.labelNomProd.AutoSize = true;
            this.labelNomProd.Location = new System.Drawing.Point(84, 60);
            this.labelNomProd.Name = "labelNomProd";
            this.labelNomProd.Size = new System.Drawing.Size(58, 13);
            this.labelNomProd.TabIndex = 3;
            this.labelNomProd.Text = "Production";
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackgroundImage = global::ToutEmballDyn.Properties.Resources.VERT_off;
            this.buttonGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGreen.Location = new System.Drawing.Point(153, 3);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(76, 54);
            this.buttonGreen.TabIndex = 2;
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ORANGE_off;
            this.buttonOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOrange.Location = new System.Drawing.Point(74, 3);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(78, 54);
            this.buttonOrange.TabIndex = 1;
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ROUGE;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRed.Location = new System.Drawing.Point(3, 3);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(71, 54);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // UCfeutricolore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNomProd);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonRed);
            this.Name = "UCfeutricolore";
            this.Size = new System.Drawing.Size(237, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Label labelNomProd;
    }
}
