using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH.Hulpvragen;
using CAREMATCH.VrijwilligerSysteem;

namespace CAREMATCH
{
    public partial class OngepasteBerichtenForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private List<Hulpvraag> hulpvragen;
        

        public OngepasteBerichtenForm(Gebruiker gebruiker)
        {
            InitializeComponent();


            this.gebruiker = gebruiker;
            database = new Database();

            lvOngepasteBerichten.View = View.Details;
            lvOngepasteBerichten.CheckBoxes = true;
            lvOngepasteBerichten.FullRowSelect = true;

            this.hulpvragen = database.HulpvragenOverzicht(gebruiker, "ongepaste hulpvragen");
            CreateListView();
            VulListViewMetHulpvragen(hulpvragen);
        }


        private void CreateListView()
        {
            lvOngepasteBerichten.Clear();
            lvOngepasteBerichten.Columns.Add("Check");
            lvOngepasteBerichten.Columns.Add("ID");
            lvOngepasteBerichten.Columns.Add("Titel");
            lvOngepasteBerichten.Columns.Add("Hulpvraag");
            lvOngepasteBerichten.Columns.Add("Uitzetter");
            lvOngepasteBerichten.Columns.Add("Beoordeling");
            lvOngepasteBerichten.Columns.Add("Cijfer");
        }


        private void VerwijderGemarkeerdeHulpvraag(Hulpvraag hulpvraag)
        {
            database.HulpvraagVerwijderen(hulpvraag.HulpvraagID);
            
            hulpvraag = null;

        }

        private void VulListViewMetHulpvragen(List<Hulpvraag> hulpvragen)
        {
            lvOngepasteBerichten.Items.Clear();
            if(hulpvragen != null)
            {
                hulpvragen.Clear();
            }
            
            this.hulpvragen = database.HulpvragenOverzicht(gebruiker, "ongepaste hulpvragen");
            if(this.hulpvragen.Count > 0)
            {
                label1.Visible = false;

                foreach (Hulpvraag hulpvraag in this.hulpvragen)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(hulpvraag.HulpvraagID.ToString());
                    item.SubItems.Add(hulpvraag.Titel);
                    item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                    item.SubItems.Add(hulpvraag.Hulpbehoevende);
                    item.SubItems.Add(hulpvraag.Beoordeling);
                    item.SubItems.Add(hulpvraag.Cijfer.ToString());

                    lvOngepasteBerichten.Items.Add(item);
                }
            }
            else
            {
                label1.Visible = true;
            }


            
        }

        private void btnLaatZien_Click(object sender, EventArgs e)
        {
            
            Hulpvraag hulpvraag = null;


            //geselecteerde hulpvraag openen.
            if(lvOngepasteBerichten.FocusedItem != null)
            {
                hulpvraag = hulpvragen[lvOngepasteBerichten.FocusedItem.Index];
            }
            
            //werkt niet, misschien wel met een eventhandler? idk ik kijk zom thuis
            
            if(hulpvraag != null)
            {
                this.Hide();
                HulpvraagForm hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
                hulpvraagForm.ShowDialog();
                if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("selecteer AUB een hulpvraag");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            if (lvOngepasteBerichten.CheckedItems.Count > 0)
            {
               // MessageBox.Show("weet je zeker dat je" + lvOngepasteBerichten.CheckedItems.Count + "hulpvraag(en) wilt verwijderen?", "", MessageBoxButtons.OKCancel);

                //verwijder alle aangevinkte items uit list
                foreach (ListViewItem item in lvOngepasteBerichten.Items)
                {
                    if (item.Checked)
                    {
                        Hulpvraag toDelete = hulpvragen[item.Index];
                        hulpvragen.RemoveAt(item.Index);
                        VerwijderGemarkeerdeHulpvraag(toDelete);
                    }
                }
                VulListViewMetHulpvragen(hulpvragen);
            }

        }

        private void OngepasteBerichtenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
