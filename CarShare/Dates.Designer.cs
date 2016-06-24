namespace CarShare
{
    partial class Dates
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
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(10, 18);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(40, 21);
            this.Day.TabIndex = 1;
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(60, 18);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(40, 21);
            this.Month.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(110, 18);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(60, 21);
            this.Year.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Day);
            this.groupBox1.Controls.Add(this.Month);
            this.groupBox1.Controls.Add(this.Year);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Dates";
            this.Size = new System.Drawing.Size(180, 46);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.ComboBox Month;
        public System.Windows.Forms.ComboBox Day;
        public System.Windows.Forms.ComboBox Year;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}
