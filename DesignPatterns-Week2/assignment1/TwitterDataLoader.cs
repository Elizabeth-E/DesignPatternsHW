using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class TwitterDataLoader : BigDataLoader
    {
        protected override void ExtractData()
        {
            Console.WriteLine("extracting twitter data...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("transforming twitter data...");
        }
    }
}
