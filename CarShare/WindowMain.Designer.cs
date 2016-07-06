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
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.tabTrajets = new System.Windows.Forms.TabControl();
            this.tabPageCreateTraj = new System.Windows.Forms.TabPage();
            this.trajetUserList = new System.Windows.Forms.GroupBox();
            this.grilleTrajets = new System.Windows.Forms.DataGridView();
            this.createur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTrajet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.trajetDescription = new System.Windows.Forms.RichTextBox();
            this.nouveauTrajet = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grilleRecherche = new System.Windows.Forms.DataGridView();
            this.conducteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTrajetChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDepartChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureArriveeChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepartChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeArriveeChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinscrireTrajet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxSeek = new System.Windows.Forms.GroupBox();
            this.buttonSeek = new System.Windows.Forms.Button();
            this.modifInfo = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gifCar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxVilleArrivee = new CarShare.NewEtape();
            this.boxVilleDepart = new CarShare.NewEtape();
            this.boxDateDepart = new CarShare.Dates();
            this.dateSeek = new CarShare.Dates();
            this.villeArriveeSeek = new CarShare.NewEtape();
            this.villeDepartSeek = new CarShare.NewEtape();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.tabTrajets.SuspendLayout();
            this.tabPageCreateTraj.SuspendLayout();
            this.trajetUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleTrajets)).BeginInit();
            this.groupBoxCreate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleRecherche)).BeginInit();
            this.groupBoxSeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifCar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUser
            // 
            this.gridUser.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridUser.Location = new System.Drawing.Point(399, 0);
            this.gridUser.Margin = new System.Windows.Forms.Padding(4);
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(647, 123);
            this.gridUser.TabIndex = 1;
            // 
            // tabTrajets
            // 
            this.tabTrajets.Controls.Add(this.tabPageCreateTraj);
            this.tabTrajets.Controls.Add(this.tabPage2);
            this.tabTrajets.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabTrajets.ItemSize = new System.Drawing.Size(391, 18);
            this.tabTrajets.Location = new System.Drawing.Point(1, 245);
            this.tabTrajets.Margin = new System.Windows.Forms.Padding(4);
            this.tabTrajets.Name = "tabTrajets";
            this.tabTrajets.SelectedIndex = 0;
            this.tabTrajets.Size = new System.Drawing.Size(1047, 593);
            this.tabTrajets.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabTrajets.TabIndex = 2;
            // 
            // tabPageCreateTraj
            // 
            this.tabPageCreateTraj.Controls.Add(this.trajetUserList);
            this.tabPageCreateTraj.Controls.Add(this.groupBoxCreate);
            this.tabPageCreateTraj.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateTraj.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCreateTraj.Name = "tabPageCreateTraj";
            this.tabPageCreateTraj.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCreateTraj.Size = new System.Drawing.Size(1039, 567);
            this.tabPageCreateTraj.TabIndex = 0;
            this.tabPageCreateTraj.Text = "Créer un trajet";
            this.tabPageCreateTraj.UseVisualStyleBackColor = true;
            // 
            // trajetUserList
            // 
            this.trajetUserList.AccessibleName = "gridTrajet";
            this.trajetUserList.Controls.Add(this.grilleTrajets);
            this.trajetUserList.Location = new System.Drawing.Point(17, 207);
            this.trajetUserList.Margin = new System.Windows.Forms.Padding(4);
            this.trajetUserList.Name = "trajetUserList";
            this.trajetUserList.Padding = new System.Windows.Forms.Padding(4);
            this.trajetUserList.Size = new System.Drawing.Size(1000, 345);
            this.trajetUserList.TabIndex = 1;
            this.trajetUserList.TabStop = false;
            this.trajetUserList.Text = "groupBox1";
            // 
            // grilleTrajets
            // 
            this.grilleTrajets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleTrajets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createur,
            this.dateTrajet,
            this.heureDepart,
            this.heureArrivee,
            this.villeDepart,
            this.villeArrivee,
            this.description});
            this.grilleTrajets.Location = new System.Drawing.Point(8, 23);
            this.grilleTrajets.Name = "grilleTrajets";
            this.grilleTrajets.RowTemplate.Height = 24;
            this.grilleTrajets.Size = new System.Drawing.Size(988, 315);
            this.grilleTrajets.TabIndex = 0;
            this.grilleTrajets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // createur
            // 
            this.createur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createur.HeaderText = "Createur";
            this.createur.Name = "createur";
            // 
            // dateTrajet
            // 
            this.dateTrajet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTrajet.HeaderText = "Date du Trajet";
            this.dateTrajet.Name = "dateTrajet";
            // 
            // heureDepart
            // 
            this.heureDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heureDepart.HeaderText = "Heure de Départ";
            this.heureDepart.Name = "heureDepart";
            // 
            // heureArrivee
            // 
            this.heureArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heureArrivee.HeaderText = "Heure d\'Arrivée";
            this.heureArrivee.Name = "heureArrivee";
            // 
            // villeDepart
            // 
            this.villeDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeDepart.HeaderText = "Ville de Depart";
            this.villeDepart.Name = "villeDepart";
            // 
            // villeArrivee
            // 
            this.villeArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeArrivee.HeaderText = "Ville d\'Arrivée";
            this.villeArrivee.Name = "villeArrivee";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.label5);
            this.groupBoxCreate.Controls.Add(this.label4);
            this.groupBoxCreate.Controls.Add(this.label3);
            this.groupBoxCreate.Controls.Add(this.label2);
            this.groupBoxCreate.Controls.Add(this.boxVilleArrivee);
            this.groupBoxCreate.Controls.Add(this.boxVilleDepart);
            this.groupBoxCreate.Controls.Add(this.boxDateDepart);
            this.groupBoxCreate.Controls.Add(this.trajetDescription);
            this.groupBoxCreate.Controls.Add(this.nouveauTrajet);
            this.groupBoxCreate.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCreate.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCreate.Size = new System.Drawing.Size(1009, 185);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            // 
            // trajetDescription
            // 
            this.trajetDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trajetDescription.Location = new System.Drawing.Point(655, 27);
            this.trajetDescription.Margin = new System.Windows.Forms.Padding(4);
            this.trajetDescription.MaxLength = 400;
            this.trajetDescription.Name = "trajetDescription";
            this.trajetDescription.Size = new System.Drawing.Size(345, 137);
            this.trajetDescription.TabIndex = 22;
            this.trajetDescription.Text = "Décrivez le plus possible votre trajet ici ! (fumeur, écoute de la musique, fait " +
    "des pauses...)";
            // 
            // nouveauTrajet
            // 
            this.nouveauTrajet.Location = new System.Drawing.Point(460, 145);
            this.nouveauTrajet.Margin = new System.Windows.Forms.Padding(4);
            this.nouveauTrajet.Name = "nouveauTrajet";
            this.nouveauTrajet.Size = new System.Drawing.Size(133, 28);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1039, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Choisir un trajet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grilleRecherche);
            this.groupBox4.Location = new System.Drawing.Point(17, 207);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1000, 345);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // grilleRecherche
            // 
            this.grilleRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conducteur,
            this.dateTrajetChoi,
            this.heureDepartChoi,
            this.heureArriveeChoi,
            this.villeDepartChoi,
            this.villeArriveeChoi,
            this.nbPlaces,
            this.descriptionChoi,
            this.sinscrireTrajet});
            this.grilleRecherche.Location = new System.Drawing.Point(8, 12);
            this.grilleRecherche.Name = "grilleRecherche";
            this.grilleRecherche.RowTemplate.Height = 24;
            this.grilleRecherche.Size = new System.Drawing.Size(992, 326);
            this.grilleRecherche.TabIndex = 0;
            this.grilleRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // conducteur
            // 
            this.conducteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conducteur.HeaderText = "Conducteur";
            this.conducteur.Name = "conducteur";
            // 
            // dateTrajetChoi
            // 
            this.dateTrajetChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTrajetChoi.HeaderText = "Date du Trajet";
            this.dateTrajetChoi.Name = "dateTrajetChoi";
            // 
            // heureDepartChoi
            // 
            this.heureDepartChoi.HeaderText = "Heure de Depart";
            this.heureDepartChoi.Name = "heureDepartChoi";
            // 
            // heureArriveeChoi
            // 
            this.heureArriveeChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heureArriveeChoi.HeaderText = "Heure d\'Arrivée";
            this.heureArriveeChoi.Name = "heureArriveeChoi";
            // 
            // villeDepartChoi
            // 
            this.villeDepartChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeDepartChoi.HeaderText = "Ville de Départ";
            this.villeDepartChoi.Name = "villeDepartChoi";
            // 
            // villeArriveeChoi
            // 
            this.villeArriveeChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeArriveeChoi.HeaderText = "Ville d\'Arrivée ";
            this.villeArriveeChoi.Name = "villeArriveeChoi";
            // 
            // nbPlaces
            // 
            this.nbPlaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbPlaces.HeaderText = "Places Restantes";
            this.nbPlaces.Name = "nbPlaces";
            // 
            // descriptionChoi
            // 
            this.descriptionChoi.HeaderText = "Description";
            this.descriptionChoi.Name = "descriptionChoi";
            // 
            // sinscrireTrajet
            // 
            this.sinscrireTrajet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sinscrireTrajet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sinscrireTrajet.HeaderText = "Go !";
            this.sinscrireTrajet.Name = "sinscrireTrajet";
            this.sinscrireTrajet.Text = "Go !";
            this.sinscrireTrajet.ToolTipText = "Go !";
            // 
            // groupBoxSeek
            // 
            this.groupBoxSeek.Controls.Add(this.label9);
            this.groupBoxSeek.Controls.Add(this.label8);
            this.groupBoxSeek.Controls.Add(this.label7);
            this.groupBoxSeek.Controls.Add(this.label6);
            this.groupBoxSeek.Controls.Add(this.buttonSeek);
            this.groupBoxSeek.Controls.Add(this.dateSeek);
            this.groupBoxSeek.Controls.Add(this.villeArriveeSeek);
            this.groupBoxSeek.Controls.Add(this.villeDepartSeek);
            this.groupBoxSeek.Location = new System.Drawing.Point(13, 12);
            this.groupBoxSeek.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSeek.Name = "groupBoxSeek";
            this.groupBoxSeek.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSeek.Size = new System.Drawing.Size(1009, 185);
            this.groupBoxSeek.TabIndex = 1;
            this.groupBoxSeek.TabStop = false;
            // 
            // buttonSeek
            // 
            this.buttonSeek.Location = new System.Drawing.Point(804, 87);
            this.buttonSeek.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeek.Name = "buttonSeek";
            this.buttonSeek.Size = new System.Drawing.Size(100, 28);
            this.buttonSeek.TabIndex = 6;
            this.buttonSeek.Text = "Rechercher";
            this.buttonSeek.UseVisualStyleBackColor = true;
            this.buttonSeek.Click += new System.EventHandler(this.buttonSeek_Click);
            // 
            // modifInfo
            // 
            this.modifInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.modifInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifInfo.Location = new System.Drawing.Point(832, 15);
            this.modifInfo.Margin = new System.Windows.Forms.Padding(4);
            this.modifInfo.Name = "modifInfo";
            this.modifInfo.Size = new System.Drawing.Size(195, 28);
            this.modifInfo.TabIndex = 0;
            this.modifInfo.Text = "Modifier vos informations";
            this.modifInfo.UseVisualStyleBackColor = false;
            this.modifInfo.Click += new System.EventHandler(this.modifInfo_Click);
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.SystemColors.Menu;
            this.disconnect.Location = new System.Drawing.Point(832, 51);
            this.disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(195, 28);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "Déconnexion";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.leave_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWelcome.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWelcome.Location = new System.Drawing.Point(10, 4);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(79, 39);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "label";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CarShare.Properties.Resources.LOGO_GSB;
            this.pictureBox1.Location = new System.Drawing.Point(832, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gifCar
            // 
            this.gifCar.Image = global::CarShare.Properties.Resources.car;
            this.gifCar.Location = new System.Drawing.Point(2, -130);
            this.gifCar.Name = "gifCar";
            this.gifCar.Size = new System.Drawing.Size(1046, 380);
            this.gifCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifCar.TabIndex = 7;
            this.gifCar.TabStop = false;
            this.gifCar.Click += new System.EventHandler(this.gifCar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Je pars de :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pour arriver à :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Heure :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Heure :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pour arriver à :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Après:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Avant :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Je pars de :";
            // 
            // boxVilleArrivee
            // 
            this.boxVilleArrivee.AccessibleName = "boxVilleArrivee";
            this.boxVilleArrivee.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxVilleArrivee.Location = new System.Drawing.Point(334, 82);
            this.boxVilleArrivee.Margin = new System.Windows.Forms.Padding(5);
            this.boxVilleArrivee.Name = "boxVilleArrivee";
            this.boxVilleArrivee.Size = new System.Drawing.Size(312, 64);
            this.boxVilleArrivee.TabIndex = 28;
            // 
            // boxVilleDepart
            // 
            this.boxVilleDepart.AccessibleName = "boxVilleDepart";
            this.boxVilleDepart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxVilleDepart.Location = new System.Drawing.Point(12, 82);
            this.boxVilleDepart.Margin = new System.Windows.Forms.Padding(5);
            this.boxVilleDepart.Name = "boxVilleDepart";
            this.boxVilleDepart.Size = new System.Drawing.Size(312, 64);
            this.boxVilleDepart.TabIndex = 27;
            this.boxVilleDepart.Load += new System.EventHandler(this.boxVilleDepart_Load);
            // 
            // boxDateDepart
            // 
            this.boxDateDepart.AccessibleName = "boxDateTrajet";
            this.boxDateDepart.BackColor = System.Drawing.Color.Transparent;
            this.boxDateDepart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDateDepart.Location = new System.Drawing.Point(12, 7);
            this.boxDateDepart.Margin = new System.Windows.Forms.Padding(5);
            this.boxDateDepart.Name = "boxDateDepart";
            this.boxDateDepart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxDateDepart.Size = new System.Drawing.Size(240, 65);
            this.boxDateDepart.TabIndex = 25;
            this.boxDateDepart.Tag = "";
            this.boxDateDepart.Load += new System.EventHandler(this.dateDepart_Load);
            // 
            // dateSeek
            // 
            this.dateSeek.AccessibleName = "boxDateTrajetChoi";
            this.dateSeek.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSeek.Location = new System.Drawing.Point(12, 11);
            this.dateSeek.Margin = new System.Windows.Forms.Padding(5);
            this.dateSeek.Name = "dateSeek";
            this.dateSeek.Size = new System.Drawing.Size(240, 57);
            this.dateSeek.TabIndex = 5;
            // 
            // villeArriveeSeek
            // 
            this.villeArriveeSeek.AccessibleName = "boxVilleArriveeChoi";
            this.villeArriveeSeek.Location = new System.Drawing.Point(12, 87);
            this.villeArriveeSeek.Margin = new System.Windows.Forms.Padding(5);
            this.villeArriveeSeek.Name = "villeArriveeSeek";
            this.villeArriveeSeek.Size = new System.Drawing.Size(312, 55);
            this.villeArriveeSeek.TabIndex = 4;
            this.villeArriveeSeek.Load += new System.EventHandler(this.villeArriveeSeek_Load);
            // 
            // villeDepartSeek
            // 
            this.villeDepartSeek.AccessibleName = "boxVilleDepartChoi";
            this.villeDepartSeek.Location = new System.Drawing.Point(334, 87);
            this.villeDepartSeek.Margin = new System.Windows.Forms.Padding(5);
            this.villeDepartSeek.Name = "villeDepartSeek";
            this.villeDepartSeek.Size = new System.Drawing.Size(312, 55);
            this.villeDepartSeek.TabIndex = 3;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 837);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.modifInfo);
            this.Controls.Add(this.tabTrajets);
            this.Controls.Add(this.gifCar);
            this.Controls.Add(this.gridUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowMain";
            this.Text = "Carshare";
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.tabTrajets.ResumeLayout(false);
            this.tabPageCreateTraj.ResumeLayout(false);
            this.trajetUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleTrajets)).EndInit();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleRecherche)).EndInit();
            this.groupBoxSeek.ResumeLayout(false);
            this.groupBoxSeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Dates boxDateDepart;
        private NewEtape boxVilleArrivee;
        private NewEtape boxVilleDepart;
        private NewEtape villeDepartSeek;
        private Dates dateSeek;
        private NewEtape villeArriveeSeek;
        private System.Windows.Forms.Button buttonSeek;
        private System.Windows.Forms.GroupBox trajetUserList;
        private System.Windows.Forms.DataGridView grilleTrajets;
        private System.Windows.Forms.DataGridViewTextBoxColumn createur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTrajet;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridView grilleRecherche;
        private System.Windows.Forms.PictureBox gifCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conducteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTrajetChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepartChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureArriveeChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepartChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeArriveeChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionChoi;
        private System.Windows.Forms.DataGridViewButtonColumn sinscrireTrajet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}