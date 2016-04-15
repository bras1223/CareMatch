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

        public ProfielForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();

            //afbeelding in de picturebox zetten als een gebruiker deze heeft.
            if (gebruiker.Pasfoto != @"\")
            {
                pbProfielFoto.Image = Image.FromFile(gebruiker.Pasfoto);
            }
            txtGebruikersInfo.Text = gebruiker.GebruikerInfo;
            txtAchternaam.Text = gebruiker.Achternaam;
            txtVoornaam.Text = gebruiker.Voornaam;
            cbAuto.Checked = gebruiker.Auto;
            if(gebruiker.Auto)
            {
                cbAuto.Checked = true;
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
                        //alle afbeeldingen verwijderen in de map. dan opnieuw bestand kopieren.
                        System.IO.DirectoryInfo di = new DirectoryInfo(gebruiker.Gebruikersnaam + @"\");
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        File.Copy(zoekFotoDialog.FileName, gebruiker.Gebruikersnaam + @"\" + gebruiker.Gebruikersnaam + Path.GetExtension(zoekFotoDialog.FileName));
                    }
                    Refresh();
                }
            }

            //Verschil maken tussen welke info veranderd is. Anders wordt er een encryptie 
            //over encryptie van het wachtwoord gedaan elke keer dat je iets aan het profiel aanpast
            gebruiker.GebruikerInfo = txtGebruikersInfo.Text;
            gebruiker.Voornaam = txtVoornaam.Text;
            gebruiker.Achternaam = txtAchternaam.Text;
            gebruiker.Auto = cbAuto.Checked;
            if (txtHerhaalWachtwoord.Text != "")
            {
                gebruiker.Wachtwoord = txtNieuwWachtwoord.Text;
                database.ProfielAanpassen(gebruiker,true,false);
            }
            if(gebruiker.Pasfoto != @"\")
            {
                database.ProfielAanpassen(gebruiker, false, true);
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
    }
}
