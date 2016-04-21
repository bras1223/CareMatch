using System;
using CAREMATCH.Gebruikers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.VrijwilligerSysteem
{
    partial class HulpvraagForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private Hulpvragen.Hulpvraag hulpvraag;
        public HulpvraagForm(Hulpvragen.Hulpvraag hulpvraag, Gebruiker gebruiker, bool hulpvraagIndienen)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
            this.hulpvraag = hulpvraag;

            //Datum en tijd Format aanpassen voor de hulpbehoevende om aan te passen.
            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.CustomFormat = "d/MM/yyyy:HH:m";
            
            //Knoppen weergeven/Verwijderen op basis van gebruiker rol.
            if (gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                txtHulpvrager.Text = gebruiker.Gebruikersnaam;
                rtxtReactieInhoud.Enabled = false;
                btnReactieOpslaan.Visible = false;
            }
            else if (gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                btnHulpvraagOpslaan.Visible = false;

                cbUrgent.Enabled = false;
                rtxtHulpvraag.Enabled = false;
                txtDuur.Enabled = false;
                txtFrequentie.Enabled = false;
                txtHulpvrager.Enabled = false;
                txtTitel.Enabled = false;
                dtpDatum.Enabled = false;
                cbAutoBenodigd.Enabled = false;
                txtLocatie.Enabled = false;
            }
            if(hulpvraag != null)
            {
                //Profiel foto in de hulpvraag zetten als een gebruiker deze ingesteld heeft.
                if (database.HulpvraagProfielFoto(gebruiker, hulpvraag, "hulpbehoevende") != null)
                {
                    pbHulpbehoevende.Image = Image.FromFile(database.HulpvraagProfielFoto(gebruiker, hulpvraag, "hulpbehoevende"));
                }
                if (database.HulpvraagProfielFoto(gebruiker, hulpvraag, "vrijwilliger") != null)
                {
                    pbVrijwilliger.Image = Image.FromFile(database.HulpvraagProfielFoto(gebruiker, hulpvraag, "vrijwilliger"));
                }
                //Waardes in Textboxes zetten.
                txtDuur.Text = hulpvraag.Duur.ToString();
                txtFrequentie.Text = hulpvraag.Frequentie;
                txtHulpvrager.Text = hulpvraag.Hulpbehoevende;
                txtTitel.Text = hulpvraag.Titel;
                rtxtHulpvraag.Text = hulpvraag.HulpvraagInhoud;
                rtxtReactieInhoud.Text = hulpvraag.Reactie + "\n" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "   " + gebruiker.Gebruikersnaam + " Zegt:\n";

                if (hulpvraag.Urgent)
                {
                    cbUrgent.Checked = true;
                }
            }
        }
        private void btnSluit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        //Vrijwilliger past hulpvraag aan.
        private void btnSlaOp_Click(object sender, EventArgs e)
        {
            rtxtReactieInhoud.Enabled = false;
            hulpvraag.Vrijwilliger = gebruiker.Gebruikersnaam;
            hulpvraag.HulpvraagInhoud = rtxtHulpvraag.Text;
            hulpvraag.Urgent = cbUrgent.Checked;
            hulpvraag.Reactie = rtxtReactieInhoud.Text + "\n";
            database.HulpvraagAanpassen(gebruiker, hulpvraag);
        }
        //Hulpbehoevende dient hulpvraag in.
        private void btnHulpvraagOpslaan_Click(object sender, EventArgs e)
        {
            hulpvraag = new Hulpvragen.Hulpvraag();
            hulpvraag.Duur = txtDuur.Text;
            hulpvraag.Frequentie = txtFrequentie.Text;
            hulpvraag.Hulpbehoevende = gebruiker.Gebruikersnaam;
            hulpvraag.Titel = txtTitel.Text;
            hulpvraag.HulpvraagInhoud = rtxtHulpvraag.Text;
            hulpvraag.Urgent = cbUrgent.Checked;
            hulpvraag.HulpbehoevendeFoto = gebruiker.Pasfoto;
            hulpvraag.Locatie = txtLocatie.Text;
            hulpvraag.Auto = cbAutoBenodigd.Checked;
            hulpvraag.DatumTijd = dtpDatum.Value;

            try
            {
                database.HulpvraagToevoegen(hulpvraag, gebruiker);
                MessageBox.Show("Hulpvraag opgeslagen.");
            }
            catch
            {
                MessageBox.Show("Er is iets foutgegaan bij het opslaan van de hulpvraag. Neem contact op met CareMatch.");
            }
            Close();
        }

        private void txtTitel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbHulpbehoevende_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
