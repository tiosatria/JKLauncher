using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Configuration;

namespace JKLauncher
{
    internal class SweetFX
    {
        private string _memState;

        public string StateSweetFX
        {
            get { return ConfigurationManager.AppSettings["SweetFXState"]; }
            set { ConfigurationManager.AppSettings.Set("SweetFXState", value); }
        }

        public Image sweetfxImage { get; set; }
        public static Image GetSweetFxPic(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Bitmap bmp = new Bitmap(JKLauncher.Properties.Resources.SweetFX_On);
                    return bmp;
                    break;

                case "Disabled":
                    Bitmap bmp2 = new Bitmap(JKLauncher.Properties.Resources.SweetFX_Off);
                    return bmp2;
                    break;
                default:
                    return null;
                    break;
            }
        }
        public static string GetStateSweetFX()
        {
            return ConfigurationManager.AppSettings["SweetFXState"];
        }
        public static void ToogleSweetFX(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Config.UpdateSetting("SweetFXState", "Enabled");
                    break;

                case "Disabled":
                    Config.UpdateSetting("SweetFXState", "Disabled");
                    break;
            }
        }
    }
}
