using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class MP3Player : IObservable
    {
        List<Song> playList;
        private Random rnd;

        public Song CurrentSong { get; private set; }
        List<IObserver> observers;

        public MP3Player()
        {
            playList = new List<Song>();
            observers = new List<IObserver>();
            BuildPlaylist();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NextSong()
        {
            rnd = new Random();
            CurrentSong = playList.ElementAt(rnd.Next(0, playList.Count - 1));

            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }
        private void BuildPlaylist()
        {
            playList =
            [
                new Song("Papillon", "Editors", new TimeSpan(0,0,5,24)),
                new Song("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 0, 5, 39)),
                new Song("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 0, 6, 26)),
                new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 0, 3, 31)),
            ];
        }
    }
}
