using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAREMATCH.VrijwilligerSysteem;

namespace CAREMATCH
{
   
    public class Gebruiker
    {

        //Fields
        private List<AgendaPunt> AgendaPunt;

        //Properties        
        public int GebruikersID { get; set; }
        public string Pasfoto { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string GebruikerInfo { get; set; }
        public string Rol { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public bool Auto { get; set; }
        public bool Approved { get; set; }
        //Constructor
        public Gebruiker()
        {
            AgendaPunt = new List<VrijwilligerSysteem.AgendaPunt>();
        }
        //Methoden
        public void AgendaPuntToevoegen(AgendaPunt agendaPunt)
        {

        }
        public void AgendaPuntVerwijderen()
        {

        }
            //Maakt een nieuw chatbericht aan met de huidige tijd en de inhoud die word meegegeven
        public void Chatberichtmaken(string inhoud)
        {
            Chatbericht bericht = new Chatbericht(inhoud);
            //Bericht in database zetten
        }
    }
}
