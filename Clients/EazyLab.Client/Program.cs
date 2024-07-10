using EazyLab;
using EazyLab.Cpt.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.IO.Directory;

namespace EazyLabClient
{
    internal static class Program
    {

        // Initialization variable 
        public static string AppType = "Cpt";
        public static CptChamber Chamber; 
        static public List<CptStation> Stations;
        static string root = @"D:\"; // Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory); 
        public static string Dir = root + AppType;
        public static string DataDir = Dir + @"\Data\";
        public static string DbDir = Dir + @"\Db\";
        public static string DataFile = DbDir + @"CptData.db";
        public static string ServerFile = DbDir + @"Server.db";
        public static string LoadProfilesDir = Dir + @"\LoadProffiles\";
        public static string ChamberFileName = DbDir + "Chamber.obj";
        static Microsoft.Win32.RegistryKey Start_RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("AHU_Start_UP");
        static Microsoft.Win32.RegistryKey Stop_RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("AHU_Stop");
        public static int UpdateTime = 2000;
        //
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                LoggerFile.WriteMessage("start1");
                if (!Exists(Dir)) CreateDirectory(Dir);
                if (!Exists(DataDir)) CreateDirectory(DataDir);
                if (!Exists(DbDir)) CreateDirectory(DbDir);
                if (!Exists(LoadProfilesDir)) CreateDirectory(LoadProfilesDir);
                InitializeDb.Initialize(ServerFile);// Database is configured here 
                Server.DbLoad();
                Server.Initialize();
                LoggerFile.WriteMessage("start2");
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                var mainForm = new frmCptMain();
                Application.Run(mainForm);
                //using (var mainForm = new frmCptMain())
                //{
                //    Application.Run(mainForm);
                //}
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

        }





    }
}
