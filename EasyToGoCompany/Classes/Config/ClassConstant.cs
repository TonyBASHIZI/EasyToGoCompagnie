namespace EasyToGoCompany.Classes.Config
{
    public class Constant
    {
        public class Database
        {
            public static string InitialDirectory = AppConfig.InitialDirectory;
            public static string Path = AppConfig.GetConnectionString;
            public static string Backup = AppConfig.BackupDirectory;
        }

        public class Table
        {
            public static string Bus = "bus";
            public static string Compagnie = "compagnie";
            public static string Utilisateur = "utilisateur";
            public static string Compte = "compte";
            public static string Transaction = "transaction";
            public static string Pos = "pos";
        }
    }
}
