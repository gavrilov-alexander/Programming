﻿using ObjectOrientedPractices.Model.Classes.Orders;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator = ObjectOrientedPractices.Services.ValueValidator;

namespace ObjectOrientedPractices.Model.Classes
{
    /// <summary>
    /// Хранит данные о предмете, его названии, описании и стоимости.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        public event EventHandler NameChanged;
        public event EventHandler CostChanged;
        public event EventHandler InfoChanged;
        /// <summary>
        /// Идентификатор количества всех объектов данного класса.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание предмета.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость предмета.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает идентификатор предмета.
        /// </summary>
        public int Id { get { return _id; } }

        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает название предмета. Длина строки должна быть меньше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                int maxLength = 200;
                Validator.AssertStringOnLength(value, maxLength);
                if (_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Возвращает и задает описание предмета. Длина строки должна быть меньше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                int maxLength = 1000;
                Validator.AssertStringOnLength(value, maxLength);
                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость предмета. Должна быть в диапозоне от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                double min = 1;
                double max = 99999;
                Validator.AssertValueInRange(value, min, max);
                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название предмета. Длина строки должна быть меньше 200 символов.</param>
        /// <param name="info">Описание предмета. Длина строки должна быть меньше 1000 символов.</param>
        /// <param name="cost">Стоимость предмета. Должна быть в диапозоне от 0 до 100000.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = _idCounter;
            _idCounter++;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> без инициализации.
        /// </summary>
        public Item()
        {
            _id = _idCounter;
            _idCounter++;
        }

        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        public bool Equals(Item? other)
        {
            if (other == null)
            {
                return false;
            }
            if (other is not Item)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if ((Name != other.Name) || (Info != other.Info) || (Cost != other.Cost) || (Category != other.Category))
            {
                return false;
            }
            return true;
        }

        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other is not Item)
            {
                return -1;
            }
            if (Cost == other.Cost)
            {
                return 0;
            }
            if (Cost > other.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
