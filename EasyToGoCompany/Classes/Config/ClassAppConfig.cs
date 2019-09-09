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
                return InitialDirectory + @"\Backup\";
            }
        }

        public static string ConnectionDirectory
        {
            get
            {
                return InitialDirectory + @"\Connection\";
            }
        }

        public static string ConnectionString
        {
            get
            {
                return ConnectionDirectory + "path.txt";
            }
        }

        public static string GetConnectionString
        {
            get
            {
                return File.ReadAllText(ConnectionString).Trim();
            }
        }

        public static void CreateInitialDirectory()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(InitialDirectory);
                if (!Directory.Exists(InitialDirectory))
                {
                    Directory.CreateDirectory(InitialDirectory);
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
                if (!Directory.Exists(ConnectionDirectory))
                {
                    Directory.CreateDirectory(ConnectionDirectory);
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
                    File.Create(ConnectionString);
                    FileIOPermission file = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, ConnectionString);
                    file.AddPathList(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, ConnectionString);
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
            return Directory.Exists(InitialDirectory) ? true : false;
        }

        public static Boolean ConnectionStringExist()
        {
            return File.Exists(ConnectionString) ? true : false;
        }

        public static Boolean ConnectionStringEmpty()
        {
            return GetConnectionString.Length == 0 ? true : false;
        }
    }
}
