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

/* 
public void HulpvraagToevoegen(Hulpvragen.Hulpvraag hulpvraag, Gebruiker gebruiker)
        {
            con.Open();
            if(hulpvraag.Urgent)
            {
                tempString = "Y";
            }
            else
            {
                tempString = "N";
            }
            command = new OracleCommand("INSERT INTO Hulpvraag(GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie, Titel, HulpbehoevendeFoto, Locatie) VALUES('" + gebruiker.GebruikersID + "','" + hulpvraag.HulpvraagInhoud + "','" + tempString + "', '" + hulpvraag.DatumTijd + "','" + hulpvraag.Duur + "', '" + hulpvraag.Frequentie+ "', '" +hulpvraag.Titel + "', '"+gebruiker.Pasfoto+"', '"+hulpvraag.Locatie+"')", con);
            command.ExecuteNonQuery();
            con.Close();
        */
namespace CAREMATCH
{
    class Database
    {
        private OracleConnection con;
        private OracleCommand command;
        private OracleDataReader reader;
        private Gebruiker gebruiker;
        private Agenda.AgendaPunt agendaPunt;
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
        public void HulpvraagToevoegen(Hulpvragen.Hulpvraag hulpvraag, Gebruiker gebruiker)
        {
            con.Open();
            if(hulpvraag.Urgent)
            {
                tempString = "Y";
            }
            else
            {
                tempString = "N";
            }
            command = new OracleCommand("INSERT INTO Hulpvraag(GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie, Titel, HulpbehoevendeFoto, Locatie) VALUES('" + gebruiker.GebruikersID + "','" + hulpvraag.HulpvraagInhoud + "','" + tempString + "', '" + hulpvraag.DatumTijd + "','" + hulpvraag.Duur + "', '" + hulpvraag.Frequentie+ "', '" +hulpvraag.Titel + "', '"+gebruiker.Pasfoto+"', '"+hulpvraag.Locatie+"')", con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void HulpvraagVerwijderen()
        {

        }
        public void HulpvraagAanpassen(Gebruiker gebruiker, Hulpvragen.Hulpvraag hulpvraag)
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

            command = new OracleCommand("UPDATE Hulpvraag SET Reactie ='"+hulpvraag.Reactie+"', LaatstGereageerdDoor='"+gebruiker.Gebruikersnaam+"', VrijwilligerID=(SELECT GebruikerID FROM Gebruiker WHERE GebruikerID ='"+gebruiker.GebruikersID+"' AND LOWER(ROL)='vrijwilliger'), Hulpvraaginhoud='"+hulpvraag.HulpvraagInhoud+"', Urgent='"+tempString+"' WHERE HulpvraagID='"+hulpvraag.HulpvraagID+"' ", con);
            reader = command.ExecuteReader();
            con.Close();
        }
        public List<Hulpvragen.Hulpvraag> HulpvragenOverzicht(bool aangenomen, Gebruiker gebruiker, string filter)
        {
            List<Hulpvragen.Hulpvraag> hulpvraagList = new List<Hulpvragen.Hulpvraag>();

            con.Open();
            if((filter == "Alle hulpvragen" || filter == "") && gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                //Standaard alle hulpvragen laten zien voor vrijwilligers.
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie, Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag", con);
            }
            else if(filter == "Eigen hulpvragen" && gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                //overzicht eigen toegekende hulpvragen voor vrijwilligers
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur, Hulpvraag.LaatstGereageerdDoor FROM Hulpvraag WHERE VrijwilligerID='" + gebruiker.GebruikersID+"'", con);
            }
            else if(filter == "Nieuwe reacties" && gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag WHERE VrijwilligerID='" + gebruiker.GebruikersID+"' AND LaatstGereageerdDoor !='"+gebruiker.Gebruikersnaam+"'", con);
            }
            else if (filter == "Nieuwe reacties" && gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag WHERE GebruikerID='" + gebruiker.GebruikersID + "' AND LaatstGereageerdDoor !='" + gebruiker.Gebruikersnaam + "'", con);
            }
            else
            {
                //Overzicht eigen hulpvragen voor hulpbehoevende.
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur, Hulpvraag.LaatstGereageerdDoor FROM Hulpvraag WHERE (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID)='" + gebruiker.Gebruikersnaam+ "'", con);
            }
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Hulpvragen.Hulpvraag hulpvraag = new Hulpvragen.Hulpvraag();
                
                hulpvraag.HulpvraagID = Convert.ToInt32(reader["HulpvraagID"]);
                hulpvraag.Titel = reader["Titel"].ToString();
                hulpvraag.Hulpbehoevende = reader["hulpbeh"].ToString();
                hulpvraag.Vrijwilliger = reader["vrijwilliger"].ToString();
                hulpvraag.HulpvraagInhoud = reader["HulpvraagInhoud"].ToString();
                hulpvraag.Frequentie = reader["Frequentie"].ToString();
                hulpvraag.Reactie = reader["Reactie"].ToString();
                hulpvraag.LaatstGereageerdDoor = reader["LaatstGereageerdDoor"].ToString();
                hulpvraag.Duur = reader["Duur"].ToString();
                hulpvraag.DatumTijd = reader["DatumTijd"].ToString();
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
        public void HulpvraagProfielFotos(Gebruiker gebruiker, Hulpvragen.Hulpvraag hulpvraag)
        {
            command = new OracleCommand("SELECT Fo FROM Gebruiker WHERE LOWER(ROL)='vrijwilliger' ", con);

            reader = command.ExecuteReader();
            try
            {
                gebruiker.Pasfoto = reader["Foto"].ToString();
            }
            catch
            {
            }
        }
        #endregion
        #region Agenda Queries
        public List<string> AgendaSelecteerVrijwilligers()
        {
            List<string> vrijwilligersList = new List<string>();
            con.Open();

            command = new OracleCommand("SELECT Gebruikersnaam FROM Gebruiker WHERE LOWER(ROL)='vrijwilliger' ", con);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                vrijwilligersList.Add(reader["Gebruikersnaam"].ToString());
            }
            return vrijwilligersList;
        }
        public void AgendaOverzicht(Gebruiker gebruiker, string filter, DateTime datum)
        {
            try
            {
                con.Open();
            }
            catch
            {
                //Soms is de connectie niet goed afgesloten en komt er een foutmelding: CON already Open. 
                //Als dat zo is, gewoon doorgaan met code. dus hoeft niet afgevangen te worden.
            }
            if(filter == "")
            {
                //Standaard eigen agenda weergeven.
                command = new OracleCommand("SELECT * FROM Agenda WHERE EigenaarID ='" + gebruiker.GebruikersID + "' AND AfspraakDatum='"+datum+"' ", con);
            }
            else
            {
                //Anders de agenda van de geselecteerde persoon weergeven.
                command = new OracleCommand("SELECT * FROM Agenda WHERE EigenaarID =(SELECT GebruikerID FROM Gebruiker WHERE Gebruikersnaam='" +filter+ "' AND AfspraakDatum='"+datum+"') ", con);
            }
            try
            {
                //Na het opnieuw inloggen als er al een keer ingelogd is, wordt de connectie niet opnieuw geopened. Vandaar nog een try catch.
                reader = command.ExecuteReader();
            }
            catch
            {
                con.Open();
                reader = command.ExecuteReader();
            }
            while (reader.Read())
            {
                agendaPunt = new Agenda.AgendaPunt();

                agendaPunt.AfspraakID = Convert.ToInt32(reader["AFSPRAAKID"]);
                agendaPunt.Titel = reader["Titel"].ToString();
                agendaPunt.Hulpbehoevende = reader["HulpBehoevende"].ToString();
                agendaPunt.Vrijwilliger = reader["Vrijwilliger"].ToString();
                agendaPunt.Beschrijving = reader["Omschrijving"].ToString();
                agendaPunt.AgendaEigenaar = Convert.ToInt32(reader["AFSPRAAKID"]);
                agendaPunt.DatumTijdStart = Convert.ToInt32(reader["StartTijd"]);
                agendaPunt.DatumTijdEind = Convert.ToInt32(reader["EindTijd"]);

                gebruiker.AgendaPuntToevoegen(agendaPunt);
            }
            con.Close();
        }
        public void AgendaPuntToevoegen(Agenda.AgendaPunt agendaPunt, Gebruiker gebruiker, DateTime datum)
        {
            con.Open();
            command = new OracleCommand("INSERT INTO Agenda(EigenaarID, Omschrijving, StartTijd, EindTijd, Titel, Hulpbehoevende, Vrijwilliger, AfspraakDatum) VALUES('"+gebruiker.GebruikersID+"','"+agendaPunt.Beschrijving+"','"+agendaPunt.DatumTijdStart+"', '"+agendaPunt.DatumTijdEind+"','"+agendaPunt.Titel+"', '"+agendaPunt.Hulpbehoevende+"', '"+agendaPunt.Vrijwilliger+"', '"+datum+"')", con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public Agenda.AgendaPunt AgendaInhoudWeergeven(Gebruiker gebruiker, int agendaID)
        {
            agendaPunt = new Agenda.AgendaPunt();
            command = new OracleCommand("SELECT * FROM Agenda WHERE GebruikerID ='" + gebruiker.GebruikersID + "' AND AgendaID='" + agendaID + "'", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                agendaPunt.AgendaEigenaar = gebruiker.GebruikersID;
                agendaPunt.Titel = reader["Titel"].ToString();
                agendaPunt.DatumTijdStart = Convert.ToInt32(reader["StartTijd"]);
                agendaPunt.DatumTijdEind = Convert.ToInt32(reader["EindTijd"]);
                agendaPunt.Beschrijving = reader["Omschrijving"].ToString();
                agendaPunt.Hulpbehoevende = reader["Hulpbehoevende"].ToString();
                agendaPunt.Vrijwilliger = reader["Vrijwilliger"].ToString();
            }
            con.Close();
            return agendaPunt;
        }
        public void AgendaAanpassen(Gebruiker gebruiker, Agenda.AgendaPunt agendaPunt)
        {
            command = new OracleCommand("UPDATE Agenda SET AfspraakID ='" + agendaPunt.AfspraakID + "', Omschrijving='" + agendaPunt.Beschrijving + "', StartTijd='" + agendaPunt.DatumTijdStart + "', EindTijd='" + agendaPunt.DatumTijdEind + "', Titel='" + agendaPunt.Titel + "',Hulpbehoevende='" + agendaPunt.Hulpbehoevende + "', Vrijwilliger='" + agendaPunt.Vrijwilliger + "'", con);
            reader = command.ExecuteReader();
            con.Close();

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
        //Agenda Queries
        public OracleDataAdapter AgendaBeheer(string query)
        {
            con.Open();
            if (query == "Alles")
            {
                tempString = "SELECT * FROM AGENDA";
            }
            else if (query == "Afspraak")
            {
                tempString = "SELECT TITEL, OMSCHRIJVING, HULPBEHOEVENDE, VRIJWILLIGER  FROM AGENDA";
            }
            OracleDataAdapter reader = new OracleDataAdapter(tempString, con);
            con.Close();
            return reader;
        }
        //Chat en Reactie Queries
        public OracleDataAdapter ChatBeheer(string query)
        {
            con.Open();
            if (query == "Chat")
            {
                tempString = "SELECT * FROM CHAT";
            }
            else if (query == "Reactie")
            {
                tempString = "SELECT * FROM REACTIE";
            }
            OracleDataAdapter reader = new OracleDataAdapter(tempString, con);
            con.Close();
            return reader;
        }
        //Gebruiker Queries
        public OracleDataAdapter GebruikerBeheer(string query)
        {
            con.Open();
            if (query == "Alles")
            {
                tempString = "SELECT * FROM GEBRUIKER";
            }
            else if (query == "Naam & Wachtwoord")
            {
                tempString = "SELECT GEBRUIKERSNAAM, WACHTWOORD FROM GEBRUIKER";
            }
            else if (query == "Niet goedgekeurde gebruikers")
            {
                tempString = "SELECT * FROM GEBRUIKER WHERE APPROVED = 'N'";
            }
            else if (query == "Vrijwilligers zonder VOG")
            {
                tempString = "SELECT * FROM GEBRUIKER WHERE ROL = 'vrijwilliger' AND VOG IS NULL";
            }
            OracleDataAdapter reader = new OracleDataAdapter(tempString, con);
            con.Close();
            return reader;
        }
        //Hulpvraag Queries
        public OracleDataAdapter HulpvraagBeheer(string query)
        {
            con.Open();
            if (query == "Alles")
            {
                tempString = "SELECT * FROM REACTIE";
            }
            else if (query == "Naam & Wachtwoord")
            {
                tempString = "SELECT GEBRUIKERSNAAM, FREQUENTIE FROM REACTIE";
            }

            OracleDataAdapter reader = new OracleDataAdapter(tempString, con);
            con.Close();
            return reader;
        }
        #endregion
        #region Gebruiker Queries
        public Gebruiker GebruikerLogin(string naam, string wachtwoord)
        {
            try
            {
                con.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("kon de verbinding met de database niet tot stand brengen");
                
            }

            //Gebruikersnaam zoeken waar gebruikersnaam gelijk is aan de ingevoerde naam + w8woord
            command = new OracleCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = '"+naam+"' AND wachtwoord = '"+EncryptString(wachtwoord)+"'", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Nieuwe gebruiker aanmaken op basis van de rol
                if (reader["ROL"].ToString().ToLower() == "hulpbehoevende")
                {
                    gebruiker = new Gebruiker();
                }
                else if (reader["ROL"].ToString().ToLower() == "beheerder")
                {
                    gebruiker = new Gebruiker();
                }
                else if (reader["ROL"].ToString().ToLower() == "vrijwilliger")
                {
                    gebruiker = new Gebruiker();
                    gebruiker.Approved = true;
                }
                //Properties toekennen aan gebruiken.
                gebruiker.Achternaam = reader["Achternaam"].ToString();
                gebruiker.Voornaam = reader["Voornaam"].ToString();
                gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                gebruiker.GebruikersID = Convert.ToInt32(reader["GebruikerID"]);
                gebruiker.GebruikerInfo = reader["GebruikerInfo"].ToString();
                gebruiker.VOG = reader["vog"].ToString();
                if (reader["Auto"].ToString() == "Y")
                {
                    gebruiker.Auto = true;
                }
                else
                {
                    gebruiker.Auto = false;
                }
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
        public void GebruikerAccountToevoegen(string Gebruikersnaam, string Wachtwoord, string Approved, string Rol, string filenameFoto, string filenameVOG, string voornaam, string achternaam, string geslacht, DateTime geboortedatum)
        {

            try
            {
                con.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("kon de verbinding met de database niet tot stand brengen");
            }

            //Hulpbehoevende hoeft geen VOG te inserten.
            if (Rol.ToLower() == "hulpbehoevende") 
            {
                command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERSNAAM, WACHTWOORD, VOORNAAM, ACHTERNAAM, FOTO, APPROVED, ROL) VALUES('" + Gebruikersnaam + "','" + EncryptString(Wachtwoord) + "', '" + voornaam + "', '" + achternaam + "', '" + filenameFoto + "', '" + Approved + "','" + Rol + "')", con);
            }
            //Vrijwilliger wel.
            else
            {
                command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERSNAAM, WACHTWOORD, VOORNAAM, ACHTERNAAM, FOTO, APPROVED, ROL, VOG) VALUES('" + Gebruikersnaam + "','" + EncryptString(Wachtwoord) + "', '" + voornaam + "', '" + achternaam + "', '" + filenameFoto + "', '" + Approved + "','" + Rol + "', '"+filenameVOG+"')", con);
            }
            command.ExecuteNonQuery();
            con.Close();
        }
        public bool GebruikerControlleerUsername(string Gebruikersnaam)
        {

            try
            {
                con.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("kon de verbinding met de database niet tot stand brengen");
            }

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
        public void GebruikerProfielAanpassen(Gebruiker gebruiker, bool wachtwoordChanged, bool fotoChanged)
        {
            try
            {
                con.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("kon de verbinding met de database niet tot stand brengen");
            }

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
        public void GebruikerBeoordelingToevoegen()
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
        public void GebruikerActiveren(string filename)
        {
            try
            {
                con.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("kon de verbinding met de database niet tot stand brengen");
            }

            //query aanpassen
            //command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERSNAAM, WACHTWOORD, APPROVED, ROL) VALUES('" + Gebruikersnaam + "','" + EncryptString(Wachtwoord) + "', '" + Approved + "','" + Rol + "')", con);
            command.ExecuteNonQuery();
            con.Close();
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
