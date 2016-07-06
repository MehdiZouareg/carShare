namespace CarShare
{
    partial class TrajetsRes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windowMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Utilisateur,
            this.VilleDepart,
            this.nbPlaces,
            this.Date,
            this.HeureDepart,
            this.VilleArrivee,
            this.HeureArrivee});
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // Utilisateur
            // 
            this.Utilisateur.HeaderText = "Utilisateur";
            this.Utilisateur.Name = "Utilisateur";
            // 
            // VilleDepart
            // 
            this.VilleDepart.HeaderText = "Départ";
            this.VilleDepart.Name = "VilleDepart";
            // 
            // nbPlaces
            // 
            this.nbPlaces.HeaderText = "Places Restantes";
            this.nbPlaces.Name = "nbPlaces";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // HeureDepart
            // 
            this.HeureDepart.HeaderText = "Heure de Départ";
            this.HeureDepart.Name = "HeureDepart";
            // 
            // VilleArrivee
            // 
            this.VilleArrivee.HeaderText = "Arrivée";
            this.VilleArrivee.Name = "VilleArrivee";
            // 
            // HeureArrivee
            // 
            this.HeureArrivee.HeaderText = "Heure d\'Arrivée";
            this.HeureArrivee.Name = "HeureArrivee";
            // 
            // windowMainBindingSource
            // 
            this.windowMainBindingSource.DataSource = typeof(CarShare.WindowMain);
            // 
            // TrajetsRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrajetsRes";
            this.Size = new System.Drawing.Size(1193, 335);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowMainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureArrivee;
        private System.Windows.Forms.BindingSource windowMainBindingSource;
    }
}
