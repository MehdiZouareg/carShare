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

        private void connectToCarShare()
        {
            string login = this.textBoxLogin.Text;
            string passwd = this.textBoxPasswd.Text;
            string query = "SELECT * FROM utilisateur WHERE login = '" + login + "'";
            NpgsqlConnection conn = new NpgsqlConnection();

            if ((this.textBoxLogin.Text == "") || (this.textBoxPasswd.Text == ""))
            {
                MessageBox.Show("Veuillez saisir tout les champs requis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn = DataResources.getConnection();
                    NpgsqlDataReader reader = DataResources.getReader(conn, query);
                    reader.Read();
                    string pseudo = reader.GetString(0);
                    string mdp = reader.GetString(6);
                    if (pseudo == login && mdp == passwd)
                    {
                        this.Hide();
                        new WindowMain(new Utilisateur(reader)).Show();
                        reader.Close();
                        conn.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error : Bad Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {
            connectToCarShare();
        }

        

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void WindowsLog_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                connectToCarShare();
            }
        }



        /*
         * Méthode de clic sur le bouton "Quitter".
         */
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void WindowLog_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
