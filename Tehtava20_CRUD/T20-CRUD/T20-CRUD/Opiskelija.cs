using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace T20_CRUD
{
    class OPISKELIJA
    {
        Yhdista yhteys = new Yhdista();

        public bool LisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            
                String lisayskysely = "INSERT INTO yhteystiedot" + "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) " + "VALUES (@enm, @snm, @puh, @eml, @ono); ";
                komento.CommandText = lisayskysely;
                komento.Connection = yhteys.OtaYhteys();

                komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
                komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
                komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
                komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
                komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

            yhteys.AvaaYhteys(); 
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true; 
            }

            else
            {
                yhteys.SuljeYhteys(); 
                return false;
            }
            
        }


        public DataTable HaeOpiskelijat()
        {
           MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot", yhteys.OtaYhteys());
           MySqlDataAdapter adapteri = new MySqlDataAdapter();
       
           DataTable taulu = new DataTable();

           adapteri.SelectCommand = komento;
           adapteri.Fill(taulu);

           return taulu;

        }


        public bool MuokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
         
                String paivityskysely = "UPDATE `yhteystiedot` SET `Etunimi` = @enm," +
                "`Sukunimi` = @snm, `puhelin` = @puh, `sahkoposti` = @eml, `opiskelijanumero` = @ono" +
                " WHERE oid = @oid";
                komento.CommandText = paivityskysely;
                komento.Connection = yhteys.OtaYhteys();

                komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;
                komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
                komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
                komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
                komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
                komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

               
                yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true; 
            }

            else
            {
                yhteys.SuljeYhteys();
                return false;
            }

                 
        }

        public bool PoistaOpiskelija(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
           
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @oid";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = ktunnus;
                
               
            yhteys.AvaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true; 

            }
            else
            {
                yhteys.SuljeYhteys();
                return false; 
            }
            
        }
    }
}
