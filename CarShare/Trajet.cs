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
        private string DateTrajet;
        private string DescriptionTrajet;
        private string Createur;
        private string VilleDepart;
        private string VilleArrivee;
        private string HeureDepart;
        private string HeureArrivee;

        public int idTrajet { get; set; }
        public string dateTrajet { get; set; }
        public string descriptionTrajet { get; set; }
        public string createur { get; set; }
        public string villeDepart { get; set; }
        public string villeArrivee { get; set; }
        public string heureDepart { get; set; }
        public string heureArrivee { get; set; }


        //Variables de recherche
        public string villeSearch;
        public string arriveeSearch;
        public string heureSearch;
        public string jourSearch;

        public Trajet()
        {

        }

        /*
         * Constructeur créant un trajet à partir d'un reader.
         */
        public Trajet(NpgsqlDataReader reader)
        {
            this.idTrajet = reader.GetInt32(0);
            this.dateTrajet = reader.GetString(1);
            this.descriptionTrajet = reader.GetString(2);
            this.createur = reader.GetString(3);
            this.villeDepart = reader.GetString(4);
            this.villeArrivee = reader.GetString(5);
            this.heureDepart = reader.GetString(6);
            this.heureArrivee = reader.GetString(7);
        }

        /*
         * Constructeur créant un trajet à partir d'une liste de paramètres.
         */
        public Trajet(string date, string description, string pilote)
        {
            this.dateTrajet = date;
            this.descriptionTrajet = description;
            this.createur = pilote;
        }


        /*
         * Méthode créant le trajet dans la BDD.
         */
        public void creerTrajet(NpgsqlConnection conn)
        {
            string query = "INSERT INTO trajet(idtrajet, datetrajet, descriptiontrajet, login, villedepart, villearrivee, heuredepart, heurearrivee) VALUES('" + this.idTrajet + "', '" + this.dateTrajet + "', '" + this.descriptionTrajet + "', '" + this.createur + "', '" + this.villeDepart + "', '" + this.villeArrivee + "', '" + this.heureDepart + "', '" + this.heureArrivee;
            //NpgsqlDataReader reader = DataResources.getReader(conn, query);
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
        }

        public NpgsqlDataReader recupTrajet(NpgsqlConnection conn, string villeSearch, string arriveeSearch, string  heureSearch, string jourSearch)
        {
            string query = "SELECT * FROM trajet WHERE " + villeSearch + " LIKE villedepart OR " + arriveeSearch + " LIKE heurearrivee OR " + heureSearch + " LIKE heuredepart OR " + jourSearch + " LIKE datetrajet";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            return reader;
        }

        public void supprimerTrajet(NpgsqlConnection conn)
        {
            string query = "DELETE FROM trajet WHERE " + this.idTrajet + " AND " + this.dateTrajet + " AND " + this.descriptionTrajet + " AND " + this.createur + " AND " + this.villeDepart + " AND " + this.villeArrivee + " AND " + this.heureDepart + " AND " + this.heureArrivee;
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

        

    }
}

