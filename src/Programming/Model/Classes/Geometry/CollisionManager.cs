﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы проверки объектов классов <see cref="Rectangle"/> и <see cref="Ring"/> на пересечение.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет пересекаются или не пересекаются 2 объекта класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый объект.</param>
        /// <param name="rectangle2">Второй проверяемый объект.</param>
        /// <returns>Возвращает true, если объекты пересекаются. И false, если объекты не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            return dX < (rectangle1.Width + rectangle2.Width) / 2 &&
                dY < (rectangle1.Height + rectangle2.Height) / 2;
        }

        /// <summary>
        /// Проверяет пересекаются или не пересекаются 2 объекта класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый объект.</param>
        /// <param name="rectangle2">Второй проверяемый объект.</param>
        /// <returns>Возвращает true, если объекты пересекаются. И false, если объекты не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double sumRadii = ring1.OuterRadius + ring2.OuterRadius;
            return sumRadii > Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
        }
    }
}
