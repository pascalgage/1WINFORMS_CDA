
namespace CheckBox
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
            this.textchoix = new System.Windows.Forms.TextBox();
            this.redcolorfont = new System.Windows.Forms.RadioButton();
            this.greencolorfont = new System.Windows.Forms.RadioButton();
            this.bluecolorfont = new System.Windows.Forms.RadioButton();
            this.carared = new System.Windows.Forms.RadioButton();
            this.carawhite = new System.Windows.Forms.RadioButton();
            this.carablack = new System.Windows.Forms.RadioButton();
            this.cassmin = new System.Windows.Forms.RadioButton();
            this.cassmaj = new System.Windows.Forms.RadioButton();
            this.cassechoix = new System.Windows.Forms.GroupBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.majmintext = new System.Windows.Forms.CheckBox();
            this.colortext = new System.Windows.Forms.CheckBox();
            this.fontcolor = new System.Windows.Forms.CheckBox();
            this.fontchoix = new System.Windows.Forms.GroupBox();
            this.carachoix = new System.Windows.Forms.GroupBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.cassechoix.SuspendLayout();
            this.groupBoxChoix.SuspendLayout();
            this.fontchoix.SuspendLayout();
            this.carachoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // textchoix
            // 
            this.textchoix.Location = new System.Drawing.Point(27, 47);
            this.textchoix.Name = "textchoix";
            this.textchoix.Size = new System.Drawing.Size(365, 20);
            this.textchoix.TabIndex = 1;
            this.textchoix.TextChanged += new System.EventHandler(this.textChoix_TextChanged);
            // 
            // redcolorfont
            // 
            this.redcolorfont.AutoSize = true;
            this.redcolorfont.Location = new System.Drawing.Point(29, 30);
            this.redcolorfont.Name = "redcolorfont";
            this.redcolorfont.Size = new System.Drawing.Size(57, 17);
            this.redcolorfont.TabIndex = 5;
            this.redcolorfont.TabStop = true;
            this.redcolorfont.Text = "Rouge";
            this.redcolorfont.UseVisualStyleBackColor = true;
            this.redcolorfont.Click += new System.EventHandler(this.redcolorfont_Click);
            this.redcolorfont.Leave += new System.EventHandler(this.redcolorfont_Click);
            // 
            // greencolorfont
            // 
            this.greencolorfont.AutoSize = true;
            this.greencolorfont.Location = new System.Drawing.Point(29, 53);
            this.greencolorfont.Name = "greencolorfont";
            this.greencolorfont.Size = new System.Drawing.Size(44, 17);
            this.greencolorfont.TabIndex = 6;
            this.greencolorfont.TabStop = true;
            this.greencolorfont.Text = "Vert";
            this.greencolorfont.UseVisualStyleBackColor = true;
            this.greencolorfont.Click += new System.EventHandler(this.greencolorfont_Click);
            // 
            // bluecolorfont
            // 
            this.bluecolorfont.AutoSize = true;
            this.bluecolorfont.Location = new System.Drawing.Point(29, 76);
            this.bluecolorfont.Name = "bluecolorfont";
            this.bluecolorfont.Size = new System.Drawing.Size(46, 17);
            this.bluecolorfont.TabIndex = 7;
            this.bluecolorfont.TabStop = true;
            this.bluecolorfont.Text = "Bleu";
            this.bluecolorfont.UseVisualStyleBackColor = true;
            this.bluecolorfont.Click += new System.EventHandler(this.bluecolorfont_Click);
            // 
            // carared
            // 
            this.carared.AutoSize = true;
            this.carared.Location = new System.Drawing.Point(36, 29);
            this.carared.Name = "carared";
            this.carared.Size = new System.Drawing.Size(57, 17);
            this.carared.TabIndex = 8;
            this.carared.TabStop = true;
            this.carared.Text = "Rouge";
            this.carared.UseVisualStyleBackColor = true;
            // 
            // carawhite
            // 
            this.carawhite.AutoSize = true;
            this.carawhite.Location = new System.Drawing.Point(36, 52);
            this.carawhite.Name = "carawhite";
            this.carawhite.Size = new System.Drawing.Size(52, 17);
            this.carawhite.TabIndex = 9;
            this.carawhite.TabStop = true;
            this.carawhite.Text = "Blanc";
            this.carawhite.UseVisualStyleBackColor = true;
            // 
            // carablack
            // 
            this.carablack.AutoSize = true;
            this.carablack.Location = new System.Drawing.Point(36, 75);
            this.carablack.Name = "carablack";
            this.carablack.Size = new System.Drawing.Size(44, 17);
            this.carablack.TabIndex = 10;
            this.carablack.TabStop = true;
            this.carablack.Text = "Noir";
            this.carablack.UseVisualStyleBackColor = true;
            // 
            // cassmin
            // 
            this.cassmin.AutoSize = true;
            this.cassmin.Location = new System.Drawing.Point(6, 38);
            this.cassmin.Name = "cassmin";
            this.cassmin.Size = new System.Drawing.Size(78, 17);
            this.cassmin.TabIndex = 11;
            this.cassmin.TabStop = true;
            this.cassmin.Text = "Minuscules";
            this.cassmin.UseVisualStyleBackColor = true;
            // 
            // cassmaj
            // 
            this.cassmaj.AutoSize = true;
            this.cassmaj.Location = new System.Drawing.Point(6, 75);
            this.cassmaj.Name = "cassmaj";
            this.cassmaj.Size = new System.Drawing.Size(78, 17);
            this.cassmaj.TabIndex = 12;
            this.cassmaj.TabStop = true;
            this.cassmaj.Text = "Majuscules";
            this.cassmaj.UseVisualStyleBackColor = true;
            // 
            // cassechoix
            // 
            this.cassechoix.Controls.Add(this.cassmin);
            this.cassechoix.Controls.Add(this.cassmaj);
            this.cassechoix.Enabled = false;
            this.cassechoix.Location = new System.Drawing.Point(544, 301);
            this.cassechoix.Name = "cassechoix";
            this.cassechoix.Size = new System.Drawing.Size(94, 112);
            this.cassechoix.TabIndex = 14;
            this.cassechoix.TabStop = false;
            this.cassechoix.Text = "Casse";
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.majmintext);
            this.groupBoxChoix.Controls.Add(this.colortext);
            this.groupBoxChoix.Controls.Add(this.fontcolor);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(606, 22);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(158, 130);
            this.groupBoxChoix.TabIndex = 15;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // majmintext
            // 
            this.majmintext.AutoSize = true;
            this.majmintext.Location = new System.Drawing.Point(17, 74);
            this.majmintext.Name = "majmintext";
            this.majmintext.Size = new System.Drawing.Size(55, 17);
            this.majmintext.TabIndex = 2;
            this.majmintext.Text = "Casse";
            this.majmintext.UseVisualStyleBackColor = true;
            this.majmintext.CheckedChanged += new System.EventHandler(this.majmintext_CheckedChanged);
            
            // 
            // colortext
            // 
            this.colortext.AutoSize = true;
            this.colortext.Location = new System.Drawing.Point(17, 51);
            this.colortext.Name = "colortext";
            this.colortext.Size = new System.Drawing.Size(135, 17);
            this.colortext.TabIndex = 1;
            this.colortext.Text = "Couleur des caractères";
            this.colortext.UseVisualStyleBackColor = true;
            this.colortext.CheckedChanged += new System.EventHandler(this.colortext_CheckedChanged);
            
            // 
            // fontcolor
            // 
            this.fontcolor.AutoSize = true;
            this.fontcolor.Location = new System.Drawing.Point(17, 27);
            this.fontcolor.Name = "fontcolor";
            this.fontcolor.Size = new System.Drawing.Size(101, 17);
            this.fontcolor.TabIndex = 0;
            this.fontcolor.Text = "Couleur du fond";
            this.fontcolor.UseVisualStyleBackColor = true;
            this.fontcolor.CheckedChanged += new System.EventHandler(this.fontcolor_CheckedChanged);
            
            // 
            // fontchoix
            // 
            this.fontchoix.Controls.Add(this.redcolorfont);
            this.fontchoix.Controls.Add(this.greencolorfont);
            this.fontchoix.Controls.Add(this.bluecolorfont);
            this.fontchoix.Enabled = false;
            this.fontchoix.Location = new System.Drawing.Point(91, 300);
            this.fontchoix.Name = "fontchoix";
            this.fontchoix.Size = new System.Drawing.Size(135, 113);
            this.fontchoix.TabIndex = 16;
            this.fontchoix.TabStop = false;
            this.fontchoix.Text = "Fond";
            // 
            // carachoix
            // 
            this.carachoix.Controls.Add(this.carared);
            this.carachoix.Controls.Add(this.carawhite);
            this.carachoix.Controls.Add(this.carablack);
            this.carachoix.Enabled = false;
            this.carachoix.Location = new System.Drawing.Point(299, 301);
            this.carachoix.Name = "carachoix";
            this.carachoix.Size = new System.Drawing.Size(200, 112);
            this.carachoix.TabIndex = 17;
            this.carachoix.TabStop = false;
            this.carachoix.Text = "Caractères";
            // 
            // labelresult
            // 
            this.labelresult.Location = new System.Drawing.Point(27, 118);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(420, 26);
            this.labelresult.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.carachoix);
            this.Controls.Add(this.fontchoix);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.cassechoix);
            this.Controls.Add(this.textchoix);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cassechoix.ResumeLayout(false);
            this.cassechoix.PerformLayout();
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.fontchoix.ResumeLayout(false);
            this.fontchoix.PerformLayout();
            this.carachoix.ResumeLayout(false);
            this.carachoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textchoix;
        private System.Windows.Forms.RadioButton redcolorfont;
        private System.Windows.Forms.RadioButton greencolorfont;
        private System.Windows.Forms.RadioButton bluecolorfont;
        private System.Windows.Forms.RadioButton carared;
        private System.Windows.Forms.RadioButton carawhite;
        private System.Windows.Forms.RadioButton carablack;
        private System.Windows.Forms.RadioButton cassmin;
        private System.Windows.Forms.RadioButton cassmaj;
        private System.Windows.Forms.GroupBox cassechoix;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.GroupBox fontchoix;
        private System.Windows.Forms.GroupBox carachoix;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.CheckBox majmintext;
        private System.Windows.Forms.CheckBox colortext;
        private System.Windows.Forms.CheckBox fontcolor;
    }
}

