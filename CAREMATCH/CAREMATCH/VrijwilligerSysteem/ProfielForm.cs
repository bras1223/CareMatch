using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.VrijwilligerSysteem
{
    public partial class ProfielForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        private OpenFileDialog zoekFotoDialog;

        public ProfielForm(Gebruiker gebruiker, bool bekijkProfiel, string gebruikerInfo)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();

            if (bekijkProfiel)
            {
                lblOverJezelf.Text = "Persoonlijke Informatie:";
                btnCancel.Visible = true;

                btnOpslaan.Visible = false;
                btnWijzig.Visible = false;
                gbWijzigWachtwoord.Visible = false;

                txtAchternaam.Enabled = false;
                txtVoornaam.Enabled = false;
                txtGebruikersInfo.Enabled = false;
                cbAuto.Enabled = false;

                if(database.GebruikerProfielOpvragen(gebruikerInfo)[2] != "")
                {
                    txtAchternaam.Text = database.GebruikerProfielOpvragen(gebruikerInfo)[2];
                }
                if(database.GebruikerProfielOpvragen(gebruikerInfo)[3] != "")
                {
                    txtVoornaam.Text = database.GebruikerProfielOpvragen(gebruikerInfo)[3];
                }
                if(database.GebruikerProfielOpvragen(gebruikerInfo)[1] != "")
                {
                    txtGebruikersInfo.Text = database.GebruikerProfielOpvragen(gebruikerInfo)[1];
                }
                if (database.GebruikerProfielOpvragen(gebruikerInfo)[4] != "")
                {
                    try
                    {
                        pbProfielFoto.Image = Image.FromFile(database.GebruikerProfielOpvragen(gebruikerInfo)[4]);
                    }
                    catch
                    {
                        // als er geen profiel foto is hoeft er geen foutmelding weergeven te worden.
                    }
                }
                if (database.GebruikerProfielOpvragen(gebruikerInfo)[0] == "Y")
                {
                    cbAuto.Checked = true;
                }
                else
                {
                    cbAuto.Checked = false;
                }
            }
            //Als een gebruiker zijn eigen profiel bekijkt wordt het volgende uitgevoerd
            else
            {
                lblOverJezelf.Text = "Vertel iets over jezelf:";
                txtGebruikersInfo.Text = gebruiker.GebruikerInfo;
                txtAchternaam.Text = gebruiker.Achternaam;
                txtVoornaam.Text = gebruiker.Voornaam;
                cbAuto.Checked = gebruiker.Auto;
                //afbeelding in de picturebox zetten als een gebruiker deze heeft.
                if (gebruiker.Pasfoto != "")
                {
                    try
                    {
                        pbProfielFoto.Image = Image.FromFile(gebruiker.Pasfoto);
                    }
                    catch
                    {

                    }
                }
                if (gebruiker.Auto)
                {
                    cbAuto.Checked = true;
                }
            }            
        }
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //dubbele IF anders foutmelding.
            if(zoekFotoDialog != null)
            {
                //Als er een afbeelding geopend is.
                if (zoekFotoDialog.FileName != "")
                {
                    //passfoto property krijgt de string van de afbeeldingnaam.
                    gebruiker.Pasfoto = gebruiker.Gebruikersnaam + @"\" + gebruiker.Gebruikersnaam + Path.GetExtension(zoekFotoDialog.FileName);
                    if (!File.Exists(gebruiker.Gebruikersnaam))
                    {
                        //Directory aanmaken als deze nog niet bestaat.
                        System.IO.Directory.CreateDirectory(gebruiker.Gebruikersnaam);
                    }
                    //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                    try
                    {
                        File.Copy(zoekFotoDialog.FileName, gebruiker.Gebruikersnaam + @"\" + gebruiker.Gebruikersnaam + Path.GetExtension(zoekFotoDialog.FileName));
                    }
                    catch
                    {
                        if(pbProfielFoto.Image != null) pbProfielFoto.Image.Dispose();
                        //alle afbeeldingen verwijderen in de map. dan opnieuw bestand kopieren.
                        System.IO.DirectoryInfo di = new DirectoryInfo(gebruiker.Gebruikersnaam + @"\");
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        File.Copy(zoekFotoDialog.FileName, gebruiker.Gebruikersnaam + @"\" + gebruiker.Gebruikersnaam + Path.GetExtension(zoekFotoDialog.FileName));
                    }
                }
            }
            //Info opslaan
            gebruiker.GebruikerInfo = txtGebruikersInfo.Text;
            gebruiker.Voornaam = txtVoornaam.Text;
            gebruiker.Achternaam = txtAchternaam.Text;
            gebruiker.Auto = cbAuto.Checked;
            //Kijken of het wachtwoord veranderd moet worden.
            if(txtNieuwWachtwoord.Text != "")
            {
                if (txtHerhaalWachtwoord.Text == txtNieuwWachtwoord.Text)
                {
                    gebruiker.Wachtwoord = txtNieuwWachtwoord.Text;
                    database.GebruikerProfielAanpassen(gebruiker, true, false);
                }
                else
                {
                    MessageBox.Show("'Nieuw Wachtwoord' is niet gelijk aan het 'Herhaal Wachtwoord'.");
                }
                if (gebruiker.Wachtwoord != database.EncryptString(txtActueelWachtwoord.Text))
                {
                    MessageBox.Show("Actueel wachtwoord klopt niet.");
                }
            }
            //Kijken of de profiel foto aangepast moet worden.
            if(gebruiker.Pasfoto != @"\")
            {
                database.GebruikerProfielAanpassen(gebruiker, false, true);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            zoekFotoDialog = new OpenFileDialog();
            zoekFotoDialog.ShowDialog();
        }

        private void pbProfielFoto_Click(object sender, EventArgs e)
        {

        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAuto.Checked)
            {
                gebruiker.Auto = true;
            }
            else
            {
                gebruiker.Auto = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
