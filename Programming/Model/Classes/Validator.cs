using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = "")
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть неотрицательным");
            }
        }
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = "")
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть неотрицательным");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }
        public static void AssertValueInRange(double value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }
    }
}
