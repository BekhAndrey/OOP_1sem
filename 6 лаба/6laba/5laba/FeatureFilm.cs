using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    sealed class FeatureFilm : Film
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
        public FeatureFilm(int duration, int rating, int date) : base(duration, rating, date)
        {
        
        }
    }
}
