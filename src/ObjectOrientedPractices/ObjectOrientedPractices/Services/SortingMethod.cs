using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Хранит данные о методе сортировки и его названии.
    /// </summary>
    public class SortingMethod
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Метод сортировки.
        /// </summary>
        public Func<object, object, bool> Method { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="SortingMethod"/>.
        /// </summary>
        /// <param name="name">Название метода сортировки.</param>
        /// <param name="method">Метод сортировки.</param>
        public SortingMethod(string name, Func<object, object, bool> method)
        {
            Name = name;
            Method = method;
        }
    }
}
