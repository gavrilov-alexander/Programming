using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private int _mark;

        public string Name { get; set; }

        public string Teacher { get; set; }

        public int Mark
        {
            get => _mark;
            set
            {
                int min = 2;
                int max = 5;
                Validator.AssertValueInRange(value, min, max);
                _mark= value;
            }
        }

        public Discipline()
        {
        }

        public Discipline(string name, string teacher, int mark)
        {
            Name = name;
            Teacher = teacher;
            Mark = mark;
        }
    }
}
