
namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            new Program().Start();
        }

        private void Start()
        {
            BatchProcessor batchProcessor = new BatchProcessor();

            CallDataLoader callDataLoader = new CallDataLoader();
            TwitterDataLoader twitterDataLoader = new TwitterDataLoader();
            SensorDataLoader sensorDataLoader = new SensorDataLoader();

            batchProcessor.AddLoader(callDataLoader);
            batchProcessor.AddLoader(twitterDataLoader);
            batchProcessor.AddLoader(sensorDataLoader);

            batchProcessor.ProcessBatch();
        }
    }
}