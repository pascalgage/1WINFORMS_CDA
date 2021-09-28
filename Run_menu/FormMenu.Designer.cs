
namespace Run_menu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTutuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuIdentify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetresToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1321, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTutuToolStripMenuItem,
            this.phase1ToolStrip,
            this.phase2ToolStrip,
            this.phase3ToolStrip,
            this.fenetresToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTutuToolStripMenuItem
            // 
            this.menuTutuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sousMenuIdentify,
            this.toolStripSeparator2,
            this.toolStripQuit});
            this.menuTutuToolStripMenuItem.Name = "menuTutuToolStripMenuItem";
            this.menuTutuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.menuTutuToolStripMenuItem.Text = "Connexion";
            // 
            // sousMenuIdentify
            // 
            this.sousMenuIdentify.Name = "sousMenuIdentify";
            this.sousMenuIdentify.Size = new System.Drawing.Size(130, 22);
            this.sousMenuIdentify.Text = "S\'identifier";
            this.sousMenuIdentify.Click += new System.EventHandler(this.sousMenuIdentify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // toolStripQuit
            // 
            this.toolStripQuit.Name = "toolStripQuit";
            this.toolStripQuit.Size = new System.Drawing.Size(130, 22);
            this.toolStripQuit.Text = "Quitter";
            this.toolStripQuit.Click += new System.EventHandler(this.toolStripQuit_Click);
            // 
            // phase1ToolStrip
            // 
            this.phase1ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem,
            this.checBoxToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.phase1ToolStrip.Enabled = false;
            this.phase1ToolStrip.Name = "phase1ToolStrip";
            this.phase1ToolStrip.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStrip.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.additionneurToolStripMenuItem_Click);
            // 
            // checBoxToolStripMenuItem
            // 
            this.checBoxToolStripMenuItem.Name = "checBoxToolStripMenuItem";
            this.checBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checBoxToolStripMenuItem.Text = "CheckBox";
            this.checBoxToolStripMenuItem.Click += new System.EventHandler(this.checBoxToolStripMenuItem_Click);
            // 
            // phase2ToolStrip
            // 
            this.phase2ToolStrip.Enabled = false;
            this.phase2ToolStrip.Name = "phase2ToolStrip";
            this.phase2ToolStrip.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStrip.Text = "Phase 2";
            // 
            // phase3ToolStrip
            // 
            this.phase3ToolStrip.Enabled = false;
            this.phase3ToolStrip.Name = "phase3ToolStrip";
            this.phase3ToolStrip.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStrip.Text = "Phase 3";
            // 
            // fenetresToolStrip
            // 
            this.fenetresToolStrip.Enabled = false;
            this.fenetresToolStrip.Name = "fenetresToolStrip";
            this.fenetresToolStrip.Size = new System.Drawing.Size(63, 20);
            this.fenetresToolStrip.Text = "Fenêtres";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            this.saisieToolStripMenuItem.Click += new System.EventHandler(this.saisieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 652);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Créer des Formulaires";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTutuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sousMenuIdentify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuit;
        private System.Windows.Forms.ToolStripMenuItem phase1ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem phase2ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem phase3ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fenetresToolStrip;
        private System.Windows.Forms.ToolStripMenuItem additionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
    }
}

