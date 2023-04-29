using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.View
{
    /// <summary>
    /// Хранит данные цветов приложения.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Белый цвет приложения.
        /// </summary>
        public static Color White = Color.White;

        /// <summary>
        /// Светло-розовый цвет приложения.
        /// </summary>
        public static Color LightPink = Color.LightPink;

        /// <summary>
        /// Красный цвет приложения.
        /// </summary>
        public static Color Red = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Зеленый цвет приложения.
        /// </summary>
        public static Color Green = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Весенний зеленый цвет приложения.
        /// </summary>
        public static Color SpringGreen = Color.FromArgb(85, 156, 69);

        /// <summary>
        /// Осенний желтый цвет приложения.
        /// </summary>
        public static Color AutumnYellow = Color.FromArgb(226, 156, 69);
    }
}
