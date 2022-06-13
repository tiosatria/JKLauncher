using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;

namespace JKLauncher
{
    internal class FpsLimiter
    {
        private string _memState;

        public string StateFPSLimiter
        {
            get { return ConfigurationManager.AppSettings["FpsLimiter"]; }
            set { ConfigurationManager.AppSettings.Set("FpsLimiter", value); }
        }
        
        public static string GetStateFPSLimiter()
        {
            return ConfigurationManager.AppSettings["FpsLimiter"];
        }
        public static void ToogleFPSLimiter(string state)
        {
            switch (state)
            {
                case "Enabled":
                    Config.UpdateSetting("FpsLimiter", "Enabled");
                    break;
                case "Disabled":
                    Config.UpdateSetting("FpsLimiter", "Disabled");
                    break;
            }
        }
    }
}
