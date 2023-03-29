using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int _year;
        private string _genre;
        private double _rating;

        public string Name { get; set; }

        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                int min = 1900;
                var date = DateTime.Now;
                int max = date.Year;
                Validator.AssertValueInRange(value, min, max);
                _year = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get { return _rating; }
            set
            {
                int min = 0;
                int max = 10;
                Validator.AssertValueInRange(value, min, max);
                _rating= value;
            }
        }

        public string Info
        {
            get
            {
                return $@"Movie: {Name}; Rating: {Math.Round(Rating)}";
            }
        }

        public Movie()
        {
        }

        public Movie(string name, int duration, int year, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}