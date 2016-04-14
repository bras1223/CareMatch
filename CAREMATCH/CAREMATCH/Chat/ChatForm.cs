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
            lbChat.DrawMode = DrawMode.OwnerDrawFixed;
            lbChat.DrawItem += new DrawItemEventHandler(lbChat_DrawItem);
            Controls.Add(lbChat);
        }

        private void lbChat_DrawItem(object sender,System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            Font myFont;
            string test;

            test = lbChat.Items.ToString();

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

        private void btnVerzenden_Click_1(object sender, EventArgs e)
        {
            Chatbericht bericht = new Chatbericht(tbBericht.Text);
            //Database
            lbChat.Items.Add(gebruiker.Gebruikersnaam+": "+bericht.Inhoud);
            lbChat.Items.Add(bericht.Datumtijd);
            lbChat.Items.Add(" ");

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
