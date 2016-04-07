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

        public ChatForm()
        {
            InitializeComponent();
            gebruikersnaam = "Gebruiker";
        }

        private void btnVerzenden_Click_1(object sender, EventArgs e)
        {
            lbChat.Items.Add(tbBericht.Text);
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
