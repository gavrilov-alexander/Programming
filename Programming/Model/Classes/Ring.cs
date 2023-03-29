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
                Validator.AssertOnPositiveValue(value);
                if (_outerRadius != null)
                {
                    if (value < _outerRadius)
                    {
                        _innerRadius = value;
                    }
                }
                else
                {
                    _innerRadius = value;
                }
            }
        }

        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (_innerRadius != null)
                {
                    if (_innerRadius < value)
                    {
                        _outerRadius = value;
                    }
                }
                else
                {
                    _outerRadius= value;
                }
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
