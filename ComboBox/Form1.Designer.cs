
namespace ComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSOURCE = new System.Windows.Forms.ComboBox();
            this.listBoxCIBLE = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonINSERT = new System.Windows.Forms.Button();
            this.buttonINSERTALL = new System.Windows.Forms.Button();
            this.buttonUNINST = new System.Windows.Forms.Button();
            this.buttonUNINSTALL = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOURCE";
            // 
            // comboBoxSOURCE
            // 
            this.comboBoxSOURCE.FormattingEnabled = true;
            this.comboBoxSOURCE.Location = new System.Drawing.Point(63, 63);
            this.comboBoxSOURCE.Name = "comboBoxSOURCE";
            this.comboBoxSOURCE.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSOURCE.TabIndex = 2;
            this.comboBoxSOURCE.DropDown += new System.EventHandler(this.comboBoxSource_DropDown);
            this.comboBoxSOURCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSource_KeyPress);
            // 
            // listBoxCIBLE
            // 
            this.listBoxCIBLE.FormattingEnabled = true;
            this.listBoxCIBLE.Location = new System.Drawing.Point(480, 63);
            this.listBoxCIBLE.Name = "listBoxCIBLE";
            this.listBoxCIBLE.Size = new System.Drawing.Size(172, 225);
            this.listBoxCIBLE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CIBLE";
            // 
            // buttonINSERT
            // 
            this.buttonINSERT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonINSERT.Enabled = false;
            this.buttonINSERT.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonINSERT.Location = new System.Drawing.Point(325, 63);
            this.buttonINSERT.Name = "buttonINSERT";
            this.buttonINSERT.Size = new System.Drawing.Size(75, 23);
            this.buttonINSERT.TabIndex = 5;
            this.buttonINSERT.Text = ">";
            this.buttonINSERT.UseVisualStyleBackColor = false;
            this.buttonINSERT.BackColorChanged += new System.EventHandler(this.buttonInsert_Click);
            this.buttonINSERT.ForeColorChanged += new System.EventHandler(this.buttonInsert_Click);
            this.buttonINSERT.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonINSERTALL
            // 
            this.buttonINSERTALL.Location = new System.Drawing.Point(326, 112);
            this.buttonINSERTALL.Name = "buttonINSERTALL";
            this.buttonINSERTALL.Size = new System.Drawing.Size(75, 23);
            this.buttonINSERTALL.TabIndex = 6;
            this.buttonINSERTALL.Text = ">>";
            this.buttonINSERTALL.UseVisualStyleBackColor = true;
            this.buttonINSERTALL.Click += new System.EventHandler(this.buttonInsertAll_Click);
            // 
            // buttonUNINST
            // 
            this.buttonUNINST.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUNINST.Enabled = false;
            this.buttonUNINST.Location = new System.Drawing.Point(325, 241);
            this.buttonUNINST.Name = "buttonUNINST";
            this.buttonUNINST.Size = new System.Drawing.Size(75, 23);
            this.buttonUNINST.TabIndex = 7;
            this.buttonUNINST.Text = "<";
            this.buttonUNINST.UseVisualStyleBackColor = false;
            // 
            // buttonUNINSTALL
            // 
            this.buttonUNINSTALL.Location = new System.Drawing.Point(325, 294);
            this.buttonUNINSTALL.Name = "buttonUNINSTALL";
            this.buttonUNINSTALL.Size = new System.Drawing.Size(75, 23);
            this.buttonUNINSTALL.TabIndex = 8;
            this.buttonUNINSTALL.Text = "<<";
            this.buttonUNINSTALL.UseVisualStyleBackColor = true;
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(514, 316);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(38, 23);
            this.buttonUP.TabIndex = 9;
            this.buttonUP.Text = "up";
            this.buttonUP.UseVisualStyleBackColor = true;
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Location = new System.Drawing.Point(577, 316);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(45, 23);
            this.buttonDOWN.TabIndex = 10;
            this.buttonDOWN.Text = "down";
            this.buttonDOWN.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDOWN);
            this.Controls.Add(this.buttonUP);
            this.Controls.Add(this.buttonUNINSTALL);
            this.Controls.Add(this.buttonUNINST);
            this.Controls.Add(this.buttonINSERTALL);
            this.Controls.Add(this.buttonINSERT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCIBLE);
            this.Controls.Add(this.comboBoxSOURCE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSOURCE;
        private System.Windows.Forms.ListBox listBoxCIBLE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonINSERT;
        private System.Windows.Forms.Button buttonINSERTALL;
        private System.Windows.Forms.Button buttonUNINST;
        private System.Windows.Forms.Button buttonUNINSTALL;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Diagnostics.EventLog eventLog1;
    }
}

