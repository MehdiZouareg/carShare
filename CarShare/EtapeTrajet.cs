using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShare
{
    public partial class EtapeTrajet : UserControl
    {
        public EtapeTrajet(Trajet trajet)
        {
            InitializeComponent();
            int sizeListe = trajet.etapes.Count - 1;
            this.label1.Text = Convert.ToString(trajet.etapes[0].villeDep);
            this.label2.Text = Convert.ToString(trajet.etapes[0].heure);
            this.label3.Text = Convert.ToString(trajet.etapes[sizeListe].villeDep);
            this.label4.Text = Convert.ToString(trajet.etapes[sizeListe].heure);
        }
    }
}
