namespace CarShare
{
    partial class GererEtape
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
            this.addEtape = new System.Windows.Forms.Button();
            this.validEtape = new System.Windows.Forms.Button();
            this.delEtape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEtape
            // 
            this.addEtape.Location = new System.Drawing.Point(40, 70);
            this.addEtape.Name = "addEtape";
            this.addEtape.Size = new System.Drawing.Size(75, 23);
            this.addEtape.TabIndex = 4;
            this.addEtape.Text = "Ajouter";
            this.addEtape.UseVisualStyleBackColor = true;
            this.addEtape.Click += new System.EventHandler(this.addEtape_Click);
            // 
            // validEtape
            // 
            this.validEtape.AutoEllipsis = true;
            this.validEtape.Location = new System.Drawing.Point(206, 70);
            this.validEtape.Name = "validEtape";
            this.validEtape.Size = new System.Drawing.Size(75, 23);
            this.validEtape.TabIndex = 5;
            this.validEtape.Text = "Valider";
            this.validEtape.UseVisualStyleBackColor = true;
            this.validEtape.Click += new System.EventHandler(this.validEtape_Click);
            // 
            // delEtape
            // 
            this.delEtape.Location = new System.Drawing.Point(294, 30);
            this.delEtape.Name = "delEtape";
            this.delEtape.Size = new System.Drawing.Size(14, 23);
            this.delEtape.TabIndex = 6;
            this.delEtape.Text = "button1";
            this.delEtape.UseVisualStyleBackColor = true;
            this.delEtape.Click += new System.EventHandler(this.delEtape_Click);
            // 
            // GererEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 102);
            this.Controls.Add(this.delEtape);
            this.Controls.Add(this.validEtape);
            this.Controls.Add(this.addEtape);
            this.Name = "GererEtape";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addEtape;
        private System.Windows.Forms.Button validEtape;
        private System.Windows.Forms.Button delEtape;
    }
}