namespace CarShare
{
    partial class WindowLog
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.buttonValid = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(263, 45);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login :";
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Location = new System.Drawing.Point(263, 79);
            this.labelPasswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(77, 17);
            this.labelPasswd.TabIndex = 1;
            this.labelPasswd.Text = "Password :";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(357, 42);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(189, 22);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "admin";
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(357, 76);
            this.textBoxPasswd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(189, 22);
            this.textBoxPasswd.TabIndex = 3;
            this.textBoxPasswd.UseSystemPasswordChar = true;
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(263, 135);
            this.buttonValid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(133, 28);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Valider";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(413, 135);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(133, 28);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::CarShare.Properties.Resources.LOGO_GSB;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WindowLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

