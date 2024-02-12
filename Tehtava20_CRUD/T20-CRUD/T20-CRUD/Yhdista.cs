
using MySql.Data.MySqlClient;
using System.Data;

namespace T20_CRUD
{
    class Yhdista
    {

        public string Yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;password=;database=hotelli";
        }

        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=opiskelijat"); 



        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }


        public void AvaaYhteys()
        {
           if (yhteys.State == ConnectionState.Closed)
          {
              yhteys.Open();
          }
          
        }

        public void SuljeYhteys()
        {
                if (yhteys.State == ConnectionState.Open)
                {
                    yhteys.Close();
                }
        }
    }
}