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
    public partial class launchform : Form
    {
        ConfirmationBox conf = new ConfirmationBox();
        Language mainlang = new Language();
        

        public launchform()
        {
            InitializeComponent();
            Confirmation confirm = new Confirmation();
            listBGMPackage.DataSource = BGMMusic.BGMMusics;
            listBGMPackage.DisplayMember = "titleBGM";
            listLeagues.DataSource = League.Leagues;
            listLeagues.DisplayMember = "LeagueName";
            dropLeagueQuick.DataSource = League.Leagues;
            dropLeagueQuick.DisplayMember = "LeagueName";
            listTools.DataSource = Tools.ToolsList;
            listTools.DisplayMember = "toolName";
            InitSweetFX(SweetFX.GetStateSweetFX());
            InitHDTurf(HDTurf.GetStateHDTurf());
            combocrowd.DataSource = Crowd.Crowds;
            combocrowd.DisplayMember = "crowdName";
            InitCrowd();
            InitFrameLimiter();
            InitRadar(Radar.GetRadarState());
        }

        private void InitRadar(string state)
        {
            switch (state)
            {
                case "Enabled":
                    radarToogle.Checked = true;
                    picRadarPreview.Image = Radar.GetRadarPic(state);
                    break;

                case "Disabled":
                    radarToogle.Checked = false;
                    picRadarPreview.Image = Radar.GetRadarPic(state);
                    break;
            }
            lblRadarStatus.Text = "Radar is " + state;
        }
        private void InitFrameLimiter()
        {
            string state = FpsLimiter.GetStateFPSLimiter();
            switch (state)
            {
                case "Enabled":
                    tooglefpslimiter.Checked = true;
                    break;

                case "Disabled":
                    tooglefpslimiter.Checked = false;
                    break;
            }
        }
        private void InitCrowd()
        {
            int state = Crowd.GetCrowdState();
            combocrowd.SelectedIndex = state;
            picCrowdPreview.Image = Crowd.Crowds[state].CrowdImage;
        }
        private void InitHDTurf(string state)
        {
            switch (state)
            {
                case "Enabled":
                    tooglehdturf.Checked = true;
                    picHDTurfPreview.Image = HDTurf.GetHDTurfPic(state);
                    break;

                case "Disabled":
                    tooglehdturf.Checked = false;
                    picHDTurfPreview.Image = HDTurf.GetHDTurfPic(state);
                    break;
            }
            labelhdturf.Text = "HD Turf is " + state;
        }
        private void InitSweetFX(string state)
        {
            switch (state)
            {
                case "Enabled":
                    tooglesweetfx.Checked = true;
                    picSweetFXPreview.Image= SweetFX.GetSweetFxPic(state);
                    break;

                case "Disabled":
                    tooglesweetfx.Checked = false;
                    picSweetFXPreview.Image = SweetFX.GetSweetFxPic(state);
                    break;
            }
            labelSweetFXState.Text = "SweetFX is " + state;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Confirmation.ShowConfirm(Confirmation.dialogType.Exit, this);
        }

        private void btnOpenGameSetting_Click(object sender, EventArgs e)
        {
            CommandExecute.LaunchApp("settings.exe");
        }

        private void btnLangIdn_Click(object sender, EventArgs e)
        {
            Confirmation.ShowConfirm(Confirmation.dialogType.LangNotSupported, this);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Confirmation.ShowConfirm(Confirmation.dialogType.LangNotSupported, this);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CommandExecute.LaunchApp(@"kitserver13\Gameplay config.exe");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BGMMusic.BGMMusicSwitch(listBGMPackage.SelectedIndex);
        }

        private void listBGMPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSong.DataSource = BGMMusic.BGMMusics[listBGMPackage.SelectedIndex].SongList;
            label3.Text = BGMMusic.BGMMusics[listBGMPackage.SelectedIndex].titleBGM;
        }

        private void listLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTeams.DataSource = League.Leagues[listLeagues.SelectedIndex].LeagueTeams;
            label4.Text = League.Leagues[listLeagues.SelectedIndex].LeagueName;
            leaguePic.Image = League.Leagues[listLeagues.SelectedIndex].LeagueImage;
        }

        private void btnApplyQuickLeagueSelect_Click(object sender, EventArgs e)
        {
            League.ApplyLeague(League.Leagues[dropLeagueQuick.SelectedIndex].LeagueCommand);
        }

        private void btnApplyLeague_Click(object sender, EventArgs e)
        {
            League.ApplyLeague(League.Leagues[listLeagues.SelectedIndex].LeagueCommand);
        }

        private void listTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listTools.SelectedIndex;
            lbltoolname.Text = Tools.ToolsList[selected].toolName;
            pictools.Image = Tools.ToolsList[selected].toolImage;
            lbltooldesc.Text = Tools.ToolsList[selected].toolDescription;
        }

        private void btnLauncTools_Click(object sender, EventArgs e)
        {
            int selected = listTools.SelectedIndex;
            Tools.ExecuteTools(Tools.ToolsList[listTools.SelectedIndex].toolCommand);
        }

        private void sweetFXSett_Click(object sender, EventArgs e)
        {
            Confirmation.ShowConfirm(Confirmation.dialogType.SweetFXTweak, this);
        }


        private void tooglesweetfx_Click(object sender, EventArgs e)
        {
            if (tooglefpslimiter.Checked == true)
            {
                MessageBox.Show("This option can't be enabled if Fps Limiter Is Enabled! Please Disable Fps Limiter!", "Not supported with SweetFX!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tooglesweetfx.Checked = false;
            }
            else
            {
                string state;
                if (tooglesweetfx.Checked)
                {
                    state = "Enabled";
                }
                else
                {
                    state = "Disabled";
                }
                SweetFX.ToogleSweetFX(state);
                picSweetFXPreview.Image = SweetFX.GetSweetFxPic(state);
                labelSweetFXState.Text = "SweetFX is " + state;
            }
            
        }

        private void tooglehdturf_Click(object sender, EventArgs e)
        {
            string state;
            if (tooglehdturf.Checked)
            {
                state = "Enabled";
            }
            else
            {
                state = "Disabled";
            }
            HDTurf.ToogleHDTurfState(state);
            picHDTurfPreview.Image = HDTurf.GetHDTurfPic(state);
            labelhdturf.Text = "HD Turf is " + state;
        }

        private void btnApplyCrowd_Click(object sender, EventArgs e)
        {
            Crowd.ApplyCrowd(combocrowd.SelectedIndex);
        }

        private void combocrowd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int state = combocrowd.SelectedIndex;
            picCrowdPreview.Image = Crowd.Crowds[state].CrowdImage; 
        }

        private void tooglefpslimiter_Click(object sender, EventArgs e)
        {
            if (tooglesweetfx.Checked==true)
            {
                MessageBox.Show("This option can't be enabled if SweetFX is Enabled!", "Not supported with SweetFX!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tooglefpslimiter.Checked = false;
            }
            else
            {
                if (tooglefpslimiter.Checked==true)
                {
                    FpsLimiter.ToogleFPSLimiter("Enabled");
                }
                else
                {
                    FpsLimiter.ToogleFPSLimiter("Disabled");
                }
            }
        }

        private void radarToogle_Click(object sender, EventArgs e)
        {
                string state;
                if (radarToogle.Checked)
                {
                    state = "Enabled";
                }
                else
                {
                    state = "Disabled";
                }
                Radar.ToogleRadarState(state);
                picRadarPreview.Image = Radar.GetRadarPic(state);
                lblRadarStatus.Text = "Radar is " + state;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < timer.Interval; i++)
            {

            }

        }
    }
}
