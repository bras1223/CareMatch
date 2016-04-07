using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH
{
    public partial class ChatForm : Form
    {
        Gebruiker gebruiker;

        public ChatForm(Gebruiker gebruiker)
        {
            this.gebruiker = gebruiker;
            InitializeComponent();
        }

        private void btnVerzenden_Click_1(object sender, EventArgs e)
        {
            Chatbericht bericht = new Chatbericht(tbBericht.Text);
            //Database
            lbChat.Items.Add(gebruiker.Gebruikersnaam+": "+bericht.Inhoud);
            lbChat.Items.Add(bericht.Datumtijd);
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
