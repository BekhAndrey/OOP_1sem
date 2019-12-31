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
        public override int Rating
        {
            get => base.Rating;
            set => base.Rating = value;
        }
        public override string ToString()
        {
            return this.Author + " " + "Рейтинг - " + this.Rating;
        }
        public FeatureFilm(int duration, int date) : base(duration, date)
        {
        
        }
    }
}
