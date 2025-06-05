using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class HighBudgetShop : ComputerShop
    {
        public override void CreateHardDisk(Computer computer)
        {
            computer.HardDisk = new HardDisk("very quickly");
        }

        public override void CreateMonitor(Computer computer)
        {
            computer.Monitor = new Monitor("very nice");
        }

        public override void CreateProcessor(Computer computer)
        {
            computer.Processor = new Processor("very quickly");
        }
    }
}
