using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Monitor : IMonitor
    {
        private string shopSpeed;

        public Monitor(string shop)
        {
            this.shopSpeed = shop;
        }
        public void Display()
        {
            Console.WriteLine($"displaying stuff {shopSpeed}...");
        }
    }
}
