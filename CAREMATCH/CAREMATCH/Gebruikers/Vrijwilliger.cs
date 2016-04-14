using System;
using System.Drawing;

namespace CAREMATCH.Gebruikers
{


    public class Vrijwilliger : Gebruiker
    {
        public bool Goedgekeurd { get; private set; }

        public Vrijwilliger(bool goedgekeurd, string gebruikersnaam, string voornaam, string achternaam, string pasfoto, string gebruikerInfo, DateTime geboorteDatum) 
            : base(gebruikersnaam, voornaam, achternaam, pasfoto, gebruikerInfo, geboorteDatum)
        {
            Goedgekeurd = goedgekeurd;
            
        }
    }
}
