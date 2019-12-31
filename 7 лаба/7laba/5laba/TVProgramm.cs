using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    abstract partial class TVProgramm
    {
        public TVProgramm(int duration, int date)
        {
            info.Duration = duration;
            info.Date = date;
        }
    }
    abstract partial class TVProgramm : Base
    {
        private int rating;
        public virtual int Rating
        {
            get { return rating; }
            set
            {
                if (value < 0)
                    throw new RatingException("Рейтинг не может быть отрицательным");
                else
                    rating = value;
            }
        }
        public virtual string Author { get; set; }
        public override string ToString()
        {
            return this.Author;
        }
        public virtual int ShowRating()
        {
            return this.Rating;
        }
    }
}
