using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAssignment
{
    class MainSystem
    {
        Logger logger = null;
        SubSystem subSystem = null;

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");

            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }

        public MainSystem()
        {
            logger = Logger.GetInstance();

            subSystem = new SubSystem();
        }
    }
}
