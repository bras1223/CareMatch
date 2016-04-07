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

        public string Datumtijd
        {
            get { return datumtijd.ToString("dd/MMMM HH:mm"); }
        }

        //Constructor
        public Chatbericht(string inhoud)
        {
            this.inhoud = inhoud;
            datumtijd = DateTime.Now;
        }
    }
}
