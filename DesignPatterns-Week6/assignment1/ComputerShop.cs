using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class ComputerShop
    {
        public Computer AssembleComputer()
        {
            Computer computer = new Computer();
            CreateProcessor(computer);
            CreateHardDisk(computer);
            CreateMonitor(computer);
            return computer;
        }

        public abstract void CreateProcessor(Computer computer);

        public abstract void CreateHardDisk(Computer computer);

        public abstract void CreateMonitor(Computer computer);
    }
}
