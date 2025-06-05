using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Tank : IAttacker
    {
        public string Driver {  get; set; }

        public Tank(string driver)
        {
            AssignDriver(driver);
        }
        public void AssignDriver(string driver)
        {
            Driver = driver;
            Console.WriteLine($"{Driver} is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}
