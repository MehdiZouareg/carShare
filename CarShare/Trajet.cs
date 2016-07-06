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
        private DateTime DescriptionTrajet;
        private string Createur;
        private string VilleDepart;
        private string VilleArrivee;
        private string HeureDepart;
        private DateTime HeureArrivee;

        public int idTrajet { get; set; }
        public DateTime dateTrajet { get; set; }
        public string descriptionTrajet { get; set; }
        public string createur { get; set; }
        public string villeDepart { get; set; }
        public string villeArrivee { get; set; }
        public TimeSpan heureDepart { get; set; }
        public TimeSpan heureArrivee { get; set; }


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
            this.dateTrajet = reader.GetDateTime(1);
            this.heureDepart = reader.GetTimeSpan(2);
            this.heureArrivee = reader.GetTimeSpan(3);
            this.createur = reader.GetString(4);
            this.villeDepart = reader.GetString(5);
            this.villeArrivee = reader.GetString(6);
            this.descriptionTrajet = reader.GetString(7);
            
        }

        public Trajet(NpgsqlConnection conn, string createur, string descriptionTrajet, string jourTrajet, string moisTrajet, string anneeTrajet, string heureDepart, string minuteDepart, string villeDepart, string heureArrivee, string minuteArrivee, string villeArrivee)
        {
            this.idTrajet = DataResources.getLastIdTrajet(conn) + 1;
            this.createur = createur;
            this.descriptionTrajet = descriptionTrajet;
            this.dateTrajet = FonctionsUsuelles.parseJour(jourTrajet, moisTrajet, anneeTrajet);
            this.heureDepart = FonctionsUsuelles.parseHeure(heureDepart, minuteDepart);
            this.villeDepart = villeDepart;
            this.heureArrivee = FonctionsUsuelles.parseHeure(heureArrivee, minuteArrivee);
            this.villeArrivee = villeArrivee;

        }

        /*
         * Constructeur créant un trajet à partir d'une liste de paramètres.
         */
        public Trajet(DateTime date, string description, string pilote)
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
            string query = "INSERT INTO trajet(idtrajet, datetrajet, description, login, villedepart, villearrivee, heuredepart, heurearrivee) VALUES('" + this.idTrajet + "', '" + this.dateTrajet + "', '" + this.descriptionTrajet + "', '" + this.createur + "', '" + this.villeDepart + "', '" + this.villeArrivee + "', '" + this.heureDepart + "', '" + this.heureArrivee + "');";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

       

       
        
       
    }
}

