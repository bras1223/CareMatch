using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.Agenda
{
    public class AgendaPunt
    {
        public int AfspraakID { get; set; }
        public int AgendaEigenaar { get; set; }
        public string DatumTijdStart { get; set; }
        public string DatumTijdEind { get; set; }
        public string Vrijwilliger { get; set; }
        public string Hulpbehoevende { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public AgendaPunt()
        {

        }
    }
}
