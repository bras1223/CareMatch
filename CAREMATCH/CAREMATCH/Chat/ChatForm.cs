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
        int partnerid = -1;
        List<Chatbericht> weergegevenberichten;
        Database database;
        bool done = false;

        //Constructors
        public ChatForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            lbGebruikerLijst.DrawMode = DrawMode.OwnerDrawFixed;
            lbGebruikerLijst.DrawItem += new DrawItemEventHandler(lbGebruikerLijst_DrawItem);
            weergegevenberichten = new List<Chatbericht>();
            Controls.Add(lbChat);
            database.ChatZetOnline(gebruiker.GebruikersID);
        }

        public ChatForm(Gebruiker gebruiker, string partnernaam)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            lbGebruikerLijst.DrawMode = DrawMode.OwnerDrawFixed;
            lbGebruikerLijst.DrawItem += new DrawItemEventHandler(lbGebruikerLijst_DrawItem);
            weergegevenberichten = new List<Chatbericht>();
            Controls.Add(lbChat);
            database.ChatZetOnline(gebruiker.GebruikersID);

            this.partnernaam = partnernaam;
            tmrTest.Start();


        }

        private void btnVerzenden_Click(object sender, EventArgs e)
        {
            int id = gebruiker.GebruikersID;
            DateTime datum;
            datum = DateTime.Now;
            try
            {
                database.ChatInvoegen(database.ControlleerMaxChatID() + 1, tbBericht.Text, partnerid, gebruiker.GebruikersID, datum.ToString("dd/MMM HH:mm"));
            }
            catch { MessageBox.Show("Selecteer een Persoon"); }
            tbBericht.Clear();
        }

        private void btnTerug_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            database.ChatZetOffline(gebruiker.GebruikersID);
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
            VeranderStatus(partnerid);
            lbChat.Items.Clear();
            ChatGeschiedenisLaden();
            lbChat.SelectedIndex = lbChat.Items.Count - 1;
            lbChat.SelectedIndex = -1;

            if (btnModus.Text == "Bestaande Chats")
            {
                lbGebruikerLijst.Items.Clear();
                LbVullen();
            }
            else
            {

                lbGebruikerLijst.Items.Clear();
                BestaandeChatLijst();
            }
        }

        private void tmrLaadberichten_Tick(object sender, EventArgs e)
        {
            if(partnerid != -1)
            {
                VeranderStatus(partnerid);
            }

            if (done)
            {
                tmrTest.Stop();
            }

            foreach (Chatbericht c in database.ChatLaden(lblGebruikersnaam.Text, gebruiker.Gebruikersnaam, database.ChatpartnerID(lblGebruikersnaam.Text), gebruiker.GebruikersID))
            {
                if (BerichtNietWeergegeven(c))
                {
                    if (c.VerzenderNaam != gebruiker.Gebruikersnaam)
                    {
                        database.ChatBerichtGelezen(c.ID);
                    }
                    lbChat.Items.Add(c);
                    lbChat.Items.Add(c.datumtijd.ToString("dd / MMM HH: mm"));
                    lbChat.Items.Add(" ");
                    weergegevenberichten.Add(c);
                    lbChat.SetSelected(lbChat.Items.Count - 1, true);
                    lbChat.SelectedIndex = lbChat.Items.Count - 1;
                    lbChat.SelectedIndex = -1;
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

        private void tbBericht_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = gebruiker.GebruikersID;
                DateTime datum;
                datum = DateTime.Now;
                try
                {
                    database.ChatInvoegen(database.ControlleerMaxChatID() + 1, tbBericht.Text, partnerid, gebruiker.GebruikersID, datum.ToString("dd/MMM HH:mm"));
                }
                catch { MessageBox.Show("Selecteer een Persoon"); }
                tbBericht.Clear();
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
                    if(database.ChatCheckGelezen(gebruiker.GebruikersID, database.ChatpartnerID(v)) != 0)
                    {
                        
                    }

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

        //Zorgt ervoor dat de namen waar je ongelezen berichten hebt een ander kleur zijn
        private void lbGebruikerLijst_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            Font myFont = new Font("Microsoft Sans Serif", 16); ;
            string test = "";
            try
            {
                test = lbGebruikerLijst.Items[e.Index].ToString();
            }
            catch { }
        
            try
            {
                if (database.ChatCheckGelezen(database.ChatpartnerID(test), gebruiker.GebruikersID) != 0)
                {
                    myBrush = Brushes.Orange;
                }
                else
                {
                    myBrush = Brushes.Black;
                }

                e.Graphics.DrawString(test,
                myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Laad alle berichten die al gestuurd zijn en zet de inhoud en datum in de listbox.
        public void ChatGeschiedenisLaden()
        {
            lbChat.Items.Clear();
            foreach (Chatbericht c in database.ChatLaden(lblGebruikersnaam.Text, gebruiker.Gebruikersnaam, database.ChatpartnerID(lblGebruikersnaam.Text), gebruiker.GebruikersID))
            {
                if(c.VerzenderNaam != gebruiker.Gebruikersnaam)
                {
                    database.ChatBerichtGelezen(c.ID);
                }
                lbChat.Items.Add(c);
                lbChat.Items.Add(c.datumtijd.ToString("dd / MMM HH: mm"));
                lbChat.Items.Add(" ");
                weergegevenberichten.Add(c);
            }
        }

        //Zet de status van je partner
        public void VeranderStatus(int id)
        {
            if(database.ChatPartnerStatus(id) == "Online")
            {
                lblParterStatus.ForeColor = Color.Green;
            }

            else
            {
                lblParterStatus.ForeColor = Color.Red;
            }

            lblParterStatus.Text = database.ChatPartnerStatus(id);           
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

         //Bij opstarten
         public void opstarten(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            lbGebruikerLijst.DrawMode = DrawMode.OwnerDrawFixed;
            lbGebruikerLijst.DrawItem += new DrawItemEventHandler(lbGebruikerLijst_DrawItem);
            weergegevenberichten = new List<Chatbericht>();
            Controls.Add(lbChat);
            database.ChatZetOnline(gebruiker.GebruikersID);
        }

        private void lbChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lbChat.SelectedIndex.ToString());
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            string test = partnernaam;
            int tset = lbGebruikerLijst.FindString(partnernaam);
            lbGebruikerLijst.SelectedIndex = tset;
            done = true;
        }
    }
}

