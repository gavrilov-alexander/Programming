using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _name;
        private string _teacher;
        private int _mark;

        public string Name { get; set; }

        public string Teacher { get; set; }

        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    _mark = value;
                }
                else
                {
                    throw new ArgumentException(message: "Оценка должна быть от 2 до 5");
                }
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
