using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departure;
        private string _destination;
        private int _time;

        public string Departure { get; set;}

        public string Destination { get; set;}

        public int Time
        {
            get { return _time; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _time = value;
            }
        }

        public Flight()
        {
        }

        public Flight(string departure, string destination, int time)
        {
            Departure = departure;
            Destination = destination;
            Time = time;
        }
    }
}
