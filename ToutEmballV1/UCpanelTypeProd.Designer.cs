
namespace ToutEmballV1
{
    partial class UCpanelTypeProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCaisseProduite = new System.Windows.Forms.Label();
            this.labelDefautParHeure = new System.Windows.Forms.Label();
            this.labelDefautDepuisDem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caisse depuis le démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taux défaut Heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // labelCaisseProduite
            // 
            this.labelCaisseProduite.AutoSize = true;
            this.labelCaisseProduite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCaisseProduite.Location = new System.Drawing.Point(269, 42);
            this.labelCaisseProduite.Name = "labelCaisseProduite";
            this.labelCaisseProduite.Size = new System.Drawing.Size(2, 15);
            this.labelCaisseProduite.TabIndex = 3;
            // 
            // labelDefautParHeure
            // 
            this.labelDefautParHeure.AutoSize = true;
            this.labelDefautParHeure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDefautParHeure.Location = new System.Drawing.Point(269, 82);
            this.labelDefautParHeure.Name = "labelDefautParHeure";
            this.labelDefautParHeure.Size = new System.Drawing.Size(2, 15);
            this.labelDefautParHeure.TabIndex = 4;
            // 
            // labelDefautDepuisDem
            // 
            this.labelDefautDepuisDem.AutoSize = true;
            this.labelDefautDepuisDem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDefautDepuisDem.Location = new System.Drawing.Point(269, 129);
            this.labelDefautDepuisDem.Name = "labelDefautDepuisDem";
            this.labelDefautDepuisDem.Size = new System.Drawing.Size(2, 15);
            this.labelDefautDepuisDem.TabIndex = 5;
            // 
            // UCpanelTypeProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDefautDepuisDem);
            this.Controls.Add(this.labelDefautParHeure);
            this.Controls.Add(this.labelCaisseProduite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCpanelTypeProd";
            this.Size = new System.Drawing.Size(398, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCaisseProduite;
        private System.Windows.Forms.Label labelDefautParHeure;
        private System.Windows.Forms.Label labelDefautDepuisDem;
    }
}
