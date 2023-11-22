using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет методы проверки чисел на вхождение в диапозон и строк на вхождение длины в диапозон.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки на максимальное количество символов.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальное количество символов.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если длина строки больше максимального количесва символов.</exception>
        public static void AssertStringOnLength(string value, int maxLength, [CallerMemberName] string propertyName = "")
        {
            if (value == null || (!(value.Length < maxLength)))
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
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
            if (!((value >= min) && (value <= max)))
            {
                throw new ArgumentException($"{propertyName} должен быть в диапозоне от {min} до {max}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!((value >= min) && (value <= max)))
            {
                throw new ArgumentException($"{propertyName} должен быть в диапозоне от {min} до {max}");
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
            if (value < 0)
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть неотрицательным");
            }
        }
    }
}
