
namespace ToutEmballDyn
{
    partial class UCprogressBarProduction
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
            this.progressBarProdA = new System.Windows.Forms.ProgressBar();
            this.LabelProductionA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarProdA
            // 
            this.progressBarProdA.Location = new System.Drawing.Point(128, 14);
            this.progressBarProdA.Name = "progressBarProdA";
            this.progressBarProdA.Size = new System.Drawing.Size(394, 26);
            this.progressBarProdA.TabIndex = 0;
            // 
            // LabelProductionA
            // 
            this.LabelProductionA.AutoSize = true;
            this.LabelProductionA.Location = new System.Drawing.Point(13, 14);
            this.LabelProductionA.Name = "LabelProductionA";
            this.LabelProductionA.Size = new System.Drawing.Size(109, 13);
            this.LabelProductionA.TabIndex = 1;
            this.LabelProductionA.Text = "Nom de la Production";
            // 
            // UCprogressBarProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelProductionA);
            this.Controls.Add(this.progressBarProdA);
            this.Name = "UCprogressBarProduction";
            this.Size = new System.Drawing.Size(538, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarProdA;
        private System.Windows.Forms.Label LabelProductionA;
    }
}
