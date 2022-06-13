using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JKLauncher
{
    internal class League
    {
        public int leagueID { get; set; }
        public string LeagueName { get; set; }
        public List<string> LeagueTeams  { get; set; }
        public string LeagueCommand { get; set; }
        public Image LeagueImage { get; set; }

        public static List<League> Leagues = new List<League>
        { 
            new League{leagueID=0, LeagueName = "Premier League", LeagueTeams = new List<string>{ "Arsenal FC", "Aston Villa", "Brentford FC", "Brighton & Hove Albion", "Burnley FC", "Chelsea FC", "Crystal Palace", "Everton FC", "Leeds United", "Leicester City", "Liverpool FC", "Manchester City", "Manchester United", "Newcastle United", "Norwich City", "Southampton FC", "Tottenham Hotspur", "Watford FC", "West Ham United", "Wolverhampton Wanderers" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\ENG"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.premier)},
            new League{leagueID=1, LeagueName = "Ligue 1", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\FRA"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.ligue1)},
            new League{leagueID=2, LeagueName = "Serie A", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\ITA"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.serie)},
            new League{leagueID=3, LeagueName = "Bundesliga", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\GER"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.bundesliga)},
            new League{leagueID=4, LeagueName = "LaLiga", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\ESP"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.laliga)},
            new League{leagueID=5, LeagueName = "Liga Portugal", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\POR"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.ligaportugal)},
            new League{leagueID=6, LeagueName = "Eredivisie", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\NED"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.eredivisie)},
            new League{leagueID=7, LeagueName = "Belgian Pro League", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\BEL"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.belgianpro)},
            new League{leagueID=8, LeagueName = "Brasileirao", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\BRA"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.brasilero)},
            new League{leagueID=9, LeagueName = "Liga Argentina", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\ARG"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.argentinaleag)},
            new League{leagueID=10, LeagueName = "Liga MX", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\MEX"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.ligamx)},
            new League{leagueID=11, LeagueName = "J-League", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\JPN"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.jleague)},
            new League{leagueID=12, LeagueName = "Liga Indonesia", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\INA"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.lib)},
            new League{leagueID=13, LeagueName = "Full (Match Only)", LeagueTeams = new List<string>{ "List is not yet updated" } , LeagueCommand = @"<nul set /p=""D"" |xcopy ""install\leagues\FULL"" ""kitserver13"" /E /H /C /R /Q /Y", LeagueImage = new Bitmap(JKLauncher.Properties.Resources.allclub)}

        };

        public static void ApplyLeague(string leaguecommand)
        {
            CommandExecute.ExecuteCommand(@"<nul set /p=""D"" |xcopy ""install\leagues\DEFAULT"" ""kitserver13"" /E /H /C /R /Q /Y");
            CommandExecute.ExecuteCommand(leaguecommand);
        }

        public League()
        {

        }

    }
}
