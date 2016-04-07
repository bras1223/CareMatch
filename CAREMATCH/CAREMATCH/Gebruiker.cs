using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH
{
   
    public class Gebruiker
    {

        //Fields
        

        //Properties
        
        public string Gebruikersnaam { get; private set; }

        public string Voornaam { get; private set; }

        public string Achternaam { get; private set; }

        public DateTime GeboorteDatum { get; private set; }

        public Image Pasfoto { get; private set; }

        public string Email { get; private set; }

        public bool Goedgekeurd { get; private set; }
        public Enum.rol rol { get; private set; }

        //Constructor
        public Gebruiker(string gebruikersnaam, string voornaam, string achternaam, Image pasfoto, string email, DateTime geboorteDatum, bool goedgekeurd)
        {
            Gebruikersnaam = gebruikersnaam;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Pasfoto = pasfoto;
            Email = email;
            GeboorteDatum = geboorteDatum;
            Goedgekeurd = goedgekeurd;
        }

        //Methoden

            //Maakt een nieuw chatbericht aan met de huidige tijd en de inhoud die word meegegeven
        public void Chatberichtmaken(string inhoud)
        {
            Chatbericht bericht = new Chatbericht(inhoud);
        }
    }
}
