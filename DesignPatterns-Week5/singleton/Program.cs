using System;

namespace SingletonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            
            logger.Log("main", "starting");

            MainSystem mainSystem = new MainSystem();
            mainSystem.DoSomeMainWork();

            logger.Log("main", "finishing");

        }
    }
}
