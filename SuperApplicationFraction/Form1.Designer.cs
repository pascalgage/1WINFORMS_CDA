
namespace SuperApplicationFraction
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxDen1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxDen2 = new System.Windows.Forms.TextBox();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonSoust = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(68, 45);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxDen1
            // 
            this.textBoxDen1.Location = new System.Drawing.Point(68, 104);
            this.textBoxDen1.Name = "textBoxDen1";
            this.textBoxDen1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(491, 44);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 7;
            // 
            // textBoxDen2
            // 
            this.textBoxDen2.Location = new System.Drawing.Point(491, 95);
            this.textBoxDen2.Name = "textBoxDen2";
            this.textBoxDen2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen2.TabIndex = 8;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(285, 36);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAdd.TabIndex = 9;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Addition";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoust
            // 
            this.radioButtonSoust.AutoSize = true;
            this.radioButtonSoust.Location = new System.Drawing.Point(285, 60);
            this.radioButtonSoust.Name = "radioButtonSoust";
            this.radioButtonSoust.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSoust.TabIndex = 10;
            this.radioButtonSoust.TabStop = true;
            this.radioButtonSoust.Text = "Soustraction";
            this.radioButtonSoust.UseVisualStyleBackColor = true;
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(285, 84);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMult.TabIndex = 11;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "Multiplication";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(285, 108);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDiv.TabIndex = 12;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "Division";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(282, 367);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(64, 13);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULTAT";
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Location = new System.Drawing.Point(285, 227);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculer.TabIndex = 14;
            this.buttonCalculer.Text = "Calculer";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculer);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.radioButtonDiv);
            this.Controls.Add(this.radioButtonMult);
            this.Controls.Add(this.radioButtonSoust);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.textBoxDen2);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxDen1);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxDen1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxDen2;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonSoust;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculer;
    }
}

