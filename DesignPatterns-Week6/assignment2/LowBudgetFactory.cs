using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class LowBudgetFactory : ComputerFactory
    {
        public override void CreateHardDisk(Computer computer)
        {
            computer.HardDisk = new HardDisk("not so quickly");
        }

        public override void CreateMonitor(Computer computer)
        {
            computer.Monitor = new Monitor("very poor");
        }

        public override void CreateProcessor(Computer computer)
        {
            computer.Processor = new Processor("not so quickly");
        }
    }
}
