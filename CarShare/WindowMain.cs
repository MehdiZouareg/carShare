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

            refreshTrajetListe(this.user.trajets, this.grilleTrajets);
            this.labelWelcome.Text = "Bonjour, " + this.user.prenom + "." ;

        }

      

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
            

            try
            {
                Trajet trajet = new Trajet(conn, this.user.login, this.trajetDescription.Text, boxDateDepart.Day.Text, boxDateDepart.Month.Text, boxDateDepart.Year.Text, boxVilleDepart.heure.Text, boxVilleDepart.minute.Text, boxVilleDepart.ville.Text, boxVilleArrivee.heure.Text, boxVilleArrivee.minute.Text, boxVilleArrivee.ville.Text);
                DataResources.creerTrajet(conn, trajet);
                MessageBox.Show("Votre trajet à été enregistré !");
                string query = "SELECT * FROM trajet WHERE login = '" + this.user.login + "' AND idtrajet = (SELECT max(idtrajet) FROM trajet)";
                NpgsqlDataReader reader = DataResources.getReader(conn, query);
                reader.Read();
                Trajet newTrajet = new Trajet(reader);
                this.user.trajets.Add(newTrajet);
                refreshTrajetListe(this.user.trajets, grilleTrajets);
                DataResources.closeReader(conn, reader);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Veuillez saisir tout les champs requis !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
            
        }

        private void buttonSeek_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = DataResources.getConnection();
            Trajet trajet = new Trajet();
            List<string> recherche = new List<string>();
            recherche.Add(this.dateSeek.Day.Text);
            recherche.Add(this.dateSeek.Month.Text);
            recherche.Add(this.dateSeek.Year.Text);
            recherche.Add(this.villeArriveeSeek.ville.Text);
            recherche.Add(this.villeArriveeSeek.heure.Text);
            recherche.Add(this.villeArriveeSeek.minute.Text);
            recherche.Add(this.villeDepartSeek.ville.Text);
            recherche.Add(this.villeDepartSeek.heure.Text);
            recherche.Add(this.villeDepartSeek.minute.Text);


            
            try
            {
                List<Trajet> listeRecherche = new List<Trajet>(DataResources.chercherTrajet(conn, recherche));
                
                MessageBox.Show("ça fonctionne !");
                if(listeRecherche == null)
                {
                    MessageBox.Show("Pas de résultats !");
                }
                refreshTrajetListe(listeRecherche, grilleRecherche);

            }
            catch(Npgsql.NpgsqlException)
            {
                MessageBox.Show("Veuillez saisir tout les champs requis !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void resultatTrajet1_Load(object sender, EventArgs e)
        {

        }

        private void dateDepart_Load(object sender, EventArgs e)
        {

        }

        private void afficherMessErreur(Exception msg)
        {
            MessageBox.Show(msg.ToString());
        }


        /*
            Permet le remplissage des trajets crées par l'utilisateur
        
        */
            
        public void refreshTrajetListe(List<Trajet> Trajets, DataGridView grid)
        {
            grid.Rows.Clear();
 
            foreach(Trajet trajet in Trajets)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = trajet.createur;
                row.Cells[1].Value = trajet.dateTrajet;
                row.Cells[2].Value = trajet.heureDepart;
                row.Cells[3].Value = trajet.heureArrivee;
                row.Cells[4].Value = trajet.villeDepart;
                row.Cells[5].Value = trajet.villeArrivee;
                row.Cells[6].Value = trajet.descriptionTrajet;
                grid.Rows.Add(row);

            }

        }

        /*
        Remplis la DatagridView de l'onglet recherche
        */
        public void fillRechercheTrajetListe(Utilisateur user, DataGridView grid)
        {
            grid.Rows.Clear();

            foreach (Trajet trajet in this.user.trajets)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = trajet.createur;
                row.Cells[1].Value = trajet.dateTrajet;
                row.Cells[2].Value = trajet.heureDepart;
                row.Cells[3].Value = trajet.heureArrivee;
                row.Cells[4].Value = trajet.villeDepart;
                row.Cells[5].Value = trajet.villeArrivee;
                row.Cells[6].Value = trajet.descriptionTrajet;
                grid.Rows.Add(row);

            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridWelcome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    this.gifCar.Image = global::CarShare.Properties.Resources.car;
                    break;
                case 1:
                    this.gifCar.Image = global::CarShare.Properties.Resources.LOGO_GSB;
                    break;
                case 2:
                    this.gifCar.Image = global::CarShare.Properties.Resources.gridcar;
                    break;
                case 3:
                    this.gifCar.Image = global::CarShare.Properties.Resources.computer;
                    break;


            }
        }

        private void gifCar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gifCar.Image = null;
        }

        private void villeArriveeSeek_Load(object sender, EventArgs e)
        {

        }

        private void boxVilleDepart_Load(object sender, EventArgs e)
        {

        }
    }
}

