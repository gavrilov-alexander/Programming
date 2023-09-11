using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Classes;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет методы случайного создания объектов класса <see cref="Customer"/>.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Объект класса <see cref="Customer"/>.</returns>
        public static Customer GenerateCustomer()
        {
            Random random = new Random();
            Array _names = Enum.GetValues(typeof(CustomerNames));
            Array _surnames = Enum.GetValues(typeof(CustomerSurnames));
            Array _patronymics = Enum.GetValues(typeof(CustomerPatronymics));
            Array _addresses = Enum.GetValues(typeof(Addresses));
            string name = _names.GetValue(random.Next(0, _names.Length)).ToString();
            string surname = _surnames.GetValue(random.Next(0, _surnames.Length)).ToString();
            string patronymic = _patronymics.GetValue(random.Next(0, _patronymics.Length)).ToString();
            string fullName = surname + " " + name + " " + patronymic;
            string address = _addresses.GetValue(random.Next(0, _addresses.Length)).ToString() +
               " " + random.Next(0, 100).ToString();
            return new Customer(fullName, address);
        }
    }
}
