using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.Agenda
{
    public partial class AgendaPuntToevoegenForm : Form
    {
        Gebruiker gebruiker;
        AgendaPunt agendaPunt;
        Database database;
        public AgendaPuntToevoegenForm(Gebruiker gebruiker, AgendaPunt ap, bool agendaWijzigen)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.agendaPunt = ap;

            database = new Database();
            //Als de agendapunt al bestaat. inhoud vullen met gegevens.
            txtBeschrijving.Text = ap.Beschrijving;
            txtEindTijd.Text = ap.DatumTijdEind.ToString();
            txtAfspraakMet.Text = ap.AfspraakMet;
            txtStartTijd.Text = ap.DatumTijdStart.ToString();
            txtTitel.Text = ap.Titel;
            dtpAfspraakDatum.Value = ap.AfspraakDatum;
            
            lblToevoegen.Visible = false;
            btnOpslaanEnSluiten.Visible = false;
        }
        public AgendaPuntToevoegenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            database = new Database();
            agendaPunt = new AgendaPunt();

            lblWijzigingOpslaan.Visible = false;
            btnWijzigingOpslaan.Visible = false;
        }
        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OplsaanEnSluiten_Click(object sender, EventArgs e)
        {
            if(txtEindTijd.Text == "" || txtStartTijd.Text == "")
            {
                MessageBox.Show("Vul in ieder geval een start- en eindtijd in.");
            }
            else
            {
                //Agendapunten opslaan
                agendaPunt.AgendaEigenaar = gebruiker.GebruikersID;
                agendaPunt.Titel = txtTitel.Text;
                agendaPunt.DatumTijdEind = int.Parse(txtEindTijd.Text);                
                agendaPunt.AfspraakMet = txtAfspraakMet.Text;
                agendaPunt.Beschrijving = txtBeschrijving.Text;
                //Zorgen dat alleen de eerste 2 cijfers van datum Eind & Start meegeven worden.
                while (agendaPunt.DatumTijdEind >= 25)
                {
                    agendaPunt.DatumTijdEind = agendaPunt.DatumTijdEind / 10;
                }
                agendaPunt.DatumTijdStart = int.Parse(txtStartTijd.Text);
                while (agendaPunt.DatumTijdStart >= 25)
                {
                    agendaPunt.DatumTijdStart = agendaPunt.DatumTijdStart / 10;
                }
                //Agendainfo inserten.
                database.AgendaPuntToevoegen(agendaPunt, gebruiker, dtpAfspraakDatum.Value.Date.ToString("dd-MMM-yy"));
                gebruiker.AgendaPuntToevoegen(agendaPunt);

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AgendaPuntToevoegenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWijzigingOpslaan_Click(object sender, EventArgs e)
        {
            database.AgendaAanpassen(gebruiker, agendaPunt, dtpAfspraakDatum.Value.Date.ToString("dd-MMM-yy"));
        }
    }
}
