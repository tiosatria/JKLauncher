using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace JKLauncher
{
    internal class CommandExecute
    {
        public static void LaunchApp(string apppath)
        {
            try
            {
                System.Diagnostics.Process.Start(apppath);

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Oops... Can't find the module", "App/Script not found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);
            process.WaitForExit();
            if (process.ExitCode>0)
            {
                MessageBox.Show("Failed to apply patch! Please Check Permission/Patch Directory!", "Failed to apply selected module", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (process.ExitCode==0)
            {
                MessageBox.Show("Process Completed Succesfully!", "Applied Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            process.Close();
        }

    }
}
