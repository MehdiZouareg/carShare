namespace CarShare
{
    partial class NewEtape
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
            this.ville = new System.Windows.Forms.ComboBox();
            this.heure = new System.Windows.Forms.ComboBox();
            this.minute = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ville
            // 
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(10, 17);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(120, 21);
            this.ville.TabIndex = 0;
            // 
            // heure
            // 
            this.heure.FormattingEnabled = true;
            this.heure.Location = new System.Drawing.Point(136, 17);
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(40, 21);
            this.heure.TabIndex = 1;
            // 
            // minute
            // 
            this.minute.FormattingEnabled = true;
            this.minute.Location = new System.Drawing.Point(182, 17);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(40, 21);
            this.minute.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.minute);
            this.groupBox.Controls.Add(this.heure);
            this.groupBox.Controls.Add(this.ville);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(234, 45);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "";
            // 
            // NewEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "NewEtape";
            this.Size = new System.Drawing.Size(234, 45);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox ville;
        public System.Windows.Forms.ComboBox heure;
        public System.Windows.Forms.ComboBox minute;
        public System.Windows.Forms.GroupBox groupBox;
    }
}
