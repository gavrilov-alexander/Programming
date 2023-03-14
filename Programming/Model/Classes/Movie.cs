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
                if (value > 0)
                {
                    _duration = value;
                }
                else
                {
                    throw new ArgumentException(message: "Продолжительность фильма должна быть больше 0");
                }
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1900 && value <= 2023)
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentException(message: "Год выпуска фильма должен быть от 1900 до 2023");
                }
            }
        }
        public string Genre { get; set; }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException(message: "Рейтинг фильма должен быть от 0 до 10");
                }
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