using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void ETLProcess() {

            ETLProcessStart();
            ExtractData();
            TransformData();
            LoadData();
            ETLProcessEnd();
        }

        protected void ETLProcessStart() {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process started]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected abstract void TransformData();

        protected abstract void ExtractData();

        protected void LoadData()
        {
            Console.WriteLine("loading transformed data...");
        }

        protected void ETLProcessEnd() {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process finished]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
