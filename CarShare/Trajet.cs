using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarShare
{
    public class Trajet
    {
        private int IdTrajet;
        private DateTime DateTrajet;
        private string DescriptionTrajet;
        private string Createur;
        private List<Etape> Etapes;

        public int idTrajet { get; set; }
        public DateTime dateTrajet { get; set; }
        public string descriptionTrajet { get; set; }
        public string createur { get; set; }
        public List<Etape> etapes { get; set; }

        /*
         * Constructeur créant un trajet à partir de rien.
         */
        public Trajet()
        {
            this.idTrajet = creerId();
            this.etapes = new List<Etape>();
            this.etapes.Add(new Etape(this.idTrajet));
        }

        /*
         * Constructeur créant un trajet à partir d'un reader.
         */
        public Trajet(NpgsqlDataReader reader)
        {
            this.idTrajet = reader.GetInt32(0);
            this.dateTrajet = reader.GetDateTime(1);
            this.descriptionTrajet = reader.GetString(2);
            this.createur = reader.GetString(3);
            this.etapes = recupEtapes();
        }

        /*
         * Constructeur créant un trajet à partir d'une liste de paramètres.
         */
        public Trajet(DateTime date, string description, string pilote)
        {
            this.idTrajet = this.creerId();
            this.dateTrajet = date;
            this.descriptionTrajet = description;
            this.createur = pilote;
        }

        /*
         * Méthode récupérant les étapes liées au trajet dans la BDD.
         */
        public List<Etape> recupEtapes()
        {
            List<Etape> liste = new List<Etape>();
            string query = "SELECT * FROM etape WHERE idtrajet = '" + this.idTrajet + "'";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            while (reader.Read())
                liste.Add(new Etape(reader));
            DataResources.closeReader(conn, reader);
            return liste;
        }

        /*
         * Méthode créant le trajet dans la BDD.
         */
        public void creerTrajet(NpgsqlConnection conn)
        {
            string query = "INSERT INTO trajet(idtrajet, datetrajet, descriptiontrajet, login) VALUES('" + this.idTrajet + "', '" + this.dateTrajet.Date + "', '" + this.descriptionTrajet + "', '" + this.createur + "'";
            foreach (Etape e in this.etapes)
                e.creerEtape(conn);
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

        /*
         * Méthode parcourant les id existant dans la bdd, afin d'en créer un unique. (vérifier qu'il n'y a pas d'auto-increment pour l'idée dans la BDD)
         */
        public int creerId()
        {
            string query = "SELECT idtrajet FROM trajet";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            Random rand = new Random();
            int id = rand.Next(100000);
            bool loop = true;
            while (loop)
            {
                loop = false;
                while (reader.Read())
                    if (id == reader.GetInt32(0))
                    {
                        id = rand.Next(100000);
                        loop = true;
                        break;
                    }
            }
            DataResources.closeReader(conn, reader);
            return id;
        }
    }
}
