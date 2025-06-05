using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class TrainController : ITrainController
    {
        public void NextStation(TrainJourney journey)
        {
            journey.NextStation();
        }

    }
}
