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

namespace CAREMATCH
{
    class Database
    {
        private OleDbConnection sql;
        public Database()
        {
            string Datasource = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = dbi327544; PASSWORD = CareMatch";
            sql = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;" +  Datasource);
      
           
        }
        #region Hulpvragen Queries
        public void HulpvraagToevoegen(Hulpvragen.Hulpvraag hulpvraag)
        {
            
        }
        public void HulpvraagVerwijderen()
        {

        }
        public void HulpvraagAanpassen()
        {

        }
        public List<Hulpvragen.Hulpvraag> HulpvragenOverzicht()
        {
            List<Hulpvragen.Hulpvraag> hulpvraagList = new List<Hulpvragen.Hulpvraag>();

            // Querry voor het halen van een lijst met alle hulpvragen hier

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
        public void ChatInvoegen()
        {

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
        public void ReactieToevoegen()
        {

        }
        public void BeoordelingToevoegen()
        {

        }
        public void AccountToevoegen()
        {
            sql.Open();
            OleDbCommand command = new OleDbCommand("INSERT INTO Hulpvraag(HulpvraagID, GebruikerID, HulpvraagInhoud, Urgent, DatumTijd, Duur, Frequentie) VALUES('@HulpvraagID','@GebruikerID, '@HulpvraagInhoud', '@Urgent', '@DatumTijd', '@Duur', '@Frequentie');", sql);
            command.Parameters.AddWithValue("HulpvraagID", 1);
            command.Parameters.AddWithValue("GebruikerID", 1);
            command.Parameters.AddWithValue("HulpvraagInhoud", "Testinhoud");
            command.Parameters.AddWithValue("Urgent", 'Y');
            command.Parameters.AddWithValue("DatumTijd", new DateTime(2016, 02, 03, 21, 05, 00));
            command.Parameters.AddWithValue("Duur", 20);
            command.Parameters.AddWithValue("Frequentie", 2);

            command.ExecuteNonQuery();
            sql.Close();
           // SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Login (Username, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", sql);
           // sda.SelectCommand.ExecuteNonQuery();
           // sql.Close();
        }
        public void ProfielAanpassen()
        {

        }
    }
}
