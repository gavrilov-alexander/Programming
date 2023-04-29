using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине, оценке, наименовании дисциплины и фамилии преподавателя.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Возвращает и задает наименование дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает фамилию преподавателя.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должна быть в диапозоне от 2 до 5.
        /// </summary>
        public int Mark
        {
            get => _mark;
            set
            {
                int min = 2;
                int max = 5;
                Validator.AssertValueInRange(value, min, max);
                _mark= value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/> без инициализации.
        /// </summary>
        public Discipline()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Наименование дисциплины.</param>
        /// <param name="teacher">Фамилия преподавателя.</param>
        /// <param name="mark">Оценка. Должна быть в диапозоне от 2 до 5.</param>
        public Discipline(string name, string teacher, int mark)
        {
            Name = name;
            Teacher = teacher;
            Mark = mark;
        }
    }
}
