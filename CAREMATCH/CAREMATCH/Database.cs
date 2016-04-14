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
        public void HulpvraagAanpassen(int vrijwilligerID, Hulpvragen.Hulpvraag hulpvraag)
        {
            con.Open();
            if (hulpvraag.Urgent)
            {
                queryString = "Y";
            }
            else
            {
                queryString = "N";
            }
            OracleCommand sda = new OracleCommand("UPDATE Hulpvraag SET Reactie ='"+hulpvraag.Reactie+"', VrijwilligerID=(SELECT GebruikerID, FROM Gebruiker WHERE GebruikerID ='"+vrijwilligerID+"', Hulpvraaginhoud='"+hulpvraag.HulpvraagInhoud+"', Urgent='"+queryString+"' WHERE HulpvraagID='"+hulpvraag.HulpvraagID+"' ", con);
            OracleDataReader reader = sda.ExecuteReader();
            while (reader.Read())
            {
                queryString = reader["Hulpvraaginhoud"].ToString();
            }
            con.Close();
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

        List<Chatbericht> chatgeschiedenis = new List<Chatbericht>();


        public List<string> VrijwilligersLijst()
        {
            List<string> vrijwilligerlijst;
            vrijwilligerlijst = new List<string>();

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT Gebruikersnaam FROM gebruiker WHERE rol = 'Vrijwilliger'", con);
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

        public void ChatInvoegen(int chatid, string inhoud, int ontvangerID, int verzenderID, string datum)
        {
                con.Open();
                OracleCommand command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('"+chatid+"','"+ontvangerID+"', '" + verzenderID + "', '" + inhoud + "', TO_TIMESTAMP('" + datum + "','DD-MON HH24.MI'))", con);
                command.ExecuteNonQuery();
                con.Close();
        }

        public int ControlleerMaxChatID()
        {
            int id = 0;
            int Chatcount = 0;

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT COUNT(CHATID) as ChatIDCount FROM Chat", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Chatcount = Convert.ToInt32(reader["ChatIDCount"]);
            }

            if (Chatcount > 0)
            {
                OracleCommand command = new OracleCommand("SELECT MAX(CHATID) as m FROM CHAT", con);
                OracleDataReader reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    id = Convert.ToInt32(reader2["m"]);
                }
                con.Close();
                return id;
            }
            else
            {
                con.Close();
                return 0;
            }  
        }

        public List<Chatbericht> ChatGeschiedenis(string ontvangerNaam, string verzenderNaam, int ontvangerID, int verzenderID)
        {      


            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT BerichtInhoud FROM chat WHERE ontvangerID = '" + ontvangerID + "' AND verzenderID = '" + verzenderID + "'", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chatgeschiedenis.Add(new Chatbericht(reader["BerichtInhoud"].ToString(), verzenderNaam));
            }

            OracleCommand cmd2 = new OracleCommand("SELECT BerichtInhoud FROM chat WHERE ontvangerID = '" + verzenderID + "' AND verzenderID = '" + ontvangerID + "'", con);
            OracleDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                chatgeschiedenis.Add(new Chatbericht(reader2["BerichtInhoud"].ToString(),ontvangerNaam));
            }

            con.Close();

            return chatgeschiedenis;
        }

        public List<string> Chatverzonden(int ontvangerID, int verzenderID)
        {
            List<string> chatverzonden;
            chatverzonden = new List<string>();

            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT Inhoud FROM chat WHERE ontvangerID = '"+ontvangerID+"' AND verzenderID = '"+verzenderID+"'", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chatverzonden.Add(reader["Inhoud"].ToString());
            }

            con.Close();

            return chatverzonden;
        }

        public List<string> ChatGekregen(int ontvangerID, int verzenderID)
        {
            List<string> chatgekregen;
            chatgekregen = new List<string>();

            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT Inhoud FROM chat WHERE ontvangerID = '" + verzenderID + "' AND verzenderID = '" + ontvangerID + "'", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chatgekregen.Add(reader["Inhoud"].ToString());
            }

            con.Close();

            return chatgekregen;
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
        public int ControlleerMaxGebruikerID()
        {
            int id = 0;
            con.Open();
            OracleCommand command = new OracleCommand("SELECT MAX(GEBRUIKERID) as MAXID FROM GEBRUIKER", con);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["MAXID"]);
            }
            con.Close();
            return id;
        }
        public bool ControlleerGebruikersnaam(string Gebruikersnaam)
        {
            con.Open();
            OracleCommand command = new OracleCommand("SELECT Gebruikersnaam FROM GEBRUIKER WHERE Gebruikersnaam ='" + Gebruikersnaam + "'", con);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                queryString = reader["Gebruikersnaam"].ToString();
            }
            con.Close();
            if (queryString == null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        public void ShowAccountGegevens()
        {

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
