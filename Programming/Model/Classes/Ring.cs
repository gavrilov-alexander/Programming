using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private Point2D _center;
        private double _innerRadius;
        private double _outerRadius;

        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double InnerRadius
        {
            get { return _innerRadius; }
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

        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (_innerRadius == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, InnerRadius, Double.MaxValue);
                }
                _outerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                double area = Math.PI*(Math.Pow(OuterRadius,2))-Math.PI*(Math.Pow(InnerRadius,2));
                return area;
            }
        }

        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}
