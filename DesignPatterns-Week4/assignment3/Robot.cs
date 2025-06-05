using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Robot
    {
        public string Person { get; set; }

        public void MoveByPerson(string person)
        {
            Person = person;
            Console.WriteLine($"Robot is moved by {Person}");
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
    }
}
