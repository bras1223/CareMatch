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
        Database database;

        public ChatForm(Gebruiker gebruiker)
        {
            this.gebruiker = gebruiker;
            database = new Database();
            InitializeComponent();
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            Controls.Add(lbChat);
        }

        private void btnVerzenden_Click(object sender, EventArgs e)
        {
            int id = gebruiker.GebruikersID;
            DateTime datum;
                datum = DateTime.Now;
                database.ChatInvoegen(database.ControlleerMaxChatID() + 1 ,tbBericht.Text, partnerid, gebruiker.GebruikersID + 1, datum.ToString("dd/MMM HH:mm"));
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
            LbVullen();
            tmrLaadberichten.Start();         
        }

        private void lbGebruikerLijst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            partnernaam = lbGebruikerLijst.SelectedItem as string;
            lblGebruikersnaam.Text = partnernaam;
            partnerid = database.ChatpartnerID(partnernaam);           
        }

        //Methodes

        //Kijk of de gebruiker hulpbehoevende of vrijwilliger is en vult de listbox met vrijwilligers of hulpbehoevende
        public void LbVullen()
        {
            if(gebruiker.GetType() == typeof(Hulpbehoevende))
            {
                foreach (String v in database.VrijwilligersLijst())
                {
                    lbGebruikerLijst.Items.Add(v);
                }
            }

            else if(gebruiker.GetType() == typeof(Vrijwilliger))
            {
                foreach (String h in database.HulpbehoevendeLijst())
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
                if (lbChat.Items[e.Index].ToString().StartsWith(" ") || lbChat.Items[e.Index].ToString().StartsWith(gebruiker.Gebruikersnaam))
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

        private void tmrLaadberichten_Tick(object sender, EventArgs e)
        {
            foreach (string s in database.ChatGeschiedenis(partnernaam, gebruiker.Gebruikersnaam, partnerid, gebruiker.GebruikersID + 1))
            {
                lbChat.Items.Clear();
                lbChat.Items.Add(s);
            }
        }
    }
}
