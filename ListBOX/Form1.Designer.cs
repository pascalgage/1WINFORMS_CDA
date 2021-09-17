
namespace ListBOX
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addList = new System.Windows.Forms.Button();
            this.emptyList = new System.Windows.Forms.Button();
            this.selectList = new System.Windows.Forms.Button();
            this.entreeText = new System.Windows.Forms.TextBox();
            this.inscritList = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.render = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvel Elément";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index Elément";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LstList";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propriétés";
            // 
            // addList
            // 
            this.addList.Location = new System.Drawing.Point(40, 90);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(157, 23);
            this.addList.TabIndex = 4;
            this.addList.Text = "Ajout Liste";
            this.addList.UseVisualStyleBackColor = true;
            // 
            // emptyList
            // 
            this.emptyList.Location = new System.Drawing.Point(563, 90);
            this.emptyList.Name = "emptyList";
            this.emptyList.Size = new System.Drawing.Size(105, 23);
            this.emptyList.TabIndex = 5;
            this.emptyList.Text = "Vider la Liste";
            this.emptyList.UseVisualStyleBackColor = true;
            // 
            // selectList
            // 
            this.selectList.Location = new System.Drawing.Point(563, 61);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(105, 23);
            this.selectList.TabIndex = 6;
            this.selectList.Text = "Sélectionner";
            this.selectList.UseVisualStyleBackColor = true;
            // 
            // entreeText
            // 
            this.entreeText.Location = new System.Drawing.Point(40, 61);
            this.entreeText.Name = "entreeText";
            this.entreeText.Size = new System.Drawing.Size(157, 20);
            this.entreeText.TabIndex = 7;
            // 
            // inscritList
            // 
            this.inscritList.Location = new System.Drawing.Point(40, 220);
            this.inscritList.Multiline = true;
            this.inscritList.Name = "inscritList";
            this.inscritList.ReadOnly = true;
            this.inscritList.Size = new System.Drawing.Size(180, 200);
            this.inscritList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "items.Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SelectedIndex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Text";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(563, 220);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(100, 20);
            this.count.TabIndex = 12;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(563, 306);
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Size = new System.Drawing.Size(100, 20);
            this.index.TabIndex = 13;
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(563, 399);
            this.render.Name = "render";
            this.render.ReadOnly = true;
            this.render.Size = new System.Drawing.Size(184, 20);
            this.render.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.render);
            this.Controls.Add(this.index);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inscritList);
            this.Controls.Add(this.entreeText);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.emptyList);
            this.Controls.Add(this.addList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.Button emptyList;
        private System.Windows.Forms.Button selectList;
        private System.Windows.Forms.TextBox entreeText;
        private System.Windows.Forms.TextBox inscritList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox render;
    }
}

