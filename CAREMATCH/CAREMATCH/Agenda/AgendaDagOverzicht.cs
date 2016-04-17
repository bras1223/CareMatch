using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAREMATCH.Agenda
{
    class AgendaDagOverzicht
    {
        private Gebruiker gebruiker;
        private Database database;
        private List<AgendaPunt> dagAfsprakenList;
        private string filter;
        int lines;
        float x;
        float y;
        float xSpace;
        float ySpace;
        Brush sbBlack;
        Brush sbColor;
        Pen p;
        Font font;
        public AgendaDagOverzicht(Gebruiker gebruiker)
        {
            this.gebruiker = gebruiker;
            dagAfsprakenList = new List<AgendaPunt>();
            database = new Database();

            lines = 22;
            x = 0f;
            y = 0f;
            //Waarden zijn: pnlWidth = 835  pnlHeight = 496
            xSpace = 835 / lines;
            ySpace = 496 / lines;
            sbBlack = new SolidBrush(Color.Black);
            p = new Pen(sbBlack);
            font = new Font("Arial", 10);
        }
        public void DrawAgendaPunten(Graphics g, string filter)
        {
            this.filter = filter;
            int aantalAfspraken = 0;
            //Agendapunten weergeven. Deze eerder tekenen dan de lijnen en tijden. anders layout problems.
            foreach (AgendaPunt ap in gebruiker.GetAgendaPunten())
            {
                //Per afspraak een andere kleur weergeven.
                switch (aantalAfspraken)
                {
                    case 0:
                        sbColor = new SolidBrush(Color.Red);
                        break;
                    case 1:
                        sbColor = new SolidBrush(Color.Green);
                        break;
                    case 2:
                        sbColor = new SolidBrush(Color.Blue);
                        break;
                    case 3:
                        sbColor = new SolidBrush(Color.Yellow);
                        break;
                    case 4:
                        sbColor = new SolidBrush(Color.Orange);
                        break;
                };
                //X = per afspraak de rectangle opschuiven bij 200 + 50 voor een vrije ruimte links + rechts
                //Y = De afstand van een regel * de tijd van een afspraak - 8 omdat er begonnen wordt om 8 uur.
                //Width = vaste breedte.
                //Height = afstand van een regel * de eindtijd - startijd. Voorbeeld: 12 - 8 = 4 hoogte van 4 * lijn afstand (xSpace).
                g.FillRectangle(sbColor, new Rectangle(aantalAfspraken * 200 + 50, Convert.ToInt32((xSpace * (ap.DatumTijdStart - 8))), 180, Convert.ToInt32((xSpace * (ap.DatumTijdEind - ap.DatumTijdStart)))));
                g.DrawString("Afspraak met:\n"+ ap.Hulpbehoevende , font, sbBlack, aantalAfspraken * 200 + 50, Convert.ToInt32((xSpace * (ap.DatumTijdStart - 8))));
                aantalAfspraken++;
            }
            y = 0f;
            //Lijnen & Tijden weergeven ------- lines-9 is zodat er niet teveel tijden weergeven worden. tot 20:00 anders tot 29:00
            for (int i = 0; i < (lines -9); i++)
            {
                g.DrawLine(p, x, y, 1033 * lines, y);
                //+8 is zodat de agenda begint vanaf 8:00 anders 0:00
                g.DrawString((i+8) + ":00", font, sbBlack, new Point(0, Convert.ToInt32(y)));
                //Zorgen dat de lijnen niet naast elkaar gezet worden
                y += xSpace;
            }                        
        }
    }
}
