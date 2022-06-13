
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;

namespace JKLauncher
{
    internal class Radar
    {
        private string _memState;

        public string StateRadar
        {
            get { return ConfigurationManager.AppSettings["RadarState"]; }
            set { ConfigurationManager.AppSettings.Set("RadarState", value); }
        }

        public Image RadarImage { get; set; }
        public static Image GetRadarPic(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Bitmap bmp = new Bitmap(JKLauncher.Properties.Resources.Radar_Enable);
                    return bmp;
                    break;

                case "Disabled":
                    Bitmap bmp2 = new Bitmap(JKLauncher.Properties.Resources.Radar_Disable);
                    return bmp2;
                    break;
                default:
                    return null;
                    break;
            }
        }
        public static string GetRadarState()
        {
            return ConfigurationManager.AppSettings["RadarState"];
        }
        public static void ToogleRadarState(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Config.UpdateSetting("RadarState", "Enabled");
                    break;

                case "Disabled":
                    Config.UpdateSetting("RadarState", "Disabled");
                    break;
            }
        }
    }
}
