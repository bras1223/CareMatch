using System;
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
    public partial class ProfielForm : Form
    {
        private OpenFileDialog zoekFotoDialog;

        public ProfielForm(Gebruiker gebruiker)
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            zoekFotoDialog = new OpenFileDialog();
            zoekFotoDialog.ShowDialog();

            if (zoekFotoDialog.FileName != "")
            {
                pbProfielFoto.Image = new Bitmap(zoekFotoDialog.FileName);
            }
        }

        private void pbProfielFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
