using System;
using System.IO;
using SharpConfig;

namespace SampleTwo
{
    static class SettingsManager
    {
        public static AppSettingsOne AppSettingsOne;
        public static AppSettingsTwo AppSettingsTwo;
        private static readonly ObjectConfiguration Configuration;

        static SettingsManager()
        {
            Configuration = new ObjectConfiguration();
            AppSettingsOne = Configuration.AddObject<AppSettingsOne>();
            AppSettingsTwo = Configuration.AddObject<AppSettingsTwo>();
        }

        public static void SaveSettings()
        {
            Configuration.Save(Path.Combine(Environment.CurrentDirectory, "config.ini"));
        }

        public static void LoadSettings()
        {
            Configuration.Load(Path.Combine(Environment.CurrentDirectory, "config.ini"));
        }

        public static void SaveBinarySettings()
        {
            Configuration.SaveBinary(Path.Combine(Environment.CurrentDirectory, "config_binary.ini"));
        }

        public static void LoadBinarySettings()
        {
            Configuration.LoadBinary(Path.Combine(Environment.CurrentDirectory, "config_binary.ini"));
        }

        public static void SaveSecureSettings()
        {
            Configuration.SaveSecure(Path.Combine(Environment.CurrentDirectory, "config_secure.ini"), "mysecurekey");
        }

        public static void LoadSecureSettings()
        {
            Configuration.LoadSecure(Path.Combine(Environment.CurrentDirectory, "config_secure.ini"), "mysecurekey");
        }
    }
}
