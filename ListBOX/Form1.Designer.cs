
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.render = new System.Windows.Forms.TextBox();
            this.entindx = new System.Windows.Forms.TextBox();
            this.inscritList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvel Elément";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index Elément";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LstList";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(604, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propriétés";
            // 
            // addList
            // 
            this.addList.Location = new System.Drawing.Point(53, 111);
            this.addList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(209, 28);
            this.addList.TabIndex = 4;
            this.addList.Text = "Ajout Liste";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.addList_Click);
            // 
            // emptyList
            // 
            this.emptyList.Location = new System.Drawing.Point(751, 111);
            this.emptyList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emptyList.Name = "emptyList";
            this.emptyList.Size = new System.Drawing.Size(140, 28);
            this.emptyList.TabIndex = 5;
            this.emptyList.Text = "Vider la Liste";
            this.emptyList.UseVisualStyleBackColor = true;
            this.emptyList.Click += new System.EventHandler(this.emptyList_Click);
            // 
            // selectList
            // 
            this.selectList.Location = new System.Drawing.Point(751, 75);
            this.selectList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(140, 28);
            this.selectList.TabIndex = 6;
            this.selectList.Text = "Sélectionner";
            this.selectList.UseVisualStyleBackColor = true;
            // 
            // entreeText
            // 
            this.entreeText.Location = new System.Drawing.Point(53, 75);
            this.entreeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entreeText.Name = "entreeText";
            this.entreeText.Size = new System.Drawing.Size(208, 22);
            this.entreeText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "items.Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "SelectedIndex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 501);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Text";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(751, 271);
            this.count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(132, 22);
            this.count.TabIndex = 12;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(751, 377);
            this.index.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Size = new System.Drawing.Size(132, 22);
            this.index.TabIndex = 13;
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(751, 491);
            this.render.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.render.Name = "render";
            this.render.ReadOnly = true;
            this.render.Size = new System.Drawing.Size(244, 22);
            this.render.TabIndex = 14;
            // 
            // entindx
            // 
            this.entindx.Location = new System.Drawing.Point(608, 75);
            this.entindx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entindx.Name = "entindx";
            this.entindx.Size = new System.Drawing.Size(95, 22);
            this.entindx.TabIndex = 15;
            // 
            // inscritList
            // 
            this.inscritList.FormattingEnabled = true;
            this.inscritList.ItemHeight = 16;
            this.inscritList.Location = new System.Drawing.Point(57, 256);
            this.inscritList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inscritList.Name = "inscritList";
            this.inscritList.Size = new System.Drawing.Size(204, 212);
            this.inscritList.TabIndex = 16;
            this.inscritList.Click += new System.EventHandler(this.inscritList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 562);
            this.Controls.Add(this.inscritList);
            this.Controls.Add(this.entindx);
            this.Controls.Add(this.render);
            this.Controls.Add(this.index);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.entreeText);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.emptyList);
            this.Controls.Add(this.addList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox render;
        private System.Windows.Forms.TextBox entindx;
        private System.Windows.Forms.ListBox inscritList;
    }
}

