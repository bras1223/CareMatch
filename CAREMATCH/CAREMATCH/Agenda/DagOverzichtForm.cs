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
    public partial class DagOverzichtForm : Form
    {
        private Gebruiker gebruiker;
        private AgendaDagOverzicht dagOverzicht;
        private AgendaPuntToevoegenForm agendaPuntToevoegen;

        
        public DagOverzichtForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            dagOverzicht = new AgendaDagOverzicht();

            lblDatumWaarde.Text = dtpTijdPicker.Value.ToString();
        }

        private void btnAgendaPuntToevoegen_Click(object sender, EventArgs e)
        {
            agendaPuntToevoegen = new AgendaPuntToevoegenForm(gebruiker);
            agendaPuntToevoegen.Show();
        }

        private void pnlWeekrooster_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            dagOverzicht.DrawAgendaPunten(g);

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

        private void lblDatumVandaag_Click(object sender, EventArgs e)
        {

        }

        private void lblDatumWaarde_Click(object sender, EventArgs e)
        {

        }
    }
}
