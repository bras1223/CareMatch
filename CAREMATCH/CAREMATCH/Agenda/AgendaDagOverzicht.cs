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
        private List<AgendaPunt> dagAfsprakenList;
        int lines;
        float x;
        float y;
        float xSpace;
        float ySpace;
        Brush sd;
        Pen p;
        Font font;
        public AgendaDagOverzicht()
        {
            dagAfsprakenList = new List<AgendaPunt>();

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
        public List<AgendaPunt> AgendaPuntToevoegenAanList(AgendaPunt agendaPunt)
        {
            dagAfsprakenList.Add(agendaPunt);
            return dagAfsprakenList;
        }
        public List<AgendaPunt> AgendaPuntVerwijderenUitList(AgendaPunt agendaPunt)
        {
            dagAfsprakenList.Remove(agendaPunt);
            return dagAfsprakenList;
        }
        public void DrawAgendaPunten(Graphics g)
        {
            //horizontal lines - -9 is zodat er niet teveel tijden weergeven worden. tot 20:00
            for (int i = 0; i < (lines -9); i++)
            {
                g.DrawLine(p, x, y, xSpace * lines, y);
                //+8 is zodat de agenda begint vanaf 8:00
                g.DrawString((i+8) + ":00", font, sd, new Point(0, Convert.ToInt32(y)));
                //Zorgen dat de lijnen niet naast elkaar gezet worden
                y += xSpace;
            }
        }
    }
}
