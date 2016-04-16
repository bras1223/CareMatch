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
        private List<AgendaPunt> dagAfsprakenList;
        int lines;
        float x;
        float y;
        float xSpace;
        float ySpace;
        Brush sd;
        Pen p;
        Font font;
        public AgendaDagOverzicht(Gebruiker gebruiker)
        {
            dagAfsprakenList = new List<AgendaPunt>();
            this.gebruiker = gebruiker;

            lines = 22;
            x = 0f;
            y = 0f;
            //Waarden zijn: pnlWidth = 835  pnlHeight = 496
            xSpace = 835 / lines;
            ySpace = 496 / lines;
            sd = new SolidBrush(Color.Black);
            p = new Pen(sd);
            font = new Font("Arial", 10);
        }
        public void DrawAgendaPunten(Graphics g)
        {
            int aantalAfspraken = 0;
            //Agendapunten weergeven. Deze eerder tekenen dan de lijnen en tijden. anders layout problems.
            foreach (AgendaPunt ap in gebruiker.GetAgendaPunten())
            {
                switch (aantalAfspraken)
                {
                    case 0:
                        sd = new SolidBrush(Color.FromArgb(150, 255, 0, 0));
                        break;
                    case 1:
                        sd = new SolidBrush(Color.FromArgb(150, 0, 0, 255));
                        break;
                    case 2:
                        sd = new SolidBrush(Color.FromArgb(150, 0, 255, 0));
                        break;
                    case 3:
                        sd = new SolidBrush(Color.FromArgb(150, 255, 255, 0));
                        break;
                    case 4:
                        sd = new SolidBrush(Color.FromArgb(150, 255, 0, 255));
                        break;
                };
                g.FillRectangle(sd, new Rectangle(aantalAfspraken * 200 + 50, Convert.ToInt32((xSpace * (ap.DatumTijdStart - 8))), 180, Convert.ToInt32((xSpace * (ap.DatumTijdEind - ap.DatumTijdStart)))));
                aantalAfspraken++;
            }
            y = 0f;
            //Lijnen & Tijden weergeven ------- lines-9 is zodat er niet teveel tijden weergeven worden. tot 20:00 anders tot 29:00
            for (int i = 0; i < (lines -9); i++)
            {
                sd = new SolidBrush(Color.Black);
                g.DrawLine(p, x, y, 1033 * lines, y);
                //+8 is zodat de agenda begint vanaf 8:00 anders 0:00
                g.DrawString((i+8) + ":00", font, sd, new Point(0, Convert.ToInt32(y)));
                //Zorgen dat de lijnen niet naast elkaar gezet worden
                y += xSpace;
            }            
            
        }
    }
}
