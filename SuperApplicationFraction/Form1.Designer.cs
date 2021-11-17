
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
            this.errorProviderDen1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDen2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDen2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(124, 61);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxDen1
            // 
            this.textBoxDen1.Location = new System.Drawing.Point(124, 120);
            this.textBoxDen1.Name = "textBoxDen1";
            this.textBoxDen1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen1.TabIndex = 1;
            this.textBoxDen1.Leave += new System.EventHandler(this.textBoxDen1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(547, 60);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 7;
            // 
            // textBoxDen2
            // 
            this.textBoxDen2.Location = new System.Drawing.Point(547, 111);
            this.textBoxDen2.Name = "textBoxDen2";
            this.textBoxDen2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen2.TabIndex = 8;
            this.textBoxDen2.Leave += new System.EventHandler(this.textBoxDen2_Leave);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(341, 52);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAdd.TabIndex = 9;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Addition";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonSoust
            // 
            this.radioButtonSoust.AutoSize = true;
            this.radioButtonSoust.Location = new System.Drawing.Point(341, 76);
            this.radioButtonSoust.Name = "radioButtonSoust";
            this.radioButtonSoust.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSoust.TabIndex = 10;
            this.radioButtonSoust.TabStop = true;
            this.radioButtonSoust.Text = "Soustraction";
            this.radioButtonSoust.UseVisualStyleBackColor = true;
            this.radioButtonSoust.CheckedChanged += new System.EventHandler(this.radioButtonSoust_CheckedChanged);
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(341, 100);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMult.TabIndex = 11;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "Multiplication";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            this.radioButtonMult.CheckedChanged += new System.EventHandler(this.radioButtonMult_CheckedChanged);
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(341, 124);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDiv.TabIndex = 12;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "Division";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            this.radioButtonDiv.CheckedChanged += new System.EventHandler(this.radioButtonDiv_CheckedChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(343, 373);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(64, 13);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULTAT";
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Location = new System.Drawing.Point(341, 243);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculer.TabIndex = 14;
            this.buttonCalculer.Text = "Calculer";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
            // 
            // errorProviderDen1
            // 
            this.errorProviderDen1.ContainerControl = this;
            // 
            // errorProviderDen2
            // 
            this.errorProviderDen2.ContainerControl = this;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(341, 158);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(66, 17);
            this.radioButtonRed.TabIndex = 15;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Simplifier";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.Click += new System.EventHandler(this.radioButtonRed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FRACTION A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "FRACTION B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "num :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "den :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "num :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "den :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonRed);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDen2)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProviderDen1;
        private System.Windows.Forms.ErrorProvider errorProviderDen2;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

