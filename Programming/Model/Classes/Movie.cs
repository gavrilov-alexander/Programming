using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме, названии, продолжительности, годе выпуска, жанре, рейтинге.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рэйтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна быть положительна.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска. Должен быть в диапозоне от 1900 до нынешнего года.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                int min = 1900;
                var date = DateTime.Now;
                int max = date.Year;
                Validator.AssertValueInRange(value, min, max);
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг. Должен быть в диапозоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                double min = 0;
                double max = 10;
                Validator.AssertValueInRange(value, min, max);
                _rating= value;
            }
        }

        /// <summary>
        /// Возвращает строку, содержащую <see cref="Name"/>, <see cref="Rating"/>.
        /// </summary>
        public string Info
        {
            get =>
                $@"Movie: {Name}; Rating: {Math.Round(Rating)}";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/> без инициализации.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма. Должна быть положительна.</param>
        /// <param name="year">Год выпуска. Должен быть в диапозоне от 1900 до нынешнего года.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг. Должен быть в диапозоне от 0 до 10.</param>
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