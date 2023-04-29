using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете, продолжительности, пункте отправления и пункте прибытия.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Продолжительность полета.
        /// </summary>
        private int _time;

        /// <summary>
        /// Пункт отправления.
        /// </summary>
        public string Departure { get; set;}

        /// <summary>
        /// Пункт прибытия.
        /// </summary>
        public string Destination { get; set;}

        /// <summary>
        /// Продолжительность полета. Должна быть положительна.
        /// </summary>
        public int Time
        {
            get => _time;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _time = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/> без инициализации.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destination">Пункт прибытия.</param>
        /// <param name="time">Продолжительность полета. Должна быть положительна.</param>
        public Flight(string departure, string destination, int time)
        {
            Departure = departure;
            Destination = destination;
            Time = time;
        }
    }
}
