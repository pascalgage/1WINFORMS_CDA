
namespace ToutEmballDyn
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
            this.labelDefautDepuisDem = new System.Windows.Forms.Label();
            this.labelDefautParHeure = new System.Windows.Forms.Label();
            this.labelCaisseProduite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDefautDepuisDem
            // 
            this.labelDefautDepuisDem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDefautDepuisDem.Location = new System.Drawing.Point(270, 122);
            this.labelDefautDepuisDem.Name = "labelDefautDepuisDem";
            this.labelDefautDepuisDem.Size = new System.Drawing.Size(54, 20);
            this.labelDefautDepuisDem.TabIndex = 11;
            this.labelDefautDepuisDem.Text = "0";
            // 
            // labelDefautParHeure
            // 
            this.labelDefautParHeure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDefautParHeure.Location = new System.Drawing.Point(270, 73);
            this.labelDefautParHeure.Name = "labelDefautParHeure";
            this.labelDefautParHeure.Size = new System.Drawing.Size(54, 21);
            this.labelDefautParHeure.TabIndex = 10;
            this.labelDefautParHeure.Text = "0";
            // 
            // labelCaisseProduite
            // 
            this.labelCaisseProduite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCaisseProduite.Location = new System.Drawing.Point(270, 33);
            this.labelCaisseProduite.Name = "labelCaisseProduite";
            this.labelCaisseProduite.Size = new System.Drawing.Size(54, 21);
            this.labelCaisseProduite.TabIndex = 9;
            this.labelCaisseProduite.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taux défaut Heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de caisse depuis le démarrage";
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
            this.Size = new System.Drawing.Size(352, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDefautDepuisDem;
        private System.Windows.Forms.Label labelDefautParHeure;
        private System.Windows.Forms.Label labelCaisseProduite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
