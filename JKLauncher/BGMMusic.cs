using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKLauncher
{
    internal class BGMMusic
    {

        public static List<BGMMusic> BGMMusics = new List<BGMMusic>
        {
            new BGMMusic {titleBGM = "PES 2013", SongList = new List<string>{ "Ai se eu te pego - Michel Telo", "Seespaces - Teeth", "Gold - Oberhofer", "On top of the world - Imagine Dragons", "Dreamers -﻿ Savior Adore", "They Call Me (Radio Mix) - Rednek", "Suename el timbal - El Negro 5 Estrellas", "Tu Pai - Vakero", "And many more"},commandBGM = @"rmdir /s /q ""kitserver13\sound\"""},
            new BGMMusic {titleBGM = "POP", SongList = new List<string>{"No Roots - Alice Merton", "Butter - BTS ft. Megan Thee Stallion", "Higher Power - Coldplay", "Make Me Move - Culture Code ft. Karra", "Beautiful Mistakes - Maroon 5 ft. Megan Thee Stallion", "Happier - Marshmello ft. Bastille", "We Are The People - Martin Garrix ft. Bono & The Edge", "Blinding Lights - The Weeknd", "and many more!"},commandBGM = @"<nul set /p=""D"" | xcopy ""install\bgm\pop"" ""kitserver13\sound"" /E /H /C /R /Q /Y"},
            new BGMMusic {titleBGM = "Custom 1", SongList = new List<string>{"Custom DLC, Please download before applying - Otherwise it will failed"},commandBGM = @"<nul set /p=""D"" | xcopy ""install\bgm\custom1"" ""kitserver13\sound"" /E /H /C /R /Q /Y"},
            new BGMMusic {titleBGM = "Custom 2", SongList = new List<string>{"Custom DLC, Please download before applying - Otherwise it will failed"},commandBGM = @"<nul set /p=""D"" | xcopy ""install\bgm\custom2"" ""kitserver13\sound"" /E /H /C /R /Q /Y"},
            new BGMMusic {titleBGM = "Custom 3", SongList = new List<string>{"Custom DLC, Please download before applying - Otherwise it will failed"},commandBGM = @"<nul set /p=""D"" | xcopy ""install\bgm\custom3"" ""kitserver13\sound"" /E /H /C /R /Q /Y"}
        };

        public static void BGMMusicSwitch(int index)
        {
            CommandExecute.ExecuteCommand(BGMMusics[index].commandBGM);
        }

        public string titleBGM { get; set; }
        public string commandBGM { get; set; }

        public List<string> SongList { get; set; }

        public BGMMusic()
        {

        }



    }
}
