using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Pencil : IPencil
    {
        private int maxToWrite; 
        private int nrOfCharsWritten; 

        public Pencil() {
            this.maxToWrite = 20;
            this.nrOfCharsWritten = 0;
        }

        public bool CanWrite { get { return nrOfCharsWritten < maxToWrite; } }

        public void AfterSharpening() {
            nrOfCharsWritten = 0;
        }

        public void Write(string message) {

            Console.ForegroundColor = ConsoleColor.Green;
            char emptyChar = '#';

            foreach (char c in message) {
                if (!this.CanWrite){
                    Console.Write(emptyChar);
                    continue;
                }
                Console.Write(c);
                nrOfCharsWritten++;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
