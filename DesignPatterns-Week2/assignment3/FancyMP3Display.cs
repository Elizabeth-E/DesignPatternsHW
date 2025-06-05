using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class FancyMP3Display : IObserver
    {
        public FancyMP3Display(IObservable mp3player) 
        {
            mp3player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} ({song.Duration.ToString(@"mm\:ss")})");
        }
    }
}
