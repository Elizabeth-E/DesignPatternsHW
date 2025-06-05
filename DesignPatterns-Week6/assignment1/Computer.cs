using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Computer : IComputer
    {
        public IProcessor Processor;
        public IHardDisk HardDisk;
        public IMonitor Monitor;

        public void Test()
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}
