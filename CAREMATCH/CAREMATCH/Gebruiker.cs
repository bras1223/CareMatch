using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH
{
   
    class Gebruiker
    {

        //Fields
        private string gebruikersnaam;
        private string voornaam;
        private string achternaam;
        private string pasfoto;
        private string email;
        private int leeftijd;
        private bool goedgekeurd;
        private Enum.rol rol; 

        //Properties
        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
        }

        public string Achternaam
        {
            get { return achternaam; }
        }

        public int Leeftijd
        {
            get { return leeftijd; }
        }

        public string Pasfoto
        {
            get { return pasfoto; }
            set { pasfoto = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Goedgekeurd
        {
            get { return goedgekeurd; }
        }

        //Constructor
        public Gebruiker(string gebruikersnaam, string voornaam, string achternaam, string pasfoto, string email, int leeftijd, bool goedgekeurd)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.pasfoto = pasfoto;
            this.email = email;
            this.leeftijd = leeftijd;
            this.goedgekeurd = goedgekeurd;
        }

        //Methoden

            //Maakt een nieuw chatbericht aan met de huidige tijd en de inhoud die word meegegeven
        public void Chatberichtmaken(string inhoud)
        {
            Chatbericht bericht = new Chatbericht(inhoud, DateTime.Now);
        }
    }
}
