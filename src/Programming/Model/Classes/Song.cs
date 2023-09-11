using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне, продолжительности, названии, авторе.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает автора.
        /// </summary>
        public string Author { get; set; } 

        /// <summary>
        /// Возвращает и задает продолжительность. Должна быть положительна.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/> без инициализации.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="author">Автор.</param>
        /// <param name="duration">Продолжительность. Должна быть положительна.</param>
        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }
    }
}
