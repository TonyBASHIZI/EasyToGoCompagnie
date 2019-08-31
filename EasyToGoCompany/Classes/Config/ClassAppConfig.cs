using System;
using System.IO;
using System.Security.Permissions;

namespace EasyToGoCompany.Classes.Config
{
    public class AppConfig
    {
        public static string InitialDirectory
        {
            get
            {
                return @"C:\ProgramData\EasyToGo";
            }
        }

        public static string BackupDirectory
        {
            get
            {
                return AppConfig.InitialDirectory + @"\Backup\";
            }
        }

        public static string ConnectionDirectory
        {
            get
            {
                return AppConfig.InitialDirectory + @"\Connection\";
            }
        }

        public static string ConnectionString
        {
            get
            {
                return AppConfig.ConnectionDirectory + "path.txt";
            }
        }

        public static string GetConnectionString
        {
            get
            {
                return File.ReadAllText(AppConfig.ConnectionString).Trim();
            }
        }

        public static void CreateInitialDirectory()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(AppConfig.InitialDirectory);
                if (!Directory.Exists(AppConfig.InitialDirectory))
                {
                    Directory.CreateDirectory(AppConfig.InitialDirectory);
                    dirInfo.Attributes = FileAttributes.Hidden;
                }
                dirInfo.Attributes = FileAttributes.Hidden;
            }
            catch (Exception ex)
            {

                throw new Exception("Une erreur s'est produite. \n" + ex.Message);
            }
        }

        public static void CreateConnectionDirectory()
        {
            try
            {
                if (!Directory.Exists(AppConfig.ConnectionDirectory))
                {
                    Directory.CreateDirectory(AppConfig.ConnectionDirectory);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur s'est produite. \n" + ex.Message);
            }
        }

        public static void CreateConnectionString()
        {
            try
            {               
                if (!File.Exists(AppConfig.ConnectionString))
                {
                    File.Create(AppConfig.ConnectionString);
                    FileIOPermission file = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, AppConfig.ConnectionString);
                    file.AddPathList(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, AppConfig.ConnectionString);
                    file.Demand();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Une erreur s'est produite. \n" + ex.Message);
            }
        }

        public static Boolean InitialDirectoryExist()
        {
            if (Directory.Exists(AppConfig.InitialDirectory))
            {
                return true;
            }
            return false;
        }

        public static Boolean ConnectionStringExist()
        {
            if (File.Exists(AppConfig.ConnectionString))
            {
                return true;
            }
            return false;
        }

        public static Boolean ConnectionStringEmpty()
        {
            if (AppConfig.GetConnectionString.Length == 0 )
            {
                return true;
            }
            return false;
        }
    }
}
