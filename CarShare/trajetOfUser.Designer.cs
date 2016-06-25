namespace CarShare
{
    partial class trajetOfUser
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.villeDepart = new System.Windows.Forms.Label();
            this.heureDepart = new System.Windows.Forms.Label();
            this.villeArrivee = new System.Windows.Forms.Label();
            this.heureArrivee = new System.Windows.Forms.Label();
            this.createur = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // villeDepart
            // 
            this.villeDepart.AutoSize = true;
            this.villeDepart.Location = new System.Drawing.Point(60, 37);
            this.villeDepart.Name = "villeDepart";
            this.villeDepart.Size = new System.Drawing.Size(35, 13);
            this.villeDepart.TabIndex = 0;
            this.villeDepart.Text = "label1";
            // 
            // heureDepart
            // 
            this.heureDepart.AutoSize = true;
            this.heureDepart.Location = new System.Drawing.Point(142, 37);
            this.heureDepart.Name = "heureDepart";
            this.heureDepart.Size = new System.Drawing.Size(35, 13);
            this.heureDepart.TabIndex = 1;
            this.heureDepart.Text = "label2";
            // 
            // villeArrivee
            // 
            this.villeArrivee.AutoSize = true;
            this.villeArrivee.Location = new System.Drawing.Point(316, 37);
            this.villeArrivee.Name = "villeArrivee";
            this.villeArrivee.Size = new System.Drawing.Size(35, 13);
            this.villeArrivee.TabIndex = 2;
            this.villeArrivee.Text = "label3";
            // 
            // heureArrivee
            // 
            this.heureArrivee.AutoSize = true;
            this.heureArrivee.Location = new System.Drawing.Point(386, 37);
            this.heureArrivee.Name = "heureArrivee";
            this.heureArrivee.Size = new System.Drawing.Size(35, 13);
            this.heureArrivee.TabIndex = 3;
            this.heureArrivee.Text = "label4";
            // 
            // createur
            // 
            this.createur.AutoSize = true;
            this.createur.Location = new System.Drawing.Point(512, 37);
            this.createur.Name = "createur";
            this.createur.Size = new System.Drawing.Size(35, 13);
            this.createur.TabIndex = 4;
            this.createur.Text = "label5";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(607, 3);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(140, 74);
            this.description.TabIndex = 5;
            this.description.Text = "";
            // 
            // trajetOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.description);
            this.Controls.Add(this.createur);
            this.Controls.Add(this.heureArrivee);
            this.Controls.Add(this.villeArrivee);
            this.Controls.Add(this.heureDepart);
            this.Controls.Add(this.villeDepart);
            this.Name = "trajetOfUser";
            this.Size = new System.Drawing.Size(750, 80);
            this.Load += new System.EventHandler(this.trajetOfUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label villeDepart;
        public System.Windows.Forms.Label heureDepart;
        public System.Windows.Forms.Label villeArrivee;
        public System.Windows.Forms.Label heureArrivee;
        public System.Windows.Forms.Label createur;
        public System.Windows.Forms.RichTextBox description;
    }
}
