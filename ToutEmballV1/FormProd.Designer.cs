
namespace ToutEmballV1
{
    partial class FormProd
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
            this.typeA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uCpanelTypeProd1 = new ToutEmballV1.UCpanelTypeProd();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uCpanelTypeProd2 = new ToutEmballV1.UCpanelTypeProd();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uCpanelTypeProd3 = new ToutEmballV1.UCpanelTypeProd();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fICHIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuIDem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuIDem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuIDem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuIArr = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuIArr = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuIArr = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuICont = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuICont = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuICont = new System.Windows.Forms.ToolStripMenuItem();
            this.timerProdA = new System.Windows.Forms.Timer(this.components);
            this.timerProdB = new System.Windows.Forms.Timer(this.components);
            this.timerProdC = new System.Windows.Forms.Timer(this.components);
            this.uCprogressBarProduction1 = new ToutEmballV1.UCprogressBarProduction();
            this.uCprogressBarProduction2 = new ToutEmballV1.UCprogressBarProduction();
            this.uCprogressBarProduction3 = new ToutEmballV1.UCprogressBarProduction();
            this.typeA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeA
            // 
            this.typeA.Controls.Add(this.tabPage1);
            this.typeA.Controls.Add(this.tabPage2);
            this.typeA.Controls.Add(this.tabPage3);
            this.typeA.Location = new System.Drawing.Point(524, 27);
            this.typeA.Name = "typeA";
            this.typeA.SelectedIndex = 0;
            this.typeA.Size = new System.Drawing.Size(345, 210);
            this.typeA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uCpanelTypeProd1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Type A";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uCpanelTypeProd1
            // 
            this.uCpanelTypeProd1.Location = new System.Drawing.Point(3, 6);
            this.uCpanelTypeProd1.Name = "uCpanelTypeProd1";
            this.uCpanelTypeProd1.Size = new System.Drawing.Size(328, 163);
            this.uCpanelTypeProd1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uCpanelTypeProd2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type B";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uCpanelTypeProd2
            // 
            this.uCpanelTypeProd2.Location = new System.Drawing.Point(6, 9);
            this.uCpanelTypeProd2.Name = "uCpanelTypeProd2";
            this.uCpanelTypeProd2.Size = new System.Drawing.Size(325, 169);
            this.uCpanelTypeProd2.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uCpanelTypeProd3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 184);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Type C";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uCpanelTypeProd3
            // 
            this.uCpanelTypeProd3.Location = new System.Drawing.Point(6, 6);
            this.uCpanelTypeProd3.Name = "uCpanelTypeProd3";
            this.uCpanelTypeProd3.Size = new System.Drawing.Size(325, 161);
            this.uCpanelTypeProd3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fICHIERToolStripMenuItem,
            this.pRODUCTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fICHIERToolStripMenuItem
            // 
            this.fICHIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fICHIERToolStripMenuItem.Name = "fICHIERToolStripMenuItem";
            this.fICHIERToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fICHIERToolStripMenuItem.Text = "FICHIER";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
           
            // 
            // pRODUCTIONToolStripMenuItem
            // 
            this.pRODUCTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrerToolStripMenuItem,
            this.arreterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.pRODUCTIONToolStripMenuItem.Name = "pRODUCTIONToolStripMenuItem";
            this.pRODUCTIONToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.pRODUCTIONToolStripMenuItem.Text = "PRODUCTION";
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuIDem,
            this.bToolStripMenuIDem,
            this.cToolStripMenuIDem});
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.demarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuIDem
            // 
            this.aToolStripMenuIDem.Name = "aToolStripMenuIDem";
            this.aToolStripMenuIDem.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuIDem.Text = "A";
            this.aToolStripMenuIDem.Click += new System.EventHandler(this.aToolStripMenuIDem_Click);
            // 
            // bToolStripMenuIDem
            // 
            this.bToolStripMenuIDem.Name = "bToolStripMenuIDem";
            this.bToolStripMenuIDem.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuIDem.Text = "B";
            this.bToolStripMenuIDem.Click += new System.EventHandler(this.bToolStripMenuIDem_Click);
            // 
            // cToolStripMenuIDem
            // 
            this.cToolStripMenuIDem.Name = "cToolStripMenuIDem";
            this.cToolStripMenuIDem.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuIDem.Text = "C";
            this.cToolStripMenuIDem.Click += new System.EventHandler(this.cToolStripMenuIDem_Click);
            // 
            // arreterToolStripMenuItem
            // 
            this.arreterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuIArr,
            this.bToolStripMenuIArr,
            this.cToolStripMenuIArr});
            this.arreterToolStripMenuItem.Name = "arreterToolStripMenuItem";
            this.arreterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arreterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuIArr
            // 
            this.aToolStripMenuIArr.Name = "aToolStripMenuIArr";
            this.aToolStripMenuIArr.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuIArr.Text = "A";
            this.aToolStripMenuIArr.Click += new System.EventHandler(this.aToolStripMenuIArr_Click);
            // 
            // bToolStripMenuIArr
            // 
            this.bToolStripMenuIArr.Name = "bToolStripMenuIArr";
            this.bToolStripMenuIArr.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuIArr.Text = "B";
            this.bToolStripMenuIArr.Click += new System.EventHandler(this.bToolStripMenuIArr_Click);
            // 
            // cToolStripMenuIArr
            // 
            this.cToolStripMenuIArr.Name = "cToolStripMenuIArr";
            this.cToolStripMenuIArr.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuIArr.Text = "C";
            this.cToolStripMenuIArr.Click += new System.EventHandler(this.cToolStripMenuIArr_Click);
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuICont,
            this.bToolStripMenuICont,
            this.cToolStripMenuICont});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuICont
            // 
            this.aToolStripMenuICont.Name = "aToolStripMenuICont";
            this.aToolStripMenuICont.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuICont.Text = "A";
            this.aToolStripMenuICont.Click += new System.EventHandler(this.aToolStripMenuICont_Click);
            // 
            // bToolStripMenuICont
            // 
            this.bToolStripMenuICont.Name = "bToolStripMenuICont";
            this.bToolStripMenuICont.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuICont.Text = "B";
            this.bToolStripMenuICont.Click += new System.EventHandler(this.bToolStripMenuICont_Click);
            // 
            // cToolStripMenuICont
            // 
            this.cToolStripMenuICont.Name = "cToolStripMenuICont";
            this.cToolStripMenuICont.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuICont.Text = "C";
            this.cToolStripMenuICont.Click += new System.EventHandler(this.cToolStripMenuICont_Click);
            // 
            // timerProdA
            // 
            this.timerProdA.Interval = 3750;
            this.timerProdA.Tick += new System.EventHandler(this.timerProdA_Tick);
            // 
            // timerProdB
            // 
            this.timerProdB.Interval = 720;
            this.timerProdB.Tick += new System.EventHandler(this.timerProdB_Tick);
            // 
            // timerProdC
            // 
            this.timerProdC.Interval = 360;
            this.timerProdC.Tick += new System.EventHandler(this.timerProdC_Tick);
            // 
            // uCprogressBarProduction1
            // 
            this.uCprogressBarProduction1.Location = new System.Drawing.Point(87, 295);
            this.uCprogressBarProduction1.Name = "uCprogressBarProduction1";
            this.uCprogressBarProduction1.Size = new System.Drawing.Size(650, 57);
            this.uCprogressBarProduction1.TabIndex = 10;
            // 
            // uCprogressBarProduction2
            // 
            this.uCprogressBarProduction2.Location = new System.Drawing.Point(87, 358);
            this.uCprogressBarProduction2.Name = "uCprogressBarProduction2";
            this.uCprogressBarProduction2.Size = new System.Drawing.Size(650, 57);
            this.uCprogressBarProduction2.TabIndex = 11;
            // 
            // uCprogressBarProduction3
            // 
            this.uCprogressBarProduction3.Location = new System.Drawing.Point(87, 421);
            this.uCprogressBarProduction3.Name = "uCprogressBarProduction3";
            this.uCprogressBarProduction3.Size = new System.Drawing.Size(650, 57);
            this.uCprogressBarProduction3.TabIndex = 12;
            // 
            // FormProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 527);
            this.Controls.Add(this.uCprogressBarProduction3);
            this.Controls.Add(this.uCprogressBarProduction2);
            this.Controls.Add(this.uCprogressBarProduction1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.typeA);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormProd";
            this.Text = "PRODUCTION DES CAISSES";
            this.typeA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl typeA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fICHIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuIDem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuIDem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuIDem;
        private System.Windows.Forms.ToolStripMenuItem arreterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuIArr;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuIArr;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuIArr;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuICont;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuICont;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuICont;
        private System.Windows.Forms.Timer timerProdA;
        private System.Windows.Forms.Timer timerProdB;
        private System.Windows.Forms.Timer timerProdC;
        private UCprogressBarProduction uCprogressBarProduction1;
        private UCprogressBarProduction uCprogressBarProduction2;
        private UCprogressBarProduction uCprogressBarProduction3;
        private UCpanelTypeProd uCpanelTypeProd1;
        private UCpanelTypeProd uCpanelTypeProd3;
        private UCpanelTypeProd uCpanelTypeProd2;
    }
}

