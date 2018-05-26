namespace WindowsFormsApplication1
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
            this.ajouter = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lister = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(368, 12);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(47, 15);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 1;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(223, 15);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "prenom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 286);
            this.dataGridView1.TabIndex = 5;
            // 
            // lister
            // 
            this.lister.Location = new System.Drawing.Point(447, 89);
            this.lister.Name = "lister";
            this.lister.Size = new System.Drawing.Size(75, 23);
            this.lister.TabIndex = 6;
            this.lister.Text = "lister";
            this.lister.UseVisualStyleBackColor = true;
            this.lister.Click += new System.EventHandler(this.lister_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(447, 142);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 7;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(447, 195);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 8;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 412);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.lister);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lister;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
    }
}

