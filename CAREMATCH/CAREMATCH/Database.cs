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
using System.Security.Cryptography;
using CAREMATCH.Gebruikers;

namespace CAREMATCH
{
    class Database
    {
        private OracleConnection con;
        private OracleCommand command;
        private OracleDataReader reader;
        private Gebruiker gebruiker;
        private DateTime vandaag;
        private string tempString;
        public Database()
        {
            vandaag = new DateTime();

            string constr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))"
                          + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));"
                          + "User ID=DBI327544; PASSWORD=CareMatch;";

            con = new OracleConnection(constr);
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
                tempString = "Y";
            }
            else
            {
                tempString = "N";
            }

            command = new OracleCommand("UPDATE Hulpvraag SET Reactie ='"+hulpvraag.Reactie+"', VrijwilligerID=(SELECT GebruikerID FROM Gebruiker WHERE GebruikerID ='"+vrijwilligerID+"'), Hulpvraaginhoud='"+hulpvraag.HulpvraagInhoud+"', Urgent='"+tempString+"' WHERE HulpvraagID='"+hulpvraag.HulpvraagID+"' ", con);
            reader = command.ExecuteReader();
            con.Close();
        }
        public List<Hulpvragen.Hulpvraag> HulpvragenOverzicht(bool aangenomen, int vrijwilligerID)
        {
            List<Hulpvragen.Hulpvraag> hulpvraagList = new List<Hulpvragen.Hulpvraag>();

            con.Open();
            if(aangenomen)
            {
                //Als de vrijwillger alleen zijn eigen aangenomen hulpvragen wil zien
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud, Hulpvraag.Aangenomen, Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie, Hulpvraag.HulpbehoevendeFoto, Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur FROM Hulpvraag WHERE Hulpvraag.VrijwilligerID='"+vrijwilligerID+"'", con);
            }
            else
            {
                //overzicht van alle hulpvragen
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud, Hulpvraag.Aangenomen, Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie, Hulpvraag.HulpbehoevendeFoto, Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur FROM Hulpvraag", con);
            }
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Hulpvragen.Hulpvraag hulpvraag = new Hulpvragen.Hulpvraag();

                hulpvraag.HulpbehoevendeFoto = reader["HulpbehoevendeFoto"].ToString();
                hulpvraag.HulpvraagID = Convert.ToInt32(reader["HulpvraagID"]);
                hulpvraag.Titel = reader["Titel"].ToString();
                hulpvraag.Hulpbehoevende = reader["hulpbeh"].ToString();
                hulpvraag.Vrijwilliger = reader["vrijwilliger"].ToString();
                hulpvraag.HulpvraagInhoud = reader["HulpvraagInhoud"].ToString();
                hulpvraag.Frequentie = reader["Frequentie"].ToString();
                hulpvraag.Reactie = reader["Reactie"].ToString();
                hulpvraag.Duur = Convert.ToInt32(reader["Duur"]);
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
            command = new OracleCommand("SELECT Gebruikersnaam FROM gebruiker WHERE rol = 'Vrijwilliger'", con);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                vrijwilligerlijst.Add(reader["Gebruikersnaam"].ToString());
            }
            con.Close();

            return vrijwilligerlijst;
        }
        public List<Chatbericht> ChatGeschiedenis(string partnerNaam, string gebruikerNaam, int partnerID, int gebruikerID)
        {
            List<Chatbericht> chatberichtenList = new List<Chatbericht>();
            return chatberichtenList;
        }
        public List<string> HulpbehoevendeLijst()
        {
            List<string> hulpbehoevendelijst;
            hulpbehoevendelijst = new List<string>();

            con.Open();
            command = new OracleCommand("SELECT Gebruikersnaam FROM gebruiker WHERE rol = 'hulpbehoevende'", con);
            reader = command.ExecuteReader();

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
            command = new OracleCommand("SELECT GebruikerID FROM gebruiker WHERE gebruikersnaam = '" + naam + "'", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["GEBRUIKERID"].ToString());
            }
            con.Close();
            return id;
        }

        public void ChatInvoegen(int chatid, string inhoud, int ontvangerID, int verzenderID, string datum)
        {
            int Chatcount = 0;

            con.Open();
            command = new OracleCommand("SELECT COUNT(CHATID) as ChatIDCount FROM Chat", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Chatcount = Convert.ToInt32(reader["ChatIDCount"]);
            }

            if(Chatcount > 0)
            {
                command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('1','" + ControlleerMaxChatID() + 1 + "', '" + verzenderID + "', '" + inhoud + "', TO_TIMESTAMP('" + datum + "','DD-MON HH24.MI'))", con);
                command.ExecuteNonQuery();
                con.Close();
            }

            else if(Chatcount <= 0)
            {
                command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('1','0', '" + verzenderID + "', '" + inhoud + "', TO_TIMESTAMP('" + datum + "','DD-MON HH24.MI'))", con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public int ControlleerMaxChatID()
        {
            int id = 0;
            con.Open();
            command = new OracleCommand("SELECT MAX(CHATID) as MAXID FROM CHAT", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["MAXID"]);
            }
            con.Close();

            return id;
        }

        public void ChatWeergeven(int ontvangerID, int verzenderID)
        {
            List<string> chatverzonden;
            List<string> chatgekregen;
            chatverzonden = new List<string>();


            con.Open();
            command = new OracleCommand("SELECT Inhoud FROM chat WHERE ontvangerID = '"+ontvangerID+"' AND verzenderID = '"+verzenderID+"'", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                chatverzonden.Add(reader["Inhoud"].ToString());
            }
            con.Close();
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
        public Gebruiker Login(string naam, string wachtwoord)
        {
            con.Open();
            //Gebruikersnaam zoeken waar gebruikersnaam gelijk is aan de ingevoerde naam + w8woord
            command = new OracleCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = '"+naam+"' AND wachtwoord = '"+EncryptString(wachtwoord)+"'", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["ROL"].ToString().ToLower() == "hulpbehoevende")
                {
                    gebruiker = new Hulpbehoevende();
                }
                else if (reader["ROL"].ToString().ToLower() == "beheerder")
                {
                    gebruiker = new Beheerder();
                }
                else if (reader["ROL"].ToString().ToLower() == "vrijwilliger")
                {
                    gebruiker = new Vrijwilliger();
                    gebruiker.Approved = true;
                }
                gebruiker.Achternaam = reader["Achternaam"].ToString();
                gebruiker.Voornaam = reader["Voornaam"].ToString();
                gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                gebruiker.GebruikersID = Convert.ToInt32(reader["GebruikerID"]);
                gebruiker.GebruikerInfo = reader["GebruikerInfo"].ToString();
                try
                {
                    gebruiker.Pasfoto = reader["Foto"].ToString();
                }
                catch
                {
                }
                gebruiker.Rol = reader["ROL"].ToString();
            }
            con.Close();
            
            return gebruiker;
        }
        public void AccountToevoegen(string GebruikerID, string Gebruikersnaam, string Wachtwoord, string Approved, string Rol)
        {
            con.Open();
            command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERID, GEBRUIKERSNAAM, WACHTWOORD, APPROVED, ROL) VALUES('"+GebruikerID+"','"+Gebruikersnaam+"','"+EncryptString(Wachtwoord)+"', '"+Approved+"','"+Rol+"')",  con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public int ControlleerMaxGebruikerID()
        {
            int id = 0;
            con.Open();
            command = new OracleCommand("SELECT MAX(GEBRUIKERID) as MAXID FROM GEBRUIKER", con);
            reader = command.ExecuteReader();
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
            command = new OracleCommand("SELECT Gebruikersnaam FROM GEBRUIKER WHERE Gebruikersnaam ='" + Gebruikersnaam + "'", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempString = reader["Gebruikersnaam"].ToString();
            }
            con.Close();
            if (tempString == null)
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
        public void ProfielAanpassen(Gebruiker gebruiker, bool wachtwoordChanged, bool fotoChanged)
        {
            con.Open();
            if (gebruiker.Auto)
            {
                tempString = "Y";
            }
            else
            {
                tempString = "N";
            }
            //Verschil maken tussen welke info veranderd is. Anders wordt er een encryptie 
            //over encryptie van het wachtwoord gedaan elke keer dat je iets aan het profiel aanpast
            if(fotoChanged)
            {
                command = new OracleCommand("UPDATE Gebruiker SET GebruikerInfo='" + gebruiker.GebruikerInfo + "', Foto='" + gebruiker.Pasfoto + "', Auto='" + tempString + "', Voornaam='"+gebruiker.Voornaam+"', Achternaam='"+gebruiker.Achternaam+"'  WHERE GebruikerID ='" + gebruiker.GebruikersID + "'", con);
            }
            else if(wachtwoordChanged)
            {
                command = new OracleCommand("UPDATE Gebruiker SET Wachtwoord = '" + EncryptString(gebruiker.Wachtwoord) + "', GebruikerInfo='" + gebruiker.GebruikerInfo + "', Auto='" + tempString + "', Voornaam='" + gebruiker.Voornaam + "', Achternaam='" + gebruiker.Achternaam + "' WHERE GebruikerID ='" + gebruiker.GebruikersID + "'", con);
            }
            else
            {
                command = new OracleCommand("UPDATE Gebruiker SET GebruikerInfo='" + gebruiker.GebruikerInfo + "', Auto='" + tempString + "', Voornaam='" + gebruiker.Voornaam + "', Achternaam='" + gebruiker.Achternaam + "' WHERE GebruikerID ='" + gebruiker.GebruikersID + "'", con);
            }
            reader = command.ExecuteReader();
            con.Close();
        }
        public void ReactieToevoegen()
        {

        }
        public void BeoordelingToevoegen()
        {
            // command = new OracleCommand("INSERT INTO Hulpvraag(HulpvraagID, GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie) VALUES('@HulpvraagID','@GebruikerID, '@HulpvraagInhoud', '@Urgent', '@DatumTijd', '@Duur', '@Frequentie');", con);
            //command.Parameters.AddWithValue("HulpvraagID", 1);
            //command.Parameters.AddWithValue("GebruikerID", 1);
            //command.Parameters.AddWithValue("HulpvraagInhoud", "Testinhoud");
            //command.Parameters.AddWithValue("Urgent", 'Y');
            //command.Parameters.AddWithValue("DatumTijd", new DateTime(2016, 02, 03, 21, 05, 00));
            //command.Parameters.AddWithValue("Duur", 20);
            //command.Parameters.AddWithValue("Frequentie", 2);


            // SqlDataAdapter command = new SqlDataAdapter("INSERT INTO Login (Username, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", sql);
            // command.SelectCommand.ExecuteNonQuery();
            // sql.Close();
        }
        #endregion
        public string EncryptString(string toEncrypt)
        {
            SHA256Managed crypt = new SHA256Managed();
            System.Text.StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt), 0, Encoding.UTF8.GetByteCount(toEncrypt));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
