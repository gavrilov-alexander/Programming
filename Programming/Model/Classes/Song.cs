using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _duration;

        public string Name { get; set; }

        public string Author { get; set; } 

        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        public Song()
        {
        }

        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }
    }
}
