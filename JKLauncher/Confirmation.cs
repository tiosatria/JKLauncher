using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace JKLauncher
{
    internal class Confirmation
    {
        public static ConfirmationBox confbox = new ConfirmationBox();

        public static dialogType dialogTypeMem;
        public enum dialogType
        {
            Exit,
            Dummy,
            LangNotSupported,
            SweetFXTweak
        }
        
        public static void DoAction(launchform form)
        {
            switch (dialogTypeMem)
            {
                case dialogType.Exit:
                    Application.Exit();
                    break;
                case dialogType.Dummy:
                    break;
                case dialogType.LangNotSupported:
                    form.Focus();
                    form.Enabled = true;
                    confbox.Hide();
                    break;
                case dialogType.SweetFXTweak:
                    CommandExecute.LaunchApp("SweetFX_settings.txt");
                    form.Focus();
                    form.Enabled = true;
                    confbox.Hide();
                    break;
            }
        }

        public static void DoCancelAction(launchform form)
        {
            switch (dialogTypeMem)
            {
                case dialogType.Exit:
                    form.Focus();
                    form.Enabled = true;
                    confbox.Hide();
                    break;
                case dialogType.Dummy:

                    break;
                case dialogType.SweetFXTweak:
                    MessageBox.Show("Good, you're not allowed to edit the configuration files. Comeback here if you're an expert!", "Noob Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    form.Focus();
                    form.Enabled = true;
                    confbox.Hide();
                    break;
            }
        }

        public static void ShowConfirm(dialogType dialog, launchform form)
        {
            form.Enabled = false;
            dialogTypeMem = dialog;
            confbox.senderform = form;
            switch (dialog)
            {
                case dialogType.Exit:
                    confbox.Reset();
                    confbox.LabelTitle = "Exit Launcher";
                    confbox.LabelSubtitle = "Are you sure you wish to exit launcher?";
                    confbox.LblButtonOk = "Yes, Quit";
                    confbox.LblButtonCancel = "No, I Misclicked";
                    confbox.IcoLbl = new Bitmap(JKLauncher.Properties.Resources.icons8_question_mark_48px);
                    break;
                case dialogType.Dummy:
                    confbox.Reset();
                    confbox.LabelTitle = "This is dummy";
                    confbox.LabelSubtitle = "Dummy";
                    confbox.LblButtonOk = "Dumm Dumm";
                    confbox.LblButtonCancel = "Dummer";
                    confbox.IcoLbl = new Bitmap(JKLauncher.Properties.Resources.icons8_question_mark_48px);
                    break;
                case dialogType.LangNotSupported:
                    confbox.Pos1Button();
                    confbox.LabelTitle = "Feature not yet supported";
                    confbox.LabelSubtitle = "Go back here on next update, we'll keep working hard to bring this update for you!";
                    confbox.LblButtonOk = "Got it!";
                    confbox.IcoLbl = new Bitmap(JKLauncher.Properties.Resources.icons8_speak_no_evil_monkey_48px);
                    confbox.senderform = form;
                    break;
                case dialogType.SweetFXTweak:
                    confbox.Reset();
                    confbox.LabelTitle = "Are you advanced user?";
                    confbox.LabelSubtitle = "WARNING! EXPERT ONLY! Proceed with caution, wrong or bad settings may cause the game laggy, have bad image or make the game crash!";
                    confbox.LblButtonOk = "Yes, I Understand the risk";
                    confbox.LblButtonCancel = "No, í'm just clicking things";
                    confbox.IcoLbl = new Bitmap(JKLauncher.Properties.Resources.icons8_guru_52px);
                    break;
            }
            confbox.Show();
        }

    }
}
