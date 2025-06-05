using assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    void Start()
    {
        // create an MP3 player
        IObservable player = new MP3Player();
        // create the displays
        IObserver mp3Display1 = new SimpleMP3Display(player);
        IObserver mp3Display2 = new FancyMP3Display(player);
        // change song a few times
        player.NextSong();
        Console.WriteLine();
        player.NextSong();
        Console.WriteLine();
        player.NextSong();
        Console.WriteLine();
    }
}