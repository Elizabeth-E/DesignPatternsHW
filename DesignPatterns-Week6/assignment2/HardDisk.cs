using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class HardDisk : IHardDisk
    {
        private string shopSpeed;

        public HardDisk(string shop)
        {
            this.shopSpeed = shop;
        }
        public void StoreData()
        {
            Console.WriteLine($"storing data {shopSpeed}...");
        }
    }
}
