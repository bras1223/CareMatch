using System;
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
    public partial class HulpvraagOverzichtForm : Form
    {
        
        private HulpvraagForm hulpvraagForm;
        private List<Hulpvragen.Hulpvraag> hulpvraagList;
        
        public HulpvraagOverzichtForm(Gebruiker gebruiker)
        {
            InitializeComponent();

            hulpvraagForm = new HulpvraagForm(gebruiker, false);
            if(gebruiker.rol == Enum.rol.hulpbehoevende)
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "hulpbehoevende";
            }
            else if(gebruiker.rol == Enum.rol.vrijwilliger)
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "vrijwilliger";
            }
            else
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "beheerder";
            }
            hulpvraagList
        }

        private void lbHulpvragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            //properties van aangeklikte hulpvraag moeten aan HulpvraagForm worden meegegeven, zodat je ze kunt bekijken.
            //selected index van listbox/view item uit list met hulpvragen halen

            this.Hide();
            hulpvraagForm.ShowDialog();
            if(hulpvraagForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }

        private void HulpvraagOverzichtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
