using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;

namespace JKLauncher
{
    internal class Crowd
    {
        public static int GetCrowdState()
        {
            int num;
                try
            {
                 num = Convert.ToInt32(ConfigurationManager.AppSettings["CrowdState"]);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
            return num;
        }
        public int crowdID { get; set; }
        public string crowdName { get; set; }
        public string crowdCommand { get; set; }
        public Image CrowdImage { get; set; }

        public static void ApplyCrowd(int crowd)
        {
            CommandExecute.ExecuteCommand(Crowds[crowd].crowdCommand);
            Config.UpdateSetting("CrowdState", crowd.ToString());
        }

        public static List<Crowd> Crowds = new List<Crowd>
        {
            new Crowd{crowdID = 0, crowdName = "Normal Crowd", crowdCommand = "" , CrowdImage = new Bitmap(JKLauncher.Properties.Resources.crowdenable)},
            new Crowd{crowdID = 1, crowdName = "Disable Crowd", crowdCommand = "" , CrowdImage = new Bitmap(JKLauncher.Properties.Resources.crowddisable)},
            new Crowd{crowdID = 2, crowdName = "Optimized Crowd", crowdCommand = "" , CrowdImage = new Bitmap(JKLauncher.Properties.Resources.crowddisable)}

        };
    }
}
