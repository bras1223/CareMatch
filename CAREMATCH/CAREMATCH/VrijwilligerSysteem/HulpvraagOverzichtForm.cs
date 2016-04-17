using System;
using System.Drawing;
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
            //Filter alleen weergeven voor vrijwilligers.
            if(gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                cbFilter.Visible = false;
                lblFilter.Visible = false;
            }
            cbFilter.SelectedIndex = 0;
            HulpvragenOverzichtWeergeven();
        }
        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                //geselecteerde hulpvraag openen.
                hulpvraag = database.HulpvragenOverzicht(aangenomen, gebruiker, cbFilter.Text)[lvHulpvragen.FocusedItem.Index];
                hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
                hulpvraagForm.ShowDialog();
                if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Selecteer eerst een hulpvraag");
            }
        }
        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HulpvragenOverzichtWeergeven();
        }
        public void HulpvragenOverzichtWeergeven()
        {
            lvHulpvragen.Clear();
            //Inlognaam weergeven links in de hoek
            lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
            //Kolommen toevoegen.
            lvHulpvragen.View = View.Details;
            lvHulpvragen.FullRowSelect = true;
            lvHulpvragen.Columns.Add("ID");
            lvHulpvragen.Columns.Add("Urgent");
            lvHulpvragen.Columns.Add("Foto");
            lvHulpvragen.Columns.Add("Hulpbehoevende");
            lvHulpvragen.Columns.Add("Vrijwilliger");
            lvHulpvragen.Columns.Add("Titel");
            lvHulpvragen.Columns.Add("Hulpvraag inhoud");
            // Hulpvragen Overzicht weergeven met inhoud.
            foreach (Hulpvragen.Hulpvraag hulpvraag in database.HulpvragenOverzicht(aangenomen, gebruiker, cbFilter.Text))
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
                    item.SubItems[1].BackColor = Color.Green;
                }
                item.SubItems.Add(hulpvraag.HulpbehoevendeFoto);
                item.SubItems.Add(hulpvraag.Hulpbehoevende);
                item.SubItems.Add(hulpvraag.Vrijwilliger);
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                lvHulpvragen.Items.Add(item);
            }
            //Autosize collumns.
            for (int i = 0; i < 7; i++)
            {
                if (i >= 5)
                {
                    lvHulpvragen.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    lvHulpvragen.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
    }
}
