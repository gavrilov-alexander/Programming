using ProgrammingAppInformationSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAppInformationSystem.Model.Classes
{
    /// <summary>
    /// Предоставляет методы проверки чисел на положительность, строк по длине и вхождение строк в перечисление.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет число на вхождение в диапозон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапозона.</param>
        /// <param name="max">Конец диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если число находится вне диапозона.</exception
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет длину строки на вхождение в диапозон.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="min">Начало диапозона.</param>
        /// <param name="max">Конец диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если длина строки находится вне диапозона.</exception
        public static void AssertValueLengthInRange(string value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!(value.Length >= min && value.Length <= max))
            {
                throw new ArgumentException($"Длина строки в свойстве {propertyName} должна быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет строку на вхождение в перечисление <see cref="Category"/>.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если строка не найдена в перечислении <see cref="Category"/>.</exception>
        public static void AssertValueInCategoryEnum(string value, [CallerMemberName] string propertyName = "")
        {
            if (!(Enum.IsDefined(typeof(Category), value)))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно находиться в перечислении Category");
            }
        }
    }
}
