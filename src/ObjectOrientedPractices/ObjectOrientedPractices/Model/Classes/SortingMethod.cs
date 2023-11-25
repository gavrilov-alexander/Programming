using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    public class SortingMethod
    {
        public string Name { get; set; }
        public Func<object, object, bool> Method { get; set; }
        public SortingMethod(string name, Func<object, object, bool> method)
        {
            Name = name;
            Method = method;
        }
    }
}
