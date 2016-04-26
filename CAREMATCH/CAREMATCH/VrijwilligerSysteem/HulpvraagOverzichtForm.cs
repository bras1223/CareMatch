using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CAREMATCH.VrijwilligerSysteem
{
    public partial class HulpvraagOverzichtForm : Form
    {
        private Gebruiker gebruiker;
        private Hulpvragen.Hulpvraag hulpvraag;
        private Database database;
        private HulpvraagForm hulpvraagForm;
        ListViewItem item;
        private bool aangenomen;
        private List<Hulpvragen.Hulpvraag> hulpvraaglist;
        public HulpvraagOverzichtForm(Gebruiker gebruiker, bool aangenomen)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.aangenomen = aangenomen;
            database = new Database();

            cbFilter.Items.Add("Eigen hulpvragen");
            cbFilter.Items.Add("Nieuwe reacties");
            if (gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                cbFilter.Items.Add("Alle hulpvragen");
            }
            cbFilter.SelectedIndex = 0;
        }
        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            this.Hide();
            //geselecteerde hulpvraag openen.
            hulpvraag = database.HulpvragenOverzicht(gebruiker, cbFilter.Text)[lvHulpvragen.FocusedItem.Index];
            hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
            hulpvraagForm.ShowDialog();
            if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            lvHulpvragen.Clear();
            //Inlognaam weergeven links in de hoek
            lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
            //Kolommen toevoegen.
            lvHulpvragen.View = View.Details;
            lvHulpvragen.FullRowSelect = true;
            lvHulpvragen.Columns.Add("ID");
            lvHulpvragen.Columns.Add("Urgent");
            lvHulpvragen.Columns.Add("Hulpbehoevende");
            lvHulpvragen.Columns.Add("Vrijwilliger");
            lvHulpvragen.Columns.Add("Laatste reactie door");
            lvHulpvragen.Columns.Add("Titel");
            lvHulpvragen.Columns.Add("Hulpvraag inhoud");

            hulpvraaglist = database.HulpvragenOverzicht(gebruiker, cbFilter.Text);
            // Hulpvragen Overzicht weergeven met inhoud.
            foreach (Hulpvragen.Hulpvraag hulpvraag in hulpvraaglist)
            {
                item = new ListViewItem(hulpvraag.ToString());
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add("    ");
                if (hulpvraag.Urgent)
                {
                    item.SubItems[1].BackColor = Color.Red;
                }
                else if (!hulpvraag.Urgent)
                {
                    item.SubItems[1].BackColor = Color.Green;
                }
                item.SubItems.Add(hulpvraag.Hulpbehoevende);
                item.SubItems.Add(hulpvraag.Vrijwilliger);
                item.SubItems.Add(hulpvraag.LaatstGereageerdDoor);
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                lvHulpvragen.Items.Add(item);

                count++;
                //Na de laatste hulpvraag de columns resizen. Performance niet optimaal.
                if (hulpvraaglist.Count -1 == count)
                {
                    //Autosize columns. column title < column inhoud = column title wordt weergeven. 
                    //is inhoud groter dan title dan resizen op inhoud.
                    foreach (ColumnHeader column in lvHulpvragen.Columns)
                    {
                        if (column.Text.Length > item.Text.Length)
                        {
                            lvHulpvragen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        else
                        {
                            lvHulpvragen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        }
                    }
                }
            }
        }

        private void lvHulpvragen_DoubleClick(object sender, EventArgs e)
        {
            btnBekijkHulpvraag_Click(sender, e);
        }
    }
}
