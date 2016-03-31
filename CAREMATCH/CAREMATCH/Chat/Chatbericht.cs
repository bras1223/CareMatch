using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH
{
    class Chatbericht
    {
        //Fields
        private string inhoud;
        private DateTime datumtijd;

        //Properties
        public string Inhoud
        {
            get { return inhoud; }
        }

        public DateTime Datumtijd
        {
            get { return Datumtijd; }
        }

        //Constructor
        public Chatbericht(string inhoud, DateTime datumtijd)
        {
            this.inhoud = inhoud;
            this.datumtijd = datumtijd;
        }
    }
}
