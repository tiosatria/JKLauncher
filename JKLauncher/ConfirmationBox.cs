using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKLauncher
{
    public partial class ConfirmationBox : Form
    {
        public void Pos1Button()
        {
            confirmButton.Location = new Point(147, 179);
            confirmButton.Visible = true;
            cancelButton2.Visible = false;
        }

        public void Reset()
        {
            confirmButton.Location = new Point(73, 179);
            cancelButton2.Location = new Point(231, 179);
            confirmButton.Visible = true;
            cancelButton2.Visible = true;
        }

        private string titlelbl;

        public string LabelTitle
        {
            get { return titlelbl; }
            set { titlelbl = value;
                labeltittle.Text = value;
            }
        }

        private string subtitlelbl;

        public string LabelSubtitle
        {
            get { return subtitlelbl; }
            set { subtitlelbl = value;
                labelsubtitle.Text = value;
            }
        }

        private string lblbuttonOk;

        public string LblButtonOk
        {
            get { return lblbuttonOk; }
            set {
                lblbuttonOk = value; confirmButton.Text = value;
            }
        }

        private string lblbuttonCancel;

        public string LblButtonCancel
        {
            get { return lblbuttonCancel; }
            set { lblbuttonCancel = value;
                cancelButton2.Text = value;
            }
        }

        private Image icolbl;

        public Image IcoLbl
        {
            get { return icolbl; }
            set { icolbl = value; icoLabel.Image = value; }
        }

        public ConfirmationBox()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Confirmation.DoAction(senderform);
        }

        public launchform senderform;

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            Confirmation.DoCancelAction(senderform);
        }
    }
}
