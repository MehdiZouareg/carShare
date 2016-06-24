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
     * Form de connexion pour l'utilisateur
     */
    public partial class WindowLog : Form
    {
        public WindowLog()
        {
            InitializeComponent();
        }

        /*
         * Méthode du clic sur le bouton d'envoi de données. (à refactoriser)
         */
        private void buttonValid_Click(object sender, EventArgs e)
        {
            string login = this.textBoxLogin.Text;
            string passwd = this.textBoxPasswd.Text;
            string query = "SELECT * FROM utilisateur WHERE login = '" + login + "'";
            NpgsqlConnection connection = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(connection, query);
            reader.Read();
            string pseudo = reader.GetString(0);
            string mdp = reader.GetString(6);
            if (pseudo == login && mdp == passwd)
            {
                this.Hide();
                new WindowMain(new Utilisateur(reader)).Show();
            }
            else
            {
                MessageBox.Show("Error : Bad Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataResources.closeReader(connection, reader);
        }           

        /*
         * Méthode de clic sur le bouton "Quitter".
         */
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
