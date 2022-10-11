using mission2.DAL;
using mission2.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2.DAL
{
    internal class SecteurDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "bd_sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;
        public List<Secteur> GetSecteur()
        {
            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = com.ExecuteReader();

                Secteur e;

                while (reader.Read())
                {

                    
                    string nom = (string)reader.GetValue(1);
                    int id = (int)reader.GetValue(0);


                    e = new Secteur(id, nom);


                    lc.Add(e);


                }

                reader.Close();

                maConnexionSql.closeConnection();


                



            }

            catch (Exception emp)
            {

                throw (emp); 

            }
            return (lc);

        }
    }
}