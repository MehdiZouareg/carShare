using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarShare
{
    public class Utilisateur
    {
        /*
         * Le constructeur reçoit un SqlReader et en extrait les propriétés de l'utilisateur.
         */
        public Utilisateur(NpgsqlDataReader reader)
        {
            this.login = reader.GetString(0);
            this.nom = reader.GetString(1);
            this.prenom = reader.GetString(2);
            this.numtel = reader.GetString(3);
            this.email = reader.GetString(4);
            this.description = reader.GetString(5);
            this.mdp = reader.GetString(6);
            this.trajets = this.recupTrajets();
            this.Etapes = this.recupEtapes();
        }

        private string Login;
        private string Nom;
        private string Prenom;
        private string Numtel;
        private string Email;
        private string Description;
        private string Mdp;
        private List<Trajet> Trajets;
        private List<Etape> Etapes;

        public string login { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string numtel { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public string mdp { get; set; }
        public List<Trajet> trajets { get; set; }
        public List<Etape> etapes { get; set; }

        /*
         * Méthode qui récupère les trajets dont l'utilisateur est le créateur.
         */ 
        private List<Trajet> recupTrajets()
        {
            List<Trajet> liste = new List<Trajet>();
            string query = "SELECT * FROM trajet WHERE login = '" + this.login + "'";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            while (reader.Read())
                liste.Add(new Trajet(reader));
            DataResources.closeReader(conn, reader);
            return liste;
        }
        
        /*
         * Méthode qui récupère les étapes dans lesquelles l'utilisateur est inscrit.
         */
        private List<Etape> recupEtapes()
        {
            List<Etape> liste = new List<Etape>();
            string query = "SELECT * FROM etape e INNER JOIN sinscrit_a s ON e.idtrajet = s.idtrajet AND e.noetape = s.noetape WHERE login = '" + this.login + "'";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            while (reader.Read())
                liste.Add(new Etape(reader));
            DataResources.closeReader(conn, reader);
            return liste;
        }

        /*
         * Méthode permettant de créer les trajets et les étapes qui lui sont liées. Appelle des méthodes de "Trajet" et "Etape".
         */
        public void creerTrajetEtEtapes(NpgsqlConnection conn, Trajet trajet)
        {
            trajet.creerTrajet(conn);
            foreach (Etape stp in etapes)
                stp.creerEtape(conn);
        }
    }
}
