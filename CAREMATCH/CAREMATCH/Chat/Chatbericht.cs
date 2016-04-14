using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH
{
    class Chatbericht
    {
        //Properties
        public string Inhoud { get;}
        public string VerzenderNaam { get; }
        private DateTime datumtijd;

        //Properties

        public string Datumtijd
        {
            get { return datumtijd.ToString("dd/MMM HH:mm"); }
        }

        //Constructor
        public Chatbericht(string inhoud, string verzender)
        {
            Inhoud = inhoud;
            VerzenderNaam = verzender;
            datumtijd = DateTime.Now;
        }

        public override string ToString()
        {
            return VerzenderNaam + ": " + Inhoud;
        }
    }
}
