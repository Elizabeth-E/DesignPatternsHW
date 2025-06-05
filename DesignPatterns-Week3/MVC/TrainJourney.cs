using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class TrainJourney : ITrainJourney
    {
        List<ITrainDisplay> observer = new List<ITrainDisplay>();
        int counter = 0;
        bool moveUp = true;
        public List<TrainStation> stations;

        public TrainJourney()
        {
            stations = new List<TrainStation>();
            stations.Add(new TrainStation("Den Helder", "S3", "16:30", "16:34"));
            stations.Add(new TrainStation("Den Helder Zuid", "S1", "16:38", "16:38"));
            stations.Add(new TrainStation("Anna Paulowna", "S1", "16:45", "16:46"));
        }

        public void NotifyObserver()
        {
            foreach (var o in observer)
            {
                o.Update(stations[counter]);
            }
        }

        public void AddObserver(ITrainDisplay observer)
        {
           this.observer.Add(observer);
        }

        public void RemoveObserver(ITrainDisplay observer)
        {
            this.observer.Remove(observer);
        }

        public void NextStation()
        {
            if(stations.Count() - 1 == counter)
            {
                moveUp = false;
            }

            if (counter == 0)
            {
                moveUp = true;
            }
            
            if (moveUp)
            {
                counter++;
            }
                
            else if (counter > 0)
            {
                counter--;
            }

            this.NotifyObserver();
        }

    }
}
