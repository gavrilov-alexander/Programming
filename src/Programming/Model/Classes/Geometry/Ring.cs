using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о кольце, его радиусах и координатах его центра.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задает координаты центра кольца. Должны быть положительны.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. Должен быть положителен. Должен быть меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                if (_outerRadius == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, 0, OuterRadius);
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. Должен быть положителен. Должен быть больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                if (_innerRadius == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, InnerRadius, double.MaxValue);
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area =>
                Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Центр.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть положителен. Должен быть меньше внешнего радиуса.</param>
        /// <param name="outerRadius">Внешний радиус. Должен быть положителен. Должен быть больше внутреннего радиуса.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}
