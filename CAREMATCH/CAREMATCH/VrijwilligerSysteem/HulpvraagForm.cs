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
        private ProfielForm profielform;
        public HulpvraagForm(Hulpvragen.Hulpvraag hulpvraag, Gebruiker gebruiker, bool hulpvraagIndienen)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
            this.hulpvraag = hulpvraag;

            //Datum en tijd Format aanpassen voor de hulpbehoevende om aan te passen.
            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.CustomFormat = "d/MM/yyyy:HH:mm";
            
            //Knoppen weergeven/Verwijderen op basis van gebruiker rol.
            if (gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                txtHulpvrager.Text = gebruiker.Gebruikersnaam;
                if (hulpvraag != null)
                {
                    rtxtReactieInhoud.Enabled = true;
                }
                else
                {
                    rtxtReactieInhoud.Enabled = false;
                }
                btnReactieOpslaan.Visible = false;
            }
            else if (gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                btnHulpvraagOpslaan.Visible = false;
                btnBeoordeel.Visible = false;

                cbUrgent.Enabled = false;
                rtxtHulpvraag.Enabled = false;
                txtDuur.Enabled = false;
                txtFrequentie.Enabled = false;
                txtHulpvrager.Enabled = false;
                txtTitel.Enabled = false;
                dtpDatum.Enabled = false;
                cbAutoBenodigd.Enabled = false;
                txtLocatie.Enabled = false;

                btnReactieOpslaan.Visible = true;
            }
            if(hulpvraag != null)
            {
                //Waardes in Textboxes zetten.
                txtDuur.Text = hulpvraag.Duur.ToString();
                txtFrequentie.Text = hulpvraag.Frequentie;
                txtHulpvrager.Text = hulpvraag.Hulpbehoevende;
                txtVrijwilliger.Text = hulpvraag.Vrijwilliger;
                txtTitel.Text = hulpvraag.Titel;
                rtxtHulpvraag.Text = hulpvraag.HulpvraagInhoud;
                dtpDatum.Value = hulpvraag.DatumTijd;
                if (hulpvraag.Reactie == "")
                {
                    hulpvraag.Reactie = "\b";
                }
                rtxtReactieInhoud.Text = hulpvraag.Reactie + "\n" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "   " + gebruiker.Gebruikersnaam + " Zegt:\n";

                if (hulpvraag.Urgent)
                {
                    cbUrgent.Checked = true;
                }

                //Profiel foto in de hulpvraag zetten als een gebruiker deze ingesteld heeft.
                if (database.HulpvraagProfielFoto(gebruiker, hulpvraag, "hulpbehoevende") != "")
                {
                    pbHulpbehoevende.Image = Image.FromFile(database.HulpvraagProfielFoto(gebruiker, hulpvraag, "hulpbehoevende"));
                }
                if (database.HulpvraagProfielFoto(gebruiker, hulpvraag, "vrijwilliger") != "" && txtVrijwilliger.Text != "")
                {
                    pbVrijwilliger.Image = Image.FromFile(database.HulpvraagProfielFoto(gebruiker, hulpvraag, "vrijwilliger"));
                }
            }
        }
        private void btnSluit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u wilt sluiten zonder opslaan?", "Let Op!", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
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
            MessageBox.Show("Aanpassingen opgeslagen.");
            Close();
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

            database.HulpvraagToevoegen(hulpvraag, gebruiker);
            MessageBox.Show("Hulpvraag opgeslagen.");
            Close();            
        }

        private void pbHulpbehoevende_Click(object sender, EventArgs e)
        {
            profielform = new ProfielForm(gebruiker, true, "hulpbehoevende");
        }
        private void pbVrijwilliger_Click(object sender, EventArgs e)
        {
            profielform = new ProfielForm(gebruiker, true, "vrijwilliger");
        }
        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnRapporteer_Click(object sender, EventArgs e)
        {
            database.HulpvraagRapporteer(hulpvraag);
            MessageBox.Show("hulpvraag gerapporteerd als ongewenst.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BeoordelingForm beoordelingsform = new BeoordelingForm(hulpvraag);
            beoordelingsform.Show();
        }

        private void HulpvraagForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStartChat_Click(object sender, EventArgs e)
        {
            ChatForm form = new ChatForm(gebruiker, txtVrijwilliger.Text);
            form.Show();
        }
    }
}
