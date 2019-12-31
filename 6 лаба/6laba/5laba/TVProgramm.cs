using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    abstract partial class TVProgramm
    {
        public TVProgramm(int duration, int rating, int date)
        {
            info.Duration = duration;
            info.Rating = rating;
            info.Date = date;
        }
    }
    abstract partial class TVProgramm : Base
    {
        public virtual string Author { get; set; }
        public override string ToString()
        {
            return this.Author;
        }
    }
}
