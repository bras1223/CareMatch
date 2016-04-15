using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.VrijwilligerSysteem
{
    public class AgendaPunt
    {
        public DateTime DatumTijdStart { get; set; }
        public DateTime DatumTijdEind { get; set; }
        public string AgendaEigenaar { get; set; }
        public string Vrijwilliger { get; set; }
        public string Hulpbehoevende { get; set; }
        public string AfspraakTitel { get; set; }
        public string AfspraakBeschrijving { get; set; }
        public AgendaPunt()
        {

        }
        public void DrawAgendaPunt(Graphics g)
        {

        }
    }
    
}
