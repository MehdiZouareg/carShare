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
    public partial class Dates : UserControl
    {
        public Dates()
        {
            InitializeComponent();
            this.initDay();
            this.initMon();
            this.initYea();
        }

        public void initDay()
        {
            for (int i = 1; i <= 31; ++i)
                this.Day.Items.Add(i);
        }

        public void initMon()
        {
            for (int i = 1; i <= 12; ++i)
                this.Month.Items.Add(i);
        }

        public void initYea()
        { 
            for (int i = 2015; i <= 2048; ++i)
                this.Year.Items.Add(i);
        }
    }
}
