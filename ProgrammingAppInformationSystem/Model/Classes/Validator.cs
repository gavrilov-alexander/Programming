using ProgrammingAppInformationSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAppInformationSystem.Model.Classes
{
    public static class Validator
    {
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно быть от {min} до {max}");
            }
        }
        public static void AssertValueLengthInRange(string value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (!(value.Length >= min && value.Length <= max))
            {
                throw new ArgumentException($"Длина строки в свойстве {propertyName} должна быть от {min} до {max}");
            }
        }
        public static void AssertValueInCategoryEnum(string value, [CallerMemberName] string propertyName = "")
        {
            if (!(Enum.IsDefined(typeof(Category), value)))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} должно находиться в перечислении Category");
            }
        }
    }
}
