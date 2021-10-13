
namespace ToutEmballDyn
{
    partial class ProductionDynamique
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
            this.ProgressBarnouvelProd = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commencerUneProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uCprogressBarProduction1 = new ToutEmballDyn.UCprogressBarProduction();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBarnouvelProd
            // 
            this.ProgressBarnouvelProd.Location = new System.Drawing.Point(50, 192);
            this.ProgressBarnouvelProd.Name = "ProgressBarnouvelProd";
            this.ProgressBarnouvelProd.Size = new System.Drawing.Size(738, 229);
            this.ProgressBarnouvelProd.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commencerUneProductionToolStripMenuItem,
            this.demarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // commencerUneProductionToolStripMenuItem
            // 
            this.commencerUneProductionToolStripMenuItem.Name = "commencerUneProductionToolStripMenuItem";
            this.commencerUneProductionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.commencerUneProductionToolStripMenuItem.Text = "Commencer une production";
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.demarrerToolStripMenuItem.Text = "Demarrer";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // uCprogressBarProduction1
            // 
            this.uCprogressBarProduction1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCprogressBarProduction1.Location = new System.Drawing.Point(0, 24);
            this.uCprogressBarProduction1.Name = "uCprogressBarProduction1";
            this.uCprogressBarProduction1.Size = new System.Drawing.Size(800, 150);
            this.uCprogressBarProduction1.TabIndex = 2;
            // 
            // ProductionDynamique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uCprogressBarProduction1);
            this.Controls.Add(this.ProgressBarnouvelProd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductionDynamique";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarnouvelProd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commencerUneProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private UCprogressBarProduction uCprogressBarProduction1;
    }
}

