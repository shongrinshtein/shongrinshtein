using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControl.Data.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Name { get; set; }
        public DateTime? ActualArrivalTime { get; set; }
        public DateTime ScheduledArrivalTime { get; set; }
        public bool IsCanceled { get; set; }
        public int TimeDelayOnGround { get; set; }
        public int TimeDelayOnFlight { get; set; }
        public int PlaceOnAirPort { get; set; }

    }
}
