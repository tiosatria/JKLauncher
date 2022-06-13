using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;

namespace JKLauncher
{
    internal class HDTurf
    {
        private string _memState;

        public string StateHDTurf
        {
            get { return ConfigurationManager.AppSettings["HDTurfState"]; }
            set { ConfigurationManager.AppSettings.Set("HDTurfState", value); }
        }

        public Image HDTurfImage { get; set; }
        public static Image GetHDTurfPic(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Bitmap bmp = new Bitmap(JKLauncher.Properties.Resources.HD_Turf_On);
                    return bmp;
                    break;

                case "Disabled":
                    Bitmap bmp2 = new Bitmap(JKLauncher.Properties.Resources.HD_Turf_Off);
                    return bmp2;
                    break;
                default:
                    return null;
                    break;
            }
        }
        public static string GetStateHDTurf()
        {
            return ConfigurationManager.AppSettings["HDTurfState"];
        }
        public static void ToogleHDTurfState(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Config.UpdateSetting("HDTurfState", "Enabled");
                    break;

                case "Disabled":
                    Config.UpdateSetting("HDTurfState", "Disabled");
                    break;
            }
        }
    }
}
