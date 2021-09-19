
namespace Saisie_Controle
{
    partial class TransactionAffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCLIENT = new System.Windows.Forms.TextBox();
            this.textBoxDATE = new System.Windows.Forms.TextBox();
            this.textBoxMONTANT = new System.Windows.Forms.TextBox();
            this.textBoxCODEPOSTAL = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM du CLIENT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 424);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTANT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 720);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "CODE POSTAL";
            // 
            // textBoxCLIENT
            // 
            this.textBoxCLIENT.Location = new System.Drawing.Point(950, 256);
            this.textBoxCLIENT.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCLIENT.Name = "textBoxCLIENT";
            this.textBoxCLIENT.ReadOnly = true;
            this.textBoxCLIENT.Size = new System.Drawing.Size(308, 44);
            this.textBoxCLIENT.TabIndex = 4;
            // 
            // textBoxDATE
            // 
            this.textBoxDATE.Location = new System.Drawing.Point(950, 424);
            this.textBoxDATE.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxDATE.Name = "textBoxDATE";
            this.textBoxDATE.ReadOnly = true;
            this.textBoxDATE.Size = new System.Drawing.Size(308, 44);
            this.textBoxDATE.TabIndex = 5;
            // 
            // textBoxMONTANT
            // 
            this.textBoxMONTANT.Location = new System.Drawing.Point(950, 589);
            this.textBoxMONTANT.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxMONTANT.Name = "textBoxMONTANT";
            this.textBoxMONTANT.ReadOnly = true;
            this.textBoxMONTANT.Size = new System.Drawing.Size(308, 44);
            this.textBoxMONTANT.TabIndex = 6;
            // 
            // textBoxCODEPOSTAL
            // 
            this.textBoxCODEPOSTAL.Location = new System.Drawing.Point(950, 697);
            this.textBoxCODEPOSTAL.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCODEPOSTAL.Name = "textBoxCODEPOSTAL";
            this.textBoxCODEPOSTAL.ReadOnly = true;
            this.textBoxCODEPOSTAL.Size = new System.Drawing.Size(308, 44);
            this.textBoxCODEPOSTAL.TabIndex = 7;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(950, 876);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(308, 88);
            this.insert.TabIndex = 8;
            this.insert.Text = "INSERTION bDD";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // TransactionAffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.textBoxCODEPOSTAL);
            this.Controls.Add(this.textBoxMONTANT);
            this.Controls.Add(this.textBoxDATE);
            this.Controls.Add(this.textBoxCLIENT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "TransactionAffForm";
            this.Text = "TransactionAffForm";
            this.Load += new System.EventHandler(this.TransactionAffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCLIENT;
        private System.Windows.Forms.TextBox textBoxDATE;
        private System.Windows.Forms.TextBox textBoxMONTANT;
        private System.Windows.Forms.TextBox textBoxCODEPOSTAL;
        private System.Windows.Forms.Button insert;
    }
}