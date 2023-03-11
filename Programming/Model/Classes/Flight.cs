using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Flight
    {
        private string _departure;
        private string _destination;
        private int _time;
        public string Departure {get; set;}
        public string Destination {get; set;}
        public int Time
        {
            get { return _time; }
            set
            {
                if (value > 0)
                {
                    _time = value;
                }
                else
                {
                    throw new ArgumentException(message: "Продолжительность полета должна быть больше 0");
                }
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
