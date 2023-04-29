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
        /// Хранит данные белого цвета приложения.
        /// </summary>
        public static Color White = Color.White;

        /// <summary>
        /// Хранит данные светло-розового цвета приложения.
        /// </summary>
        public static Color LightPink = Color.LightPink;

        /// <summary>
        /// Хранит данные красного цвета приложения.
        /// </summary>
        public static Color Red = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Хранит данные зеленого цвета приложения.
        /// </summary>
        public static Color Green = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Хранит данные весеннего зеленого цвета приложения.
        /// </summary>
        public static Color SpringGreen = Color.FromArgb(85, 156, 69);

        /// <summary>
        /// Хранит данные осеннего желтого цвета приложения.
        /// </summary>
        public static Color AutumnYellow = Color.FromArgb(226, 156, 69);
    }
}
