using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о координатах точки.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Значение координаты точки по оси OX.
        /// </summary>
        private double _x;

        /// <summary>
        /// Значение координаты точки по оси OY.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает значение координаты точки по оси OX. Должно быть положительным.
        /// </summary>
        public double X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значение координаты точки по оси OY. Должно быть положительным.
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительным.</param>
        /// <param name="y">Координата Y. Должна быть положительным.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
