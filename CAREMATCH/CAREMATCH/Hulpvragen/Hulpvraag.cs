using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.Hulpvragen
{
    class Hulpvraag
    {
        public DateTime DatumTijd;

        public string Titel { get; set;}
        public string Omschrijving { get; set; }
        public string Frequentie { get; set; }
        public int Duur { get; set; }

        public Hulpvraag()
        {

        }
        public void VerwijderHulpvraag()
        {

        }
    }
}
