using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы случайного создания объектов класса <see cref="Rectangle"/>.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Rectangle"/>.
        /// </summary>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize()
        {
            Random random = new Random();
            Array colors = Enum.GetValues(typeof(Color));
            double height = random.Next(1, 100) + random.NextDouble();
            double width = random.Next(1, 100) + random.NextDouble();
            string color = colors.GetValue(random.Next(0, colors.Length)).ToString();
            Point2D center = new Point2D(random.NextDouble() * 100, random.NextDouble() * 100);
            return new Rectangle(height, width, color, center);
        }

        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Rectangle"/> в зависимости от размеров панели.
        /// </summary>
        /// <param name="canvas">Панель.</param>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(Panel canvas)
        {
            Random random = new Random();
            Array colors = Enum.GetValues(typeof(Color));
            double x = Convert.ToDouble(random.Next(15, canvas.Width - 15));
            double y = Convert.ToDouble(random.Next(15, canvas.Height - 15));
            double width = random.Next(1, Convert.ToInt32((canvas.Width - x) / 2));
            double height = random.Next(1, Convert.ToInt32((canvas.Height - y) / 2));
            string color = colors.GetValue(random.Next(0, colors.Length)).ToString();
            return new Rectangle(height, width, color, new Point2D(x + width / 2, y + height / 2));
        }
    }
}
