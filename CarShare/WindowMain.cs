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
         * Le trajet que l'utilisateur pourra créer.
         */ 
        private Trajet Trajet;
        public Trajet trajet;

        private List<EtapeTrajet> ListeTrajets;
        public List<EtapeTrajet> listeTrajets;

        private List<EtapeTrajet> ListeEtapes;
        public List<EtapeTrajet> listeEtapes;

        /*
         * Constructeur
         */
        public WindowMain(Utilisateur utili) 
        {
            InitializeComponent();
            this.destinations = new Destinations();
            this.boxVilleDepart.initVilles(this.destinations.villes);
            this.boxVilleArrivee.initVilles(this.destinations.villes);
            this.user = utili;
            this.trajet = new Trajet();
            this.labelWelcome.Text = "Bonjour, " + this.user.login + ".";
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
            this.trajet.creerTrajet(conn);            
        }

        /*
         * Méthode ouvrant la fenêtre pour ajouter des étapes au trajet
         */
        private void ajouterEtape_Click(object sender, EventArgs e)
        {
            GererEtape newEtape = new GererEtape(this.destinations, this.trajet);
            newEtape.Show();
        }
    }
}
