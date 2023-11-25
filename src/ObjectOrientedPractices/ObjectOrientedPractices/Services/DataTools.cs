using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет методы фильтрации и сортировки списков.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список, согласно предоставленному методу.
        /// </summary>
        /// <param name="array">Список.</param>
        /// <param name="filter">Метод фильтрации.</param>
        /// <returns>Отфильтрованный список.</returns>
        public static BindingList<object> Filter(BindingList<object> array, Func<object, bool> filter)
        {
            BindingList<object> result = new BindingList<object>();
            foreach (object item in array)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Сортирует список, согласно предосталенному методу сортировки.
        /// </summary>
        /// <param name="array">Список.</param>
        /// <param name="compare">Метод сортировки.</param>
        /// <returns>Отсортированный список.</returns>
        public static BindingList<object> Sort(BindingList<object> array, Func<object, object, bool> compare)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (compare(array[i], array[j]))
                    {
                        object temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            return array;
        }
    }
}
