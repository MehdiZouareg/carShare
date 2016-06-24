using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CarShare
{
    /*
     * Fenêtre principale.
     */
    public partial class WindowMain : Form
    {
        private Utilisateur User;
        public Utilisateur user { get; set; }

        /*
         * Les destinations à choisir dans les ListBox.
         */
        private Destinations Destinations;
        public Destinations destinations { get; set; }

        /*
         * La liste des trajets de l'utilisateur en cours 
         */
        private List<Trajet> listeTrajet = new List<Trajet>();
        public Trajet trajet { get; set; }

        /*
         * 
         */
        private List<trajetOfUser> ListeTrajets = new List<trajetOfUser>();
         public List<trajetOfUser> listeTrajets { get; set; }

        /*
         * Constructeur
         */
        public WindowMain(Utilisateur utili) 
        {
            InitializeComponent();
            this.destinations = new Destinations();
            this.boxVilleDepart.initVilles(this.destinations.villes);
            this.boxVilleArrivee.initVilles(this.destinations.villes);
            this.villeDepartSeek.initVilles(this.destinations.villes);
            this.villeArriveeSeek.initVilles(this.destinations.villes);
            this.user = utili;
            this.labelWelcome.Text = "Bonjour, " + this.user.login + ".";
            foreach (Trajet traj in this.user.trajets)
            {
                int i = 0;
                int verticalLocation = 9;
                trajetOfUser boxTrajet = new trajetOfUser();
                boxTrajet.Location = new System.Drawing.Point(0, verticalLocation);
                boxTrajet.Name = "trajetOfUser" + i;
                boxTrajet.Size = new System.Drawing.Size(750, 80);
                boxTrajet.TabIndex = 0;
                boxTrajet.villeDepart.Text = traj.villeDepart;
                boxTrajet.heureDepart.Text = traj.heureDepart;
                boxTrajet.villeArrivee.Text = traj.villeArrivee;
                boxTrajet.heureArrivee.Text = traj.heureArrivee;
                boxTrajet.createur.Text = traj.createur;
                boxTrajet.description.Text = traj.descriptionTrajet;
                this.trajetUserList.Controls.Add(boxTrajet);
                i++;
                verticalLocation += 80;
            }
        }

        /*  private void getTripsUser()
        {
            int y_axe = 168;
            foreach (Trajet t in this.user.trajets)
            {
                this.createControlEtapeOrTrajet(t, y_axe);
                y_axe += 78;
            }
           foreach (Etape e in this.user.etapes)
            {
                this.createControlEtapeOrTrajet(e, y_axe);
                y_axe += 78;
            }
        }

        /* private void createControlEtapeOrTrajet(Trajet t, int y)
        {
            EtapeTrajet etapeTrajet = new EtapeTrajet(t);
            etapeTrajet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            etapeTrajet.Location = new System.Drawing.Point(13, y);
            etapeTrajet.Name = "etapeTrajet";
            etapeTrajet.Size = new System.Drawing.Size(750, 78);
            etapeTrajet.TabIndex = 2;
            this.listeTrajets.Add(etapeTrajet);
            this.TrajectDataGrid.Controls.Add(etapeTrajet);
        } */

        /*
         * Méthode ouvrant la fenêtre pour modifier les infos utilisateur.
         */
        private void modifInfo_Click(object sender, EventArgs e)
        {
            ModifInfo modif = new ModifInfo(this.user);
            modif.Show();
        }

        /*
         * Méthode déconnectant l'utilisateur et relançant l'application.
         */
        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        /*
         * Méthode ouvrant la fenêtre pour ajouter des étapes au trajet
         */
        private void ajouterTrajet_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = DataResources.getConnection();
            Trajet trajet = new Trajet();
            trajet.createur = this.user.login;
            trajet.descriptionTrajet = this.trajetDescription.Text;
            trajet.dateTrajet = dateDepart.Day.Text + "/" + dateDepart.Month.Text + "/" + dateDepart.Year.Text;
            trajet.heureDepart = boxVilleDepart.heure.Text + ":" + boxVilleDepart.minute.Text;
            trajet.villeDepart = boxVilleDepart.ville.Text;
            trajet.heureArrivee = boxVilleArrivee.heure.Text + ":" + boxVilleArrivee.minute.Text;
            trajet.villeArrivee = boxVilleArrivee.ville.Text;
            trajet.creerTrajet(conn);
            string query = "SELECT * FROM TRAJET WHERE login = " + this.user.login + " AND max(idTrajet)";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            Trajet newTrajet = new Trajet(reader);
            this.user.trajets.Add(newTrajet);
            DataResources.closeReader(conn, reader);
        }
    }
}

