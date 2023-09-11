using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике, его размерах и координатах его центра.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Идентификатор количества всех объектов данного класса.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть положительна.
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительна.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника. Должны быть положительны.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        public int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }

        /// <summary>
        /// Возвращает идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        /// <summary>
        /// Возвращает строку, содержащую <see cref="Id"/>, <see cref="Center"/>, <see cref="Width"/>, <see cref="Height"/>.
        /// </summary>
        public string Info
        {
            get =>
                $"{Id}: (X = {Math.Round(Center.X)}; Y = {Math.Round(Center.Y)}; " +
                $"W = {Math.Round(Width)}; H = {Math.Round(Height)})";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/> без инициализации.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна быть положительна.</param>
        /// <param name="width">Ширина. Должна быть положительна.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра. Должны быть положительны.</param>
        public Rectangle(double height, double width, string color, Point2D center)
        {
            Id = AllRectanglesCount;
            AllRectanglesCount++;
            Height = height;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}