using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _5laba
{
    class Film : TVProgramm
    {
        public override string Author
        {
            get => base.Author;
            set => base.Author = value;
        }
        public override int Rating
        {
            get => base.Rating;
            set => base.Rating = value;
        }
        public override string ToString()
        {
            return this.Author+ " " + "Рейтинг - " + this.Rating;
        }
        public Film(int duration, int date) : base(duration, date)
        {
           
        }
    }
   
}
