
namespace COLOR_BOX
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.labelRedSample = new System.Windows.Forms.Label();
            this.labelGreenSample = new System.Windows.Forms.Label();
            this.labelBlueSample = new System.Windows.Forms.Label();
            this.labelRGBsample = new System.Windows.Forms.Label();
            this.hexa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(240, 126);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(272, 23);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.Value = 255;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(240, 177);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(272, 22);
            this.hScrollBarGreen.TabIndex = 1;
            this.hScrollBarGreen.Value = 255;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(240, 226);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(272, 24);
            this.hScrollBarBlue.TabIndex = 2;
            this.hScrollBarBlue.Value = 255;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROUGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VERT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLEU";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(535, 132);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRed.TabIndex = 6;
            this.numericUpDownRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(535, 177);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreen.TabIndex = 7;
            this.numericUpDownGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(535, 226);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBlue.TabIndex = 8;
            this.numericUpDownBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // labelRedSample
            // 
            this.labelRedSample.BackColor = System.Drawing.Color.Red;
            this.labelRedSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRedSample.Location = new System.Drawing.Point(690, 132);
            this.labelRedSample.Name = "labelRedSample";
            this.labelRedSample.Size = new System.Drawing.Size(49, 20);
            this.labelRedSample.TabIndex = 9;
            // 
            // labelGreenSample
            // 
            this.labelGreenSample.BackColor = System.Drawing.Color.Green;
            this.labelGreenSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGreenSample.Location = new System.Drawing.Point(690, 177);
            this.labelGreenSample.Name = "labelGreenSample";
            this.labelGreenSample.Size = new System.Drawing.Size(49, 20);
            this.labelGreenSample.TabIndex = 10;
            // 
            // labelBlueSample
            // 
            this.labelBlueSample.BackColor = System.Drawing.Color.Blue;
            this.labelBlueSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBlueSample.Location = new System.Drawing.Point(690, 226);
            this.labelBlueSample.Name = "labelBlueSample";
            this.labelBlueSample.Size = new System.Drawing.Size(49, 20);
            this.labelBlueSample.TabIndex = 11;
            // 
            // labelRGBsample
            // 
            this.labelRGBsample.BackColor = System.Drawing.SystemColors.Control;
            this.labelRGBsample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRGBsample.Location = new System.Drawing.Point(134, 333);
            this.labelRGBsample.Name = "labelRGBsample";
            this.labelRGBsample.Size = new System.Drawing.Size(521, 55);
            this.labelRGBsample.TabIndex = 12;
            this.labelRGBsample.Text = "RGB rendu";
            // 
            // hexa
            // 
            this.hexa.Location = new System.Drawing.Point(310, 294);
            this.hexa.Name = "hexa";
            this.hexa.Size = new System.Drawing.Size(175, 23);
            this.hexa.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Code HEXA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hexa);
            this.Controls.Add(this.labelRGBsample);
            this.Controls.Add(this.labelBlueSample);
            this.Controls.Add(this.labelGreenSample);
            this.Controls.Add(this.labelRedSample);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Name = "Form1";
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Label labelRedSample;
        private System.Windows.Forms.Label labelGreenSample;
        private System.Windows.Forms.Label labelBlueSample;
        private System.Windows.Forms.Label labelRGBsample;
        private System.Windows.Forms.Label hexa;
        private System.Windows.Forms.Button button1;
    }
}

