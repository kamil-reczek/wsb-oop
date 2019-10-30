using Zadanie0;

namespace Zadanie2
{
    public class Trip
    {
        private Date start;
        private Date end;
        private string destination;

        public Trip(Date start, Date end, string destination)
        {
            this.start = start;
            this.end = end;
            this.destination = destination;
        }

        public string getInfo()
        {
            return $"Trip to {destination} starts on {start} and ends on {end}";
        }
    }
}