using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.Gebruikers
{
    public class Beheerder : Gebruiker
    {
        public Beheerder(string gebruikersnaam, string voornaam, string achternaam, Image pasfoto, string email, DateTime geboorteDatum) : base(gebruikersnaam, voornaam, achternaam, pasfoto, email, geboorteDatum)
        {
            
        }
    }
}
