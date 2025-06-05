using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class CallDataLoader : BigDataLoader
    {
        protected override void ExtractData()
        {
            Console.WriteLine("extracting call data...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("transforming call data...");
        }
    }
}
