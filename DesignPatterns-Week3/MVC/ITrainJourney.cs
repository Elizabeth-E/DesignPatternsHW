using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface ITrainJourney
    {
        void NotifyObserver();
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
    }
}
