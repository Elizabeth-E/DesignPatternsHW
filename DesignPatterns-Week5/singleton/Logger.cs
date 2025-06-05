using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAssignment
{
    class Logger
    {
        private int numberOfLines = 1;
        private static Logger uniqueInstance = null;

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }

        public void Log(string location, string message)
        {
            string logMessage = String.Format("{0} - [{1}] {2}", this.numberOfLines.ToString(), location, message);
            Console.WriteLine(logMessage);

            this.numberOfLines++;
        }

        private Logger()
        {

        }
    }
}
