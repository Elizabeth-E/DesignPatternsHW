using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class ComputerShop
    {
        private ComputerFactory factory;

        public ComputerShop(ComputerFactory factory)
        {
            this.factory = factory;
        }

        public Computer AssembleComputer()
        {
            Computer computer = new Computer();
            factory.CreateProcessor(computer);
            factory.CreateHardDisk(computer);
            factory.CreateMonitor(computer);
            return computer;
        }
    }
}
