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
    public partial class AgendaPuntToevoegenForm : Form
    {
        Gebruiker gebruiker;
        AgendaPunt agendaPunt;
        public AgendaPuntToevoegenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            agendaPunt = new AgendaPunt();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            agendaPunt.AgendaEigenaar = gebruiker.Gebruikersnaam;
            agendaPunt.Titel = txtTitel.Text;
            agendaPunt.DatumTijdEind = txtEindTijd.Text;
            agendaPunt.DatumTijdStart = txtStartTijd.Text;
            agendaPunt.Hulpbehoevende = txtHulpbehoevende.Text;
            agendaPunt.Beschrijving = txtBeschrijving.Text;

            gebruiker.AgendaPuntToevoegen(agendaPunt);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
