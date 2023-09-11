using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет методы случайного создания объектов класса <see cref="Item"/>.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Объект класса <see cref="Item"/>.</returns>
        public static Item GenerateItem()
        {
            Random random = new Random();
            Array _names = Enum.GetValues(typeof(ItemNames));
            string name = _names.GetValue(random.Next(0, _names.Length)).ToString();
            string info = name;
            double cost = random.Next(0, 100000);
            return new Item(name, info, cost);
        }
    }
}
