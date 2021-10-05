
namespace ToutEmball
{
    partial class FormPROD
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTauxDefDemA = new System.Windows.Forms.TextBox();
            this.textTauxDefHeureA = new System.Windows.Forms.TextBox();
            this.textCaissDepDemA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTauxDefDemB = new System.Windows.Forms.TextBox();
            this.textTauxDefHeureB = new System.Windows.Forms.TextBox();
            this.textCaissDepDemB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTauxDefDemC = new System.Windows.Forms.TextBox();
            this.textTauxDefHeureC = new System.Windows.Forms.TextBox();
            this.textCaissDepDemC = new System.Windows.Forms.TextBox();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.typeA.Location = new System.Drawing.Point(396, 66);
            this.typeA.Name = "typeA";
            this.typeA.SelectedIndex = 0;
            this.typeA.Size = new System.Drawing.Size(345, 210);
            this.typeA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textTauxDefDemA);
            this.tabPage1.Controls.Add(this.textTauxDefHeureA);
            this.tabPage1.Controls.Add(this.textCaissDepDemA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Type A";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taux défaut heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nbr de caisses depuis le démarrage";
            // 
            // textTauxDefDemA
            // 
            this.textTauxDefDemA.Location = new System.Drawing.Point(219, 116);
            this.textTauxDefDemA.Name = "textTauxDefDemA";
            this.textTauxDefDemA.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefDemA.TabIndex = 2;
            // 
            // textTauxDefHeureA
            // 
            this.textTauxDefHeureA.Location = new System.Drawing.Point(219, 72);
            this.textTauxDefHeureA.Name = "textTauxDefHeureA";
            this.textTauxDefHeureA.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefHeureA.TabIndex = 1;
            // 
            // textCaissDepDemA
            // 
            this.textCaissDepDemA.Location = new System.Drawing.Point(219, 28);
            this.textCaissDepDemA.Name = "textCaissDepDemA";
            this.textCaissDepDemA.Size = new System.Drawing.Size(100, 20);
            this.textCaissDepDemA.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textTauxDefDemB);
            this.tabPage2.Controls.Add(this.textTauxDefHeureB);
            this.tabPage2.Controls.Add(this.textCaissDepDemB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type B";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Taux défaut depuis démarrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Taux défaut heure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nbr de caisses depuis le démarrage";
            // 
            // textTauxDefDemB
            // 
            this.textTauxDefDemB.Location = new System.Drawing.Point(216, 126);
            this.textTauxDefDemB.Name = "textTauxDefDemB";
            this.textTauxDefDemB.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefDemB.TabIndex = 8;
            // 
            // textTauxDefHeureB
            // 
            this.textTauxDefHeureB.Location = new System.Drawing.Point(216, 82);
            this.textTauxDefHeureB.Name = "textTauxDefHeureB";
            this.textTauxDefHeureB.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefHeureB.TabIndex = 7;
            // 
            // textCaissDepDemB
            // 
            this.textCaissDepDemB.Location = new System.Drawing.Point(216, 38);
            this.textCaissDepDemB.Name = "textCaissDepDemB";
            this.textCaissDepDemB.Size = new System.Drawing.Size(100, 20);
            this.textCaissDepDemB.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textTauxDefDemC);
            this.tabPage3.Controls.Add(this.textTauxDefHeureC);
            this.tabPage3.Controls.Add(this.textCaissDepDemC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 184);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Type C";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Taux défaut depuis démarrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Taux défaut heure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nbr de caisses depuis le démarrage";
            // 
            // textTauxDefDemC
            // 
            this.textTauxDefDemC.Location = new System.Drawing.Point(216, 126);
            this.textTauxDefDemC.Name = "textTauxDefDemC";
            this.textTauxDefDemC.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefDemC.TabIndex = 8;
            // 
            // textTauxDefHeureC
            // 
            this.textTauxDefHeureC.Location = new System.Drawing.Point(216, 82);
            this.textTauxDefHeureC.Name = "textTauxDefHeureC";
            this.textTauxDefHeureC.Size = new System.Drawing.Size(100, 20);
            this.textTauxDefHeureC.TabIndex = 7;
            // 
            // textCaissDepDemC
            // 
            this.textCaissDepDemC.Location = new System.Drawing.Point(216, 38);
            this.textCaissDepDemC.Name = "textCaissDepDemC";
            this.textCaissDepDemC.Size = new System.Drawing.Size(100, 20);
            this.textCaissDepDemC.TabIndex = 6;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(396, 316);
            this.progressBarA.Maximum = 1000;
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(341, 23);
            this.progressBarA.TabIndex = 1;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(396, 359);
            this.progressBarB.Maximum = 5000;
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(341, 23);
            this.progressBarB.TabIndex = 2;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(396, 400);
            this.progressBarC.Maximum = 10000;
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(341, 23);
            this.progressBarC.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "PRODUCTION A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "PRODUCTION B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "PRODUCTION C";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fICHIERToolStripMenuItem,
            this.pRODUCTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
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
            this.cToolStripMenuIDem.Size = new System.Drawing.Size(180, 22);
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
            this.aToolStripMenuIArr.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuIArr.Text = "A";
            this.aToolStripMenuIArr.Click += new System.EventHandler(this.aToolStripMenuIArr_Click);
            // 
            // bToolStripMenuIArr
            // 
            this.bToolStripMenuIArr.Name = "bToolStripMenuIArr";
            this.bToolStripMenuIArr.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuIArr.Text = "B";
            this.bToolStripMenuIArr.Click += new System.EventHandler(this.bToolStripMenuIArr_Click);
            // 
            // cToolStripMenuIArr
            // 
            this.cToolStripMenuIArr.Name = "cToolStripMenuIArr";
            this.cToolStripMenuIArr.Size = new System.Drawing.Size(180, 22);
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
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuICont
            // 
            this.aToolStripMenuICont.Name = "aToolStripMenuICont";
            this.aToolStripMenuICont.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuICont.Text = "A";
            // 
            // bToolStripMenuICont
            // 
            this.bToolStripMenuICont.Name = "bToolStripMenuICont";
            this.bToolStripMenuICont.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuICont.Text = "B";
            // 
            // cToolStripMenuICont
            // 
            this.cToolStripMenuICont.Name = "cToolStripMenuICont";
            this.cToolStripMenuICont.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuICont.Text = "C";
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
            // FormPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.typeA);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPROD";
            this.Text = "PRODUCTION DES CAISSES";
            this.typeA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl typeA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTauxDefDemA;
        private System.Windows.Forms.TextBox textTauxDefHeureA;
        private System.Windows.Forms.TextBox textCaissDepDemA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTauxDefDemB;
        private System.Windows.Forms.TextBox textTauxDefHeureB;
        private System.Windows.Forms.TextBox textCaissDepDemB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTauxDefDemC;
        private System.Windows.Forms.TextBox textTauxDefHeureC;
        private System.Windows.Forms.TextBox textCaissDepDemC;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
    }
}

