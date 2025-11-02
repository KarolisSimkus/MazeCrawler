using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class SoundManager
    {
        private SoundPlayer SoundPlayer;

        public SoundManager(string filepath)
        {
            SoundPlayer = new SoundPlayer(filepath);
        }
        public void Play() 
        {
            try
            {
                SoundPlayer.Play();
            }
            catch (Exception ex)
            {
                // This will fire on any other computer since my github repo doesn't include the music.vaw file and the bin/debug folderpath
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }
    }
}
