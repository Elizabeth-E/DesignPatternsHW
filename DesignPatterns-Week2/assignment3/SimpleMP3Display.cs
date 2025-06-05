using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class SimpleMP3Display : IObserver
    {
        public SimpleMP3Display(IObservable mp3player)
        {
            mp3player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }
    }
}
