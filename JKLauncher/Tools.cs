using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JKLauncher
{
    internal class Tools
    {
        public int idTools { get; set; }
        public string toolName { get; set; }
        public string toolCommand { get; set; }
        public Image toolImage { get; set; }
        public string toolDescription { get; set; }

        public static List<Tools> ToolsList = new List<Tools>
        { new Tools {idTools = 0, toolName = "ML Money Tool", toolDescription = "Select your Master League save file 'ML0x.bin' and set your preferred money." ,toolImage = new Bitmap(JKLauncher.Properties.Resources.laliga), toolCommand = @"install\tools\ML Money\MoneyML.exe"  },
          new Tools{idTools = 1, toolName = "Fraps FPS Counter", toolDescription = "You can run this app minimized to the system tray to show FPS count on PES JK Patch",toolImage = new Bitmap(JKLauncher.Properties.Resources.laliga), toolCommand = @""},
          new Tools{idTools = 2, toolName = "Starting Year Tool", toolDescription = "Select 'jkgame.exe' and set your preferred starting year for Competition and Football Life mode",toolImage = new Bitmap(JKLauncher.Properties.Resources.laliga), toolCommand = @""}
        };

        public static void ExecuteTools(string toolcommand)
        {
            CommandExecute.LaunchApp(toolcommand);
        }

    }
}
