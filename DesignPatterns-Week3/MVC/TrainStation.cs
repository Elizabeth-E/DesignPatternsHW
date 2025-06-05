using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class TrainStation
    {
        public string Name;
        public string ArrivalTrack;
        public string ArrivalTime;
        public string DepatureTime;

        public TrainStation(string name, string arrivalTrack, string arrivalTime, string depatureTime)
        {
            this.Name = name;
            this.ArrivalTrack = arrivalTrack;
            this.ArrivalTime = arrivalTime;
            this.DepatureTime = depatureTime;
        }

        
    }
}
