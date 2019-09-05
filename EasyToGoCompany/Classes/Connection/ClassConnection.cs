using EasyToGoCompany.Classes.Config;
using MySql.Data.MySqlClient;
using System.Data;

namespace EasyToGoCompany.Classes.Connection
{
    public class Connection
    {
        private static Connection _instance = null;

        public IDbConnection Con { get; set;}

        public static Connection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Connection();
                return _instance;
            }
        }

        public IDbConnection Connect()
        {
            Con = new MySqlConnection(Constant.Database.Path);
            return Con;
        }        
    }
}
