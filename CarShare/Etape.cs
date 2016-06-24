using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarShare
{
    public class Etape
    {
        /*
         * Constructeur pour créer la première étape de la liste.
         */
        public Etape(int id)
        {
            this.idTrajet = id;
            this.noEtape = 1;
        }

        /*
         * Constructeur pour créer une étape à partir d'un reader.
         */
        public Etape(NpgsqlDataReader reader)
        {
            this.idTrajet = reader.GetInt32(0);
            this.noEtape = reader.GetInt16(1);
            this.heure = reader.GetDateTime(2);
            this.villeDep = reader.GetString(3);
        }

        /*
         * Constructeur pour créer une étape à partir d'une liste de paramètres.
         */
        public Etape(int id, int no, DateTime heure, string ville)
        {
            this.idTrajet = id;
            this.noEtape = no;
            this.heure = heure;
            this.villeDep = ville;
        }

        /*
         * Méthode pour envoyer les étapes à la BDD.
         */
        public void creerEtape(NpgsqlConnection conn)
        {
            string query = "INSERT INTO etape(idtrajet, noetape, heure, ville) VALUES('" + this.idTrajet + "', '" + this.noEtape + "', '" + this.heure.TimeOfDay + "', '" + this.villeDep + "'";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

        private int IdTrajet;
        private int NoEtape;
        private DateTime Heure;
        private string VilleDep;

        public int idTrajet { get; set; }
        public int noEtape { get; set; }
        public DateTime heure { get; set; }
        public string villeDep { get; set; }
    }
}
