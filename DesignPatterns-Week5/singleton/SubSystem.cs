using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAssignment
{
    class SubSystem
    {
        Logger logger = null;

        public SubSystem()
        {
            logger = Logger.GetInstance();
        }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "do some work");
        }

        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "do some more work");
        }
    }
}
