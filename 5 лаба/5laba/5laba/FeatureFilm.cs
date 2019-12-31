using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    sealed class FeatureFilm : Film
    {
        int duration;
        int hash;
        int rating;

        public override int Duration
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
        public override int Rating
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
            return "This is a feature film";
        }
        public override void ShowProgram()
        {
            Console.WriteLine("Showing feature film...");
        }
    }
}
