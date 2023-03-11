using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException(message: "Длина должна быть больше 0");
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException(message: "Ширина должна быть больше 0");
                }
            }
        }
        public string Color { get; set; }
        public Rectangle()
        {
        }
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }

