using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    abstract class TVProgramm : IProgramm
    {
        int duration;
        int hash;
        int rating;
        public Author Author { get; set; }
        public virtual int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value < 0)
                {
                    duration = 0;
                    hash = 0;
                }
                else
                {
                    duration = value;
                    hash = value;
                }
            }
        }
        public virtual int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value < 0)
                {
                    rating = 0;
                    hash = 0;
                }
                else
                {
                    rating = value;
                    hash = value;
                }
            }
        }
        public override string ToString()
        {
            return "TVProgram type";
        }

        public abstract void ShowProgram();

    }
}
