using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    sealed class Cartoon : Film
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
        public Cartoon(int duration, int rating, int date) : base(duration, rating, date)
        {

        }
    }
}
