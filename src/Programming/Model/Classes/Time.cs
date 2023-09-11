using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени, количестве часов, минут и секунд.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает количество часов. Должно быть положительно.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество минут. Должно быть в диапозоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
            }
        }

        /// <summary>
        /// Возвращает и задает количество секунд. Должно быть в диапозоне от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/> без инициализации.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Количество часов. Должно быть положительно.</param>
        /// <param name="minutes">Количество минут. Должно быть в диапозоне от 0 до 59.</param>
        /// <param name="seconds">Количество секунд. Должно быть в диапозоне от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
