using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH.Gebruikers;

namespace CAREMATCH
{
    public partial class ChatForm : Form
    {
        Gebruiker gebruiker;
        string partnernaam = "";
        int partnerid;
        List<Chatbericht> oudchatbericht;
        List<Chatbericht> weergegevenberichten;
        Database database;

        public ChatForm(Gebruiker gebruiker)
        {
            this.gebruiker = gebruiker;
            database = new Database();
            InitializeComponent();
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            oudchatbericht = new List<Chatbericht>();
            weergegevenberichten = new List<Chatbericht>();
            Controls.Add(lbChat);
        }

        private void btnVerzenden_Click(object sender, EventArgs e)
        {
            int id = gebruiker.GebruikersID;
            DateTime datum;
            datum = DateTime.Now;
            database.ChatInvoegen(database.ControlleerMaxChatID() + 1, tbBericht.Text, partnerid, gebruiker.GebruikersID, datum.ToString("dd/MMM HH:mm"));
            tbBericht.Clear();
            //database.closeCon();
            //Chatbericht bericht = new Chatbericht(tbBericht.Text);
            //Database
            //lbChat.Items.Add(gebruiker.Gebruikersnaam+": "+bericht.Inhoud);
            //lbChat.Items.Add(bericht.Datumtijd);
            //lbChat.Items.Add(" ");
        }

        private void btnTerug_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            tmrLaadberichten.Stop();
            DialogResult = DialogResult.OK;
        }

        private void ChatForm_Load_1(object sender, EventArgs e)
        {
            tmrLaadberichten.Start();
            BestaandeChatLijst();
            ChatGeschiedenisLaden();
        }

        private void lbGebruikerLijst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            partnernaam = lbGebruikerLijst.SelectedItem as string;
            lblGebruikersnaam.Text = partnernaam;
            partnerid = database.ChatpartnerID(partnernaam);
            lbChat.Items.Clear();
            ChatGeschiedenisLaden();
        }

        private void tmrLaadberichten_Tick(object sender, EventArgs e)
        {
            foreach (Chatbericht c in database.ChatLaden(lblGebruikersnaam.Text, gebruiker.Gebruikersnaam, database.ChatpartnerID(lblGebruikersnaam.Text), gebruiker.GebruikersID))
            {
                if (BerichtNietWeergegeven(c))
                {
                    lbChat.Items.Add(c);
                    lbChat.Items.Add(c.datumtijd.ToString("dd / MMM HH: mm"));
                    lbChat.Items.Add(" ");
                    weergegevenberichten.Add(c);
                }
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            if (btnModus.Text == "Bestaande Chats")
            {
                btnModus.Text = "Nieuwe Chat";
                lbGebruikerLijst.Items.Clear();
                lbChat.Items.Clear();
                BestaandeChatLijst();
            }

            else if (btnModus.Text == "Nieuwe Chat")
            {
                btnModus.Text = "Bestaande Chats";
                lbGebruikerLijst.Items.Clear();
                lbChat.Items.Clear();
                LbVullen();
            }
        }

        //Methodes

        //vult de lb met alle vrijwilligers/hulpbehoevende
        public void LbVullen()
        {
            if (gebruiker.Rol == "Hulpbehoevende")
            {
                foreach (String v in database.VrijwilligersLijst())
                {
                    lbGebruikerLijst.Items.Add(v);
                }
            }

            else if (gebruiker.Rol == "Vrijwilliger")
            {
                foreach (String h in database.HulpbehoevendeLijst())
                {
                    lbGebruikerLijst.Items.Add(h);
                }
            }
        }

        //Kijkt of de gebruiker hulpbehoevende of vrijwilliger is en vult de listbox met vrijwilligers of hulpbehoevende waarmee dde gebruiker een openstaande chat mee heeft.
        public void BestaandeChatLijst()
        {
            if (gebruiker.Rol == "Hulpbehoevende")
            {
                foreach (String v in database.BestaandeChatlijstVrijwilligers(gebruiker.GebruikersID))
                {
                    lbGebruikerLijst.Items.Add(v);
                }
            }

            else if (gebruiker.Rol == "Vrijwilliger")
            {
                foreach (String h in database.BestaandeChatlijstHulpbehoevende(gebruiker.GebruikersID))
                {
                    lbGebruikerLijst.Items.Add(h);
                }
            }
        }

        //Zorgt ervoor dat de datum/tijd in een kleiner font heeft dan de tekst.
        private void lbChat_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            Font myFont = new Font("Microsoft Sans Serif", 16); ;
            string test;

            test = lbChat.Items.ToString();
            try
            {
                if (lbChat.Items[e.Index].ToString().StartsWith(" ") || lbChat.Items[e.Index].ToString().StartsWith(gebruiker.Gebruikersnaam) || lbChat.Items[e.Index].ToString().StartsWith(partnernaam))
                {
                    myFont = new Font("Microsoft Sans Serif", 16);
                }

                else
                {
                    myFont = new Font("Microsoft Sans Serif", 9);
                }
                e.Graphics.DrawString(lbChat.Items[e.Index].ToString(),
                myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
            catch
            {
            }

        }


        //Laad alle berichten die al gestuurd zijn en zet de inhoud en datum in de listbox.
        public void ChatGeschiedenisLaden()
        {
            lbChat.Items.Clear();
            foreach (Chatbericht c in database.ChatLaden(lblGebruikersnaam.Text, gebruiker.Gebruikersnaam, database.ChatpartnerID(lblGebruikersnaam.Text), gebruiker.GebruikersID))
            {

                lbChat.Items.Add(c);
                lbChat.Items.Add(c.datumtijd.ToString("dd / MMM HH: mm"));
                lbChat.Items.Add(" ");
                weergegevenberichten.Add(c);
            }
        }


        //Kijkt of een bericht al is weergegeven
        private bool BerichtNietWeergegeven(Chatbericht bericht)
        {
            bool weergegeven;
            weergegeven = true;

            foreach(Chatbericht c in weergegevenberichten)
            {
                if(c.ID == bericht.ID)
                {
                    weergegeven = false;
                }
            }

            return weergegeven;
        }
    }
}

