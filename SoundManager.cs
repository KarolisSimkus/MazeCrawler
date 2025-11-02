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
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }
    }
}
