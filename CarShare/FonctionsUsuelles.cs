using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShare
{
    public static class FonctionsUsuelles
    {
        public static DateTime toDateTime(string heure, string minute)
        {
            string timestr = "" + heure + ":" + minute + "";
            return Convert.ToDateTime(timestr);
        }
    }
}
