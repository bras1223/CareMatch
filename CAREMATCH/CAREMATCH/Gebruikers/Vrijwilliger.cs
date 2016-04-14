using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.Gebruikers
{
    

    public class Vrijwilliger : Gebruiker
    {
        public bool Goedgekeurd { get; private set; }

        public Vrijwilliger(bool goedgekeurd, string gebruikersnaam, string voornaam, string achternaam, Image pasfoto, string email, DateTime geboorteDatum) : base(gebruikersnaam, voornaam, achternaam, pasfoto, email, geboorteDatum)
        {
            Goedgekeurd = goedgekeurd;
            
        }

        public bool Keur()
        {
            return true;
        }
    }
}
