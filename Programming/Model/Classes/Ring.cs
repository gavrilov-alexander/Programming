using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _innerRadius;
        private double _outerRadius;

        public Point2D Center { get; set; }

        public double InnerRadius
        {
            get => _innerRadius;
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
            get => _outerRadius;
            set
            {
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

        public double Area => 
                Math.PI*(Math.Pow(OuterRadius,2))-Math.PI*(Math.Pow(InnerRadius,2));

        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}
