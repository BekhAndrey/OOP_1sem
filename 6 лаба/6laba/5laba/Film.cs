using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    class Film : TVProgramm
    {
        public override string Author
        {
            get => base.Author;
            set => base.Author = value;
        }
        public override string ToString()
        {
            return this.Author;
        }
        public Film(int duration, int rating, int date) : base(duration, rating, date)
        {
           
        }
    }
}
