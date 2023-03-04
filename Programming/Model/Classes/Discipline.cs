using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Discipline
    {
        private string _name;
        private string _teacher;
        private int _mark;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value > 1 && value < 6)
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
