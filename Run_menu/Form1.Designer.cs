
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripConnexion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripPhase1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripPhase2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripPhase3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripFenetres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1321, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "S\'identifier";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 25);
            this.toolStripButton2.Text = "Phase 3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnexion,
            this.toolStripPhase1,
            this.toolStripPhase2,
            this.toolStripPhase3,
            this.toolStripFenetres});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripConnexion
            // 
            this.toolStripConnexion.Enabled = false;
            this.toolStripConnexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripConnexion.Name = "toolStripConnexion";
            this.toolStripConnexion.Size = new System.Drawing.Size(100, 23);
            this.toolStripConnexion.Text = "Connection";
            // 
            // toolStripPhase1
            // 
            this.toolStripPhase1.Enabled = false;
            this.toolStripPhase1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPhase1.Name = "toolStripPhase1";
            this.toolStripPhase1.Size = new System.Drawing.Size(100, 23);
            this.toolStripPhase1.Text = "Phase 1";
            // 
            // toolStripPhase2
            // 
            this.toolStripPhase2.Enabled = false;
            this.toolStripPhase2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPhase2.Name = "toolStripPhase2";
            this.toolStripPhase2.Size = new System.Drawing.Size(100, 23);
            this.toolStripPhase2.Text = "Phase 2";
            
            // 
            // toolStripPhase3
            // 
            this.toolStripPhase3.Enabled = false;
            this.toolStripPhase3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPhase3.Name = "toolStripPhase3";
            this.toolStripPhase3.Size = new System.Drawing.Size(100, 23);
            this.toolStripPhase3.Text = "Phase 3";
            // 
            // toolStripFenetres
            // 
            this.toolStripFenetres.Enabled = false;
            this.toolStripFenetres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripFenetres.Name = "toolStripFenetres";
            this.toolStripFenetres.Size = new System.Drawing.Size(100, 23);
            this.toolStripFenetres.Text = "Fenêtres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 652);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Créer des Formulaires";
            
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripConnexion;
        private System.Windows.Forms.ToolStripTextBox toolStripPhase1;
        private System.Windows.Forms.ToolStripTextBox toolStripPhase2;
        private System.Windows.Forms.ToolStripTextBox toolStripPhase3;
        private System.Windows.Forms.ToolStripTextBox toolStripFenetres;
    }
}

