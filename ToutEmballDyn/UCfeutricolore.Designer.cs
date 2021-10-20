
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
            this.buttonGREEN = new System.Windows.Forms.Button();
            this.buttonORANGE = new System.Windows.Forms.Button();
            this.buttonRED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGREEN
            // 
            this.buttonGREEN.BackgroundImage = global::ToutEmballDyn.Properties.Resources.VERT;
            this.buttonGREEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGREEN.Location = new System.Drawing.Point(640, 9);
            this.buttonGREEN.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonGREEN.Name = "buttonGREEN";
            this.buttonGREEN.Size = new System.Drawing.Size(310, 196);
            this.buttonGREEN.TabIndex = 2;
            this.buttonGREEN.UseVisualStyleBackColor = true;
            // 
            // buttonORANGE
            // 
            this.buttonORANGE.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ORANGE;
            this.buttonORANGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonORANGE.Location = new System.Drawing.Point(314, 9);
            this.buttonORANGE.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonORANGE.Name = "buttonORANGE";
            this.buttonORANGE.Size = new System.Drawing.Size(323, 196);
            this.buttonORANGE.TabIndex = 1;
            this.buttonORANGE.UseVisualStyleBackColor = true;
            // 
            // buttonRED
            // 
            this.buttonRED.BackgroundImage = global::ToutEmballDyn.Properties.Resources.THeMe4_soustheme5_131424381416;
            this.buttonRED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRED.Location = new System.Drawing.Point(10, 9);
            this.buttonRED.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonRED.Name = "buttonRED";
            this.buttonRED.Size = new System.Drawing.Size(301, 196);
            this.buttonRED.TabIndex = 0;
            this.buttonRED.UseVisualStyleBackColor = true;
            this.buttonRED.Click += new System.EventHandler(this.buttonRED_Click);
            // 
            // UCfeutricolore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGREEN);
            this.Controls.Add(this.buttonORANGE);
            this.Controls.Add(this.buttonRED);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "UCfeutricolore";
            this.Size = new System.Drawing.Size(969, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRED;
        private System.Windows.Forms.Button buttonORANGE;
        private System.Windows.Forms.Button buttonGREEN;
    }
}
