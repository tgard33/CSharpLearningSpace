using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    internal class StaticClassAttributesEX
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public StaticClassAttributesEX(string aTitle, string aArtist, int aDuration)
        { 
            title = aTitle; 
            artist = aArtist;
            duration = aDuration;
            songCount++;

        }

        public int getSongCount()
        {
            return songCount;
        }



    }
}
