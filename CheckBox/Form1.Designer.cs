
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
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.majmintext = new System.Windows.Forms.CheckBox();
            this.colortext = new System.Windows.Forms.CheckBox();
            this.fontcolor = new System.Windows.Forms.CheckBox();
            this.fontchoix = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxChoix.SuspendLayout();
            this.fontchoix.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(36, 29);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(57, 17);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Rouge";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(36, 52);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(52, 17);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Blanc";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(36, 75);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(44, 17);
            this.radioButton9.TabIndex = 10;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Noir";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 38);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(78, 17);
            this.radioButton10.TabIndex = 11;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Minuscules";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 75);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(78, 17);
            this.radioButton11.TabIndex = 12;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Majuscules";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(544, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casse";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.radioButton9);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(299, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 112);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caractères";
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
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.fontchoix);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textchoix);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.fontchoix.ResumeLayout(false);
            this.fontchoix.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textchoix;
        private System.Windows.Forms.RadioButton redcolorfont;
        private System.Windows.Forms.RadioButton greencolorfont;
        private System.Windows.Forms.RadioButton bluecolorfont;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.GroupBox fontchoix;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.CheckBox majmintext;
        private System.Windows.Forms.CheckBox colortext;
        private System.Windows.Forms.CheckBox fontcolor;
    }
}

