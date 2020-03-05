using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NarudzbenicaModels.DataAccess;
using NarudzbenicaModels.Models;

namespace NarudzbenicaModels
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections()
        {
            //if (db == DatabaseType.SQLite)
            //{
            //    SQLiteConnector sqlite = new SQLiteConnector();
            //    Connection = sqlite;
            //}
            //else if (db == DatabaseType.TextFile)
            //{
            //    TextConnector text = new TextConnector();
            //    Connection = text;
            //}
            SQLiteConnector sqlite = new SQLiteConnector();
            Connection = sqlite;
        }
        /// <summary>
        /// Returning Data source path saved into settings.settings file
        /// </summary>
        /// <returns></returns>
        public static string CnnString()
        {

            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;

            // return FirstTimeConfig.LoadPath(name).Location;
            // TODO: ispravi return string
            //return @"Data Source=C:\Users\Korisnik\Dropbox\_ZenkaNoTachi\Development\LIdacApp\Database\NarudzbenicaDatabase\NarudzbenicaDatabase.db;Version=3;";
            //string fullPath = @"C:/Users/Korisnik/Documents/BazaNarudzbenica/sqliteNarudzbenice.db";

            //DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            //DirectorySecurity dSecurity = dInfo.GetAccessControl();
            //dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            //dInfo.SetAccessControl(dSecurity);


            //return @"Data Source=C:/Database/BazaNarudzbenica/sqliteNarudzbenice.db; Version=3;";
            //return @"Data Source=C:/Users/Korisnik/Documents/BazaNarudzbenica/sqliteNarudzbenice.db; Version=3;"; 

            if (!File.Exists(System.IO.Path.Combine(NarudzbenicaModels.Properties.Settings.Default.DatabaseaPath, "sqliteNarudzbenice.db")))
            {
                return null;
            }
            else
            {
                string path = System.IO.Path.Combine(NarudzbenicaModels.Properties.Settings.Default.DatabaseaPath, "sqliteNarudzbenice.db");
                return @"Data Source=" + path + "; Version=3;";

            }

        }
    }
}
