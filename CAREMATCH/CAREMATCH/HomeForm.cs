using CAREMATCH.VrijwilligerSysteem;
using CAREMATCH.Gebruikers;
using System;
using System.Windows.Forms;
using Login;
using CAREMATCH.Beheerder;
using System.Drawing;

namespace CAREMATCH
{
    public partial class HomeForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        private Agenda.DagOverzichtForm weekrooster;
        private ChatForm chatForm;
        private HulpvraagForm hulpvraagForm;
        private HulpvraagOverzichtForm hulpvraagOverzichtForm;
        private ProfielForm profielForm;
        private GebruikerBeheer GebruikerBeheerderForm;
        private AgendaBeheerderForm AgendaBeheerderForm;
        private ChatBeheerdersForm ChatBeheerderForm;
        private OngepasteBerichtenForm OngepasteBerichtenForm;

        PictureBox img;
        public HomeForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();
            img = new PictureBox();

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
                btnProfiel.Visible = false;
            }
            RefreshNieuwBerichtImg();
        }

        private void btnHulpvraagIndienen_Click(object sender, EventArgs e)
        {
            //De hulpvraag hoeft niet gevuld te zijn. Bestaat nog niet.
            Hulpvragen.Hulpvraag hulpvraag = null;

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
                if (AgendaBeheerderForm.DialogResult == DialogResult.OK || profielForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }
        private void btnBerichten_Click(object sender, EventArgs e)
        {
            if (gebruiker.Rol.ToLower() =="vrijwilliger"|| gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                chatForm = new ChatForm(gebruiker);
                chatForm.ShowDialog();
                if (chatForm.DialogResult == DialogResult.OK || chatForm.DialogResult == DialogResult.Cancel)
                {
                    RefreshNieuwBerichtImg();
                    this.Show();
                }
            }
            else
            {
                this.Hide();
                ChatBeheerderForm = new ChatBeheerdersForm(gebruiker);
                ChatBeheerderForm.ShowDialog();
                if (ChatBeheerderForm.DialogResult == DialogResult.OK || chatForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }

        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.Hide();
            profielForm = new ProfielForm(gebruiker, false, "");
            profielForm.ShowDialog();
            if (profielForm.DialogResult == DialogResult.OK || profielForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            gebruiker = null;
            this.Close();
        }

        private void btnOngepasteBerichten_Click(object sender, EventArgs e)
        {
            this.Hide();
            OngepasteBerichtenForm = new OngepasteBerichtenForm(gebruiker);
            OngepasteBerichtenForm.ShowDialog();
            if (OngepasteBerichtenForm.DialogResult == DialogResult.OK || OngepasteBerichtenForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnAccountOverzicht_Click(object sender, EventArgs e)
        {
            this.Hide();
            GebruikerBeheerderForm = new GebruikerBeheer(gebruiker);
            GebruikerBeheerderForm.ShowDialog();
            if (GebruikerBeheerderForm.DialogResult == DialogResult.OK|| profielForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }   
        }
        private void RefreshNieuwBerichtImg()
        {
            //Icon laten zien als er een nieuw bericht is voor de gebruiker.
            if (database.ChatNieuwBericht(gebruiker))
            {
                img.Parent = btnBerichten;
                img.Location = new Point(20, 20);
                img.Image = Properties.Resources.new_message;
                img.BackColor = Color.Transparent;
                img.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                img.Image = null;
            }
        }
    }
}
