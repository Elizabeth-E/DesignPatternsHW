using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    abstract class ComputerFactory
    {
        public abstract void CreateProcessor(Computer computer);

        public abstract void CreateHardDisk(Computer computer);

        public abstract void CreateMonitor(Computer computer);
    }
}
