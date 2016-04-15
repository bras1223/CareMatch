﻿using System;
using CAREMATCH.Gebruikers;
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
    partial class HulpvraagForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private Hulpvragen.Hulpvraag hulpvraag;
        public HulpvraagForm(Hulpvragen.Hulpvraag hulpvraag, Gebruiker gebruiker, bool hulpvraagIndienen)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
            this.hulpvraag = hulpvraag;

            if (gebruiker.GetType() == typeof(Hulpbehoevende) && hulpvraagIndienen == true)
            {
                rtxtReactieInhoud.Enabled = false;
                btnReactieOpslaan.Visible = false;
            }
            else if (gebruiker.GetType() == typeof(Vrijwilliger))
            {
                btnHulpvraagOpslaan.Visible = false;

                cbUrgent.Enabled = false;
                rtxtHulpvraag.Enabled = false;

                txtDuur.Enabled = false;
                txtFrequentie.Enabled = false;
                txtHulpvrager.Enabled = false;
                txtTitel.Enabled = false;
            }

            txtDuur.Text = hulpvraag.Duur.ToString();
            txtFrequentie.Text = hulpvraag.Frequentie;
            txtHulpvrager.Text = hulpvraag.Hulpbehoevende;
            txtTitel.Text = hulpvraag.Titel;
            rtxtHulpvraag.Text = hulpvraag.HulpvraagInhoud;
            rtxtReactieInhoud.Text = hulpvraag.Reactie +"\n\n"+ DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "   " + gebruiker.Gebruikersnaam +" Zegt:\n";

            if (hulpvraag.Urgent)
            {
                cbUrgent.Checked = true;
            }
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSlaOp_Click(object sender, EventArgs e)
        {
            rtxtReactieInhoud.Enabled = false;
            hulpvraag.Vrijwilliger = gebruiker.Gebruikersnaam;
            hulpvraag.HulpvraagInhoud = rtxtHulpvraag.Text;
            hulpvraag.Urgent = cbUrgent.Checked;
            hulpvraag.Reactie = rtxtReactieInhoud.Text + "\n";
            database.HulpvraagAanpassen(gebruiker.GebruikersID, hulpvraag);
        }
    }
}
