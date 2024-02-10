using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_CRUD
{
    internal class Yhdista
    {
       
        public string Yhteyslause()
        {
            return "datasource=localhost;port3306;username=root;password=;database-hotelli";

        }

        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port3306;username=root;password=;database-opiskelijat");

        public MySqlConnection otaYhteys()
        {
            return yhteys; 
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }

    }
}
