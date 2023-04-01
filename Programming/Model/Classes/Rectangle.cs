using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private int _id;
        private double _length;
        private double _width;
        private static int _allRectanglesCount;

        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
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
            get { return _allRectanglesCount; }
        }

        public int Id
        {
            get => _id;
        }

        public string Info 
        {
            get => 
                $@"Rectangle: Length:{Math.Round(Length)}; Width:{Math.Round(Width)}";
        }

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            _id = AllRectanglesCount;
            _allRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}