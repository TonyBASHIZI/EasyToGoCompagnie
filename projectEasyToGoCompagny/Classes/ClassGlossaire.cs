using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectEasyToGoCompagny.Classes.Connection;

namespace projectEasyToGoCompagny.Classes
{
    public class Glossaire
    {
        private projectEasyToGoCompagny.Classes.Connection.Connection cnx = null;

        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataAdapter dt = null;
        private MySqlDataReader dr = null;
        
        private static Glossaire _instance = null;

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }
    }
}
