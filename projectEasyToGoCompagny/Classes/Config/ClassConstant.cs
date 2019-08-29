using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToGoCompany.Classes.Config
{
    public class Constant
    {
        public class Database
        {
            //public static string InitialDirectory = "C:\\cheminBdStorm";
            //public static string Path = @"C:\cheminBdStorm\monChemin.txt";
            //public static string Backup = "C:\\BackupStorm";

            public static string InitialDirectory = AppConfig.InitialDirectory;
            public static string Path = AppConfig.GetConnectionString;
            public static string Backup = AppConfig.BackupDirectory;
        }

        public class Table
        {
            public static string Bus = "bus";
            public static string Compagnie = "compagnie";
            public static string Utilisateur = "utilisateur";
            public static string Pos = "pos";
        }
    }
}
