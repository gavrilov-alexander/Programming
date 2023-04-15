using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class Rectangle
    {
        private int _id;
        private double _height;
        private double _width;
        private static int _allRectanglesCount;

        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Info
        {
            get =>
                $"{Id}: (X = {Math.Round(Center.X)}; Y = {Math.Round(Center.Y)}; " +
                $"W = {Math.Round(Width)}; H = {Math.Round(Height)})";
        }

        public Rectangle()
        {
        }

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