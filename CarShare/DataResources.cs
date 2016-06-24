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
            NpgsqlConnection conn = new NpgsqlConnection("User Id=goodman;Password=goodman;Host=192.168.1.92;Database=gsb-db");
            conn.Open();
            return conn;
        }

        /*
         * Methode permettant d'ouvrir une commande et d'en tirer un reader.
         */
        public static NpgsqlDataReader getReader(NpgsqlConnection conn, string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
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
    }
}
