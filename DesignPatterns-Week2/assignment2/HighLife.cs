using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    internal class HighLife : ConwayGameOfLife
    {
        //Highlife variant B36/S23, see http://www.conwaylife.com/wiki/HighLife
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            //new cell
            if (!livingCell && (neighbourCount == 3 || neighbourCount == 6))
                return true;

            //cell lives
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            //dead cell
            return false;
        }

    }
}
