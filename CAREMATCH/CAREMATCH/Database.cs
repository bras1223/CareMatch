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
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace CAREMATCH
{
    class Database
    {
        private OracleConnection con;
        private string queryString;
        public Database()
        {
            string constr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))"
                          + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));"
                          + "User ID=DBI327544; PASSWORD=CareMatch;";

            con = new OracleConnection(constr);
        }
        public void closeCon()
        {
            con.Close();
        }

        #region Hulpvragen Queries
        public void HulpvraagToevoegen(Hulpvragen.Hulpvraag hulpvraag)
        {
            
        }
        public void HulpvraagVerwijderen()
        {

        }
        public string HulpvraagAanpassen()
        {
            con.Open();

            OracleCommand sda = new OracleCommand("SELECT * FROM Hulpvraag", con);
            OracleDataReader reader = sda.ExecuteReader();
            while (reader.Read())
            {
                queryString = reader["Hulpvraaginhoud"].ToString();
            }
            con.Close();
            return queryString;
        }
        public List<Hulpvragen.Hulpvraag> HulpvragenOverzicht()
        {
            List<Hulpvragen.Hulpvraag> hulpvraagList = new List<Hulpvragen.Hulpvraag>();

            con.Open();
            OracleCommand sda = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud, Hulpvraag.Aangenomen, Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie, Hulpvraag.Titel FROM Hulpvraag", con);
            OracleDataReader reader = sda.ExecuteReader();
            while (reader.Read())
            {
                Hulpvragen.Hulpvraag hulpvraag = new Hulpvragen.Hulpvraag();

                hulpvraag.HulpvraagID = Convert.ToInt32(reader["HulpvraagID"]);
                hulpvraag.Titel = reader["Titel"].ToString();
                hulpvraag.Hulpbehoevende = reader["hulpbeh"].ToString();
                hulpvraag.Vrijwilliger = reader["vrijwilliger"].ToString();
                hulpvraag.HulpvraagInhoud = reader["HulpvraagInhoud"].ToString();
                hulpvraag.Frequentie = reader["Frequentie"].ToString();
                hulpvraag.DatumTijd = Convert.ToDateTime(reader["DatumTijd"]);
                if (reader["Aangenomen"].ToString() == "Y")
                {
                    hulpvraag.Aangenomen = true;
                }
                else
                {
                    hulpvraag.Aangenomen = false;
                }
                if (reader["Urgent"].ToString() == "Y")
                {
                    hulpvraag.Urgent = true;
                }
                else
                {
                    hulpvraag.Urgent = false;
                }

                hulpvraagList.Add(hulpvraag);
            }
            con.Close();

            return hulpvraagList;
        }
        public void HulpvragenAangenomen()
        {

        }
        public void HulpvragenIngediend()
        {

        } 
        #endregion
        #region Agenda Queries
        public void AgendaOverzicht()
        {

        }
        public void AgendaOverzichtVolgendeWeek()
        {

        }
        public void AgendaOverzichtVorigeWeek()
        {

        }
        public void AgendaPuntToevoegen()
        {

        }
        public void AgendaPuntAanpassen()
        {

        }
        public void AgendaPuntVerwijderen()
        {

        }
        #endregion
        #region Chat Queries
        public List<string> VrijwilligersLijst()
        {
            List<string> vrijwilligerlijst;
            vrijwilligerlijst = new List<string>();

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT Gebruikersnaam FROM gebruiker WHERE rol = 'vrijwilliger'", con);
            OracleDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                vrijwilligerlijst.Add(reader["Gebruikersnaam"].ToString());
            }
            con.Close();

            return vrijwilligerlijst;
        }

        public List<string> HulpbehoevendeLijst()
        {
            List<string> hulpbehoevendelijst;
            hulpbehoevendelijst = new List<string>();

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT Gebruikersnaam FROM gebruiker WHERE rol = 'hulpbehoevende'", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hulpbehoevendelijst.Add(reader["Gebruikersnaam"].ToString());
            }
            con.Close();

            return hulpbehoevendelijst;
        }

        public int ChatpartnerID(string naam)
        {
            int id = 0;
            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT GebruikerID FROM gebruiker WHERE gebruikersnaam = '" + naam + "'", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["GEBRUIKERID"].ToString());
            }
            con.Close();
            return id;
        }

        public void ChatInvoegen(string inhoud, int ontvangerID, int verzenderID)
        {
            con.Open();
            OracleCommand command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('1','"+ontvangerID+"', '"+verzenderID+"', '"+inhoud+"', '"+DateTime.Now+"');", con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void ChatWeergeven()
        {

        }

        #endregion
        #region Beheerder Queries
        public void BOverzichtOngepasteBerichten()
        {
            //Overzicht ongepaste hulpvragen - Recensies - Reacties
        }
        public void BVerwijderOngepasteBerichten()
        {

        }
        public void BAccountOverzicht()
        {

        }
        public void BAccountActiveren()
        {

        }
        public void BAccountVerwijderen()
        {

        }
        #endregion
        #region Gebruiker Queries
        private string rol;
        public string Login(string naam, string wachtwoord)
        {
            con.Open();
            OracleCommand sda = new OracleCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = '"+naam+"' AND wachtwoord = '"+wachtwoord+"'", con);
            OracleDataReader reader = sda.ExecuteReader();

            while (reader.Read())
            {
                naam = reader["GEBRUIKERSNAAM"].ToString();
                wachtwoord = reader["WACHTWOORD"].ToString();
                rol = reader["ROL"].ToString();
            }
            con.Close();
            if (rol == null)
            {
                return "";
            }
            else
            {
                return rol;
            }
        }
        public void AccountToevoegen(string GebruikerID, string Gebruikersnaam, string Wachtwoord, string Approved, string Rol)
        {
            con.Open();
            OracleCommand command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERID, GEBRUIKERSNAAM, WACHTWOORD, APPROVED, ROL) VALUES('"+GebruikerID+"','"+Gebruikersnaam+"','"+Wachtwoord+"', '"+Approved+"','"+Rol+"')",  con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void ControlleerMaxGebruikerID()
        {
            con.Open();
            OracleCommand command = new OracleCommand("SELECT MAX(GEBRUIKERID)FROM GEBRUIKER", con);
            command.ExecuteNonQuery();
            con.Close();
           
        }
            





        public void ProfielAanpassen()
        {

        }
        public void ReactieToevoegen()
        {

        }
        public void BeoordelingToevoegen()
        {
            // OracleCommand command = new OracleCommand("INSERT INTO Hulpvraag(HulpvraagID, GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie) VALUES('@HulpvraagID','@GebruikerID, '@HulpvraagInhoud', '@Urgent', '@DatumTijd', '@Duur', '@Frequentie');", con);
            //command.Parameters.AddWithValue("HulpvraagID", 1);
            //command.Parameters.AddWithValue("GebruikerID", 1);
            //command.Parameters.AddWithValue("HulpvraagInhoud", "Testinhoud");
            //command.Parameters.AddWithValue("Urgent", 'Y');
            //command.Parameters.AddWithValue("DatumTijd", new DateTime(2016, 02, 03, 21, 05, 00));
            //command.Parameters.AddWithValue("Duur", 20);
            //command.Parameters.AddWithValue("Frequentie", 2);


            // SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Login (Username, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", sql);
            // sda.SelectCommand.ExecuteNonQuery();
            // sql.Close();
        }
        #endregion
    }
}
