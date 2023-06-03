using ProgrammingAppInformationSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingAppInformationSystem.Model.Classes
{
    /// <summary>
    /// Хранит данные об организации.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Название организации.
        /// </summary>
        private string _name;

        /// <summary>
        /// Адресс организации.
        /// </summary>
        private string _address;

        /// <summary>
        /// Категория организации.
        /// </summary>
        private string _category;

        /// <summary>
        /// Рейтинг организации.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название организации. Длина должна быть не более 200.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                int min = 1;
                int max = 200;
                Validator.AssertValueLengthInRange(value, min, max);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес организации. Длина должна быть не более 100.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                int min = 1;
                int max = 100;
                Validator.AssertValueLengthInRange(value, min, max);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию организации. Должна быть в перечислении <see cref="Enums.Category"/>.
        /// </summary>
        public string Category
        {
            get { return _category; }
            set
            {
                Validator.AssertValueInCategoryEnum(value);
                _category = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг организации. Должен быть от 0 до 5.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                double min = 0;
                double max = 5;
                Validator.AssertValueInRange(value, min, max);
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает строку, содержащую <see cref="Category"/>, <see cref="Name"/>.
        /// </summary>
        public string Info => $"{Category} - {Name}";

        /// <summary>
        /// Возвращает результат сравнения двух организаций.
        /// </summary>
        /// <param name="organization1">Первая сравниваемая организация.</param>
        /// <param name="organization2">Вторая сравниваемая организация.</param>
        /// <returns></returns>
        public static int Compare(Organization organization1, Organization organization2)
        {
            if (String.Compare(organization1.Category, organization2.Category) == 0)
            {
                return String.Compare(organization1.Name, organization2.Name);
            }
            else
            {
                return String.Compare(organization1.Category, organization2.Category);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Organization"/> без инициализации.
        /// </summary>
        public Organization()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Organization"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть не более 200 символов.</param>
        /// <param name="address">Адрес. Должен быть не более 100 символов.</param>
        /// <param name="category">Категория. Должна входить в перечисление <see cref="Enums.Category"/>/</param>
        /// <param name="rating">Рейтинг. Должен быть о 0 до 5.</param>
        public Organization(string name, string address, string category, double rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Organization"/> копирую значения другого объекта.
        /// </summary>
        /// <param name="organization">Копируемый объект.</param>
        public Organization(Organization organization)
        {
            Name = organization.Name;
            Address = organization.Address;
            Category = organization.Category;
            Rating = organization.Rating;
        }
    }
}
