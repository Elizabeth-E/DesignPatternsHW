using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    internal class StandardLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            //new cell
            if (!livingCell && (neighbourCount == 3))
                return true;

            //cell lives
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            //dead cell
            return false;
        }
    }
}
