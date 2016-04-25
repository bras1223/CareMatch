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
            string tempString2;
            con.Open();
            if (hulpvraag.Urgent)
            {
                tempString = "Y";
            }
            else
            {
                tempString = "N";
            }
            if (hulpvraag.Auto)
            {
                tempString2 = "Y";
            }
            else
            {
                tempString2 = "N";
            }
            command = new OracleCommand("INSERT INTO Hulpvraag(GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie, Titel, Locatie, AutoBenodigd) VALUES(:gebruikerid, :hulpvraaginhoud, :temp, :datumtijd, :duur, :frequentie, :titel, :locatie, :string2')", con);
            command.Parameters.Add("gebruikerid", gebruiker.GebruikersID);
            command.Parameters.Add("reactie", hulpvraag.Reactie);
            command.Parameters.Add("hulpvraaginhoud", hulpvraag.HulpvraagInhoud);
            command.Parameters.Add("temp", tempString);
            command.Parameters.Add("hulpvraagid", hulpvraag.HulpvraagID);
            command.Parameters.Add("titel", hulpvraag.Titel);
            command.Parameters.Add("datumtijd", hulpvraag.DatumTijd);
            command.Parameters.Add("duur", hulpvraag.Duur);
            command.Parameters.Add("frequentie", hulpvraag.Frequentie);
            command.Parameters.Add("locatie", hulpvraag.Locatie);
            command.Parameters.Add("string", tempString2);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void HulpvraagVerwijderen(Hulpvragen.Hulpvraag hulpvraag)
        {
            con.Open();

            int id = hulpvraag.HulpvraagID;
            command = new OracleCommand("DELETE FROM Hulpvraag WHERE HulpvraagID =:id;", con);
            command.Parameters.Add("id", id);
            con.Close();
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

            command = new OracleCommand("UPDATE Hulpvraag SET Reactie =:reactie, LaatstGereageerdDoor=:gebruikersnaam, VrijwilligerID=(SELECT GebruikerID FROM Gebruiker WHERE GebruikerID =:gebruikerid AND LOWER(ROL)='vrijwilliger'), Hulpvraaginhoud=:hulpvraaginhoud, Urgent=:temp WHERE HulpvraagID=:hulpvraagid ", con);
            command.Parameters.Add("gebruikerid", gebruiker.GebruikersID);
            command.Parameters.Add("reactie", hulpvraag.Reactie);
            command.Parameters.Add("hulpvraaginhoud", hulpvraag.HulpvraagInhoud);
            command.Parameters.Add("temp", tempString);
            command.Parameters.Add("hulpvraagid", hulpvraag.HulpvraagID);
            reader = command.ExecuteReader();
            con.Close();
        }
        public List<Hulpvragen.Hulpvraag> HulpvragenOverzicht(Gebruiker gebruiker, string filter)
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
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur, Hulpvraag.LaatstGereageerdDoor FROM Hulpvraag WHERE VrijwilligerID=:gebruikerid", con);
            }
            else if(filter == "Nieuwe reacties" && gebruiker.Rol.ToLower() == "vrijwilliger")
            {
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag WHERE VrijwilligerID=:gebruikerid AND LaatstGereageerdDoor !=:gebruikersnaam", con);
            }
            else if (filter == "Nieuwe reacties" && gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag WHERE GebruikerID=:gebruikerid AND LaatstGereageerdDoor !=:gebruikersnaam", con);
            }
            else if(filter.ToLower() == "ongepaste hulpvragen" && gebruiker.Rol.ToLower() == "beheerder")
            {
                //throw new NotImplementedException();
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie, Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.LaatstGereageerdDoor, Hulpvraag.Duur FROM Hulpvraag -- WHERE Hulpvraag.Flagged = 'Y'", con);
                //Hulpvraag.Flagged Y or N moet nog in de database
                

                //nog niet af, moeten nog 2 querries bij, dus nog 2 else-if statements met 2 querries
                //op basis van OngepasteBerichtenForm;
            }
            else if(filter == "")
            {

            }
            else
            {
                //Overzicht eigen hulpvragen voor hulpbehoevende.
                command = new OracleCommand("SELECT Hulpvraag.HulpvraagID, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID) as hulpbeh, (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.VrijwilligerID = Gebruiker.GebruikerID) as vrijwilliger, Hulpvraag.HulpvraagInhoud,  Hulpvraag.DatumTijd, Hulpvraag.Urgent, Hulpvraag.Frequentie,  Hulpvraag.Titel, Hulpvraag.Reactie, Hulpvraag.Duur, Hulpvraag.LaatstGereageerdDoor FROM Hulpvraag WHERE (SELECT Gebruikersnaam FROM Gebruiker WHERE Hulpvraag.GebruikerID = Gebruiker.GebruikerID)=:gebruikersnaam", con);
            }
            
            command.Parameters.Add("gebruikerid", gebruiker.GebruikersID);
            command.Parameters.Add("gebruikersnaam", gebruiker.Gebruikersnaam);
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
                if(!(reader["DatumTijd"] is DBNull))
                {
                    hulpvraag.DatumTijd = Convert.ToDateTime(reader["DatumTijd"]);
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
        public string HulpvraagProfielFoto(Gebruiker gebruiker, Hulpvragen.Hulpvraag hulpvraag, string rol)
        {
            con.Open();
            if(rol == "hulpbehoevende")
            {
                command = new OracleCommand("SELECT Foto FROM Gebruiker WHERE GebruikerID=(SELECT GebruikerID FROM Hulpvraag WHERE HulpvraagID=:hulpvraagid) ", con);
            }
            else if(rol == "vrijwilliger")
            {
                command = new OracleCommand("SELECT Foto FROM Gebruiker WHERE Gebruikersnaam=:vrijwilliger", con);
            }
            command.Parameters.Add("hulpvraagid", hulpvraag.HulpvraagID);
            command.Parameters.Add("vrijwilliger", hulpvraag.Vrijwilliger);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempString = reader["Foto"].ToString();
            }
            con.Close();
            return tempString;
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
                command = new OracleCommand("SELECT * FROM Agenda WHERE EigenaarID =:gebruikersid AND AfspraakDatum=:datum", con);
                command.Parameters.Add("gebruikersid", gebruiker.GebruikersID);
                command.Parameters.Add("datum", datum);
            }
            else
            {
                //Anders de agenda van de geselecteerde persoon weergeven.
                command = new OracleCommand("SELECT * FROM Agenda WHERE EigenaarID =(SELECT GebruikerID FROM Gebruiker WHERE Gebruikersnaam=:filter AND AfspraakDatum=:datum) ", con);
                command.Parameters.Add("filter", filter);
                command.Parameters.Add("datum", datum);
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
            command = new OracleCommand("INSERT INTO Agenda(EigenaarID, Omschrijving, StartTijd, EindTijd, Titel, Hulpbehoevende, Vrijwilliger, AfspraakDatum) VALUES(:gebruikersid,:beschrijving ,:starttijd ,:eindtijd ,:titel ,:hulpbehoevende ,:vrijwilliger ,:datum)", con);
            command.Parameters.Add("gebruikersid", gebruiker.GebruikersID);
            command.Parameters.Add("beschrijving", agendaPunt.Beschrijving);
            command.Parameters.Add("starttijd", agendaPunt.DatumTijdStart);
            command.Parameters.Add("eindtijd", agendaPunt.DatumTijdEind);
            command.Parameters.Add("titel", agendaPunt.Titel);
            command.Parameters.Add("hulpbehoevende", agendaPunt.Hulpbehoevende);
            command.Parameters.Add("vrijwilliger", agendaPunt.Vrijwilliger);
            command.Parameters.Add("datum", datum);
            command.ExecuteNonQuery();
            con.Close();
        }
        public Agenda.AgendaPunt AgendaInhoudWeergeven(Gebruiker gebruiker, int agendaID)
        {
            agendaPunt = new Agenda.AgendaPunt();
            command = new OracleCommand("SELECT * FROM Agenda WHERE GebruikerID =:gebruikersid AND AgendaID=:agendaID", con);
            command.Parameters.Add("gebruikersid", gebruiker.GebruikersID);
            command.Parameters.Add("agendaID", agendaID);
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
            command = new OracleCommand("UPDATE Agenda SET AfspraakID =:afspraakid, Omschrijving=:beschrijving, StartTijd=:starttijd, EindTijd=:eindtijd, Titel=:titel ,Hulpbehoevende=:hulpbehoevende, Vrijwilliger=:vrijwilliger", con);
            command.Parameters.Add("afspraakid", agendaPunt.AfspraakID);
            command.Parameters.Add("beschrijving", agendaPunt.Beschrijving);
            command.Parameters.Add("starttijd", agendaPunt.DatumTijdStart);
            command.Parameters.Add("eindtijd", agendaPunt.DatumTijdEind);
            command.Parameters.Add("titel", agendaPunt.Titel);
            command.Parameters.Add("hulpbehoevende", agendaPunt.Hulpbehoevende);
            command.Parameters.Add("vrijwilliger", agendaPunt.Vrijwilliger);
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
            command = new OracleCommand("SELECT GebruikerID FROM gebruiker WHERE gebruikersnaam = :naam", con);
            command.Parameters.Add("naam", naam);
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
                command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('1', :maxid, :verzenderid, :inhoud, TO_TIMESTAMP(:datum,'DD-MON HH24.MI'))", con);
                command.Parameters.Add("maxid", (ControlleerMaxChatID() + 1));
                command.Parameters.Add("verzenderid", verzenderID);
                command.Parameters.Add("inhoud", inhoud);
                command.Parameters.Add("datum", datum);
                command.ExecuteNonQuery();
                con.Close();
            }

            else if(Chatcount <= 0)
            {
                command = new OracleCommand("INSERT INTO Chat(ChatID, OntvangerID, VerzenderID, BerichtInhoud, Datumtijd) VALUES('1','0', :verzenderid, :inhoud, TO_TIMESTAMP(:datum,'DD-MON HH24.MI'))", con);
                command.Parameters.Add("verzenderid", verzenderID);
                command.Parameters.Add("inhoud", inhoud);
                command.Parameters.Add("datum", datum);

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
            //List<string> chatgekregen;
            chatverzonden = new List<string>();


            con.Open();
            command = new OracleCommand("SELECT Inhoud FROM chat WHERE ontvangerID = :ontvangerid AND verzenderID = :verzenderid", con);
            command.Parameters.Add("ontvangerid", ontvangerID);
            command.Parameters.Add("verzenderid", verzenderID);
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
                tempString = "SELECT * FROM HULPVRAAG";
            }
            else if (query == "Hulpvraag info")
            {
                tempString = "SELECT GEBRUIKERSNAAM, TITEL, FREQUENTIE FROM HULPVRAAG";
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
                MessageBox.Show("Kan de verbinding met de database niet tot stand brengen");
                
            }
            //Gebruikersnaam zoeken waar gebruikersnaam gelijk is aan de ingevoerde naam + w8woord
            command = new OracleCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = :naam AND wachtwoord = :pw", con);
            command.Parameters.Add("naam", naam);
            command.Parameters.Add("pw", EncryptString(wachtwoord));
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Nieuwe gebruiker aanmaken op basis van de rol
                if (reader["ROL"].ToString().ToLower() == "vrijwilliger")
                {
                    gebruiker = new Gebruiker();
                    gebruiker.Approved = true;
                }
                else
                {
                    gebruiker = new Gebruiker();
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
                command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERSNAAM, WACHTWOORD, VOORNAAM, ACHTERNAAM, FOTO, APPROVED, ROL) VALUES(:gebruikersnaam, :wachtwoord, :voornaam, :achternaam, :filenamefoto, :Approved, :Rol)", con);
                command.Parameters.Add("gebruikersnaam", Gebruikersnaam);
                command.Parameters.Add("wachtwoord", EncryptString(Wachtwoord));
                command.Parameters.Add("voornaam", voornaam);
                command.Parameters.Add("achternaam", achternaam);
                command.Parameters.Add("filenamefoto", filenameFoto);
                command.Parameters.Add("Approved", Approved);
                command.Parameters.Add("Rol", Rol);

            }
            //Vrijwilliger wel.
            else
            {
                command = new OracleCommand("INSERT INTO GEBRUIKER(GEBRUIKERSNAAM, WACHTWOORD, VOORNAAM, ACHTERNAAM, FOTO, APPROVED, ROL, VOG) VALUES(:gebruikersnaam, :wachtwoord, :voornaam, :achternaam, :filenamefoto, :Approved, :Rol, :filenameVOG)", con);
                command.Parameters.Add("gebruikersnaam", Gebruikersnaam);
                command.Parameters.Add("wachtwoord", EncryptString(Wachtwoord));
                command.Parameters.Add("voornaam", voornaam);
                command.Parameters.Add("achternaam", achternaam);
                command.Parameters.Add("filenamefoto", filenameFoto);
                command.Parameters.Add("Approved", Approved);
                command.Parameters.Add("Rol", Rol);
                command.Parameters.Add("filenameVOG", filenameVOG);
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

            command = new OracleCommand("SELECT Gebruikersnaam FROM GEBRUIKER WHERE Gebruikersnaam =:gebruikersnaam", con);
            command.Parameters.Add("Gebruikersnaam", Gebruikersnaam);
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
                command = new OracleCommand("UPDATE Gebruiker SET GebruikerInfo=:info, Foto=:pasfoto, Auto=:temp, Voornaam=:voornaam, Achternaam=:achternaam  WHERE GebruikerID =:gebruikerid", con);
            }
            else if(wachtwoordChanged)
            {
                command = new OracleCommand("UPDATE Gebruiker SET Wachtwoord =:password, GebruikerInfo=:info, Auto=:temp, Voornaam=:voornaam, Achternaam=:achternaam WHERE GebruikerID =:gebruikerid", con);
            }
            else
            {
                command = new OracleCommand("UPDATE Gebruiker SET GebruikerInfo=:info, Auto=:temp, Voornaam=:voornaam, Achternaam=:achternaam WHERE GebruikerID =:gebruikerid", con);
            }
            command.Parameters.Add("info", gebruiker.GebruikerInfo)s;
            command.Parameters.Add("pasfoto", gebruiker.Pasfoto);
            command.Parameters.Add("temp", tempString);
            command.Parameters.Add("voornaam", gebruiker.Voornaam);
            command.Parameters.Add("achternaam", gebruiker.Achternaam);
            command.Parameters.Add("gebruikerid", gebruiker.GebruikersID);
            command.Parameters.Add("password", EncryptString(gebruiker.Wachtwoord));
            reader = command.ExecuteReader();
            con.Close();
        }
        public List<string> GebruikerProfielOpvragen(string rol)
        {
            List<string> ProfielInfo = new List<string>();
            con.Open();
            command = new OracleCommand("SELECT * FROM GEBRUIKER WHERE ROL =:rol", con);
            command.Parameters.Add("rol", rol);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                tempString = reader["Auto"].ToString();
                ProfielInfo.Add(tempString);
                tempString = reader["GebruikerInfo"].ToString();
                ProfielInfo.Add(tempString);
                tempString = reader["Achternaam"].ToString();
                ProfielInfo.Add(tempString);
                tempString = reader["Voornaam"].ToString();
                ProfielInfo.Add(tempString);
                tempString = reader["Foto"].ToString();
                ProfielInfo.Add(tempString);
            }
            con.Close();

            return ProfielInfo;
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
