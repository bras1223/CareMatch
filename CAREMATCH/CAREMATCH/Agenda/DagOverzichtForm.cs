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

            dagOverzicht = new AgendaDagOverzicht(gebruiker);

            lblDatumWaarde.Text = dtpTijdPicker.Value.ToString();
        }

        private void btnAgendaPuntToevoegen_Click(object sender, EventArgs e)
        {
            agendaPuntToevoegen = new AgendaPuntToevoegenForm(gebruiker);
            agendaPuntToevoegen.ShowDialog();
            if (agendaPuntToevoegen.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void pnlWeekrooster_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            dagOverzicht.DrawAgendaPunten(g);
            
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKiesKleur_Click(object sender, EventArgs e)
        {
            cdKiesKleur.ShowDialog();
        }

        private void DagOverzichtForm_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
