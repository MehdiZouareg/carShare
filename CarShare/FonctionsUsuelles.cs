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

        public static TimeSpan parseHeure(string heureStr, string minuteStr)
        {
            TimeSpan heureTS = new TimeSpan(Convert.ToInt32(heureStr), Convert.ToInt32(minuteStr), 0);
            return heureTS;
        }
        public static DateTime parseJour(string jourStr, string moisStr, string anneeStr)
        {
            DateTime jourDT = new DateTime(Convert.ToInt32(anneeStr), Convert.ToInt32(moisStr), Convert.ToInt32(jourStr));
            return jourDT;
        }
    }
}
