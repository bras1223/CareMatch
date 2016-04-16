using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.Agenda
{
    public partial class WeekroosterForm : Form
    {
        private Gebruiker gebruiker;
        private WeekOverzicht weekOverzicht;
        private AgendaPuntToevoegenForm agendaPuntToevoegen;

        int lines;
        float x;
        float y;
        float xSpace;
        float ySpace;
        Brush sd;
        Pen p;
        Font font;
        public WeekroosterForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            weekOverzicht = new WeekOverzicht();

            lines = 22;
            x = 0f;
            y = 0f;
            xSpace = pnlWeekrooster.Width / lines;
            ySpace = pnlWeekrooster.Height / lines;
            sd = new SolidBrush(Color.Black);
            p = new Pen(sd);
            font = new Font("Arial", 10);
        }

        private void btnAgendaPuntToevoegen_Click(object sender, EventArgs e)
        {
            agendaPuntToevoegen = new AgendaPuntToevoegenForm(gebruiker);
            agendaPuntToevoegen.Show();
        }

        private void pnlWeekrooster_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //horizontal lines
            for (int i = 0; i < lines; i++)
            {
                g.DrawLine(p, x, y, xSpace * lines, y);
                g.DrawString(i + ":00", font, sd, new Point(0, Convert.ToInt32(ySpace * i)));
                //Zorgen dat de lijnen niet naast elkaar gezet worden
                y += xSpace;
            }

            //weekOverzicht.DrawAgendaPunt(g);
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKiesKleur_Click(object sender, EventArgs e)
        {
            //cdKiesKleur.ShowDialog();
        }
    }
}
