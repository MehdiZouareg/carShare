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
    public partial class NewEtape : UserControl
    {
        public NewEtape()
        {
            InitializeComponent();
            this.initHeures();
        }

        public void initVilles(List<string> liste)
        {
            foreach (string l in liste)
                this.ville.Items.Add(l);
        }

        public void initHeures()
        {
            int i;
            for (i = 0; i <= 23; ++i)
                this.heure.Items.Add(i);
            for (i = 1; i <= 59; ++i)
                this.minute.Items.Add(i);
        }
    }
}
