using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShare
{
    public partial class GererEtape : Form
    {
        private List<NewEtape> listEtape = new List<NewEtape>();
        private Destinations listeVilles;
        private const int marginNext = 55;
        private Trajet trajet; 

        public GererEtape(Destinations liste, Trajet trajet)
        {
            InitializeComponent();
            this.listeVilles = liste;
            this.trajet = trajet;
            this.delEtape.Hide();
            this.nextEtape(5);
        }

        private void addEtape_Click(object sender, EventArgs e)
        {
            if (listEtape.Count < 8)
            {
                this.Height += 55;
                this.addEtape.Top += 55;
                this.validEtape.Top += 55;
                this.delEtape.Top += 55;
                this.delEtape.Show();
                this.nextEtape(this.listEtape[this.listEtape.Count-1].Top + 55);
            }
            else
                MessageBox.Show("Erreur : 8 étapes maximum.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void delEtape_Click(object sender, EventArgs e)
        {
            this.Height -= 55;
            this.addEtape.Top -= 55;
            this.validEtape.Top -= 55;
            this.delEtape.Top -= 55;
            this.listEtape[this.listEtape.Count - 1].Hide();
            this.listEtape.Remove(this.listEtape[this.listEtape.Count - 1]);
            if (this.listEtape.Count == 1)
                this.delEtape.Hide();
        }

        private void nextEtape(int i)
        {
            NewEtape newEtape = new NewEtape();
            newEtape.initVilles(this.listeVilles.villes);
            newEtape.groupBox.Text = "Etape " + (this.listEtape.Count + 1) + "";
            newEtape.Location = new System.Drawing.Point(43, i);
            newEtape.Name = "newEtape" + (this.listEtape.Count + 1) + "";
            newEtape.Size = new System.Drawing.Size(234, 45);
            newEtape.TabIndex = 6;
            this.listEtape.Add(newEtape);
            this.Controls.Add(this.listEtape[this.listEtape.Count - 1]);
        }

        public void remplirListeEtapes()
        {
            int i = 2;
            DateTime time;
            this.trajet.etapes.Clear();
            foreach (NewEtape stp in this.listEtape)
            {
                time = FonctionsUsuelles.toDateTime(stp.heure.Text, stp.minute.Text);
                Etape tmp = new Etape(this.trajet.idTrajet, i++, time, stp.ville.Text);
                this.trajet.etapes.Add(tmp);
            }
            this.Close();
        }

        private void validEtape_Click(object sender, EventArgs e)
        {
            this.remplirListeEtapes();
        }
    }
}
