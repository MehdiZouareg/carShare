using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CarShare
{
    /*
    * Classe contenant les villes.
    */
    public class Destinations
    {
        public List<string> villes = new List<string>();

        public Destinations()
        {
            this.getVilles();
        }

        /*
         * Méthode de récupération des villes dans la BDD.
         */
        public void getVilles()
        {
            string query = "SELECT nomVille FROM ville";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            while (reader.Read())
                villes.Add(reader.GetString(0));
            DataResources.closeReader(conn, reader);
        }
    }
}
