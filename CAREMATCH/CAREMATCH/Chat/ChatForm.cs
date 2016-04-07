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
        string gebruikersnaam;

        public ChatForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            gebruikersnaam = "Gebruikersnaam";
        }

        private void btnVerzenden_Click_1(object sender, EventArgs e)
        {
            Chatbericht bericht = new Chatbericht(tbBericht.Text);
            lbChat.Items.Add(gebruikersnaam+": "+bericht.Inhoud);
            lbChat.Items.Add("");
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
