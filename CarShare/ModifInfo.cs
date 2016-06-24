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
    public partial class ModifInfo : Form
    {
        private Utilisateur User;
        public Utilisateur user { get; set; }

        public ModifInfo(Utilisateur user)
        {
            InitializeComponent();
            this.user = user;
            this.textBoxNumTel.Text = this.user.numtel;
            this.textBoxEmail.Text = this.user.email;
            this.richTextBoxDesc.Text = this.user.description;
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            this.user.numtel = this.textBoxNumTel.Text;
            this.user.email = this.textBoxEmail.Text;
            this.user.mdp = this.textBoxPass.Text;
            this.user.description = this.richTextBoxDesc.Text;
            string query = "UPDATE utilisateur SET numtel = '" + this.user.numtel + "', email = '" + this.user.email + "', mdp = '" + this.user.mdp + "', description = '" + this.user.description + "' WHERE login = '" + this.user.login + "'";
            NpgsqlConnection conn = DataResources.getConnection();
            NpgsqlDataReader reader = DataResources.getReader(conn, query);
            DataResources.closeReader(conn, reader);
            this.Close();
        }
    }
}
