using CAREMATCH.VrijwilligerSysteem;
using CAREMATCH.Gebruikers;
using CAREMATCH.Beheerder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH.Agenda;
using Login;

namespace CAREMATCH
{
    public partial class HomeForm : Form
    {
        private Gebruiker gebruiker;
        private Hulpvragen.Hulpvraag hulpvraag;
        private Agenda.DagOverzichtForm weekrooster;
        private ChatForm chatForm;
        private HulpvraagForm hulpvraagForm;
        private HulpvraagOverzichtForm hulpvraagOverzichtForm;
        private ProfielForm profielForm;
        private GebruikerBeheer GebruikerBeheerderForm;
        private AgendaBeheerderForm AgendaBeheerderForm;
        private ChatBeheerdersForm ChatBeheerderForm;

        public HomeForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
                        
            if (gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                btnOngepasteBerichten.Visible = false;
                btnAccountOverzicht.Visible = false;
            }
            else if (gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                btnHulpvraagIndienen.Visible = false;

                btnOngepasteBerichten.Visible = false;
                btnAccountOverzicht.Visible = false;
            }
            else
            {
                btnHulpvraagIndienen.Visible = false;
            }
        }

        private void btnHulpvraagIndienen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, true);
            hulpvraagForm.ShowDialog();
            if(hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnHulpvraagAannemen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm = new HulpvraagOverzichtForm(gebruiker, false);
            hulpvraagOverzichtForm.ShowDialog();
            if(hulpvraagOverzichtForm.DialogResult == DialogResult.OK || hulpvraagOverzichtForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            if (gebruiker.Rol.ToLower() == "vrijwilliger" || gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                this.Hide();
                weekrooster = new Agenda.DagOverzichtForm(gebruiker);
                weekrooster.ShowDialog();
                if (weekrooster.DialogResult == DialogResult.OK || weekrooster.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                this.Hide();
                AgendaBeheerderForm = new AgendaBeheerderForm(gebruiker);
                AgendaBeheerderForm.ShowDialog();
                if (AgendaBeheerderForm.DialogResult == DialogResult.Cancel || profielForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }
        private void btnBerichten_Click(object sender, EventArgs e)
        {
            if (gebruiker.Rol.ToLower() =="vrijwilliger"|| gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                this.Hide();
                chatForm = new ChatForm(gebruiker);
                chatForm.ShowDialog();
                if (chatForm.DialogResult == DialogResult.Cancel || chatForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                this.Hide();
                ChatBeheerderForm = new ChatBeheerdersForm(gebruiker);
                ChatBeheerderForm.ShowDialog();
                if (ChatBeheerderForm.DialogResult == DialogResult.Cancel || chatForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }

        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.Hide();
            profielForm = new ProfielForm(gebruiker);
            profielForm.ShowDialog();
            if (profielForm.DialogResult == DialogResult.OK || profielForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void btnOngepasteBerichten_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountOverzicht_Click(object sender, EventArgs e)
        {
                this.Hide();
                GebruikerBeheerderForm = new GebruikerBeheer(gebruiker);
                GebruikerBeheerderForm.ShowDialog();
                if (GebruikerBeheerderForm.DialogResult == DialogResult.Cancel|| profielForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
           

        }
    }
}
