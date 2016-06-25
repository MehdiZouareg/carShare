namespace CarShare
{
    partial class WindowMain
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
            this.gridWelcome = new System.Windows.Forms.DataGridView();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.tabTrajets = new System.Windows.Forms.TabControl();
            this.tabPageCreateTraj = new System.Windows.Forms.TabPage();
            this.trajetUserList = new System.Windows.Forms.GroupBox();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trajetDescription = new System.Windows.Forms.RichTextBox();
            this.nouveauTrajet = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxSeek = new System.Windows.Forms.GroupBox();
            this.buttonSeek = new System.Windows.Forms.Button();
            this.modifInfo = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.boxVilleArrivee = new CarShare.NewEtape();
            this.boxVilleDepart = new CarShare.NewEtape();
            this.dateDepart = new CarShare.Dates();
            this.dateSeek = new CarShare.Dates();
            this.villeArriveeSeek = new CarShare.NewEtape();
            this.villeDepartSeek = new CarShare.NewEtape();
            ((System.ComponentModel.ISupportInitialize)(this.gridWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.tabTrajets.SuspendLayout();
            this.tabPageCreateTraj.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxSeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridWelcome
            // 
            this.gridWelcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWelcome.Location = new System.Drawing.Point(0, 0);
            this.gridWelcome.Name = "gridWelcome";
            this.gridWelcome.Size = new System.Drawing.Size(300, 100);
            this.gridWelcome.TabIndex = 0;
            // 
            // gridUser
            // 
            this.gridUser.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridUser.Location = new System.Drawing.Point(299, 0);
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(485, 100);
            this.gridUser.TabIndex = 1;
            // 
            // tabTrajets
            // 
            this.tabTrajets.Controls.Add(this.tabPageCreateTraj);
            this.tabTrajets.Controls.Add(this.tabPage2);
            this.tabTrajets.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabTrajets.ItemSize = new System.Drawing.Size(391, 18);
            this.tabTrajets.Location = new System.Drawing.Point(0, 100);
            this.tabTrajets.Name = "tabTrajets";
            this.tabTrajets.SelectedIndex = 0;
            this.tabTrajets.Size = new System.Drawing.Size(785, 482);
            this.tabTrajets.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabTrajets.TabIndex = 2;
            // 
            // tabPageCreateTraj
            // 
            this.tabPageCreateTraj.Controls.Add(this.trajetUserList);
            this.tabPageCreateTraj.Controls.Add(this.groupBoxCreate);
            this.tabPageCreateTraj.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateTraj.Name = "tabPageCreateTraj";
            this.tabPageCreateTraj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateTraj.Size = new System.Drawing.Size(777, 456);
            this.tabPageCreateTraj.TabIndex = 0;
            this.tabPageCreateTraj.Text = "Créer un trajet";
            this.tabPageCreateTraj.UseVisualStyleBackColor = true;
            // 
            // trajetUserList
            // 
            this.trajetUserList.Location = new System.Drawing.Point(13, 168);
            this.trajetUserList.Name = "trajetUserList";
            this.trajetUserList.Size = new System.Drawing.Size(750, 280);
            this.trajetUserList.TabIndex = 1;
            this.trajetUserList.TabStop = false;
            this.trajetUserList.Text = "groupBox1";
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.label1);
            this.groupBoxCreate.Controls.Add(this.boxVilleArrivee);
            this.groupBoxCreate.Controls.Add(this.boxVilleDepart);
            this.groupBoxCreate.Controls.Add(this.dateDepart);
            this.groupBoxCreate.Controls.Add(this.trajetDescription);
            this.groupBoxCreate.Controls.Add(this.nouveauTrajet);
            this.groupBoxCreate.Location = new System.Drawing.Point(10, 10);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(757, 150);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // trajetDescription
            // 
            this.trajetDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trajetDescription.Location = new System.Drawing.Point(562, 22);
            this.trajetDescription.Name = "trajetDescription";
            this.trajetDescription.Size = new System.Drawing.Size(189, 112);
            this.trajetDescription.TabIndex = 22;
            this.trajetDescription.Text = "Description...";
            // 
            // nouveauTrajet
            // 
            this.nouveauTrajet.Location = new System.Drawing.Point(345, 118);
            this.nouveauTrajet.Name = "nouveauTrajet";
            this.nouveauTrajet.Size = new System.Drawing.Size(100, 23);
            this.nouveauTrajet.TabIndex = 10;
            this.nouveauTrajet.Text = "Créer";
            this.nouveauTrajet.UseVisualStyleBackColor = true;
            this.nouveauTrajet.Click += new System.EventHandler(this.ajouterTrajet_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBoxSeek);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Choisir un trajet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(13, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 280);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // groupBoxSeek
            // 
            this.groupBoxSeek.Controls.Add(this.buttonSeek);
            this.groupBoxSeek.Controls.Add(this.dateSeek);
            this.groupBoxSeek.Controls.Add(this.villeArriveeSeek);
            this.groupBoxSeek.Controls.Add(this.villeDepartSeek);
            this.groupBoxSeek.Location = new System.Drawing.Point(10, 10);
            this.groupBoxSeek.Name = "groupBoxSeek";
            this.groupBoxSeek.Size = new System.Drawing.Size(757, 150);
            this.groupBoxSeek.TabIndex = 1;
            this.groupBoxSeek.TabStop = false;
            // 
            // buttonSeek
            // 
            this.buttonSeek.Location = new System.Drawing.Point(603, 71);
            this.buttonSeek.Name = "buttonSeek";
            this.buttonSeek.Size = new System.Drawing.Size(75, 23);
            this.buttonSeek.TabIndex = 6;
            this.buttonSeek.Text = "Rechercher";
            this.buttonSeek.UseVisualStyleBackColor = true;
            // 
            // modifInfo
            // 
            this.modifInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifInfo.Location = new System.Drawing.Point(374, 70);
            this.modifInfo.Name = "modifInfo";
            this.modifInfo.Size = new System.Drawing.Size(150, 23);
            this.modifInfo.TabIndex = 0;
            this.modifInfo.Text = "Modifier vos informations";
            this.modifInfo.UseVisualStyleBackColor = false;
            this.modifInfo.Click += new System.EventHandler(this.modifInfo_Click);
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.disconnect.Location = new System.Drawing.Point(559, 70);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(150, 23);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "Déconnexion";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.leave_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(400, 24);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(63, 25);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "label";
            // 
            // boxVilleArrivee
            // 
            this.boxVilleArrivee.Location = new System.Drawing.Point(294, 67);
            this.boxVilleArrivee.Name = "boxVilleArrivee";
            this.boxVilleArrivee.Size = new System.Drawing.Size(234, 45);
            this.boxVilleArrivee.TabIndex = 28;
            // 
            // boxVilleDepart
            // 
            this.boxVilleDepart.Location = new System.Drawing.Point(19, 67);
            this.boxVilleDepart.Name = "boxVilleDepart";
            this.boxVilleDepart.Size = new System.Drawing.Size(234, 45);
            this.boxVilleDepart.TabIndex = 27;
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(19, 15);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(180, 46);
            this.dateDepart.TabIndex = 25;
            // 
            // dateSeek
            // 
            this.dateSeek.Location = new System.Drawing.Point(20, 19);
            this.dateSeek.Name = "dateSeek";
            this.dateSeek.Size = new System.Drawing.Size(180, 46);
            this.dateSeek.TabIndex = 5;
            // 
            // villeArriveeSeek
            // 
            this.villeArriveeSeek.Location = new System.Drawing.Point(276, 71);
            this.villeArriveeSeek.Name = "villeArriveeSeek";
            this.villeArriveeSeek.Size = new System.Drawing.Size(234, 45);
            this.villeArriveeSeek.TabIndex = 4;
            // 
            // villeDepartSeek
            // 
            this.villeDepartSeek.Location = new System.Drawing.Point(20, 71);
            this.villeDepartSeek.Name = "villeDepartSeek";
            this.villeDepartSeek.Size = new System.Drawing.Size(234, 45);
            this.villeDepartSeek.TabIndex = 3;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 582);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.modifInfo);
            this.Controls.Add(this.tabTrajets);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.gridWelcome);
            this.Name = "WindowMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.tabTrajets.ResumeLayout(false);
            this.tabPageCreateTraj.ResumeLayout(false);
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxSeek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridWelcome;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.TabControl tabTrajets;
        private System.Windows.Forms.TabPage tabPageCreateTraj;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button modifInfo;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBoxSeek;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Button nouveauTrajet;
        private System.Windows.Forms.RichTextBox trajetDescription;
        private Dates dateDepart;
        private NewEtape boxVilleArrivee;
        private NewEtape boxVilleDepart;
        private System.Windows.Forms.Label label1;
        private NewEtape villeDepartSeek;
        private Dates dateSeek;
        private NewEtape villeArriveeSeek;
        private System.Windows.Forms.Button buttonSeek;
        private System.Windows.Forms.GroupBox trajetUserList;
    }
}