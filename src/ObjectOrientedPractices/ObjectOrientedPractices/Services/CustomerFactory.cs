using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Classes;
using System.ComponentModel;
using ObjectOrientedPractices.Model.Interfaces;
using ObjectOrientedPractices.Model.Classes.Discounts;

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
            Array categories = Enum.GetValues(typeof(Category));
            string name = _names.GetValue(random.Next(0, _names.Length)).ToString();
            string surname = _surnames.GetValue(random.Next(0, _surnames.Length)).ToString();
            string patronymic = _patronymics.GetValue(random.Next(0, _patronymics.Length)).ToString();
            string fullName = surname + " " + name + " " + patronymic;
            Address address = new Address(random.Next(100000, 1000000), "Country", "City", "Street", "Building", "Apartment");
            BindingList<IDiscount> discounts = new BindingList<IDiscount> { new PointsDiscount(random.Next(100000)),
                                                                            new PercentDiscount(random.Next(5000), (Category)categories.GetValue(random.Next(0, categories.Length)))};
            return new Customer(fullName, address , false, discounts);
        }
    }
}
