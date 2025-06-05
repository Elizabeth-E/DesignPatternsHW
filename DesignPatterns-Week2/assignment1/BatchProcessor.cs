using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class BatchProcessor
    {
        private List<BigDataLoader> bigDataLoaders;

        public BatchProcessor()
        {
            this.bigDataLoaders = new List<BigDataLoader>();
        }

        public void AddLoader(BigDataLoader loader)
        {
            bigDataLoaders.Add(loader);
        }

        public void ProcessBatch()
        {
            foreach (var loader in bigDataLoaders)
            {
                loader.ETLProcess();
            }
        }
    }
}
