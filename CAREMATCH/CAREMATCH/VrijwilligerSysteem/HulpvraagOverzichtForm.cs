﻿using System;
using CAREMATCH;
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
    public partial class HulpvraagOverzichtForm : Form
    {
        private Gebruiker gebruiker;
        private Hulpvragen.Hulpvraag hulpvraag;
        private Database database;
        private HulpvraagForm hulpvraagForm;

        private bool aangenomen;
        public HulpvraagOverzichtForm(Gebruiker gebruiker, bool aangenomen)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.aangenomen = aangenomen;
            database = new Database();
            //Inlognaam weergeven links in de hoek
            lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;

            lvHulpvragen.View = View.Details;
            lvHulpvragen.FullRowSelect = true;
            lvHulpvragen.Columns.Add("ID");
            lvHulpvragen.Columns.Add("Urgent");
            lvHulpvragen.Columns.Add("Foto");
            lvHulpvragen.Columns.Add("Hulpbehoevende");
            lvHulpvragen.Columns.Add("Vrijwilliger");
            lvHulpvragen.Columns.Add("Titel");
            lvHulpvragen.Columns.Add("Hulpvraag inhoud");
            // Hulpvragen Overzicht
            foreach (Hulpvragen.Hulpvraag hulpvraag in database.HulpvragenOverzicht(aangenomen, gebruiker.GebruikersID +1))
            {
                ListViewItem item = new ListViewItem(hulpvraag.ToString());
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add("    ");
                if (hulpvraag.Urgent)
                {
                    item.SubItems[1].BackColor = Color.Red;
                }
                else if (!hulpvraag.Urgent)
                {
                    item.SubItems[1].BackColor = Color.Blue;
                }
                item.SubItems.Add(hulpvraag.HulpbehoevendeFoto);
                item.SubItems.Add(hulpvraag.Hulpbehoevende);
                item.SubItems.Add(hulpvraag.Vrijwilliger);
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                lvHulpvragen.Items.Add(item);
            }
            //Autosize collumns.
            for(int i =0;i<7;i++)
            {
                if(i >= 5)
                {
                    lvHulpvragen.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    lvHulpvragen.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                hulpvraag = database.HulpvragenOverzicht(aangenomen, gebruiker.GebruikersID)[lvHulpvragen.FocusedItem.Index];
                hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
                hulpvraagForm.ShowDialog();
                if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een hulpvraag");
            }
        }
        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
