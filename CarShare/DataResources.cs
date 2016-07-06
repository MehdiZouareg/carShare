using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarShare
{
    /*
     * Classe statique d'accès à la base de données.
     */
    public static class DataResources
    {
        /*
         * Méthode permettant de récupérer et d'ouvrir la connexion à la bdd.
         */
        public static NpgsqlConnection getConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection("User Id=postgres;Password=admin;Host=127.0.0.1;Database=carshare;Port=5432");
            conn.Open();
            return conn;
        }

        /*
         * Methode permettant d'ouvrir une commande et d'en tirer un reader.
         */
        public static NpgsqlDataReader getReader(NpgsqlConnection conn, string query)
        {
   
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
            
            
        }

        /*
         * Méthode permettant de fermer un reader et une connexion envoyés en paramètre.
         */
        public static void closeReader(NpgsqlConnection conn, NpgsqlDataReader reader)
        {
            reader.Close();
            conn.Close();
        }

        public static int getLastIdTrajet(NpgsqlConnection conn)
        {
            string query = "SELECT MAX(idtrajet) FROM trajet ;";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Read();
            try
            {
                int lastIdTrajet = reader.GetInt32(0);
                reader.Close();
                return lastIdTrajet;
            }
            catch
            {
                int lastIdTrajet = 0;
                reader.Close();
                return lastIdTrajet;
            }
            
            
        }

        public static void creerTrajet(NpgsqlConnection conn, Trajet trajet)
        {
            string query = "INSERT INTO trajet(idtrajet, datetrajet, description, login, villedepart, villearrivee, heuredepart, heurearrivee) VALUES('" + trajet.idTrajet + "', '" + trajet.dateTrajet + "', '" + trajet.descriptionTrajet + "', '" + trajet.createur + "', '" + trajet.villeDepart + "', '" + trajet.villeArrivee + "', '" + trajet.heureDepart + "', '" + trajet.heureArrivee + "');";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

        public static void creerInscription(NpgsqlConnection conn, Trajet trajet)
        {
            string query = "INSERT INTO sinscrit(login, idtrajet) VALUES('(SELECT login FROM trajet WHERE idtrajet = '" + trajet.idTrajet +"')," + trajet.idTrajet +"');";
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            reader.Close();
        }

        public static List<Trajet> chercherTrajet(NpgsqlConnection conn, List<string> champsStr)
        {
            string query = "SELECT * FROM trajet WHERE";

            /*
            * Gère les cas où on transmet des champs vides pour les heures et jours
            */
            if (champsStr[0] != "" && champsStr[1] != "" && champsStr[2] != "")
            {
                DateTime dateTrajet = FonctionsUsuelles.parseJour(champsStr[0], champsStr[1], champsStr[2]);
                query +="'" + dateTrajet.ToString() + "'= datetrajet AND";
            }
            

            if(champsStr[7] != "" && champsStr[8] != "" )
            {
                TimeSpan heureDepart = FonctionsUsuelles.parseHeure(champsStr[7], champsStr[8]);
                query +="'" + heureDepart.ToString() + "'> heureDepart AND";
            }
            
            
            if(champsStr[4] != "" && champsStr[5] != "")
            {
                TimeSpan heureArrivee = FonctionsUsuelles.parseHeure(champsStr[4], champsStr[5]);
                query +="'" + heureArrivee.ToString() + "'< heurearrivee AND";
            }

            if(champsStr[3] != "")
            {
                string villeDepart = champsStr[3];
                query +="'" + villeDepart + "'= villedepart AND";
            }

            if (champsStr[6] != "")
            {
                string villeArrivee = champsStr[6];
                query += "'" + villeArrivee + "'= villearrivee;";
            }
            
            
            List<Trajet> liste = new List<Trajet>();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            while (reader.Read())
                liste.Add(new Trajet(reader));
            reader.Close();
            return liste;
        }
    }
}
