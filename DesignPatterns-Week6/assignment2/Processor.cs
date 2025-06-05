using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Processor : IProcessor
    {

        private string shopSpeed;

        public Processor(string shop)
        {
            this.shopSpeed = shop;
        }
        public void PerformOperation()
        {
            Console.WriteLine($"performing operation {shopSpeed}...");
        }
    }
}
