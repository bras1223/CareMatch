using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CAREMATCH;
using System.IO;
using Phidgets;
using Phidgets.Events;
using System.Text.RegularExpressions;

namespace CAREMATCH.LoginSysteem
{
    public partial class SignupForm : Form
    {
        private RFID rfid;
        private Database database;
        private OpenFileDialog ofd;
        private OpenFileDialog zoekFotoDialog;
        private string vog;
        public SignupForm()
        {
            InitializeComponent();
            database = new Database();

            cbRol.SelectedIndex = 0;

            btnUploadVOG.Visible = false;
            lblVOGPath.Visible = false;
            lblVOG.Visible = false;     
        }
        //Gebruiker toevoegen
        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            //Controlleer of gebruikersnaam bestaat.
            bool GebruikNaam = database.GebruikerControlleerUsername(tbGebruikersnaam.Text);

            if (GebruikNaam == false)
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            if (tbWachtwoord.Text != tbHerhWachtwoord.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (tbGebruikersnaam.Text == "")
            {
                MessageBox.Show("Geen gebruikersnaam ingevuld");
            }
            if (tbWachtwoord.Text == "")
            {
                MessageBox.Show("Geen wachtwoord ingevuld");
            }
            else if (cbRol.Text == "Hulpbehoevende" && tbWachtwoord.Text == tbHerhWachtwoord.Text && GebruikNaam == true)
            {
                bool oke;
                PasfotoOpslaan();
                try
                {
                   oke = database.GebruikerAccountToevoegen(tbGebruikersnaam.Text, tbWachtwoord.Text, "Y", cbRol.Text, tbGebruikersnaam.Text + @"\" + tbGebruikersnaam.Text + Path.GetExtension(zoekFotoDialog.FileName), lblVOGPath.Text, tbVoornaam.Text, tbAchternaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value);
                }
                catch
                {
                   oke = database.GebruikerAccountToevoegen(tbGebruikersnaam.Text, tbWachtwoord.Text, "Y", cbRol.Text, "", lblVOGPath.Text, tbVoornaam.Text, tbAchternaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value);
                }
                if (oke)
                {
                    MessageBox.Show("Account aangemaakt. U kunt nu inloggen.");
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (cbRol.Text == "Vrijwilliger" && tbWachtwoord.Text == tbHerhWachtwoord.Text && GebruikNaam == true)
            {
                //Vrijwilliger moet een VOG uploaden.
                if (lblVOGPath.Text == "")
                {
                    MessageBox.Show("Een vrijwilliger is verplicht een VOG bij te voegen.");
                }
                else
                {
                    //VOG uploaden
                    if (ofd != null)
                    {
                        //Als er een afbeelding geopend is.
                        if (ofd.FileName != "")
                        {
                            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DropBox\CareMatch\"+ tbGebruikersnaam.Text))
                            {
                                //Directory aanmaken als deze nog niet bestaat.
                                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text);
                            }
                            //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                            try
                            {
                                vog = @"\VOG" + Path.GetExtension(ofd.FileName);
                                File.Copy(ofd.FileName, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text +"\\VOG"+Path.GetExtension(ofd.FileName));
                            }
                            catch
                            {
                                MessageBox.Show("Er is iets fout gegaan bij het uploaden van uw VOG. Contacteer een beheerder.");
                            }
                        }
                    }
                    PasfotoOpslaan();
                    database.GebruikerAccountToevoegen(tbGebruikersnaam.Text, tbWachtwoord.Text, "Y", cbRol.Text, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text + Path.GetExtension(zoekFotoDialog.FileName), vog, tbVoornaam.Text, tbAchternaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value);
                    MessageBox.Show("Account aangemaakt. U moet wachten tot dat uw account is geactiveerd voordat u kunt inloggen.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        //Wachtwoord controle
        private void txtHerhWachtwoord_TextChanged(object sender, EventArgs e)
        {
            if (tbWachtwoord.Text.Length < 6)
            {
                lblZwakWW.Visible = true;
                lblSterkWW.Visible = false;
            }
            //Wachtwoord moet langer zijn dan 5 cijfers, hoofdletters en kleine letters bevatten.
            if (tbWachtwoord.Text.Length >= 6 && 
                tbWachtwoord.Text.Any(c => char.IsUpper(c)) && 
                tbWachtwoord.Text.Any(c => char.IsLower(c)))
            {
                lblZwakWW.Visible = false;
                lblSterkWW.Visible = true;
            }
        }
        //Terug naar LoginForm
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            RFIDClose();
            Close();
            Dispose();
        } //terug knop
        private void btnUploadVOG_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                lblVOGPath.Text = ofd.FileName;
            }
        }
        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRol.Text.ToLower() == "vrijwilliger")
            {
                btnUploadVOG.Visible = true;
                lblVOG.Visible = true;
                lblRFIDUitleg.Visible = false;

            }
            else
            {
               
                btnUploadVOG.Visible = false;
                lblVOG.Visible = false;
                lblRFIDUitleg.Visible = true;
            }
        }

        private void btnPasfotoToevoegen_Click(object sender, EventArgs e)
        {
            zoekFotoDialog = new OpenFileDialog();
            if (zoekFotoDialog.ShowDialog() == DialogResult.OK)
            {
                lblPasFotoPath.Text = zoekFotoDialog.FileName;
            }
        }
        public void PasfotoOpslaan()
        {
            //Pasfoto uploaden. - dubbele if anders foutmelding.
            if (zoekFotoDialog != null)
            {
                //Als er een afbeelding geopend is.
                if (zoekFotoDialog.FileName != "")
                {
                    //Directory aanmaken als deze nog niet bestaat.
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text))
                    {
                        System.IO.Directory.CreateDirectory(Environment.SpecialFolder.UserProfile.ToString() + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text);
                    }
                    //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                    File.Copy(zoekFotoDialog.FileName, Environment.SpecialFolder.UserProfile.ToString() + @"\DropBox\CareMatch\" + tbGebruikersnaam.Text + @"\" + tbGebruikersnaam.Text + Path.GetExtension(zoekFotoDialog.FileName));
                }
            }
        }
        #region RFID
        private void SignupForm_Load(object sender, EventArgs e)
        {
            
            rfid = new RFID(); //Krijg nogsteeds foutmelding. 
            rfid.open();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            openCmdLine(rfid);               
        }
        void rfid_Tag(object sender, TagEventArgs e)
        {
            if (database.GebruikerLogin(e.Tag, e.Tag) !=null)
            {
                MessageBox.Show("Deze tag is reeds aangemeld, klik op OK om u in te loggen.");
                RFIDLogin login = new RFIDLogin();
                this.Close();
                this.Dispose();
                login.Show();
            }
            else
            {
                tbGebruikersnaam.Visible = false;
                tbWachtwoord.Visible = false;
                tbHerhWachtwoord.Visible = false;
                lblRFIDAttached.Visible = true;
                lblRFIDUitleg.Visible = false;
                lblGebruikersnaam.Visible = false;
                lblWachtwoord.Visible = false;
                lblWachtwoord2.Visible = false;
                lblSterkWW.Visible = false;
                lblZwakWW.Visible = false;
                
            }

            //This sends the RFID tag and an enter to the active application

        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            tbGebruikersnaam.Visible = true;
            tbWachtwoord.Visible = true;
            tbHerhWachtwoord.Visible = true;
            lblGebruikersnaam.Visible = true;
            lblWachtwoord.Visible = true;
            lblWachtwoord2.Visible = true;
            lblSterkWW.Visible = true;
            lblZwakWW.Visible = true;
            lblRFIDAttached.Visible = false;
            lblRFIDUitleg.Visible = true;
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
            switch (attached.ID)
            {
                case Phidget.PhidgetID.RFID_2OUTPUT_READ_WRITE:
                    break;
                case Phidget.PhidgetID.RFID:
                case Phidget.PhidgetID.RFID_2OUTPUT:
                default:
                    break;
            }

            if (rfid.outputs.Count > 0)
            {
                rfid.Antenna = true;
            }
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
        }


        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion

        private void RFIDClose()
        {
            rfid.Attach -= new AttachEventHandler(rfid_Attach);
            rfid.Detach -= new DetachEventHandler(rfid_Detach);
            rfid.Tag -= new TagEventHandler(rfid_Tag);
            rfid.TagLost -= new TagEventHandler(rfid_TagLost);

            //run any events in the message queue - otherwise close will hang if there are any outstanding events
            Application.DoEvents();

            rfid.close();
        }
        #endregion
    }
}
