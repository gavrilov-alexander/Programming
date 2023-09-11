using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы проверки чисел на положительность и вхождение в диапозон.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет число на положительность.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если число неположительно.</exception>
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть неотрицательным");
            }
        }

        /// <summary>
        /// Проверяет число на положительность.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если число неположительно.</exception>
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть неотрицательным");
            }
        }

        /// <summary>
        /// Проверяет число на вхождение в диапозон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапозона.</param>
        /// <param name="max">Конец диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если число находится вне диапозона.</exception>
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет число на вхождение в диапозон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапозона.</param>
        /// <param name="max">Конец диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если число находится вне диапозона.</exception>
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }
    }
}
